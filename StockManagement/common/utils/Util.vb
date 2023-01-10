Imports Microsoft.VisualBasic.FileIO

Public Class Util

#Region "Converter"

    Public Shared Function obj2Integer(value As Object, Optional defVal As Integer = 0) As Integer

        If IsDBNull(value) OrElse Util.isEmpty(value) Then
            Return defVal
        End If

        Return value
    End Function

    Public Shared Function obj2String(ByVal obj As String, ByVal defVal As String)
        Dim rtn As String = obj
        If obj Is Nothing OrElse IsDBNull(obj) Then
            rtn = defVal
        End If
        Return rtn
    End Function

    Public Shared Function obj2Date(ByVal obj As Object)
        If IsDBNull(obj) OrElse obj Is Nothing Then
            Return Nothing
        End If
        Return CDate(obj)
    End Function
#End Region

    Public Shared Function readCsv(ByVal filePath As String) As DataTable
        Dim dt As New DataTable
        Using tfp As New TextFieldParser(filePath, System.Text.Encoding.GetEncoding("shift_jis"))
            tfp.Delimiters = New String() {","}
            tfp.TextFieldType = FieldType.Delimited
            While tfp.EndOfData = False
                Dim fields = tfp.ReadFields()
                If dt.Columns.Count = 0 Then
                    For Each field As String In fields
                        dt.Columns.Add(field, GetType(String))
                    Next
                Else
                    Dim row As DataRow = dt.NewRow
                    dt.Rows.Add(row)
                    For i As Integer = 0 To fields.Count - 1
                        row(i) = fields(i)
                    Next
                End If
            End While
        End Using

        Return dt
    End Function

    Public Shared Sub CopyDataGridView(_dgv As DataGridView)
        _dgv.SelectAll()
        'Copy to clipboard
        _dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Dim dataObj As DataObject = _dgv.GetClipboardContent()
        If dataObj IsNot Nothing Then
            Clipboard.SetDataObject(dataObj, True)
        End If
        _dgv.ClearSelection()
    End Sub

#Region "日付"

    Public Shared Function toDateStr(d As Date, Optional fmt As String = Consts.DATE_LONG) As String
        Return d.ToString(fmt)
    End Function

    Public Shared Function removeTime(d As Date) As Date
        Return FormatDateTime(d, DateFormat.ShortDate)
    End Function
#End Region


#Region "Check"
    Public Shared Function isEmpty(v As Object) As Boolean
        Return obj2String(v, "") = ""
    End Function

    Public Shared Function isNumber(v As Object) As Boolean

        Return Not isEmpty(v) AndAlso IsNumeric(v)
    End Function
#End Region
End Class
