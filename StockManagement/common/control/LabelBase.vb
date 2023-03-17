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
        Me.ForeColor = System.Drawing.Color.WhiteSmoke

        If Me._type = Consts.LabelType.COMMON Then
        End If
    End Sub
End Class
