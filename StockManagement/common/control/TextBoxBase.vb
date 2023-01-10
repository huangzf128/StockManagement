Imports System.ComponentModel

Public Class TextBoxBase
    Inherits TextBox
    Implements IControl

    Private _type As Integer = 0

    <Category("Int"),
    Description("Type of the TextBox.")>
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
        If Me._type = Consts.TextBoxType.NUMBER Then
            AddHandler Me.KeyPress, AddressOf TextBox_KeyPress
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class
