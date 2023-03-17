Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class DataGridViewBase
    Inherits DataGridView
    Implements IControl

    Private _type As Integer = 0

    <Category("Int"),
    Description("Type of the DataGridView.")>
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

        Call New GridStyle().setStyle(Me)

        If _type = Consts.DataGridView.READ_ONLY Then
            Me.ReadOnly = False
            AddHandler Me.EditingControlShowing, AddressOf grd_EditingControlShowing
        End If
    End Sub

    Private Sub grd_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If TypeOf e.Control Is TextBox Then
            ' Set the TextBoxCell to readonly
            Dim textBoxCell As TextBox = DirectCast(e.Control, TextBox)
            textBoxCell.[ReadOnly] = True
        End If
    End Sub
End Class
