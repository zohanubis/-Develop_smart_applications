﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bank")]
	public partial class BankDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public BankDataContext() : 
				base(global::DTO.Properties.Settings.Default.BankConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _customer_id;
		
		private System.Nullable<int> _credit_score;
		
		private string _country;
		
		private string _gender;
		
		private System.Nullable<int> _age;
		
		private System.Nullable<int> _tenure;
		
		private System.Nullable<double> _balance;
		
		private System.Nullable<int> _products_number;
		
		private System.Nullable<bool> _credit_card;
		
		private System.Nullable<bool> _active_member;
		
		private System.Nullable<double> _estimated_salary;
		
		private System.Nullable<bool> _churn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncustomer_idChanging(string value);
    partial void Oncustomer_idChanged();
    partial void Oncredit_scoreChanging(System.Nullable<int> value);
    partial void Oncredit_scoreChanged();
    partial void OncountryChanging(string value);
    partial void OncountryChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnageChanging(System.Nullable<int> value);
    partial void OnageChanged();
    partial void OntenureChanging(System.Nullable<int> value);
    partial void OntenureChanged();
    partial void OnbalanceChanging(System.Nullable<double> value);
    partial void OnbalanceChanged();
    partial void Onproducts_numberChanging(System.Nullable<int> value);
    partial void Onproducts_numberChanged();
    partial void Oncredit_cardChanging(System.Nullable<bool> value);
    partial void Oncredit_cardChanged();
    partial void Onactive_memberChanging(System.Nullable<bool> value);
    partial void Onactive_memberChanged();
    partial void Onestimated_salaryChanging(System.Nullable<double> value);
    partial void Onestimated_salaryChanged();
    partial void OnchurnChanging(System.Nullable<bool> value);
    partial void OnchurnChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_credit_score", DbType="Int")]
		public System.Nullable<int> credit_score
		{
			get
			{
				return this._credit_score;
			}
			set
			{
				if ((this._credit_score != value))
				{
					this.Oncredit_scoreChanging(value);
					this.SendPropertyChanging();
					this._credit_score = value;
					this.SendPropertyChanged("credit_score");
					this.Oncredit_scoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_country", DbType="VarChar(50)")]
		public string country
		{
			get
			{
				return this._country;
			}
			set
			{
				if ((this._country != value))
				{
					this.OncountryChanging(value);
					this.SendPropertyChanging();
					this._country = value;
					this.SendPropertyChanged("country");
					this.OncountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(10)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int")]
		public System.Nullable<int> age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenure", DbType="Int")]
		public System.Nullable<int> tenure
		{
			get
			{
				return this._tenure;
			}
			set
			{
				if ((this._tenure != value))
				{
					this.OntenureChanging(value);
					this.SendPropertyChanging();
					this._tenure = value;
					this.SendPropertyChanged("tenure");
					this.OntenureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_balance", DbType="Float")]
		public System.Nullable<double> balance
		{
			get
			{
				return this._balance;
			}
			set
			{
				if ((this._balance != value))
				{
					this.OnbalanceChanging(value);
					this.SendPropertyChanging();
					this._balance = value;
					this.SendPropertyChanged("balance");
					this.OnbalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_products_number", DbType="Int")]
		public System.Nullable<int> products_number
		{
			get
			{
				return this._products_number;
			}
			set
			{
				if ((this._products_number != value))
				{
					this.Onproducts_numberChanging(value);
					this.SendPropertyChanging();
					this._products_number = value;
					this.SendPropertyChanged("products_number");
					this.Onproducts_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_credit_card", DbType="Bit")]
		public System.Nullable<bool> credit_card
		{
			get
			{
				return this._credit_card;
			}
			set
			{
				if ((this._credit_card != value))
				{
					this.Oncredit_cardChanging(value);
					this.SendPropertyChanging();
					this._credit_card = value;
					this.SendPropertyChanged("credit_card");
					this.Oncredit_cardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active_member", DbType="Bit")]
		public System.Nullable<bool> active_member
		{
			get
			{
				return this._active_member;
			}
			set
			{
				if ((this._active_member != value))
				{
					this.Onactive_memberChanging(value);
					this.SendPropertyChanging();
					this._active_member = value;
					this.SendPropertyChanged("active_member");
					this.Onactive_memberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estimated_salary", DbType="Float")]
		public System.Nullable<double> estimated_salary
		{
			get
			{
				return this._estimated_salary;
			}
			set
			{
				if ((this._estimated_salary != value))
				{
					this.Onestimated_salaryChanging(value);
					this.SendPropertyChanging();
					this._estimated_salary = value;
					this.SendPropertyChanged("estimated_salary");
					this.Onestimated_salaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_churn", DbType="Bit")]
		public System.Nullable<bool> churn
		{
			get
			{
				return this._churn;
			}
			set
			{
				if ((this._churn != value))
				{
					this.OnchurnChanging(value);
					this.SendPropertyChanging();
					this._churn = value;
					this.SendPropertyChanged("churn");
					this.OnchurnChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591