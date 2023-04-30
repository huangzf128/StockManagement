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
            Me.ImeMode = ImeMode.Disable
            AddHandler Me.KeyPress, AddressOf TextBox_KeyPress
        End If
    End Sub

    ''' <summary>
    ''' 数値のみ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso
            e.KeyChar <> ControlChars.Back Then
            '押されたキーが 0～9でない場合は、イベントをキャンセルする
            e.Handled = True
        End If
    End Sub
End Class
