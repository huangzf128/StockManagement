Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Util

#Region "Converter"

    Public Shared Function obj2Integer(value As Object, Optional defVal As Integer = 0) As Integer

        If IsDBNull(value) OrElse Util.isEmpty(value) Then
            Return defVal
        End If

        Return value
    End Function

    Public Shared Function obj2String(ByVal obj As Object, ByVal defVal As String)
        If obj Is Nothing OrElse IsDBNull(obj) Then
            Return defVal
        End If
        Return obj.ToString
    End Function

    Public Shared Function obj2Date(ByVal obj As Object)
        If IsDBNull(obj) OrElse obj Is Nothing Then
            Return Nothing
        End If
        Return CDate(obj)
    End Function

#End Region


#Region "CSV"


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

#End Region


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


    Public Shared Function getPcName() As String
        Return My.Computer.Name
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


#Region "File"

    Public Shared Function GetPgFolderPath() As String
        Return IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Consts.PROGRAM_FOLDER)
    End Function

    Public Shared Sub WriteFile(filePath As String, content As String)
        Dim sw As New IO.StreamWriter(filePath, True, Text.Encoding.GetEncoding("utf-8"))
        sw.Write("" + content)
        sw.Close()
    End Sub

    Public Shared Sub CreateFolder(path As String)
        If Not System.IO.Directory.Exists(path) Then
            System.IO.Directory.CreateDirectory(path)
        End If
    End Sub

    Public Shared Sub Write2Xml(filePath As String, obj As Info)
        'XmlSerializerオブジェクトを作成
        Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(Info))
        '書き込むファイルを開く（UTF-8 BOM無し）
        Dim sw As New System.IO.StreamWriter(filePath, False, New System.Text.UTF8Encoding(False))
        'シリアル化し、XMLファイルに保存する
        serializer.Serialize(sw, obj)
        sw.Close()
    End Sub

    Public Shared Function LoadXml(file As String) As Info

        If Not System.IO.File.Exists(file) Then
            Return Nothing
        End If

        Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(Info))
        '読み込むファイルを開く
        Dim sr As New System.IO.StreamReader(file, New System.Text.UTF8Encoding(False))
        'XMLファイルから読み込み、逆シリアル化する
        Dim obj As Info = DirectCast(serializer.Deserialize(sr), Info)
        sr.Close()
        Return obj
    End Function

#End Region

End Class
