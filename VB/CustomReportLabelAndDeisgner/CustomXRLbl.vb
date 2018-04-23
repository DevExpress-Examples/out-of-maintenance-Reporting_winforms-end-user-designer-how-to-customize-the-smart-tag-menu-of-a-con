Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports

Namespace CustomReportControl
    <XRDesigner("CustomReportControl.CustomXRLblDesigner")> _
    Public Class CustomXRLbl
        Inherits XRLabel

        Public Sub New()
            MyBase.New()
        End Sub

        Public Property CustomProperty() As String
    End Class
End Namespace
