<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604952/14.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T211487)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))
* [TypeDescriptorFilterService.cs](./CS/WindowsFormsApplication1/TypeDescriptorFilterService.cs) (VB: [TypeDescriptorFilterService.vb](./VB/WindowsFormsApplication1/TypeDescriptorFilterService.vb))
* [XtraReport1.cs](./CS/WindowsFormsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication1/XtraReport1.vb))
<!-- default file list end -->
# WinForms End-User Designer - How to hide a property in the Properties window


This example demonstrates how to hide connection (<strong>ConnectionName</strong> and <strong>ConnectionParameter)</strong> properties of the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessSqlSqlDataSourcetopic">SqlDataSource</a> component set as a a report's data source.<br /><br />You can customize the Properties window for the report's End-User Designer, so only required properties are displayed.<br /> The <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2539">How to: Hide Properties from End-Users in the Report Designer</a> example illustrates how to implement this. The idea is to handle the static <a href="https://documentation.devexpress.com/XtraReports/DevExpressXtraReportsUIXtraReport_FilterComponentPropertiestopic.aspx">XtraReport.FilterComponentProperties</a> event and hide (or remove) an unnecessary property from the entire control's properties collection.<br />Please note that this approach is applicable for a <strong>report</strong>, its <strong>bands</strong> and <strong>XRControls </strong>(<a href="https://documentation.devexpress.com/XtraReports/clsDevExpressXtraReportsUIXRControltopic.aspx">XRControl</a> class descendants)<strong>.</strong><br /><br />If you want to hide properties for a non-XRControl descendant, for instance, for the report's data source, we recommend the following. <br />In the <strong><a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUserDesignerXRDesignMdiController_DesignPanelLoadedtopic">XRDesignMdiController.DesignPanelLoaded</a></strong> event handler, substitute the default ITypeDescriptorFilterService object with your custom one. In this custom ITypeDescriptorFilterService class, override the <strong>FilterProperties</strong> method to remove unnecessary properties.<br /><br />See also:<br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2552">Customize an End-User Report Designer</a><br /><br /><br />WPF: <a href="https://www.devexpress.com/Support/Center/p/T285448">WPF Report Designer - How to hide a property in the Properties window</a>

<br/>


