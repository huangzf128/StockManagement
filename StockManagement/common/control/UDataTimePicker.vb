Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class UDataTimePicker

#Region "EVENT"
    Private Sub UDataTimePicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbHour.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19"})
        cmbMinute.Items.AddRange(New Object() {"00", "15", "30", "45"})
    End Sub

    Private Sub cmbHour_Enter(sender As Object, e As EventArgs) Handles cmbHour.Enter
        'Me.cmbHour.DroppedDown = True
    End Sub

    Private Sub cmbMinute_Enter(sender As Object, e As EventArgs) Handles cmbMinute.Enter
        'Me.cmbMinute.DroppedDown = True
    End Sub
#End Region


    Public Sub setDateTime(ByRef d As Date, ByRef h As String, ByRef m As String)
        dtpDate.Value = d
        cmbHour.SelectedText = h
        cmbMinute.SelectedText = m
    End Sub


    Public Sub setDateTime(ByRef dTime As Date)

        dtpDate.Value = dTime

        Select Case Hour(Now)
            Case 0, 1, 2, 3, 4, 5, 6
                cmbHour.SelectedText = "08"
            Case 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18
                cmbHour.SelectedText = Strings.Right("0" & Hour(Now), 2)
            Case 19, 20, 21, 22, 23
                cmbHour.SelectedText = "19"
        End Select

        cmbMinute.SelectedText = Minute(Now)
    End Sub


    Public Function getDateTime(Optional dateFormat As String = "yyyy-MM-dd") As String
        Return dtpDate.Value.Date.ToString(dateFormat) & " " & cmbHour.Text.PadLeft(2, "0") & ":" & cmbMinute.Text.PadLeft(2, "0")
    End Function


    Public Function getDate(Optional dateFormat As String = "yyyy-MM-dd") As String
        Return dtpDate.Value.Date.ToString(dateFormat)
    End Function

End Class
