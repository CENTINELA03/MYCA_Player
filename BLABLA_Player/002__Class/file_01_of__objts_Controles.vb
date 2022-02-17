Imports System.IO

Public Class objts__Controles

    Inherits mtds__Controles

    Function wmp__SET__media_consola(ByRef _file_info As pprtys__WMP__Status, ByRef _player_Consola As AxWMPLib.AxWindowsMediaPlayer,
                                    ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                                    ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                                    ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton) As _type_REPRODUCTION_STATUS
        Try
            '_player_Consola.Ctlcontrols.stop()
            _player_Consola.URL = _file_info.video_path
            _player_Consola.Ctlcontrols.play()
            _player_Consola.Ctlcontrols.stop()
            _player_Consola.Refresh()
            _player_Consola.Refresh()
            Application.DoEvents()
            Application.DoEvents()

            _file_info.video_duration = _player_Consola.Ctlcontrols.currentItem.duration
            _track__Duration.Properties.Maximum = _file_info.video_duration

            _file_info.video_status = _type_REPRODUCTION_STATUS._ready

            Return _type_REPRODUCTION_STATUS._ready
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function

    Function wmp__SET__media_client(ByRef _file_info As pprtys__WMP__Status,
                                    ByRef _player_Cliente_consola As AxWMPLib.AxWindowsMediaPlayer,
                                    ByRef _player_Cliente_player As AxWMPLib.AxWindowsMediaPlayer,
                                    ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                                    ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                                    ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                                    ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton) As _type_REPRODUCTION_STATUS
        Try
            '_player_Consola.Ctlcontrols.stop()
            _player_Cliente_consola.URL = _file_info.video_path
            _player_Cliente_player.URL = _file_info.video_path
            _player_Cliente_consola.Ctlcontrols.play()
            _player_Cliente_player.Ctlcontrols.play()
            _player_Cliente_consola.Ctlcontrols.stop()
            _player_Cliente_player.Ctlcontrols.stop()
            _player_Cliente_consola.Refresh()
            _player_Cliente_player.Refresh()
            Application.DoEvents()
            Application.DoEvents()

            _file_info.video_duration = _player_Cliente_consola.Ctlcontrols.currentItem.duration
            _track__Duration.Properties.Maximum = _file_info.video_duration

            _file_info.video_status = _type_REPRODUCTION_STATUS._ready

            Return _type_REPRODUCTION_STATUS._ready
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function

    Function wmp__PLAY__consola(ByRef _file_info As pprtys__WMP__Status, ByRef _player_Consola As AxWMPLib.AxWindowsMediaPlayer,
                                 ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                                 ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                                 ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton,
                                 ByRef _btn__Upload__Control As DevExpress.XtraEditors.SimpleButton) As _type_REPRODUCTION_STATUS
        Try
            '_player_Consola.Ctlcontrols.stop()
            '_player_Consola.URL = _file_info.video_path
            _player_Consola.Refresh()
            _player_Consola.Refresh()

            If _file_info.video_mute = True Then
                _player_Consola.settings.mute = True
                _btn__Mute.Checked = True
            Else
                _player_Consola.settings.mute = False
                _btn__Mute.Checked = False
            End If

            _btn__Pause.Enabled = True
            _btn__Stop.Enabled = True
            _btn__Upload__Control.Enabled = True

            Application.DoEvents()
            Application.DoEvents()

            _player_Consola.Ctlcontrols.play()
            _file_info.video_status = _type_REPRODUCTION_STATUS._play

            Return _type_REPRODUCTION_STATUS._play
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function

    Function wmp__PLAY__cliente(ByRef _file_info As pprtys__WMP__Status,
                                ByRef _player_Cliente_Consola As AxWMPLib.AxWindowsMediaPlayer,
                                ByRef _player_Cliente_Front As AxWMPLib.AxWindowsMediaPlayer,
                                 ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                                 ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                                 ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton,
                                 ByRef _btn__Upload__Control As DevExpress.XtraEditors.SimpleButton) As _type_REPRODUCTION_STATUS
        Try
            _player_Cliente_Consola.Refresh()
            _player_Cliente_Front.Refresh()

            If _file_info.video_mute = True Then
                _player_Cliente_Consola.settings.mute = True
                _player_Cliente_Front.settings.mute = True
                _btn__Mute.Checked = True
            Else
                _player_Cliente_Consola.settings.mute = False
                _player_Cliente_Front.settings.mute = False
                _btn__Mute.Checked = False
            End If

            _btn__Pause.Enabled = True
            _btn__Stop.Enabled = True
            _btn__Upload__Control.Enabled = True

            Application.DoEvents()
            Application.DoEvents()

            _player_Cliente_Consola.Ctlcontrols.play()
            _player_Cliente_Consola.Ctlcontrols.pause()
            _player_Cliente_Consola.Refresh()
            _player_Cliente_Front.Ctlcontrols.play()
            _player_Cliente_Front.Ctlcontrols.pause()
            _player_Cliente_Front.Refresh()

            _player_Cliente_Consola.Ctlcontrols.play()
            _player_Cliente_Front.Ctlcontrols.play()

            _file_info.video_status = _type_REPRODUCTION_STATUS._play
            Application.DoEvents()

            Return _type_REPRODUCTION_STATUS._play
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function

    Function wmp__STOP__Consola(ByRef _file_info As pprtys__WMP__Status, ByRef _player_Control As AxWMPLib.AxWindowsMediaPlayer,
                        ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                        ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                        ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton) As _type_REPRODUCTION_STATUS
        Try
            If _file_info.video_status = _type_REPRODUCTION_STATUS._play Then
                _player_Control.Ctlcontrols.stop()
                _btn__Stop.Enabled = False
            End If

            _player_Control.Ctlcontrols.stop()
            _player_Control.Refresh()
            Application.DoEvents()

            Return _type_REPRODUCTION_STATUS._stop
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function

    Function wmp__STOP__Cliente(ByRef _file_info As pprtys__WMP__Status,
                                ByRef _player_Cliente_Consola As AxWMPLib.AxWindowsMediaPlayer,
                                ByRef _player_Cliente_Front As AxWMPLib.AxWindowsMediaPlayer,
                                ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                                ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                                ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                                ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                                ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                                ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                                ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                                ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton) As _type_REPRODUCTION_STATUS
        Try
            'If _file_info.video_status = _type_REPRODUCTION_STATUS._play Then
            '    _player_Cliente_Consola.Ctlcontrols.stop()

            '    _player_Cliente_Front.Ctlcontrols.stop()
            'End If

            _player_Cliente_Consola.Ctlcontrols.stop()
            _player_Cliente_Consola.Refresh()
            _player_Cliente_Front.Ctlcontrols.stop()
            _player_Cliente_Front.Refresh()
            Application.DoEvents()

            _btn__Stop.Enabled = False

            Return _type_REPRODUCTION_STATUS._stop
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function

    Function wmp__PAUSE__Consola(ByRef _file_info As pprtys__WMP__Status,
                                 ByRef _player_Control As AxWMPLib.AxWindowsMediaPlayer,
                        ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                        ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                        ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                        ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton) As _type_REPRODUCTION_STATUS
        Try
            If _file_info.video_status = _type_REPRODUCTION_STATUS._play Then
                _player_Control.Ctlcontrols.pause()
                _btn__Pause.Enabled = False
            End If

            _player_Control.Refresh()
            Application.DoEvents()

            Return _type_REPRODUCTION_STATUS._pausa
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function

    Function wmp__PAUSE__Cliente(ByRef _file_info As pprtys__WMP__Status,
                                 ByRef _player_Cliente_Consola As AxWMPLib.AxWindowsMediaPlayer,
                                 ByRef _player_Cliente_Front As AxWMPLib.AxWindowsMediaPlayer,
                                 ByRef _track__Duration As DevExpress.XtraEditors.TrackBarControl,
                                 ByRef _track__Volume As DevExpress.XtraEditors.TrackBarControl,
                                 ByRef _btn__Play As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Pause As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Stop As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Next As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Back As DevExpress.XtraEditors.SimpleButton,
                                 ByRef _btn__Mute As DevExpress.XtraEditors.CheckButton) As _type_REPRODUCTION_STATUS
        Try
            If _file_info.video_status = _type_REPRODUCTION_STATUS._play Then
                _player_Cliente_Consola.Ctlcontrols.pause()
                _player_Cliente_Front.Ctlcontrols.pause()
                _btn__Pause.Enabled = False
            End If

            _player_Cliente_Consola.Refresh()
            Application.DoEvents()

            Return _type_REPRODUCTION_STATUS._pausa
            'Me.Cursor = Cursors.Default
        Catch ex As Exception
            Return _type_REPRODUCTION_STATUS._error
        End Try
    End Function


    Function get__Videos(_path As String, ByRef _gdv As DevExpress.XtraGrid.GridControl) As DataTable
        Dim _files As String()
        Dim _dt As DataTable
        Try

            _dt = New DataTable
            _dt.Columns.Add("id", GetType(Int32))
            _dt.Columns.Add("nombre_archivo", GetType(String))
            _dt.Columns.Add("artista", GetType(String))
            _dt.Columns.Add("album", GetType(String))
            _dt.Columns.Add("cancion", GetType(String))



            Dim _i As Integer = 0
            _files = Directory.GetFiles(_path, "*.mp4")
            For Each _XML_FILE As String In _files
                Console.WriteLine(_XML_FILE)

                _dt.Rows.Add(_i, _XML_FILE, "3", "4", "5")
                _i += 1

            Next

            _gdv.DataSource = _dt

            Return _dt
        Catch ex As Exception
            _dt = New DataTable
            _gdv.DataSource = _dt
            Return _dt
        Finally
            _files = Nothing
            _dt = Nothing
            GC.Collect()
        End Try

    End Function

    Function import__Files(_path_to_upload As String, _path_final As String, ByRef _gdv_files As DevExpress.XtraGrid.GridControl, ByRef _gdv_database As DevExpress.XtraGrid.GridControl) As DataTable
        Dim _files As String()
        Dim _i As Integer = 0
        Dim _dt As DataTable
        Dim _file_name As String
        Try
            _dt = New DataTable
            _dt.Columns.Add("id", GetType(Int32))
            _dt.Columns.Add("nombre_archivo", GetType(String))
            _dt.Columns.Add("artista", GetType(String))
            _dt.Columns.Add("album", GetType(String))
            _dt.Columns.Add("cancion", GetType(String))
            _files = Directory.GetFiles(_path_to_upload, "*.mp4")

            _i = _db__max_id()

            For Each _file_selected As String In _files
                Try
                    Console.WriteLine(_file_selected)
                    Console.WriteLine(Strings.Right(_file_selected, (Len(_file_selected) - Len(_path_to_upload) - 1)))

                    _file_name = _path_final & "\" & Format(_i, "00000") & "." & Strings.Right(_file_selected, 3)
                    System.IO.File.Copy(_file_selected, _file_name)

                    If System.IO.File.Exists(_file_name) = True Then
                        Call _db__add_item(_i,
                                           Format(_i, "00000") & "." & Strings.Right(_file_selected, 3),
                                           Strings.Right(_file_selected, (Len(_file_selected) - Len(_path_to_upload) - 1)),
                                           "ND",
                                           "ND",
                                           "ND",
                                           Strings.Right(_file_selected, (Len(_file_selected) - Len(_path_to_upload) - 1)),
                                           _file_name)
                        Kill(_file_selected)
                        _dt.Rows.Add(_i, Strings.Right(_file_selected, (Len(_file_selected) - Len(_path_to_upload) - 1)), "ND", "ND", "ND")


                        _i += 1
                    Else
                        MsgBox("Error al eliminar el archivo..." & _file_name)
                    End If

                    _gdv_database.DataSource = _dt
                    Application.DoEvents()

                    Call get__Videos(_path_to_upload, _gdv_files)

                    Application.DoEvents()
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Function

End Class
