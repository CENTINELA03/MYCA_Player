Imports System.Windows
Public Class _video_WINDOW
    Private Sub _video_WINDOW_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '_wmp.URL = "C:\Como descargar o bajar videos y msica de youtube gratis, tutorial en poco ms de un minuto.avi"
        '_wmp.Ctlcontrols.play()
    End Sub

    Private Sub _wmp_DoubleClickEvent(sender As System.Object, e As AxWMPLib._WMPOCXEvents_DoubleClickEvent) Handles _wmp_PRINCIPAL.DoubleClickEvent
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

    Private Sub _wmp_MouseDownEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseDownEvent) Handles _wmp_PRINCIPAL.MouseDownEvent
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub _wmp_MouseMoveEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseMoveEvent) Handles _wmp_PRINCIPAL.MouseMoveEvent
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub _wmp_MouseUpEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseUpEvent) Handles _wmp_PRINCIPAL.MouseUpEvent
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

End Class
