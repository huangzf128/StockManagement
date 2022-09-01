Imports System.ComponentModel
Imports System.Reflection

Public Class CheckBoxBase
    Inherits CheckBox
    Implements IControl

    Private _type As Integer = 0

    <Category("Int"),
    Description("Type of the Button.")>
    Public Property Type() As Integer Implements IControl.Type
        Get
            Return _type
        End Get
        Set(ByVal value As Integer)
            _type = value
            initVisualStyle()
            MyBase.Invalidate()
        End Set
    End Property

    Public Sub initVisualStyle() Implements IControl.initVisualStyle
        Me.ForeColor = System.Drawing.SystemColors.Info

    End Sub

End Class
