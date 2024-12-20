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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_KHACHHANG")]
	public partial class QL_KHACHHANGDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTrain_Data_(Train_Data_ instance);
    partial void UpdateTrain_Data_(Train_Data_ instance);
    partial void DeleteTrain_Data_(Train_Data_ instance);
    #endregion
		
		public QL_KHACHHANGDataContext() : 
				base(global::DTO.Properties.Settings.Default.QL_KHACHHANGConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QL_KHACHHANGDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QL_KHACHHANGDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QL_KHACHHANGDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QL_KHACHHANGDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Train_Data_> Train_Data_s
		{
			get
			{
				return this.GetTable<Train_Data_>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Train_Data$")]
	public partial class Train_Data_ : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private double _ID;
		
		private string _Gender;
		
		private string _Ever_Married;
		
		private System.Nullable<double> _Age;
		
		private string _Graduated;
		
		private string _Profession;
		
		private System.Nullable<double> _Work_Experience;
		
		private string _Spending_Score;
		
		private System.Nullable<double> _Family_Size;
		
		private string _Var_1;
		
		private string _Segmentation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(double value);
    partial void OnIDChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnEver_MarriedChanging(string value);
    partial void OnEver_MarriedChanged();
    partial void OnAgeChanging(System.Nullable<double> value);
    partial void OnAgeChanged();
    partial void OnGraduatedChanging(string value);
    partial void OnGraduatedChanged();
    partial void OnProfessionChanging(string value);
    partial void OnProfessionChanged();
    partial void OnWork_ExperienceChanging(System.Nullable<double> value);
    partial void OnWork_ExperienceChanged();
    partial void OnSpending_ScoreChanging(string value);
    partial void OnSpending_ScoreChanged();
    partial void OnFamily_SizeChanging(System.Nullable<double> value);
    partial void OnFamily_SizeChanged();
    partial void OnVar_1Changing(string value);
    partial void OnVar_1Changed();
    partial void OnSegmentationChanging(string value);
    partial void OnSegmentationChanged();
    #endregion
		
		public Train_Data_()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Float NOT NULL", IsPrimaryKey=true)]
		public double ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(255)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ever_Married", DbType="NVarChar(255)")]
		public string Ever_Married
		{
			get
			{
				return this._Ever_Married;
			}
			set
			{
				if ((this._Ever_Married != value))
				{
					this.OnEver_MarriedChanging(value);
					this.SendPropertyChanging();
					this._Ever_Married = value;
					this.SendPropertyChanged("Ever_Married");
					this.OnEver_MarriedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Float")]
		public System.Nullable<double> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Graduated", DbType="NVarChar(255)")]
		public string Graduated
		{
			get
			{
				return this._Graduated;
			}
			set
			{
				if ((this._Graduated != value))
				{
					this.OnGraduatedChanging(value);
					this.SendPropertyChanging();
					this._Graduated = value;
					this.SendPropertyChanged("Graduated");
					this.OnGraduatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profession", DbType="NVarChar(255)")]
		public string Profession
		{
			get
			{
				return this._Profession;
			}
			set
			{
				if ((this._Profession != value))
				{
					this.OnProfessionChanging(value);
					this.SendPropertyChanging();
					this._Profession = value;
					this.SendPropertyChanged("Profession");
					this.OnProfessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Work_Experience", DbType="Float")]
		public System.Nullable<double> Work_Experience
		{
			get
			{
				return this._Work_Experience;
			}
			set
			{
				if ((this._Work_Experience != value))
				{
					this.OnWork_ExperienceChanging(value);
					this.SendPropertyChanging();
					this._Work_Experience = value;
					this.SendPropertyChanged("Work_Experience");
					this.OnWork_ExperienceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Spending_Score", DbType="NVarChar(255)")]
		public string Spending_Score
		{
			get
			{
				return this._Spending_Score;
			}
			set
			{
				if ((this._Spending_Score != value))
				{
					this.OnSpending_ScoreChanging(value);
					this.SendPropertyChanging();
					this._Spending_Score = value;
					this.SendPropertyChanged("Spending_Score");
					this.OnSpending_ScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Family_Size", DbType="Float")]
		public System.Nullable<double> Family_Size
		{
			get
			{
				return this._Family_Size;
			}
			set
			{
				if ((this._Family_Size != value))
				{
					this.OnFamily_SizeChanging(value);
					this.SendPropertyChanging();
					this._Family_Size = value;
					this.SendPropertyChanged("Family_Size");
					this.OnFamily_SizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Var_1", DbType="NVarChar(255)")]
		public string Var_1
		{
			get
			{
				return this._Var_1;
			}
			set
			{
				if ((this._Var_1 != value))
				{
					this.OnVar_1Changing(value);
					this.SendPropertyChanging();
					this._Var_1 = value;
					this.SendPropertyChanged("Var_1");
					this.OnVar_1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Segmentation", DbType="NVarChar(255)")]
		public string Segmentation
		{
			get
			{
				return this._Segmentation;
			}
			set
			{
				if ((this._Segmentation != value))
				{
					this.OnSegmentationChanging(value);
					this.SendPropertyChanging();
					this._Segmentation = value;
					this.SendPropertyChanged("Segmentation");
					this.OnSegmentationChanged();
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
