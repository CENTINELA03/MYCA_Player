<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class video__PLAYER
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(video__PLAYER))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me._wmp__CLIENT = New AxWMPLib.AxWindowsMediaPlayer()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me._wmp__CLIENT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        '_wmp__CLIENT
        '
        Me._wmp__CLIENT.Enabled = True
        Me._wmp__CLIENT.Location = New System.Drawing.Point(0, 0)
        Me._wmp__CLIENT.Name = "_wmp__CLIENT"
        Me._wmp__CLIENT.OcxState = CType(resources.GetObject("_wmp__CLIENT.OcxState"), System.Windows.Forms.AxHost.State)
        Me._wmp__CLIENT.Size = New System.Drawing.Size(1087, 694)
        Me._wmp__CLIENT.TabIndex = 1
        Me._wmp__CLIENT.UseWaitCursor = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(288, 42)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Restaurante BlaBla"
        '
        'video__PLAYER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 694)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me._wmp__CLIENT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "video__PLAYER"
        Me.Text = "XtraForm1"
        CType(Me._wmp__CLIENT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents _wmp__CLIENT As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
