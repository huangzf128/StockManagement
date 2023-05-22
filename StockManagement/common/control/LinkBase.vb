Imports System.ComponentModel

Public Class LinkBase
    Inherits LinkLabel
    Implements IControl

    Private _type As Integer = 0

    <Category("Int"),
    Description("Type of the LinkLabel.")>
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
        If Session.darkMode Then
            Me.ForeColor = System.Drawing.Color.WhiteSmoke
        End If

    End Sub

End Class
