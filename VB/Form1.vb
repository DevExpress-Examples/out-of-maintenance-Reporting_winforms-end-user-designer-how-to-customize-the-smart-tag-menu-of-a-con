Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports CustomReportControl
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace dxExample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            ShowDesigner()

        End Sub
        Private Sub ShowDesigner()
            Dim designer As New XRDesignFormEx()
            Dim r As New XtraReport()
            AddHandler r.DesignerLoaded, AddressOf r_DesignerLoaded
            designer.OpenReport(r)
            designer.ShowDialog()
        End Sub
        Private Sub r_DesignerLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs)
            Dim ts As IToolboxService = TryCast(e.DesignerHost.GetService(GetType(IToolboxService)), IToolboxService)
            RemoveStandardItem(ts)
            AddCustomItem(ts)
        End Sub
        Private Shared Sub RemoveStandardItem(ByVal ts As IToolboxService)
            Dim items As ToolboxItemCollection = ts.GetToolboxItems()
            Dim standardItem As ToolboxItem = items.OfType(Of ToolboxItem)().FirstOrDefault(Function(x) x.DisplayName = "Label")
            If standardItem IsNot Nothing Then
                ts.RemoveToolboxItem(standardItem)
            End If
        End Sub
        Private Shared Sub AddCustomItem(ByVal ts As IToolboxService)
            ts.AddToolboxItem(New ToolboxItem(GetType(CustomXRLbl)))
        End Sub
    End Class
End Namespace
