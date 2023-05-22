Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class LabelBase
    Inherits Label
    Implements IControl

    Private _type As Integer = 0


    <Category("Int"),
    Description("Type of the Label.")>
    Public Property Type() As Integer Implements IControl.Type
        Get
            Return _Type
        End Get
        Set(ByVal value As Integer)
            _Type = value
            initVisualStyle()
            MyBase.Invalidate()
        End Set
    End Property


    Public Sub initVisualStyle() Implements IControl.initVisualStyle

        If Session.darkMode Then
            Me.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.BackColor = Color.Transparent
        End If

    End Sub
End Class
