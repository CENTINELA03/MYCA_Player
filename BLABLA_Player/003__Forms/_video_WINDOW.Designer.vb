<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _video_WINDOW
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_video_WINDOW))
        Me._wmp_PRINCIPAL = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me._wmp_PRINCIPAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_wmp_PRINCIPAL
        '
        Me._wmp_PRINCIPAL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._wmp_PRINCIPAL.Enabled = True
        Me._wmp_PRINCIPAL.Location = New System.Drawing.Point(0, 0)
        Me._wmp_PRINCIPAL.Name = "_wmp_PRINCIPAL"
        Me._wmp_PRINCIPAL.OcxState = CType(resources.GetObject("_wmp_PRINCIPAL.OcxState"), System.Windows.Forms.AxHost.State)
        Me._wmp_PRINCIPAL.Size = New System.Drawing.Size(700, 400)
        Me._wmp_PRINCIPAL.TabIndex = 0
        Me._wmp_PRINCIPAL.UseWaitCursor = True
        '
        '_video_WINDOW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me._wmp_PRINCIPAL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_video_WINDOW"
        Me.Text = "... ACORP Player ..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._wmp_PRINCIPAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents _wmp_PRINCIPAL As AxWMPLib.AxWindowsMediaPlayer

End Class
