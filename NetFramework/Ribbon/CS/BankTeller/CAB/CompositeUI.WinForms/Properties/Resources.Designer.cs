﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.CompositeUI.WinForms.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.CompositeUI.WinForms.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to There are no zones in the workspace to display smart parts..
        /// </summary>
        internal static string NoZonesInZoneWorkspace {
            get {
                return ResourceManager.GetString("NoZonesInZoneWorkspace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no zone named {0} to display the smart part in..
        /// </summary>
        internal static string NoZoneWithName {
            get {
                return ResourceManager.GetString("NoZoneWithName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Smart part is not a control..
        /// </summary>
        internal static string SmartPartNotControl {
            get {
                return ResourceManager.GetString("SmartPartNotControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Smart part has not been shown previously by the current manager..
        /// </summary>
        internal static string SmartPartNotInManager {
            get {
                return ResourceManager.GetString("SmartPartNotInManager", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Workspace supports smart parts of type {0}..
        /// </summary>
        internal static string UnsupportedSmartPartType {
            get {
                return ResourceManager.GetString("UnsupportedSmartPartType", resourceCulture);
            }
        }
    }
}
