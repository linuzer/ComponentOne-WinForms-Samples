//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdersEFWinForms
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    
    public partial class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    	protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    
        public Order()
        {
            this.Order_Details = new ObservableCollection<Order_Detail>();
        }
    
        int _OrderID;
        public int OrderID 
        {
            get { return _OrderID; }
            set
            {
                _OrderID = value;
                OnPropertyChanged("OrderID");
            }
        }
        string _CustomerID;
        public string CustomerID 
        {
            get { return _CustomerID; }
            set
            {
                _CustomerID = value;
                OnPropertyChanged("CustomerID");
            }
        }
        Nullable<int> _EmployeeID;
        public Nullable<int> EmployeeID 
        {
            get { return _EmployeeID; }
            set
            {
                _EmployeeID = value;
                OnPropertyChanged("EmployeeID");
            }
        }
        Nullable<System.DateTime> _OrderDate;
        public Nullable<System.DateTime> OrderDate 
        {
            get { return _OrderDate; }
            set
            {
                _OrderDate = value;
                OnPropertyChanged("OrderDate");
            }
        }
        Nullable<System.DateTime> _RequiredDate;
        public Nullable<System.DateTime> RequiredDate 
        {
            get { return _RequiredDate; }
            set
            {
                _RequiredDate = value;
                OnPropertyChanged("RequiredDate");
            }
        }
        Nullable<System.DateTime> _ShippedDate;
        public Nullable<System.DateTime> ShippedDate 
        {
            get { return _ShippedDate; }
            set
            {
                _ShippedDate = value;
                OnPropertyChanged("ShippedDate");
            }
        }
        Nullable<int> _ShipVia;
        public Nullable<int> ShipVia 
        {
            get { return _ShipVia; }
            set
            {
                _ShipVia = value;
                OnPropertyChanged("ShipVia");
            }
        }
        Nullable<decimal> _Freight;
        public Nullable<decimal> Freight 
        {
            get { return _Freight; }
            set
            {
                _Freight = value;
                OnPropertyChanged("Freight");
            }
        }
        string _ShipName;
        public string ShipName 
        {
            get { return _ShipName; }
            set
            {
                _ShipName = value;
                OnPropertyChanged("ShipName");
            }
        }
        string _ShipAddress;
        public string ShipAddress 
        {
            get { return _ShipAddress; }
            set
            {
                _ShipAddress = value;
                OnPropertyChanged("ShipAddress");
            }
        }
        string _ShipCity;
        public string ShipCity 
        {
            get { return _ShipCity; }
            set
            {
                _ShipCity = value;
                OnPropertyChanged("ShipCity");
            }
        }
        string _ShipRegion;
        public string ShipRegion 
        {
            get { return _ShipRegion; }
            set
            {
                _ShipRegion = value;
                OnPropertyChanged("ShipRegion");
            }
        }
        string _ShipPostalCode;
        public string ShipPostalCode 
        {
            get { return _ShipPostalCode; }
            set
            {
                _ShipPostalCode = value;
                OnPropertyChanged("ShipPostalCode");
            }
        }
        string _ShipCountry;
        public string ShipCountry 
        {
            get { return _ShipCountry; }
            set
            {
                _ShipCountry = value;
                OnPropertyChanged("ShipCountry");
            }
        }
    
        public virtual Customer Customer { get; set; }
        public virtual ObservableCollection<Order_Detail> Order_Details { get; set; }
    }
}
