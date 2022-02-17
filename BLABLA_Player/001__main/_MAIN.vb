Module _MAIN

    Public core_CLASS As New objts__Controles
    Public _frm__CONTROL As New video__CONTROL
    Public _video__PLAYER As New video__PLAYER

    Sub MAIN()


        Call video__IMPORTER_youtube.ShowDialog()
        Call _frm__CONTROL.ShowDialog()

        'Dim __video_CONTROLS As New _video_CONTROLS
        '__video_CONTROLS.ShowDialog()


    End Sub

End Module
