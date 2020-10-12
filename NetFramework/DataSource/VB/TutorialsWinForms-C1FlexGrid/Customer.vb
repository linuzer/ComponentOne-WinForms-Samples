'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Partial Public Class Customer
	Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value
            OnPropertyChanged("CustomerID")
        End Set
    End Property

    Private _CompanyName As String
    Public Property CompanyName As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal value As String)
            _CompanyName = value
            OnPropertyChanged("CompanyName")
        End Set
    End Property

    Private _ContactName As String
    Public Property ContactName As String
        Get
            Return _ContactName
        End Get
        Set(ByVal value As String)
            _ContactName = value
            OnPropertyChanged("ContactName")
        End Set
    End Property

    Private _ContactTitle As String
    Public Property ContactTitle As String
        Get
            Return _ContactTitle
        End Get
        Set(ByVal value As String)
            _ContactTitle = value
            OnPropertyChanged("ContactTitle")
        End Set
    End Property

    Private _Address As String
    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
            OnPropertyChanged("Address")
        End Set
    End Property

    Private _City As String
    Public Property City As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
            OnPropertyChanged("City")
        End Set
    End Property

    Private _Region As String
    Public Property Region As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
            OnPropertyChanged("Region")
        End Set
    End Property

    Private _PostalCode As String
    Public Property PostalCode As String
        Get
            Return _PostalCode
        End Get
        Set(ByVal value As String)
            _PostalCode = value
            OnPropertyChanged("PostalCode")
        End Set
    End Property

    Private _Country As String
    Public Property Country As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
            OnPropertyChanged("Country")
        End Set
    End Property

    Private _Phone As String
    Public Property Phone As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
            OnPropertyChanged("Phone")
        End Set
    End Property

    Private _Fax As String
    Public Property Fax As String
        Get
            Return _Fax
        End Get
        Set(ByVal value As String)
            _Fax = value
            OnPropertyChanged("Fax")
        End Set
    End Property


    Private _Orders As ObservableCollection(Of Order) = New ObservableCollection(Of Order)
    Public Overridable Property Orders As ObservableCollection(Of Order)
        Get
            Return _Orders
        End Get
        Set(ByVal value As ObservableCollection(Of Order))
            _Orders = value
            OnPropertyChanged("Orders")
        End Set
    End Property

    Private _CustomerDemographics As ObservableCollection(Of CustomerDemographic) = New ObservableCollection(Of CustomerDemographic)
    Public Overridable Property CustomerDemographics As ObservableCollection(Of CustomerDemographic)
        Get
            Return _CustomerDemographics
        End Get
        Set(ByVal value As ObservableCollection(Of CustomerDemographic))
            _CustomerDemographics = value
            OnPropertyChanged("CustomerDemographics")
        End Set
    End Property

End Class
