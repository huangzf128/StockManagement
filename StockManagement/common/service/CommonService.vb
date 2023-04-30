Imports System.Text

Public Class CommonService

#Region "倉庫(LOCATION)"

    ''' <summary>
    ''' 倉庫リスト取得
    ''' </summary>
    ''' <param name="needEmptyItem"></param>
    ''' <returns></returns>
    Public Shared Function GetLocation(Optional ByVal needEmptyItem As Boolean = True) As DataTable

        Dim sb As New StringBuilder
        sb.Append(" SELECT  ")
        sb.Append("   CODE ")
        sb.Append("  ,CODE + '-' + VALUE1 AS NAME ")
        sb.Append("  ,VALUE1 AS LOCATIONNM ")
        sb.Append(" FROM M_Code ")
        sb.Append(" WHERE CATEGORY = 'LOCATIONCD' ")
        sb.Append(" AND   CODE NOT IN (2) ")
        sb.Append(" ORDER BY CODE ")

        Dim cmdSrchDt As DataTable = DbHandler.executeSelect(New DbParamEnt(sb, Nothing))

        If needEmptyItem Then
            Dim dr As DataRow = cmdSrchDt.NewRow
            dr("CODE") = ""
            dr("NAME") = ""
            cmdSrchDt.Rows.InsertAt(dr, 0)
        End If

        Return cmdSrchDt

    End Function

    Public Shared Function GetLocationName(ByRef dt As DataTable, ByVal cd As String) As String

        If dt Is Nothing OrElse Util.isEmpty(cd) Then
            Return ""
        End If

        For Each row As DataRow In dt.Rows
            If row("CODE") = cd Then
                Return row("NAME")
            End If
        Next

        Return ""
    End Function

#End Region


End Class
