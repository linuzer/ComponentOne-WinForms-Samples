﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
Public Module Resources
    
    Private resourceMan As Global.System.Resources.ResourceManager
    
    Private resourceCulture As Global.System.Globalization.CultureInfo
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WorkingWithTopicMap.Resources", GetType(Resources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Public Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to &lt;Dictionary&gt;
    '''  &lt;item&gt;
    '''    &lt;key&gt;Form1&lt;/key&gt;
    '''    &lt;value&gt;WordDocuments/overview.htm&lt;/value&gt;
    '''    &lt;events useDefaultEvents=&quot;True&quot;&gt;0&lt;/events&gt;
    '''    &lt;onload&gt;True&lt;/onload&gt;
    '''  &lt;/item&gt;
    '''&lt;/Dictionary&gt;.
    '''</summary>
    Public ReadOnly Property ResTopicMap() As String
        Get
            Return ResourceManager.GetString("ResTopicMap", resourceCulture)
        End Get
    End Property
End Module
