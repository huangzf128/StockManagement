Public Class FrmBase

    Protected needInit As Boolean = True

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not DesignMode Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            End If
            Return cp
        End Get
    End Property


    Protected Delegate Sub SetDataSourceDelegate(ByRef grd As DataGridView, ByRef dt As DataTable)

    Protected Sub SetDataSource(ByRef grd As DataGridView, ByRef dt As DataTable)
        grd.DataSource = dt
    End Sub


    Protected Sub TxtNumber_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
    End Sub


#Region "画面遷移"

    Protected frmFrom As FrmBase
    Protected params As List(Of String)
    Protected returnParams As List(Of String)

    Protected Sub moveTo(frmTo As FrmBase, params As List(Of String))
        frmTo.frmFrom = Me
        frmTo.params = params

        frmTo.TopLevel = False
        frmTo.MdiParent = Me.MdiParent
        frmTo.Dock = DockStyle.Fill
        frmTo.Show()
    End Sub

    Protected Sub backTo(params As List(Of String))
        frmFrom.returnParams = params
        Me.Close()
    End Sub

    Protected Sub DisabledPanel(pnl As Panel)
        Dim ctlCount As Integer = pnl.Controls.Count - 1
        For i As Integer = ctlCount To 0 Step -1
            Dim element As Control = pnl.Controls(i)
            If TypeOf element Is UDataTimePicker OrElse
                TypeOf element Is CheckBoxBase OrElse
                TypeOf element Is TextBox Then

                element.Enabled = False
            End If

            If TypeOf element Is ButtonBase Then
                element.Enabled = False
                element.Visible = False
            End If
        Next
    End Sub

#End Region


#Region "POP"

    Protected parentFrm As FrmBase
    Protected paramsPop As List(Of String)
    Protected returnParamsPop As List(Of String)

    ''' <summary>
    ''' parent windowが呼び出す
    ''' </summary>
    ''' <param name="popFrm"></param>
    ''' <param name="params"></param>
    Protected Sub OpenPop(popFrm As FrmBase, params As List(Of String))

        returnParamsPop = Nothing

        popFrm.parentFrm = Me
        popFrm.paramsPop = params
        popFrm.ShowDialog()
    End Sub

    ''' <summary>
    ''' PopWindowが呼び出す
    ''' </summary>
    ''' <param name="params"></param>
    Protected Sub ClosePop(params As List(Of String))
        parentFrm.returnParamsPop = params
        Me.Close()
    End Sub


#End Region




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

    Protected Sub CloseLoadingForm()
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