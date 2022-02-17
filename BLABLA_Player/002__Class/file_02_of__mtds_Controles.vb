Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Data.SqlTypes

Public Class mtds__Controles

    Inherits atribs__Controles

    Sub _start__paths(_path_MYCA As String)
        Try
            If System.IO.Directory.Exists(_path_MYCA & "\Media_Database") = False Then System.IO.Directory.CreateDirectory(_path_MYCA & "\Media_Database")
            If System.IO.Directory.Exists(_path_MYCA & "\Media_to_Upload") = False Then System.IO.Directory.CreateDirectory(_path_MYCA & "\Media_to_Upload")
            If System.IO.Directory.Exists(_path_MYCA & "\Software") = False Then System.IO.Directory.CreateDirectory(_path_MYCA & "\Software")

            _path__media_database = _path_MYCA & "\Media_Database"
            _path__media_upload = _path_MYCA & "\Media_to_Upload"
            _path__software = _path_MYCA & "\Software"

            _cnn__string = "Data Source =" + _path__media_database + "\db_videos.db ;Version=3;"

        Catch ex As Exception

        End Try
    End Sub

    'Function cnn_open(_path As String)
    '    Try
    '        cnn = New SQLiteConnection(_cnn__string, True)
    '    Catch ex As Exception

    '    End Try
    'End Function

    Function _db__add_table() As Object
        Dim objCon As SQLiteConnection
        Dim objCommand As SQLiteCommand
        Dim _sql As String
        Try
            _sql = "CREATE TABLE db_videos(id integer primary key, track_name text, title text, artist text, album text, picture text, file_name text, file_path text);"
            Using sqlconn As New SQLiteConnection(_cnn__string)
                objCommand = New SQLiteCommand(_sql, sqlconn)
                sqlconn.Open()
                objCommand.ExecuteNonQuery()
            End Using

            'If Not IsNothing(objCon) Then objCon.Close()
            Return True
        Catch ex As Exception
            If Not IsNothing(objCon) Then objCon.Close()
            Return ex
        Finally
            objCon = Nothing
            objCommand = Nothing
            GC.Collect()
        End Try
    End Function

    'Sub _db__add_table()
    '    Dim objCon As SQLiteConnection
    '    Dim objCommand As SQLiteCommand
    '    Try
    '        objCon = New SQLiteConnection(_cnn__string & "New=true;")
    '        objCon.Open()
    '        objCommand = objCon.CreateCommand
    '        objCommand.CommandText = "CREATE TABLE db_videos(id integer primary key, track_name text, title text, artist text, album text, picture text, file_name text, file_path text);"
    '        objCommand.ExecuteNonQuery()
    '        If Not IsNothing(objCon) Then objCon.Close()
    '    Catch ex As Exception
    '        If Not IsNothing(objCon) Then objCon.Close()
    '        MsgBox(ex.ToString)
    '    Finally
    '        objCon = Nothing
    '        objCommand = Nothing
    '        GC.Collect()
    '    End Try
    'End Sub

    Sub _db__add_item(_id As Integer, _track_name As String, _title As String, _artist As String, _album As String, _picture As String, _file_name As String, _file_path As String)
        Dim objcommand As SQLiteCommand
        Dim _sql As String
        Try
            Application.DoEvents()
            Using objConn = New SQLiteConnection(_cnn__string & "New=True;")
                _sql = "Insert into db_videos(id, track_name, title, artist, album, picture, file_name, file_path) values(@_id, @_track_name, @_title, @_artist, @_album, @_picture, @_file_name, @_file_path);"
                objcommand = New SQLiteCommand(_sql, objConn)
                objcommand.Parameters.AddWithValue("@_id", _id)
                objcommand.Parameters.AddWithValue("@_track_name", _track_name)
                objcommand.Parameters.AddWithValue("@_title", _title)
                objcommand.Parameters.AddWithValue("@_artist", _artist)
                objcommand.Parameters.AddWithValue("@_album", _album)
                objcommand.Parameters.AddWithValue("@_picture", _picture)
                objcommand.Parameters.AddWithValue("@_file_name", _file_name)
                objcommand.Parameters.AddWithValue("@_file_path", _file_path)
                objConn.Open()
                objcommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            objcommand = Nothing
            _id = Nothing
            GC.Collect()
        End Try
    End Sub

    'Sub _db__add_item(_id As Integer, _track_name As String, _title As String, _artist As String, _album As String, _picture As String, _file_name As String, _file_path As String)
    '    Dim objConn As SQLiteConnection
    '    Dim objcommand As SQLiteCommand
    '    'Dim _id As Integer
    '    Try
    '        '_id = _db__max_id()
    '        Application.DoEvents()
    '        objConn = New SQLiteConnection(_cnn__string & "New=True;")
    '        objConn.Open()
    '        objcommand = objConn.CreateCommand()
    '        objcommand.CommandText = "Insert into db_videos(id, track_name, title, artist, album, picture, file_name, file_path) values(" & _id & ",'" & _track_name & "','" & _title & "','" & _artist & "','" & _album & "','" & _picture & "','" & _file_name & "','" & _file_path & "');"
    '        objcommand.ExecuteNonQuery()
    '        If Not IsNothing(objConn) Then
    '            objConn.Close()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        objConn = Nothing
    '        objcommand = Nothing
    '        _id = Nothing
    '        GC.Collect()
    '    End Try
    'End Sub

    Function _db__max_id() As Integer
        Dim objConn As SQLiteConnection
        Dim objcommand As SQLiteCommand
        Dim objReader As SQLiteDataReader

        Try
            objConn = New SQLiteConnection(_cnn__string)
            objConn.Open()
            objcommand = objConn.CreateCommand()
            objcommand.CommandText = "SELECT max(id) + 1  as valor FROM db_videos;"
            objReader = objcommand.ExecuteReader()

            While (objReader.Read())
                If IsError(objReader("valor")) = False Then
                    If IsDBNull(objReader("valor")) = False Then
                        Return objReader("valor")
                    Else
                        Return 0
                    End If
                Else
                    Return 0
                End If
                'Return objReader("valor")
                Exit Function
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return -1

        Finally
            objReader.Close()
            objcommand.Connection.Close()
            objConn.Close()

            objConn = Nothing
            objcommand = Nothing
            objReader = Nothing
            GC.Collect()
        End Try
    End Function


    Function _db__read_table(ByRef _gdc_files As DevExpress.XtraGrid.GridControl, ByRef _gdv_files As DevExpress.XtraGrid.Views.Grid.GridView) As DataTable
        Dim objConn As SQLiteConnection
        Dim objcommand As SQLiteCommand
        Dim objReader As SQLiteDataReader
        Dim _dt As DataTable

        Try
            _dt = New DataTable
            _dt.Columns.Add("id", GetType(Int32))
            _dt.Columns.Add("track_name", GetType(String))
            _dt.Columns.Add("title", GetType(String))
            _dt.Columns.Add("artist", GetType(String))
            _dt.Columns.Add("album", GetType(String))
            _dt.Columns.Add("picture", GetType(String))
            _dt.Columns.Add("file_name", GetType(String))
            _dt.Columns.Add("file_path", GetType(String))

            objConn = New SQLiteConnection(_cnn__string)
            objConn.Open()
            objcommand = objConn.CreateCommand()
            objcommand.CommandText = "SELECT * FROM db_videos order by id desc"
            objReader = objcommand.ExecuteReader()

            While (objReader.Read())
                'id, track_name, title, artist, album, picture, file_name, file_path
                _dt.Rows.Add(objReader("id"), objReader("track_name"), objReader("title"), objReader("artist"), objReader("album"), objReader("picture"), objReader("file_name"), objReader("file_path"))
            End While

            _gdc_files.DataSource = _dt

            _gdv_files.Columns("id").Width = 50
            _gdv_files.Columns("track_name").Width = 200
            _gdv_files.Columns("title").Width = 250
            _gdv_files.Columns("artist").Width = 100
            _gdv_files.Columns("album").Width = 150
            _gdv_files.Columns("picture").Width = 150
            _gdv_files.Columns("file_name").Width = 150
            _gdv_files.Columns("file_path").Width = 150

            _gdv_files.Columns("picture").Visible = False
            _gdv_files.Columns("file_name").Visible = False
            _gdv_files.Columns("file_path").Visible = False

            '_gv___DataGrid_Empleados.Columns("productStatus").OptionsColumn.FixedWidth = True
            '_gv___DataGrid_Empleados.OptionsView.ColumnAutoWidth = True
            'colSalesDate = _gv___DataGrid_Empleados.Columns("FECHAHORA")
            'colSalesDate.DisplayFormat.FormatType = FormatType.DateTime
            'colSalesDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
            Return _dt

        Catch ex As Exception
            _dt = New DataTable
            _gdc_files.DataSource = _dt
            Return _dt
            MsgBox(ex.ToString)
        Finally
            objReader.Close()
            objcommand.Connection.Close()
            objConn.Close()
            objConn = Nothing
            objcommand = Nothing
            objReader = Nothing
            _dt = Nothing
            GC.Collect()
        End Try

    End Function


End Class
