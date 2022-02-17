Imports System.IO
Imports VideoLibrary

Public Class video__IMPORTER_youtube

    Sub SaveVideoToDisk(ByVal link As String)
        Dim video = YouTube.Default.GetVideo(link)
        File.WriteAllBytes("C:\" & video.FullName, video.GetBytes())
    End Sub

    Private Sub video__IMPORTER_youtube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaveVideoToDisk("https://www.youtube.com/watch?v=4He3THjP4IE")
    End Sub

End Class