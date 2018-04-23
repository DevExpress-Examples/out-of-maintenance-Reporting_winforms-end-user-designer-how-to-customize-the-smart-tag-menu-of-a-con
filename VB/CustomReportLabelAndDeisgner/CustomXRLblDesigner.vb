Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraReports.Design
Imports System.ComponentModel.Design

Namespace CustomReportControl
    Friend Class CustomXRLblDesigner
        Inherits XRLabelDesigner

        Public Sub New()
            MyBase.New()
        End Sub
        Protected Overrides Sub RegisterActionLists(ByVal list As DesignerActionListCollection)
            list.Add(New XRLabelDesignerCustomActionList(Me))
        End Sub
    End Class
End Namespace
