Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Helpers

Partial Public Class video__IMPORTER
    Private Sub video__IMPORTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call core_CLASS.get__Videos(core_CLASS._path__media_upload, _gdv__Files)


        Catch ex As Exception

        End Try

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
                Case "Refresh"
                    Me.Cursor = Cursors.WaitCursor
                    Call core_CLASS.get__Videos(core_CLASS._path__media_upload, _gdv__Files)
                    Me.Cursor = Cursors.Default
                Case "Importar"
                    Me.Cursor = Cursors.WaitCursor
                    Call core_CLASS.import__Files(core_CLASS._path__media_upload, core_CLASS._path__media_database, _gdv__Files, _gdv__Database)
                    Me.Cursor = Cursors.Default
                Case "Borrar"


                    'System.IO.File.Copy(_XML_FILE, _path_XMLs_Procesados & "\Walmart__XML___" & Format(Now, "yyyy_MM_dd____HH_mm_ss") & ".xml")
                    'Kill(_XML_FILE)

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


End Class
