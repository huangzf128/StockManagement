Imports System.ComponentModel

Public Class ButtonBase
    Inherits Button
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
        Me.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Size = New System.Drawing.Size(70, 30)
        Me.UseVisualStyleBackColor = False

        If Session.darkMode Then
            If Me._type = Consts.ButtonType.CLOSE Then
                Me.BackColor = System.Drawing.Color.Goldenrod
                Me.ForeColor = System.Drawing.SystemColors.ControlText

            ElseIf Me._type = Consts.ButtonType.SEARCH Then
                Me.BackColor = System.Drawing.Color.DeepSkyBlue
                Me.ForeColor = System.Drawing.SystemColors.ControlText

            ElseIf Me._type = Consts.ButtonType.SECOND_SEARCH Then
                Me.BackColor = System.Drawing.Color.DarkGreen
                Me.ForeColor = Color.WhiteSmoke

            ElseIf Me._type = Consts.ButtonType.SETTING Then
                Me.BackColor = System.Drawing.Color.DimGray
                Me.ForeColor = Color.WhiteSmoke

            ElseIf Me._type = Consts.ButtonType.FUN Then
                Me.BackColor = System.Drawing.Color.Sienna
                Me.ForeColor = Color.WhiteSmoke

            ElseIf Me._type = Consts.ButtonType.DELETE Then
                Me.BackColor = System.Drawing.Color.DarkRed
                Me.ForeColor = Color.WhiteSmoke

            End If
        Else
            Me.BackColor = System.Drawing.Color.DeepSkyBlue
            Me.ForeColor = System.Drawing.SystemColors.ControlText
        End If

    End Sub

End Class
