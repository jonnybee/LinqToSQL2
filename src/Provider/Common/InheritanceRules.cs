using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace System.Data.Linq.Provider.Common
{
	/// <summary>
	/// This class defines the rules for inheritance behaviors. The rules:
	/// 
	///  (1) The same field may not be mappSed to different database columns.    
	///      The DistinguishedMemberName and AreSameMember methods describe what 'same' means between two MemberInfos.
	///  (2) Discriminators held in fixed-length fields in the database don't need
	///      to be manually padded in inheritance mapping [InheritanceMapping(Code='x')]. 
	///  
	/// </summary>
	internal static class InheritanceRules
	{
		/// <summary>
		/// Creates a name that is the same when the member should be considered 'same'
		/// for the purposes of the inheritance feature.
		/// </summary>
		internal static object DistinguishedMemberName(MemberInfo mi)
		{
			PropertyInfo pi = mi as PropertyInfo;
			FieldInfo fi = mi as FieldInfo;
			if(fi != null)
			{
				// Human readable variant:
				// return "fi:" + mi.Name + ":" + mi.DeclaringType;
				return new MetaPosition(mi);
			}
			if(pi != null)
			{
				MethodInfo meth = null;

				if(pi.CanRead)
				{
					meth = pi.GetGetMethod();
				}
				if(meth == null && pi.CanWrite)
				{
					meth = pi.GetSetMethod();
				}
				bool isVirtual = meth != null && meth.IsVirtual;

				// Human readable variant:
				// return "pi:" + mi.Name + ":" + (isVirtual ? "virtual" : mi.DeclaringType.ToString());

				if(isVirtual)
				{
					return mi.Name;
				}
				return new MetaPosition(mi);
			}
			throw Error.ArgumentOutOfRange("mi");
		}

		/// <summary>
		/// Compares two MemberInfos for 'same-ness'.
		/// </summary>
		internal static bool AreSameMember(MemberInfo mi1, MemberInfo mi2)
		{
			return DistinguishedMemberName(mi1).Equals(DistinguishedMemberName(mi2));
		}

		/// <summary>
		/// The representation of a inheritance code when mapped to a specific provider type.
		/// </summary>
		internal static object InheritanceCodeForClientCompare(object rawCode, ProviderType providerType)
		{
			// If its a fixed-size string type in the store then pad it with spaces so that 
			// comparing the string on the client agrees with the value returnd on the store.
			var rawCodeAsString = rawCode as string;
			if(providerType.IsFixedSize && (rawCodeAsString!=null))
			{
				if(providerType.Size.HasValue && rawCodeAsString.Length != providerType.Size)
				{
					rawCodeAsString = rawCodeAsString.PadRight(providerType.Size.Value).Substring(0, providerType.Size.Value);
				}
				return rawCodeAsString;
			}
			return rawCode;
		}
	}
}
