<!-- default file list -->
*Files to look at*:

* [CustomXRLbl.cs](./CS/CustomReportLabelAndDeisgner/CustomXRLbl.cs) (VB: [CustomXRLblDesigner.vb](./VB/CustomReportLabelAndDeisgner/CustomXRLblDesigner.vb))
* [CustomXRLblDesigner.cs](./CS/CustomReportLabelAndDeisgner/CustomXRLblDesigner.cs) (VB: [CustomXRLblDesigner.vb](./VB/CustomReportLabelAndDeisgner/CustomXRLblDesigner.vb))
* **[XRLabelDesignerCustomActionList.cs](./CS/CustomReportLabelAndDeisgner/XRLabelDesignerCustomActionList.cs) (VB: [XRLabelDesignerCustomActionList.vb](./VB/CustomReportLabelAndDeisgner/XRLabelDesignerCustomActionList.vb))**
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# WinForms End-User Designer - How to customize the Smart Tag menu of a control


<p>This example demonstrates how to customize the <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRLabeltopic">XRLabel</a>'s Smart Tag menu to make the following properties available: <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_Texttopic">Text</a>, <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_DataBindingstopic">Data Binding (the Text property)</a>, <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_WidthFtopic">WidthF</a>, <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_HeightFtopic">HeightF</a>, <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_LocationFtopic">LocationF.X</a>, <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_LocationFtopic">LocationF.Y</a>.<br>To achieve this, we do the following:<br>1. Implement a DevExpress.XtraReports.Design.XRControlDesigner descendant and override XRControlDesigner.RegisterActionLists to provide a custom action list.<br>2. Create a custom report control by subclassing a required control (<a href="https://documentation.devexpress.com/#xtrareports/CustomDocument2607">Creating Custom Controls</a>) and register the custom control on the toolbox by using the design-time <strong>IToolboxService</strong> service. <br>For more information on adding custom controls to the Toolbox and removing standard ones from it, check the following articles:<br><a href="https://documentation.devexpress.com/#xtrareports/CustomDocument7546">How to: Register a Custom Control in the End-User Designer's Toolbox</a>.<br><a href="https://documentation.devexpress.com/#xtrareports/CustomDocument2212">How to: Make a Custom Control be Available Only for a Specific Report Instance</a> <br>3. Link this designer to the custom XRControl by using the XRDesigner attribute. <br><br>See also:<br><a href="https://www.devexpress.com/Support/Center/p/E57">How to create custom report controls</a><br><a href="https://www.devexpress.com/Support/Center/p/T317195">How to programatically invoke the smart tag once an XRControl is added to report in the WinForms End-User Designer</a><br><a href="https://www.devexpress.com/Support/Center/p/T335090">How to remove the ReportSource property from a smart tag menu of the XRSubreport control</a></p>

<br/>


