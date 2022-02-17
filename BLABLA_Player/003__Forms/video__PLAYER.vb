Public Class video__PLAYER

    Dim _scree_nunber As Integer = 0
    'Dim scr As Screen = Screen.FromPoint(Cursor.Position)
    Private Sub _video_WINDOW_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Me.WindowState = FormWindowState.Maximized
        'Me.Location = New Point(Screen.AllScreens(_scree_nunber).Bounds.Width, Screen.AllScreens(0).Bounds.Top)
        ' Me.Location = New Point(Screen.AllScreens(_scree_nunber).Bounds.Width, Screen.AllScreens(0).Bounds.Top)

        'Dim scr As Screen = Screen.FromPoint(Cursor.Position)
        'Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Bottom - Me.Height)

        'Me._wmp__CLIENT.URL = "B:\NET\_BUNKER_\DEVELOP\021__BLABLA\BLABLA_Player\Pictures\_no_picture.jpg"
        _video__PLAYER._wmp__CLIENT.Refresh()

    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    'scr = Screen.FromPoint(Cursor.Position)
    '    Application.DoEvents()
    '    Debug.Print(Me.Location.X & " - " & Me.Location.Y)
    'End Sub


    Private Sub _wmp_DoubleClickEvent(sender As System.Object, e As AxWMPLib._WMPOCXEvents_DoubleClickEvent) Handles _wmp__CLIENT.DoubleClickEvent
        Select Case Me.WindowState
            Case FormWindowState.Maximized
                Me.WindowState = FormWindowState.Normal
            Case FormWindowState.Normal
                Me.WindowState = FormWindowState.Maximized
        End Select
    End Sub

    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub _wmp_MouseDownEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseDownEvent) Handles _wmp__CLIENT.MouseDownEvent
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub _wmp_MouseMoveEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseMoveEvent) Handles _wmp__CLIENT.MouseMoveEvent
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub _wmp_MouseUpEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseUpEvent) Handles _wmp__CLIENT.MouseUpEvent
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

End Class