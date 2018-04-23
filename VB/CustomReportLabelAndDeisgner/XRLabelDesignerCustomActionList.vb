Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UI

Namespace CustomReportControl
    Public Class XRLabelDesignerCustomActionList
        Inherits XRControlTextDesignerActionList

        Public Sub New(ByVal designer As XRControlDesigner)
            MyBase.New(designer)
        End Sub
        Private ReadOnly Property Label() As XRLabel
            Get
                Return CType(Component, XRLabel)
            End Get
        End Property
        <RefreshProperties(RefreshProperties.All)> _
        Public Property WidthF() As Single
            Get
                Return Label.WidthF
            End Get
            Set(ByVal value As Single)
                SetPropertyValue("WidthF", value)
            End Set
        End Property
        <RefreshProperties(RefreshProperties.All)> _
        Public Property HeightF() As Single
            Get
                Return Label.HeightF
            End Get
            Set(ByVal value As Single)
                SetPropertyValue("HeightF", value)
            End Set
        End Property
        <RefreshProperties(RefreshProperties.All)> _
        Public Property LocationX() As Single
            Get
                Return Label.LocationF.X
            End Get
            Set(ByVal value As Single)
                SetPropertyValue("LocationF", New PointF(value, Label.LocationF.Y))
            End Set
        End Property
        <RefreshProperties(RefreshProperties.All)> _
        Public Property LocationY() As Single
            Get
                Return Label.LocationF.Y
            End Get
            Set(ByVal value As Single)
                SetPropertyValue("LocationF", New PointF(Label.LocationF.X, value))
            End Set
        End Property
        Public Overrides Function GetSortedActionItems() As DesignerActionItemCollection
            Dim items As DesignerActionItemCollection = MyBase.GetSortedActionItems()
            Dim item As DesignerActionPropertyItem = items.OfType(Of DesignerActionPropertyItem)().FirstOrDefault(Function(x) x.MemberName = "FormatString")
            If item IsNot Nothing Then
                items.Remove(item)
            End If
            items.Add(New DesignerActionPropertyItem("WidthF", "WidthF"))
            items.Add(New DesignerActionPropertyItem("HeightF", "HeightF"))
            items.Add(New DesignerActionPropertyItem("LocationX", "LocationX"))
            items.Add(New DesignerActionPropertyItem("LocationY", "LocationY"))
            Return items
        End Function
    End Class
End Namespace
