Imports System.Configuration

Public Class Consts

    Public Structure ButtonType
        Public Const COMMON As Integer = 0
        Public Const CLOSE As Integer = 1
        Public Const SEARCH As Integer = 2
        Public Const SECOND_SEARCH As Integer = 3
        Public Const SETTING As Integer = 4
        Public Const FUN As Integer = 5
        Public Const DELETE As Integer = 6
    End Structure

    Public Structure LabelType
        Public Const COMMON As Integer = 0
    End Structure

    Public Structure TextBoxType
        Public Const COMMON As Integer = 0
        Public Const NUMBER As Integer = 1
    End Structure

    Public Structure DataGridView
        Public Const READ_ONLY As Integer = 0
        Public Const EDITABLE As Integer = 1
    End Structure

    Public Const PAGE_COUNT = 1000

    Public Shared ReadOnly DATA_INTERVAL As String = ConfigurationManager.AppSettings.Get("DATE_INTERVAL").ToString

    Public Const DATE_LONG = "yyyy-MM-dd HH:mm:ss"

    Public Const PROGRAM_FOLDER = "SyoutenStockManage"
    Public Const INFO_FILE_NAME = "info.txt"
    Public Const LOG_FILE_NAME = "log.txt"

End Class
