Public Class FrmBase

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not DesignMode Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            End If
            Return cp
        End Get
    End Property

    Protected Sub FrmBase_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded

        If TypeOf (e.Control) Is DataGridView Then
            Dim grd As DataGridView = TryCast(e.Control, DataGridView)
            Call New GridStyle().setStyle(grd)
            grd.ReadOnly = False
            AddHandler grd.EditingControlShowing, AddressOf grd_EditingControlShowing
        End If
    End Sub


    Private Sub grd_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If TypeOf e.Control Is TextBox Then
            ' Set the TextBoxCell to readonly
            Dim textBoxCell As TextBox = DirectCast(e.Control, TextBox)
            textBoxCell.[ReadOnly] = True
        End If
    End Sub

    Protected Delegate Sub SetDataSourceDelegate(ByRef grd As DataGridView, ByRef dt As DataTable)

    Protected Sub SetDataSource(ByRef grd As DataGridView, ByRef dt As DataTable)
        grd.DataSource = dt
    End Sub


#Region "Loading Form"

    Private _loadingForm As LoadingForm
    Private Delegate Sub CloseDelegate()

    Protected Sub ShowWaitForm()
        ' don't display more than one wait form at a time
        If _loadingForm IsNot Nothing AndAlso Not _loadingForm.IsDisposed Then
            Return
        End If

        _loadingForm = New LoadingForm
        _loadingForm.SetMessage("Loading data. Please wait...")
        _loadingForm.StartPosition = FormStartPosition.CenterScreen
        _loadingForm.Show()
        _loadingForm.Refresh()

        ' force the wait window to display for at least 700ms so it doesn't just flash on the screen
        System.Threading.Thread.Sleep(100)

        ' 注释理由：改为由他线程调用CloseForm关闭
        'AddHandler Application.Idle, AddressOf OnLoaded
    End Sub

    Protected Sub CloseForm()
        _loadingForm.Invoke(New CloseDelegate(Sub()
                                                  If _loadingForm IsNot Nothing AndAlso _loadingForm.Visible Then
                                                      _loadingForm.Close()
                                                      _loadingForm = Nothing
                                                  End If
                                              End Sub))
    End Sub

    Private Sub OnLoaded(sender As Object, e As EventArgs)
        RemoveHandler Application.Idle, AddressOf OnLoaded
        _loadingForm.Close()
    End Sub

#End Region
End Class