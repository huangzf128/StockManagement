Imports System.ComponentModel


Public Class UBindingNavigator

    Public Event CurrentChanged(sender As Object, e As EventArgs)
    Private _isBindingProcess As Object = Nothing

    Private Sub UBindingNavigator_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BindingNavigator1.BindingSource = BindingSource1
    End Sub

    Public Sub initBindingSource(ByVal totalCount As Integer, ByVal pageCount As Integer)

        _isBindingProcess = True
        BindingSource1.DataSource = Nothing
        BindingSource1.DataSource = New PageOffsetList(totalCount, pageCount)
        _isBindingProcess = Nothing

        lblTotalCount.Text = totalCount
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged
        If _isBindingProcess IsNot Nothing AndAlso _isBindingProcess = False Then
            Return
        End If

        RaiseEvent CurrentChanged(sender, e)

        If _isBindingProcess IsNot Nothing Then
            _isBindingProcess = False
        End If
    End Sub

    Public Class PageOffsetList
        Implements System.ComponentModel.IListSource

        Private _totalCount As Integer = 0
        Private _pageCount As Integer = 0

        Sub New(ByVal totalCount As Integer, ByVal pageCount As Integer)
            _totalCount = totalCount
            _pageCount = pageCount
        End Sub

        Public ReadOnly Property ContainsListCollection As Boolean Implements IListSource.ContainsListCollection
            Get
                Return True
            End Get
        End Property

        Public Function GetList() As IList Implements IListSource.GetList

            Dim pageOffsets As New List(Of Integer)()
            For offset As Integer = 0 To _totalCount Step _pageCount
                pageOffsets.Add(offset)
            Next
            Return pageOffsets
        End Function
    End Class

End Class

