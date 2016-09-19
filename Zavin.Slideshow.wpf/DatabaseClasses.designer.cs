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

namespace Zavin.Slideshow.wpf
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mczavidord")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertacaf(acaf instance);
    partial void Updateacaf(acaf instance);
    partial void Deleteacaf(acaf instance);
    partial void Insertconfig(config instance);
    partial void Updateconfig(config instance);
    partial void Deleteconfig(config instance);
    partial void Insertwachtboek(wachtboek instance);
    partial void Updatewachtboek(wachtboek instance);
    partial void Deletewachtboek(wachtboek instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Zavin.Slideshow.wpf.Properties.Settings.Default.mczavidordConnectionString3, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<acaf> acafs
		{
			get
			{
				return this.GetTable<acaf>();
			}
		}
		
		public System.Data.Linq.Table<config> configs
		{
			get
			{
				return this.GetTable<config>();
			}
		}
		
		public System.Data.Linq.Table<wachtboek> wachtboeks
		{
			get
			{
				return this.GetTable<wachtboek>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="mcmain.acaf")]
	public partial class acaf : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _acaf_nmr;
		
		private System.Nullable<System.DateTime> _acaf_datum;
		
		private System.Nullable<decimal> _acaf_gewge;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onacaf_nmrChanging(string value);
    partial void Onacaf_nmrChanged();
    partial void Onacaf_datumChanging(System.Nullable<System.DateTime> value);
    partial void Onacaf_datumChanged();
    partial void Onacaf_gewgeChanging(System.Nullable<decimal> value);
    partial void Onacaf_gewgeChanged();
    #endregion
		
		public acaf()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_acaf_nmr", DbType="Char(16) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string acaf_nmr
		{
			get
			{
				return this._acaf_nmr;
			}
			set
			{
				if ((this._acaf_nmr != value))
				{
					this.Onacaf_nmrChanging(value);
					this.SendPropertyChanging();
					this._acaf_nmr = value;
					this.SendPropertyChanged("acaf_nmr");
					this.Onacaf_nmrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_acaf_datum", DbType="DateTime")]
		public System.Nullable<System.DateTime> acaf_datum
		{
			get
			{
				return this._acaf_datum;
			}
			set
			{
				if ((this._acaf_datum != value))
				{
					this.Onacaf_datumChanging(value);
					this.SendPropertyChanging();
					this._acaf_datum = value;
					this.SendPropertyChanged("acaf_datum");
					this.Onacaf_datumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_acaf_gewge", DbType="Decimal(8,0)")]
		public System.Nullable<decimal> acaf_gewge
		{
			get
			{
				return this._acaf_gewge;
			}
			set
			{
				if ((this._acaf_gewge != value))
				{
					this.Onacaf_gewgeChanging(value);
					this.SendPropertyChanging();
					this._acaf_gewge = value;
					this.SendPropertyChanged("acaf_gewge");
					this.Onacaf_gewgeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="mcmain.config")]
	public partial class config : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _YearTargetTon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnYearTargetTonChanging(System.Nullable<int> value);
    partial void OnYearTargetTonChanged();
    #endregion
		
		public config()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearTargetTon", DbType="Int")]
		public System.Nullable<int> YearTargetTon
		{
			get
			{
				return this._YearTargetTon;
			}
			set
			{
				if ((this._YearTargetTon != value))
				{
					this.OnYearTargetTonChanging(value);
					this.SendPropertyChanging();
					this._YearTargetTon = value;
					this.SendPropertyChanged("YearTargetTon");
					this.OnYearTargetTonChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="mcmain.wachtboek")]
	public partial class wachtboek : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _wb_nmr;
		
		private System.Nullable<System.DateTime> _wb_date;
		
		private System.Nullable<decimal> _wb_verstoo;
		
		private System.Nullable<decimal> _wb_wasta;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onwb_nmrChanging(string value);
    partial void Onwb_nmrChanged();
    partial void Onwb_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onwb_dateChanged();
    partial void Onwb_verstooChanging(System.Nullable<decimal> value);
    partial void Onwb_verstooChanged();
    partial void Onwb_wastaChanging(System.Nullable<decimal> value);
    partial void Onwb_wastaChanged();
    #endregion
		
		public wachtboek()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wb_nmr", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string wb_nmr
		{
			get
			{
				return this._wb_nmr;
			}
			set
			{
				if ((this._wb_nmr != value))
				{
					this.Onwb_nmrChanging(value);
					this.SendPropertyChanging();
					this._wb_nmr = value;
					this.SendPropertyChanged("wb_nmr");
					this.Onwb_nmrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wb_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> wb_date
		{
			get
			{
				return this._wb_date;
			}
			set
			{
				if ((this._wb_date != value))
				{
					this.Onwb_dateChanging(value);
					this.SendPropertyChanging();
					this._wb_date = value;
					this.SendPropertyChanged("wb_date");
					this.Onwb_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wb_verstoo", DbType="Decimal(8,0)")]
		public System.Nullable<decimal> wb_verstoo
		{
			get
			{
				return this._wb_verstoo;
			}
			set
			{
				if ((this._wb_verstoo != value))
				{
					this.Onwb_verstooChanging(value);
					this.SendPropertyChanging();
					this._wb_verstoo = value;
					this.SendPropertyChanged("wb_verstoo");
					this.Onwb_verstooChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wb_wasta", DbType="Decimal(2,0)")]
		public System.Nullable<decimal> wb_wasta
		{
			get
			{
				return this._wb_wasta;
			}
			set
			{
				if ((this._wb_wasta != value))
				{
					this.Onwb_wastaChanging(value);
					this.SendPropertyChanging();
					this._wb_wasta = value;
					this.SendPropertyChanged("wb_wasta");
					this.Onwb_wastaChanged();
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