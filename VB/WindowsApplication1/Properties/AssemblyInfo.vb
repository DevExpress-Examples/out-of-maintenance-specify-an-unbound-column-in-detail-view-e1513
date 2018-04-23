' Developer Express Code Central Example:
' Specify an unbound column in detail view
' 
' You should configure your detail view as described in the Master-Detail:
' DataTable Use
' (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/CustomDocument731.htm) help
' topic. Take note of the 5th point: "Specify and Customize Views To Represent
' Datatables ". Create an unbound column for the detail view, and subscribe to the
' CustomUnboundColumnData event of the detail view. Handle this event as described
' in the following topic:
' ColumnView.CustomUnboundColumnData Event
' (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsBaseColumnView_CustomUnboundColumnDatatopic.htm)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1513

Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("WindowsApplication1")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("WindowsApplication1")>
<Assembly: AssemblyCopyright("Copyright ©  2008")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("a419e9b3-e21f-4450-99c3-5a7d59437d29")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
