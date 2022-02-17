Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Data.SqlTypes

Public Class atribs__Controles

    Public _cnn__string As String
    Public _path__app As String
    Public _path__media_database As String
    Public _path__media_upload As String
    Public _path__software As String

    Public _wmp__Consola As New pprtys__WMP__Status
    Public _wmp__Cliente As New pprtys__WMP__Status

    Enum _type_REPRODUCTION_STATUS
        _nd = 0
        _error = 1
        _play = 2
        _pausa = 3
        _stop = 4
        _ready = 5
    End Enum

    Public Class pprtys__WMP__Status

        Public Property video_id As Integer
        Public Property video_name As String
        Public Property video_path As String
        Public Property video_volume As String
        Public Property video_mute As Boolean
        Public Property video_duration As Integer
        Public Property video_status As _type_REPRODUCTION_STATUS

    End Class

End Class
