Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Helpers
Imports System.Threading

Partial Public Class video__CONTROL

    Dim _status_player As objts__Controles._type_REPRODUCTION_STATUS

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _video__PLAYER = New video__PLAYER
    End Sub

    Private Sub video__CONTROL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call core_CLASS._start__paths("B:\MYCA\")
        Call core_CLASS._db__add_table()

        Call core_CLASS._db__read_table(_gdc__Songs, _gdv__Songs)

        _status_player = atribs__Controles._type_REPRODUCTION_STATUS._stop
        _video__PLAYER.Show()

        core_CLASS._wmp__Consola.video_id = -1
        core_CLASS._wmp__Consola.video_name = "ND"
        core_CLASS._wmp__Consola.video_path = "ND"
        core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._pausa
        core_CLASS._wmp__Consola.video_mute = True
        core_CLASS._wmp__Consola.video_volume = 0
        core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._stop

        core_CLASS._wmp__Cliente.video_id = -1
        core_CLASS._wmp__Cliente.video_name = "ND"
        core_CLASS._wmp__Cliente.video_path = "ND"
        core_CLASS._wmp__Cliente.video_status = atribs__Controles._type_REPRODUCTION_STATUS._pausa
        core_CLASS._wmp__Cliente.video_mute = True
        core_CLASS._wmp__Cliente.video_volume = 0
        core_CLASS._wmp__Cliente.video_status = atribs__Controles._type_REPRODUCTION_STATUS._stop

        _btn__VolMute__Consola.Checked = True
        _track__Volumen__Consola.Enabled = False

        _track__Volumen__Consola.Value = core_CLASS._wmp__Consola.video_volume
        _track__Volumen__Cliente.Value = core_CLASS._wmp__Consola.video_volume

        _wmp__CONSOLA.settings.volume = core_CLASS._wmp__Consola.video_volume

        'Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        Me.Show()
    End Sub

    Private Sub _btn__Play_Click(sender As Object, e As EventArgs) Handles _btn__Play__Consola.Click
        Me.Cursor = Cursors.WaitCursor
        If core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._pausa Then
            _status_player = core_CLASS.wmp__PLAY__consola(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _track__Duration__Consola, _track__Volumen__Consola, _btn__Play__Consola, _btn__Pause__Control, _btn__Stop__Control, _btn__Next__Consola, _btn__Back__Consola, _btn__VolMute__Consola, _btn__Upload__Control)
        Else
            _status_player = core_CLASS.wmp__PLAY__consola(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _track__Duration__Consola, _track__Volumen__Consola, _btn__Play__Consola, _btn__Pause__Control, _btn__Stop__Control, _btn__Next__Consola, _btn__Back__Consola, _btn__VolMute__Consola, _btn__Upload__Control)
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub _btn__Play__Cliente_Click(sender As Object, e As EventArgs) Handles _btn__Play__Cliente.Click
        Me.Cursor = Cursors.WaitCursor
        If core_CLASS._wmp__Cliente.video_status = atribs__Controles._type_REPRODUCTION_STATUS._pausa Then
            _status_player = core_CLASS.wmp__PLAY__cliente(core_CLASS._wmp__Cliente, Me._wmp__CLIENTE, _video__PLAYER._wmp__CLIENT, _track__Duration__Cliente, _track__Volumen__Cliente, _btn__Play__Cliente, _btn__Pause__Cliente, _btn__Stop__Cliente, _btn__Next__Cliente, _btn__Back__Cliente, _btn__VolMute__Cliente, _btn__Upload__Control)
        Else
            _status_player = core_CLASS.wmp__PLAY__cliente(core_CLASS._wmp__Cliente, Me._wmp__CLIENTE, _video__PLAYER._wmp__CLIENT, _track__Duration__Cliente, _track__Volumen__Cliente, _btn__Play__Cliente, _btn__Pause__Cliente, _btn__Stop__Cliente, _btn__Next__Cliente, _btn__Back__Cliente, _btn__VolMute__Cliente, _btn__Upload__Control)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub _btn__Pause_Click(sender As Object, e As EventArgs) Handles _btn__Pause__Control.Click
        Me.Cursor = Cursors.WaitCursor
        _status_player = core_CLASS.wmp__PAUSE__Consola(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _track__Duration__Consola, _track__Volumen__Consola, _btn__Play__Consola, _btn__Pause__Control, _btn__Stop__Control, _btn__Next__Consola, _btn__Back__Consola, _btn__VolMute__Consola)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub _btn__Pause__Cliente_Click(sender As Object, e As EventArgs) Handles _btn__Pause__Cliente.Click
        Me.Cursor = Cursors.WaitCursor
        _status_player = core_CLASS.wmp__PAUSE__Cliente(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _video__PLAYER._wmp__CLIENT, _track__Duration__Cliente, _track__Volumen__Cliente, _btn__Play__Cliente, _btn__Pause__Cliente, _btn__Stop__Cliente, _btn__Next__Cliente, _btn__Back__Cliente, _btn__VolMute__Cliente)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub _btn__Stop__Control_Click(sender As Object, e As EventArgs) Handles _btn__Stop__Control.Click
        Me.Cursor = Cursors.WaitCursor
        _status_player = core_CLASS.wmp__STOP__Consola(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _track__Duration__Consola, _track__Volumen__Consola, _btn__Play__Consola, _btn__Pause__Control, _btn__Stop__Control, _btn__Next__Consola, _btn__Back__Consola, _btn__VolMute__Consola)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub _btn__Stop__Cliente_Click(sender As Object, e As EventArgs) Handles _btn__Stop__Cliente.Click
        Me.Cursor = Cursors.WaitCursor
        _status_player = core_CLASS.wmp__STOP__Cliente(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _video__PLAYER._wmp__CLIENT, _track__Duration__Cliente, _track__Volumen__Cliente, _btn__Play__Cliente, _btn__Pause__Cliente, _btn__Stop__Cliente, _btn__Next__Cliente, _btn__Back__Cliente, _btn__VolMute__Cliente)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frm__Panel__buttons_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles frm__Panel__buttons.ButtonClick
        Dim _RESULT As Object
        Dim _dt As DataTable
        Try
            _dt = New DataTable
            _dt.Columns.Add("id", GetType(Int32))
            _dt.Columns.Add("nombre_archivo", GetType(String))
            _dt.Columns.Add("artista", GetType(String))
            _dt.Columns.Add("album", GetType(String))
            _dt.Columns.Add("cancion", GetType(String))


            Select Case e.Button.Properties.Caption
                Case "Carga de Videos"

                    Dim _video__IMPORTER As New video__IMPORTER
                    _video__IMPORTER.ShowDialog()
                    Call core_CLASS._db__read_table(_gdc__Songs, _gdv__Songs)

                Case "Actualizar videos"

                    Call core_CLASS._db__read_table(_gdc__Songs, _gdv__Songs)

                Case "New"
                    MsgBox("Hola mundo")
                    Dim _xml_Files As String()
                    Dim _i As Integer = 0
                    _xml_Files = Directory.GetFiles("b:\_VIDEOS\Blabla", "*.mp4")
                    For Each _XML_FILE As String In _xml_Files
                        Console.WriteLine(_XML_FILE)

                        _dt.Rows.Add(_i, _XML_FILE, "3", "4", "5")
                        _i += 1

                    Next

                    _gdc__Songs.DataSource = _dt

                    'System.IO.File.Copy(_XML_FILE, _path_XMLs_Procesados & "\Walmart__XML___" & Format(Now, "yyyy_MM_dd____HH_mm_ss") & ".xml")
                    'Kill(_XML_FILE)
                Case "Close"
                    Me.Close()
            End Select

        Catch ex As Exception
            '_st = New System.Diagnostics.StackTrace()
            'Call core__MSGs.log(ex.ToString, "ERROR DE SISTEMA :  [" & _st.GetFrame(0).GetMethod().Name & "]", book__PARAMETROS.app__NAME, pprts__tools3.type_CLASIFICACION._log_ERROR, pprts__tools3.type_LOG._log__TXT_Plano, "system")
            'Call core__MSGs.msg(ex.ToString, "ERROR DE SISTEMA EN: [" & _st.GetFrame(0).GetMethod().Name & "]", MsgBoxStyles__types.DESKTOP_ERROR)
        Finally
            _RESULT = Nothing
            GC.Collect()
        End Try
    End Sub

    Private Sub frm__Panel__buttons_Click(sender As Object, e As EventArgs) Handles frm__Panel__buttons.Click

    End Sub

    Private Sub _gdc__Songs_DoubleClick(sender As Object, e As EventArgs) Handles _gdc__Songs.DoubleClick
        Try
            If _gdv__Songs.RowCount > 1 Then

                core_CLASS._wmp__Consola.video_id = _gdv__Songs.GetFocusedRowCellValue("id").ToString()
                core_CLASS._wmp__Consola.video_name = _gdv__Songs.GetFocusedRowCellValue("file_name").ToString()
                core_CLASS._wmp__Consola.video_path = _gdv__Songs.GetFocusedRowCellValue("file_path").ToString()
                core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._play

                _status_player = core_CLASS.wmp__SET__media_consola(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _track__Duration__Consola, _track__Volumen__Consola, _btn__Play__Consola, _btn__Pause__Control, _btn__Stop__Control, _btn__Next__Consola, _btn__Back__Consola, _btn__VolMute__Consola)
                _status_player = core_CLASS.wmp__PLAY__consola(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _track__Duration__Consola, _track__Volumen__Consola, _btn__Play__Consola, _btn__Pause__Control, _btn__Stop__Control, _btn__Next__Consola, _btn__Back__Consola, _btn__VolMute__Consola, _btn__Upload__Control)

            End If
        Catch ex As Exception
            '_st = New System.Diagnostics.StackTrace()
            'Call core__MSGs.log(ex.ToString, "ERROR DE SISTEMA :  [" & _st.GetFrame(0).GetMethod().Name & "]", book__PARAMETROS.app__NAME, api_TOOLS3_Community__v210531FR48._MSGs.type_CLASIFICACION._log_ERROR)
            'Call core__MSGs.msg(ex.ToString, "ERROR DE SISTEMA EN: [" & _st.GetFrame(0).GetMethod().Name & "]", api_TOOLS3_Community__v210531FR48._MSGs.MsgBoxStyles__types.DESKTOP_ERROR)
        Finally

            GC.Collect()
        End Try
    End Sub

    Private Sub _btn__VolDown__Control_Click(sender As Object, e As EventArgs) Handles _btn__VolDown__Consola.Click
        If _wmp__CONSOLA.settings.volume > 0 Then
            core_CLASS._wmp__Consola.video_volume = _wmp__CONSOLA.settings.volume - 1
            _wmp__CONSOLA.settings.volume = core_CLASS._wmp__Consola.video_volume
            _track__Volumen__Consola.Value = core_CLASS._wmp__Consola.video_volume
        End If
    End Sub

    Private Sub _btn__VolUp__Control_Click(sender As Object, e As EventArgs) Handles _btn__VolUp__Consola.Click
        If _wmp__CONSOLA.settings.volume < 100 Then
            core_CLASS._wmp__Consola.video_volume = _wmp__CONSOLA.settings.volume + 1
            _wmp__CONSOLA.settings.volume = core_CLASS._wmp__Consola.video_volume
            _track__Volumen__Consola.Value = core_CLASS._wmp__Consola.video_volume
        End If
    End Sub

    Private Sub _btn__VolMute__Control_CheckedChanged(sender As Object, e As EventArgs) Handles _btn__VolMute__Consola.CheckedChanged
        _btn__VolMute__Consola.Refresh()
        Application.DoEvents()
        If _btn__VolMute__Consola.Checked = True Then
            core_CLASS._wmp__Consola.video_mute = True
            _wmp__CONSOLA.settings.mute = True
            _btn__VolDown__Consola.Enabled = False
            _btn__VolUp__Consola.Enabled = False
            _track__Volumen__Consola.Enabled = False
        Else
            core_CLASS._wmp__Consola.video_mute = False
            _wmp__CONSOLA.settings.mute = False
            _btn__VolDown__Consola.Enabled = True
            _btn__VolUp__Consola.Enabled = True
            _track__Volumen__Consola.Enabled = True
        End If
    End Sub

    Private Sub TrackBarControl1_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles _track__Volumen__Consola.Properties.EditValueChanged
        _wmp__CONSOLA.settings.volume = _track__Volumen__Consola.Value
    End Sub

    Private Sub _track__Duration__Control_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles _track__Duration__Consola.Properties.EditValueChanged
        If core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._play Then Me._wmp__CONSOLA.Ctlcontrols.currentPosition = _track__Duration__Consola.Value
    End Sub

    Private Sub _btn__Upload__Control_Click(sender As Object, e As EventArgs) Handles _btn__Upload__Control.Click
        core_CLASS._wmp__Cliente = core_CLASS._wmp__Consola
        Me.Cursor = Cursors.WaitCursor
        _btn__Play__Cliente.Enabled = True
        _btn__Pause__Cliente.Enabled = True
        _btn__Stop__Cliente.Enabled = True
        _btn__VolDown__Cliente.Enabled = True
        _btn__VolUp__Cliente.Enabled = True
        _btn__VolMute__Cliente.Enabled = True
        _track__Volumen__Cliente.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub _gdc__Songs_Click(sender As Object, e As EventArgs) Handles _gdc__Songs.Click
        Try
            If _gdv__Songs.RowCount > 1 Then
                If core_CLASS._wmp__Cliente.video_status = atribs__Controles._type_REPRODUCTION_STATUS._stop Then
                    core_CLASS._wmp__Cliente.video_id = _gdv__Songs.GetFocusedRowCellValue("id").ToString()
                    core_CLASS._wmp__Cliente.video_name = _gdv__Songs.GetFocusedRowCellValue("file_name").ToString()
                    core_CLASS._wmp__Cliente.video_path = _gdv__Songs.GetFocusedRowCellValue("file_path").ToString()
                    core_CLASS._wmp__Cliente.video_status = atribs__Controles._type_REPRODUCTION_STATUS._play
                    _status_player = core_CLASS.wmp__SET__media_client(core_CLASS._wmp__Cliente, Me._wmp__CLIENTE, _video__PLAYER._wmp__CLIENT, _track__Duration__Cliente, _track__Volumen__Cliente, _btn__Play__Cliente, _btn__Pause__Cliente, _btn__Stop__Cliente, _btn__Next__Cliente, _btn__Back__Cliente, _btn__VolMute__Cliente)

                    _btn__Back__Cliente.Enabled = True
                    _btn__Play__Cliente.Enabled = True
                    _btn__Next__Cliente.Enabled = True
                    _btn__VolDown__Cliente.Enabled = True
                    _btn__VolUp__Cliente.Enabled = True
                    _btn__VolMute__Cliente.Enabled = True
                    _track__Volumen__Cliente.Enabled = True
                    _track__Duration__Cliente.Enabled = True
                End If


                If core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._stop Then
                    core_CLASS._wmp__Consola.video_id = _gdv__Songs.GetFocusedRowCellValue("id").ToString()
                    core_CLASS._wmp__Consola.video_name = _gdv__Songs.GetFocusedRowCellValue("file_name").ToString()
                    core_CLASS._wmp__Consola.video_path = _gdv__Songs.GetFocusedRowCellValue("file_path").ToString()
                    core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._play
                    _status_player = core_CLASS.wmp__SET__media_consola(core_CLASS._wmp__Consola, Me._wmp__CONSOLA, _track__Duration__Consola, _track__Volumen__Consola, _btn__Play__Consola, _btn__Pause__Control, _btn__Stop__Control, _btn__Next__Consola, _btn__Back__Consola, _btn__VolMute__Consola)

                    _btn__Back__Consola.Enabled = True
                    _btn__Play__Consola.Enabled = True
                    _btn__Next__Consola.Enabled = True
                    _btn__VolDown__Consola.Enabled = True
                    _btn__VolUp__Consola.Enabled = True
                    _btn__VolMute__Consola.Enabled = True
                    _track__Volumen__Consola.Enabled = True
                    _track__Duration__Consola.Enabled = True
                End If

            End If
        Catch ex As Exception
            '_st = New System.Diagnostics.StackTrace()
            'Call core__MSGs.log(ex.ToString, "ERROR DE SISTEMA :  [" & _st.GetFrame(0).GetMethod().Name & "]", book__PARAMETROS.app__NAME, api_TOOLS3_Community__v210531FR48._MSGs.type_CLASIFICACION._log_ERROR)
            'Call core__MSGs.msg(ex.ToString, "ERROR DE SISTEMA EN: [" & _st.GetFrame(0).GetMethod().Name & "]", api_TOOLS3_Community__v210531FR48._MSGs.MsgBoxStyles__types.DESKTOP_ERROR)
        Finally
            GC.Collect()
        End Try
    End Sub






    'Private Sub _timer_Tick(sender As Object, e As EventArgs) Handles _timer.Tick
    '    If core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._play And _track__Duration__Control.Properties.Maximum > 0 Then
    '        _track__Duration__Control.Value = Me._wmp__CONSOLA.Ctlcontrols.currentPosition
    '    ElseIf core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._play And _track__Duration__Control.Properties.Maximum = 0 Then
    '        _track__Duration__Control.Properties.Maximum = _wmp__CONSOLA.Ctlcontrols.currentItem.duration
    '    End If
    '    '_track__Duration__Control.Refresh()
    'End Sub

    'Private Sub _btn__Upload__Control_Click(sender As Object, e As EventArgs) Handles _btn__Upload__Control.Click
    '    Try
    '        core_CLASS._wmp__Clientes = core_CLASS._wmp__Consola
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    Do
    '        Try
    '            If core_CLASS._wmp__Consola.video_status = atribs__Controles._type_REPRODUCTION_STATUS._play Then
    '                If _track__Duration__Control.Properties.Maximum > 0 Then
    '                    _track__Duration__Control.Value = Me._wmp__CONSOLA.Ctlcontrols.currentPosition
    '                ElseIf _track__Duration__Control.Properties.Maximum = 0 Then
    '                    _track__Duration__Control.Properties.Maximum = _wmp__CONSOLA.Ctlcontrols.currentItem.duration
    '                End If
    '            Else

    '            End If
    '            System.Threading.Thread.Sleep(100)
    '        Catch ex As Exception
    '            Debug.Print(ex.ToString)
    '        End Try
    '    Loop
    'End Sub
End Class
