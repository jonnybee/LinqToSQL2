﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace WriteTests.EntityClasses
{
	/// <summary>Class which represents the entity 'Employee', mapped on table 'LLBLGenProUnitTest.dbo.Employee'.</summary>
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_employeeId;
		private System.DateTime	_employeeSince;
		private Nullable<System.Int32>	_managedBy;
		private System.String	_name;
		private System.Data.Linq.Binary	_photo;
		private System.Guid	_testRunId;
		private EntityRef <Employee> _managedByEmployee;
		private EntitySet <Employee> _managesEmployees;
		private EntitySet <Order> _orders;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnEmployeeIdChanging(System.Int32 value);
		partial void OnEmployeeIdChanged();
		partial void OnEmployeeSinceChanging(System.DateTime value);
		partial void OnEmployeeSinceChanged();
		partial void OnManagedByChanging(Nullable<System.Int32> value);
		partial void OnManagedByChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnPhotoChanging(System.Data.Linq.Binary value);
		partial void OnPhotoChanged();
		partial void OnTestRunIdChanging(System.Guid value);
		partial void OnTestRunIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Employee"/> class.</summary>
		public Employee()
		{
			_managedByEmployee = default(EntityRef<Employee>);
			_managesEmployees = new EntitySet<Employee>(new Action<Employee>(this.Attach_ManagesEmployees), new Action<Employee>(this.Detach_ManagesEmployees) );
			_orders = new EntitySet<Order>(new Action<Order>(this.Attach_Orders), new Action<Order>(this.Detach_Orders) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_ManagesEmployees(Employee entity)
		{
			this.SendPropertyChanging("ManagesEmployees");
			entity.ManagedByEmployee = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_ManagesEmployees(Employee entity)
		{
			this.SendPropertyChanging("ManagesEmployees");
			entity.ManagedByEmployee = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_Orders(Order entity)
		{
			this.SendPropertyChanging("Orders");
			entity.Employee = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_Orders(Order entity)
		{
			this.SendPropertyChanging("Orders");
			entity.Employee = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the EmployeeId field. Mapped on target field 'EmployeeID'. </summary>
		public System.Int32 EmployeeId
		{
			get	{ return _employeeId; }
			set
			{
				if((_employeeId != value))
				{
					OnEmployeeIdChanging(value);
					SendPropertyChanging("EmployeeId");
					_employeeId = value;
					SendPropertyChanged("EmployeeId");
					OnEmployeeIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the EmployeeSince field. Mapped on target field 'EmployeeSince'. </summary>
		public System.DateTime EmployeeSince
		{
			get	{ return _employeeSince; }
			set
			{
				if((_employeeSince != value))
				{
					OnEmployeeSinceChanging(value);
					SendPropertyChanging("EmployeeSince");
					_employeeSince = value;
					SendPropertyChanged("EmployeeSince");
					OnEmployeeSinceChanged();
				}
			}
		}

		/// <summary>Gets or sets the ManagedBy field. Mapped on target field 'ManagedBy'. </summary>
		public Nullable<System.Int32> ManagedBy
		{
			get	{ return _managedBy; }
			set
			{
				if((_managedBy != value))
				{
					if(_managedByEmployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					if(_managedByEmployee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnManagedByChanging(value);
					SendPropertyChanging("ManagedBy");
					_managedBy = value;
					SendPropertyChanged("ManagedBy");
					OnManagedByChanged();
				}
			}
		}

		/// <summary>Gets or sets the Name field. Mapped on target field 'Name'. </summary>
		public System.String Name
		{
			get	{ return _name; }
			set
			{
				if((_name != value))
				{
					OnNameChanging(value);
					SendPropertyChanging("Name");
					_name = value;
					SendPropertyChanged("Name");
					OnNameChanged();
				}
			}
		}

		/// <summary>Gets or sets the Photo field. Mapped on target field 'Photo'. </summary>
		public System.Data.Linq.Binary Photo
		{
			get	{ return _photo; }
			set
			{
				if((_photo != value))
				{
					OnPhotoChanging(value);
					SendPropertyChanging("Photo");
					_photo = value;
					SendPropertyChanged("Photo");
					OnPhotoChanged();
				}
			}
		}

		/// <summary>Gets or sets the TestRunId field. Mapped on target field 'TestRunID'. </summary>
		public System.Guid TestRunId
		{
			get	{ return _testRunId; }
			set
			{
				if((_testRunId != value))
				{
					OnTestRunIdChanging(value);
					SendPropertyChanging("TestRunId");
					_testRunId = value;
					SendPropertyChanged("TestRunId");
					OnTestRunIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Employee.ManagedByEmployee - Employee.ManagesEmployees (m:1)'</summary>
		public Employee ManagedByEmployee
		{
			get { return _managedByEmployee.Entity; }
			set
			{
				Employee previousValue = _managedByEmployee.Entity;
				if((previousValue != value) || (_managedByEmployee.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("ManagedByEmployee");
					if(previousValue != null)
					{
						_managedByEmployee.Entity = null;
						previousValue.ManagesEmployees.Remove(this);
					}
					_managedByEmployee.Entity = value;
					if(value == null)
					{
						_managedBy = default(Nullable<System.Int32>);
					}
					else
					{
						value.ManagesEmployees.Add(this);
						_managedBy = value.EmployeeId;
					}
					this.SendPropertyChanged("ManagedByEmployee");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Employee.ManagedByEmployee - Employee.ManagesEmployees (m:1)'</summary>
		public EntitySet<Employee> ManagesEmployees
		{
			get { return this._managesEmployees; }
			set { this._managesEmployees.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Order.Employee - Employee.Orders (m:1)'</summary>
		public EntitySet<Order> Orders
		{
			get { return this._orders; }
			set { this._orders.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649