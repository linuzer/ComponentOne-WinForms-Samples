﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlFilter.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SqlFilter.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;OlapViews&gt;
        ///
        ///  &lt;C1Olap id=&quot;category_country&quot;&gt;
        ///    &lt;Fields&gt;
        ///      &lt;Field name=&quot;Sales&quot; subtotal=&quot;Sum&quot; format=&quot;n0&quot; /&gt;
        ///      &lt;Field name=&quot;OrderDate&quot; subtotal=&quot;Count&quot; format=&quot;d&quot; /&gt;
        ///      &lt;Field name=&quot;Product&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;Customer&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;Country&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;Employee&quot; subtotal=&quot;Count&quot; /&gt;
        ///      &lt;Field name=&quot;Category&quot; subtotal=&quot;Count&quot; /&gt;
        ///    &lt;/Fields&gt;
        ///    &lt;RowFields&gt;
        ///      &lt;Fie [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FlexPivotViews {
            get {
                return ResourceManager.GetString("FlexPivotViews", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT DISTINCT 
        ///    ([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount) AS [Sales],
        ///    Orders.OrderDate AS [OrderDate],
        ///    Products.ProductName AS [Product],
        ///    Customers.CompanyName AS [Customer],
        ///    Customers.Country AS [Country],
        ///    Employees.FirstName + &apos; &apos; + Employees.LastName AS [Employee],
        ///    Categories.CategoryName AS [Category]
        ///FROM 
        ///    (Employees INNER JOIN
        ///    (Customers INNER JOIN
        ///    (Orders INNER JOIN
        ///    ([Order Details] INNER JOIN
        ///    (Products INNER  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlTemplate {
            get {
                return ResourceManager.GetString("SqlTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WHERE Customers.CompanyName in ({0}).
        /// </summary>
        internal static string WhereTemplate {
            get {
                return ResourceManager.GetString("WhereTemplate", resourceCulture);
            }
        }
    }
}
