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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyKhachSan")]
	public partial class QuanLyKhachSanDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertPhong(Phong instance);
    partial void UpdatePhong(Phong instance);
    partial void DeletePhong(Phong instance);
    partial void InsertNhanPhong(NhanPhong instance);
    partial void UpdateNhanPhong(NhanPhong instance);
    partial void DeleteNhanPhong(NhanPhong instance);
    #endregion
		
		public QuanLyKhachSanDataContext() : 
				base(global::DTO.Properties.Settings.Default.QuanLyKhachSanConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyKhachSanDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyKhachSanDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyKhachSanDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyKhachSanDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<Phong> Phongs
		{
			get
			{
				return this.GetTable<Phong>();
			}
		}
		
		public System.Data.Linq.Table<NhanPhong> NhanPhongs
		{
			get
			{
				return this.GetTable<NhanPhong>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhachHang;
		
		private string _HoTen;
		
		private string _DiaChi;
		
		private string _DienThoai;
		
		private EntitySet<NhanPhong> _NhanPhongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    #endregion
		
		public KhachHang()
		{
			this._NhanPhongs = new EntitySet<NhanPhong>(new Action<NhanPhong>(this.attach_NhanPhongs), new Action<NhanPhong>(this.detach_NhanPhongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(100)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(200)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(20)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_NhanPhong", Storage="_NhanPhongs", ThisKey="MaKhachHang", OtherKey="MaKhachHang")]
		public EntitySet<NhanPhong> NhanPhongs
		{
			get
			{
				return this._NhanPhongs;
			}
			set
			{
				this._NhanPhongs.Assign(value);
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
		
		private void attach_NhanPhongs(NhanPhong entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_NhanPhongs(NhanPhong entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phong")]
	public partial class Phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhong;
		
		private System.Nullable<int> _SoNguoi;
		
		private System.Nullable<decimal> _DonGia;
		
		private EntitySet<NhanPhong> _NhanPhongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnSoNguoiChanging(System.Nullable<int> value);
    partial void OnSoNguoiChanged();
    partial void OnDonGiaChanging(System.Nullable<decimal> value);
    partial void OnDonGiaChanged();
    #endregion
		
		public Phong()
		{
			this._NhanPhongs = new EntitySet<NhanPhong>(new Action<NhanPhong>(this.attach_NhanPhongs), new Action<NhanPhong>(this.detach_NhanPhongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNguoi", DbType="Int")]
		public System.Nullable<int> SoNguoi
		{
			get
			{
				return this._SoNguoi;
			}
			set
			{
				if ((this._SoNguoi != value))
				{
					this.OnSoNguoiChanging(value);
					this.SendPropertyChanging();
					this._SoNguoi = value;
					this.SendPropertyChanged("SoNguoi");
					this.OnSoNguoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_NhanPhong", Storage="_NhanPhongs", ThisKey="MaPhong", OtherKey="MaPhong")]
		public EntitySet<NhanPhong> NhanPhongs
		{
			get
			{
				return this._NhanPhongs;
			}
			set
			{
				this._NhanPhongs.Assign(value);
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
		
		private void attach_NhanPhongs(NhanPhong entity)
		{
			this.SendPropertyChanging();
			entity.Phong = this;
		}
		
		private void detach_NhanPhongs(NhanPhong entity)
		{
			this.SendPropertyChanging();
			entity.Phong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanPhong")]
	public partial class NhanPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhanPhong;
		
		private string _MaKhachHang;
		
		private string _MaPhong;
		
		private System.Nullable<System.DateTime> _NgayVao;
		
		private System.Nullable<System.DateTime> _NgayDi;
		
		private System.Nullable<decimal> _ThanhTien;
		
		private EntityRef<KhachHang> _KhachHang;
		
		private EntityRef<Phong> _Phong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhanPhongChanging(string value);
    partial void OnMaNhanPhongChanged();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnMaPhongChanging(string value);
    partial void OnMaPhongChanged();
    partial void OnNgayVaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayVaoChanged();
    partial void OnNgayDiChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDiChanged();
    partial void OnThanhTienChanging(System.Nullable<decimal> value);
    partial void OnThanhTienChanged();
    #endregion
		
		public NhanPhong()
		{
			this._KhachHang = default(EntityRef<KhachHang>);
			this._Phong = default(EntityRef<Phong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanPhong", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhanPhong
		{
			get
			{
				return this._MaNhanPhong;
			}
			set
			{
				if ((this._MaNhanPhong != value))
				{
					this.OnMaNhanPhongChanging(value);
					this.SendPropertyChanging();
					this._MaNhanPhong = value;
					this.SendPropertyChanged("MaNhanPhong");
					this.OnMaNhanPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="VarChar(10)")]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhong", DbType="VarChar(10)")]
		public string MaPhong
		{
			get
			{
				return this._MaPhong;
			}
			set
			{
				if ((this._MaPhong != value))
				{
					if (this._Phong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPhongChanging(value);
					this.SendPropertyChanging();
					this._MaPhong = value;
					this.SendPropertyChanged("MaPhong");
					this.OnMaPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayVao", DbType="Date")]
		public System.Nullable<System.DateTime> NgayVao
		{
			get
			{
				return this._NgayVao;
			}
			set
			{
				if ((this._NgayVao != value))
				{
					this.OnNgayVaoChanging(value);
					this.SendPropertyChanging();
					this._NgayVao = value;
					this.SendPropertyChanged("NgayVao");
					this.OnNgayVaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDi", DbType="Date")]
		public System.Nullable<System.DateTime> NgayDi
		{
			get
			{
				return this._NgayDi;
			}
			set
			{
				if ((this._NgayDi != value))
				{
					this.OnNgayDiChanging(value);
					this.SendPropertyChanging();
					this._NgayDi = value;
					this.SendPropertyChanged("NgayDi");
					this.OnNgayDiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_NhanPhong", Storage="_KhachHang", ThisKey="MaKhachHang", OtherKey="MaKhachHang", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.NhanPhongs.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.NhanPhongs.Add(this);
						this._MaKhachHang = value.MaKhachHang;
					}
					else
					{
						this._MaKhachHang = default(string);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phong_NhanPhong", Storage="_Phong", ThisKey="MaPhong", OtherKey="MaPhong", IsForeignKey=true)]
		public Phong Phong
		{
			get
			{
				return this._Phong.Entity;
			}
			set
			{
				Phong previousValue = this._Phong.Entity;
				if (((previousValue != value) 
							|| (this._Phong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phong.Entity = null;
						previousValue.NhanPhongs.Remove(this);
					}
					this._Phong.Entity = value;
					if ((value != null))
					{
						value.NhanPhongs.Add(this);
						this._MaPhong = value.MaPhong;
					}
					else
					{
						this._MaPhong = default(string);
					}
					this.SendPropertyChanged("Phong");
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
