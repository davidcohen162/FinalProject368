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

namespace FinalProject368
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FinalProject368Database")]
	public partial class FinalProject368DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItemsForSale(ItemsForSale instance);
    partial void UpdateItemsForSale(ItemsForSale instance);
    partial void DeleteItemsForSale(ItemsForSale instance);
    partial void InsertPurchase(Purchase instance);
    partial void UpdatePurchase(Purchase instance);
    partial void DeletePurchase(Purchase instance);
    partial void InsertUserAccount(UserAccount instance);
    partial void UpdateUserAccount(UserAccount instance);
    partial void DeleteUserAccount(UserAccount instance);
    #endregion
		
		public FinalProject368DatabaseDataContext() : 
				base(global::FinalProject368.Properties.Settings.Default.FinalProject368DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FinalProject368DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FinalProject368DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FinalProject368DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FinalProject368DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ItemsForSale> ItemsForSales
		{
			get
			{
				return this.GetTable<ItemsForSale>();
			}
		}
		
		public System.Data.Linq.Table<Purchase> Purchases
		{
			get
			{
				return this.GetTable<Purchase>();
			}
		}
		
		public System.Data.Linq.Table<UserAccount> UserAccounts
		{
			get
			{
				return this.GetTable<UserAccount>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemsForSale")]
	public partial class ItemsForSale : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemID;
		
		private string _ItemName;
		
		private decimal _ItemPrice;
		
		private int _ItemQuantity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIDChanging(int value);
    partial void OnItemIDChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    partial void OnItemPriceChanging(decimal value);
    partial void OnItemPriceChanged();
    partial void OnItemQuantityChanging(int value);
    partial void OnItemQuantityChanged();
    #endregion
		
		public ItemsForSale()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ItemName
		{
			get
			{
				return this._ItemName;
			}
			set
			{
				if ((this._ItemName != value))
				{
					this.OnItemNameChanging(value);
					this.SendPropertyChanging();
					this._ItemName = value;
					this.SendPropertyChanged("ItemName");
					this.OnItemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemPrice", DbType="Decimal(18,2) NOT NULL")]
		public decimal ItemPrice
		{
			get
			{
				return this._ItemPrice;
			}
			set
			{
				if ((this._ItemPrice != value))
				{
					this.OnItemPriceChanging(value);
					this.SendPropertyChanging();
					this._ItemPrice = value;
					this.SendPropertyChanged("ItemPrice");
					this.OnItemPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemQuantity", DbType="Int NOT NULL")]
		public int ItemQuantity
		{
			get
			{
				return this._ItemQuantity;
			}
			set
			{
				if ((this._ItemQuantity != value))
				{
					this.OnItemQuantityChanging(value);
					this.SendPropertyChanging();
					this._ItemQuantity = value;
					this.SendPropertyChanged("ItemQuantity");
					this.OnItemQuantityChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Purchases")]
	public partial class Purchase : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PurchaseId;
		
		private int _UserId;
		
		private string _Username;
		
		private string _Fname;
		
		private string _Lname;
		
		private int _ItemID;
		
		private string _ItemName;
		
		private int _ItemQuantity;
		
		private decimal _BalanceChange;
		
		private decimal _BalanceAfter;
		
		private System.DateTime _Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseIdChanging(int value);
    partial void OnPurchaseIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnFnameChanging(string value);
    partial void OnFnameChanged();
    partial void OnLnameChanging(string value);
    partial void OnLnameChanged();
    partial void OnItemIDChanging(int value);
    partial void OnItemIDChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    partial void OnItemQuantityChanging(int value);
    partial void OnItemQuantityChanged();
    partial void OnBalanceChangeChanging(decimal value);
    partial void OnBalanceChangeChanged();
    partial void OnBalanceAfterChanging(decimal value);
    partial void OnBalanceAfterChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Purchase()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PurchaseId
		{
			get
			{
				return this._PurchaseId;
			}
			set
			{
				if ((this._PurchaseId != value))
				{
					this.OnPurchaseIdChanging(value);
					this.SendPropertyChanging();
					this._PurchaseId = value;
					this.SendPropertyChanged("PurchaseId");
					this.OnPurchaseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Fname
		{
			get
			{
				return this._Fname;
			}
			set
			{
				if ((this._Fname != value))
				{
					this.OnFnameChanging(value);
					this.SendPropertyChanging();
					this._Fname = value;
					this.SendPropertyChanged("Fname");
					this.OnFnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Lname
		{
			get
			{
				return this._Lname;
			}
			set
			{
				if ((this._Lname != value))
				{
					this.OnLnameChanging(value);
					this.SendPropertyChanging();
					this._Lname = value;
					this.SendPropertyChanged("Lname");
					this.OnLnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="Int NOT NULL")]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ItemName
		{
			get
			{
				return this._ItemName;
			}
			set
			{
				if ((this._ItemName != value))
				{
					this.OnItemNameChanging(value);
					this.SendPropertyChanging();
					this._ItemName = value;
					this.SendPropertyChanged("ItemName");
					this.OnItemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemQuantity", DbType="Int NOT NULL")]
		public int ItemQuantity
		{
			get
			{
				return this._ItemQuantity;
			}
			set
			{
				if ((this._ItemQuantity != value))
				{
					this.OnItemQuantityChanging(value);
					this.SendPropertyChanging();
					this._ItemQuantity = value;
					this.SendPropertyChanged("ItemQuantity");
					this.OnItemQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BalanceChange", DbType="Decimal(18,2) NOT NULL")]
		public decimal BalanceChange
		{
			get
			{
				return this._BalanceChange;
			}
			set
			{
				if ((this._BalanceChange != value))
				{
					this.OnBalanceChangeChanging(value);
					this.SendPropertyChanging();
					this._BalanceChange = value;
					this.SendPropertyChanged("BalanceChange");
					this.OnBalanceChangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BalanceAfter", DbType="Decimal(18,2) NOT NULL")]
		public decimal BalanceAfter
		{
			get
			{
				return this._BalanceAfter;
			}
			set
			{
				if ((this._BalanceAfter != value))
				{
					this.OnBalanceAfterChanging(value);
					this.SendPropertyChanging();
					this._BalanceAfter = value;
					this.SendPropertyChanged("BalanceAfter");
					this.OnBalanceAfterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserAccounts")]
	public partial class UserAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Username;
		
		private string _Fname;
		
		private string _Lname;
		
		private string _Password;
		
		private decimal _Balance;
		
		private bool _isLoggedIn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnFnameChanging(string value);
    partial void OnFnameChanged();
    partial void OnLnameChanging(string value);
    partial void OnLnameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBalanceChanging(decimal value);
    partial void OnBalanceChanged();
    partial void OnisLoggedInChanging(bool value);
    partial void OnisLoggedInChanged();
    #endregion
		
		public UserAccount()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Fname
		{
			get
			{
				return this._Fname;
			}
			set
			{
				if ((this._Fname != value))
				{
					this.OnFnameChanging(value);
					this.SendPropertyChanging();
					this._Fname = value;
					this.SendPropertyChanged("Fname");
					this.OnFnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Lname
		{
			get
			{
				return this._Lname;
			}
			set
			{
				if ((this._Lname != value))
				{
					this.OnLnameChanging(value);
					this.SendPropertyChanging();
					this._Lname = value;
					this.SendPropertyChanged("Lname");
					this.OnLnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Decimal(18,2) NOT NULL")]
		public decimal Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isLoggedIn", DbType="Bit NOT NULL")]
		public bool isLoggedIn
		{
			get
			{
				return this._isLoggedIn;
			}
			set
			{
				if ((this._isLoggedIn != value))
				{
					this.OnisLoggedInChanging(value);
					this.SendPropertyChanging();
					this._isLoggedIn = value;
					this.SendPropertyChanged("isLoggedIn");
					this.OnisLoggedInChanged();
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