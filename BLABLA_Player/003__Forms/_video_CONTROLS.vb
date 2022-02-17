Public Class _video_CONTROLS

    Dim __video_WINDOW As New _video_WINDOW

    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub

    Private Sub _video_CONTROLS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '__video_WINDOW.Show()
        '__video_WINDOW._wmp_PRINCIPAL.URL = "A:\Codigo Fuente ACORP 2010\BLABLA\BLABLA_Player\Pictures\blabla_Orizaba.jpg"
        '_consulta_ARCHIVOS("C:\Users\Centinela\Downloads")
        _frm__FRAME = New video__FRAME
    End Sub




    Sub _consulta_ARCHIVOS(PATH As String)
        Flexg_ARCHIVOS.Rows.Count = 1

        For Each file As String In IO.Directory.GetFiles(PATH)
            Select Case Strings.Right(file, 4)
                Case ".mp3", ".mp4", ".flv"
                    Dim fi As New IO.FileInfo(file)
                    Flexg_ARCHIVOS.AddItem("" & vbTab & file & vbTab & fi.Length & vbTab & fi.CreationTime.ToString)
                    fi = Nothing
                Case Else

            End Select

        Next
    End Sub

    Private Sub Flexg_ARCHIVOS_DoubleClick(sender As System.Object, e As System.EventArgs) Handles Flexg_ARCHIVOS.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        __video_WINDOW._wmp_PRINCIPAL.Ctlcontrols.stop()
        __video_WINDOW._wmp_PRINCIPAL.URL = "B:\NET\_BUNKER_\DEVELOP\021__BLABLA\BLABLA_Player\Pictures\blabla_Orizaba.jpg"
        __video_WINDOW._wmp_PRINCIPAL.Refresh()
        System.Threading.Thread.Sleep(1000)
        __video_WINDOW._wmp_PRINCIPAL.URL = Flexg_ARCHIVOS(Flexg_ARCHIVOS.Row, 1)
        __video_WINDOW._wmp_PRINCIPAL.Ctlcontrols.play()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub _play_Click(sender As System.Object, e As System.EventArgs) Handles _Play.Click
        Me._wmp_PREVIEW.Ctlcontrols.stop()
        __video_WINDOW._wmp_PRINCIPAL.Ctlcontrols.stop()
        Me._wmp_PREVIEW.URL = "B:\The.Peanuts.Movie.2015.DVDSCR.avi"
        Me._wmp_PREVIEW.Ctlcontrols.play()
        Me._wmp_PREVIEW.windowlessVideo = False
        Me._wmp_PREVIEW.Refresh()
        Application.DoEvents()
        _track_BAR.Maximum = _wmp_PREVIEW.currentMedia.duration
        __video_WINDOW._wmp_PRINCIPAL.URL = "B:\The.Peanuts.Movie.2015.DVDSCR.avi"
        __video_WINDOW._wmp_PRINCIPAL.Refresh()
    End Sub

    Private Sub _Stop_Click(sender As System.Object, e As System.EventArgs) Handles _Stop.Click
        __video_WINDOW._wmp_PRINCIPAL.Ctlcontrols.stop()
    End Sub

    Private Sub _Pausa_Click(sender As System.Object, e As System.EventArgs) Handles _Pausa.Click
        __video_WINDOW._wmp_PRINCIPAL.Ctlcontrols.pause()
    End Sub

    Private Sub _Next_Click(sender As System.Object, e As System.EventArgs) Handles _Next.Click
        Flexg_ARCHIVOS.Row = Flexg_ARCHIVOS.Row + 1
    End Sub

    Private Sub _Back_Click(sender As System.Object, e As System.EventArgs) Handles _Back.Click
        Flexg_ARCHIVOS.Row = Flexg_ARCHIVOS.Row - 1
    End Sub

    Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles C1Button1.Click
        _wmp_PREVIEW.Ctlcontrols.currentPosition = 1000
    End Sub

    Private Sub _track_BAR_Scroll(sender As Object, e As EventArgs) Handles _track_BAR.Scroll
        _wmp_PREVIEW.Ctlcontrols.currentPosition = _track_BAR.Value
    End Sub

    Private Sub _wmp_PREVIEW_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles _wmp_PREVIEW.PlayStateChange
        Debug.Print(e.newState)
    End Sub
End Class