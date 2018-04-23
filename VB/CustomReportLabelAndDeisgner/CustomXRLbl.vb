Imports Microsoft.VisualBasic
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

		Private privateCustomProperty As String
		Public Property CustomProperty() As String
			Get
				Return privateCustomProperty
			End Get
			Set(ByVal value As String)
				privateCustomProperty = value
			End Set
		End Property
	End Class
End Namespace
