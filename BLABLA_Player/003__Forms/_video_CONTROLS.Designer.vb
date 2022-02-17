<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _video_CONTROLS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_video_CONTROLS))
        Me.C1DockingTab2 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.Flexg_ARCHIVOS = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DockingTabPage6 = New C1.Win.C1Command.C1DockingTabPage()
        Me._Back = New C1.Win.C1Input.C1Button()
        Me._Next = New C1.Win.C1Input.C1Button()
        Me._Pausa = New C1.Win.C1Input.C1Button()
        Me._Stop = New C1.Win.C1Input.C1Button()
        Me._Play = New C1.Win.C1Input.C1Button()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.Pro = New DevExpress.XtraEditors.ProgressBarControl()
        Me._track_BAR = New System.Windows.Forms.TrackBar()
        Me._wmp_PREVIEW = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.C1DockingTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab2.SuspendLayout()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.Flexg_ARCHIVOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Pausa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Stop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._track_BAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._wmp_PREVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTab2
        '
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab2.Controls.Add(Me.C1DockingTabPage6)
        Me.C1DockingTab2.Location = New System.Drawing.Point(5, 2)
        Me.C1DockingTab2.Name = "C1DockingTab2"
        Me.C1DockingTab2.SelectedIndex = 4
        Me.C1DockingTab2.Size = New System.Drawing.Size(708, 545)
        Me.C1DockingTab2.TabAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1DockingTab2.TabIndex = 265
        Me.C1DockingTab2.TabsSpacing = 0
        Me.C1DockingTab2.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1DockingTabPage2.Controls.Add(Me.Flexg_ARCHIVOS)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(706, 520)
        Me.C1DockingTabPage2.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1DockingTabPage2.TabBackColorSelected = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1DockingTabPage2.TabIndex = 0
        Me.C1DockingTabPage2.Text = "Page1"
        '
        'Flexg_ARCHIVOS
        '
        Me.Flexg_ARCHIVOS.AllowEditing = False
        Me.Flexg_ARCHIVOS.ColumnInfo = resources.GetString("Flexg_ARCHIVOS.ColumnInfo")
        Me.Flexg_ARCHIVOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Flexg_ARCHIVOS.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Flexg_ARCHIVOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Flexg_ARCHIVOS.Location = New System.Drawing.Point(0, 0)
        Me.Flexg_ARCHIVOS.Name = "Flexg_ARCHIVOS"
        Me.Flexg_ARCHIVOS.Rows.Count = 10
        Me.Flexg_ARCHIVOS.Rows.DefaultSize = 19
        Me.Flexg_ARCHIVOS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Flexg_ARCHIVOS.Size = New System.Drawing.Size(706, 520)
        Me.Flexg_ARCHIVOS.StyleInfo = resources.GetString("Flexg_ARCHIVOS.StyleInfo")
        Me.Flexg_ARCHIVOS.TabIndex = 232
        Me.Flexg_ARCHIVOS.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(706, 520)
        Me.C1DockingTabPage3.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1DockingTabPage3.TabBackColorSelected = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1DockingTabPage3.TabIndex = 1
        Me.C1DockingTabPage3.Text = "Page2"
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(706, 520)
        Me.C1DockingTabPage4.TabIndex = 2
        Me.C1DockingTabPage4.Text = "Page3"
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(706, 520)
        Me.C1DockingTabPage5.TabIndex = 3
        Me.C1DockingTabPage5.Text = "Page4"
        '
        'C1DockingTabPage6
        '
        Me.C1DockingTabPage6.Location = New System.Drawing.Point(1, 24)
        Me.C1DockingTabPage6.Name = "C1DockingTabPage6"
        Me.C1DockingTabPage6.Size = New System.Drawing.Size(706, 520)
        Me.C1DockingTabPage6.TabIndex = 4
        Me.C1DockingTabPage6.Text = "Page5"
        '
        '_Back
        '
        Me._Back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Back.Image = CType(resources.GetObject("_Back.Image"), System.Drawing.Image)
        Me._Back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Back.Location = New System.Drawing.Point(875, 418)
        Me._Back.Name = "_Back"
        Me._Back.Size = New System.Drawing.Size(106, 31)
        Me._Back.TabIndex = 269
        Me._Back.Text = "Anterior"
        Me._Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Back.UseVisualStyleBackColor = True
        Me._Back.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        '_Next
        '
        Me._Next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Next.Image = CType(resources.GetObject("_Next.Image"), System.Drawing.Image)
        Me._Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Next.Location = New System.Drawing.Point(875, 381)
        Me._Next.Name = "_Next"
        Me._Next.Size = New System.Drawing.Size(106, 31)
        Me._Next.TabIndex = 268
        Me._Next.Text = "Siguiente"
        Me._Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Next.UseVisualStyleBackColor = True
        Me._Next.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        '_Pausa
        '
        Me._Pausa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Pausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Pausa.Image = CType(resources.GetObject("_Pausa.Image"), System.Drawing.Image)
        Me._Pausa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Pausa.Location = New System.Drawing.Point(874, 344)
        Me._Pausa.Name = "_Pausa"
        Me._Pausa.Size = New System.Drawing.Size(106, 31)
        Me._Pausa.TabIndex = 267
        Me._Pausa.Text = "Pausar"
        Me._Pausa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Pausa.UseVisualStyleBackColor = True
        Me._Pausa.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        '_Stop
        '
        Me._Stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Stop.Image = CType(resources.GetObject("_Stop.Image"), System.Drawing.Image)
        Me._Stop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Stop.Location = New System.Drawing.Point(875, 307)
        Me._Stop.Name = "_Stop"
        Me._Stop.Size = New System.Drawing.Size(105, 31)
        Me._Stop.TabIndex = 266
        Me._Stop.Text = "Detener"
        Me._Stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Stop.UseVisualStyleBackColor = True
        Me._Stop.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        '_Play
        '
        Me._Play.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Play.Image = CType(resources.GetObject("_Play.Image"), System.Drawing.Image)
        Me._Play.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._Play.Location = New System.Drawing.Point(874, 270)
        Me._Play.Name = "_Play"
        Me._Play.Size = New System.Drawing.Size(106, 31)
        Me._Play.TabIndex = 241
        Me._Play.Text = "Reproducir"
        Me._Play.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._Play.UseVisualStyleBackColor = True
        Me._Play.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Button1
        '
        Me.C1Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Button1.Image = CType(resources.GetObject("C1Button1.Image"), System.Drawing.Image)
        Me.C1Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.C1Button1.Location = New System.Drawing.Point(855, 494)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(106, 31)
        Me.C1Button1.TabIndex = 272
        Me.C1Button1.Text = "Anterior"
        Me.C1Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Pro
        '
        Me.Pro.Location = New System.Drawing.Point(722, 219)
        Me.Pro.Name = "Pro"
        Me.Pro.Size = New System.Drawing.Size(270, 18)
        Me.Pro.TabIndex = 273
        '
        '_track_BAR
        '
        Me._track_BAR.LargeChange = 1
        Me._track_BAR.Location = New System.Drawing.Point(713, 193)
        Me._track_BAR.Name = "_track_BAR"
        Me._track_BAR.Size = New System.Drawing.Size(288, 45)
        Me._track_BAR.TabIndex = 275
        '
        '_wmp_PREVIEW
        '
        Me._wmp_PREVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._wmp_PREVIEW.Enabled = True
        Me._wmp_PREVIEW.Location = New System.Drawing.Point(720, 26)
        Me._wmp_PREVIEW.Name = "_wmp_PREVIEW"
        Me._wmp_PREVIEW.OcxState = CType(resources.GetObject("_wmp_PREVIEW.OcxState"), System.Windows.Forms.AxHost.State)
        Me._wmp_PREVIEW.Size = New System.Drawing.Size(273, 166)
        Me._wmp_PREVIEW.TabIndex = 270
        Me._wmp_PREVIEW.UseWaitCursor = True
        '
        '_video_CONTROLS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 552)
        Me.Controls.Add(Me._wmp_PREVIEW)
        Me.Controls.Add(Me.Pro)
        Me.Controls.Add(Me._track_BAR)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me._Back)
        Me.Controls.Add(Me._Next)
        Me.Controls.Add(Me._Pausa)
        Me.Controls.Add(Me._Stop)
        Me.Controls.Add(Me.C1DockingTab2)
        Me.Controls.Add(Me._Play)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.WindowsApplication1.My.MySettings.Default, "_location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("WindowState", Global.WindowsApplication1.My.MySettings.Default, "_window_STATE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.WindowsApplication1.My.MySettings.Default._location
        Me.Name = "_video_CONTROLS"
        Me.Text = "... ACORP Video Controls ..."
        Me.WindowState = Global.WindowsApplication1.My.MySettings.Default._window_STATE
        CType(Me.C1DockingTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab2.ResumeLayout(False)
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.Flexg_ARCHIVOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Pausa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Stop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._track_BAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._wmp_PREVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _Play As C1.Win.C1Input.C1Button
    Friend WithEvents C1DockingTab2 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage6 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents Flexg_ARCHIVOS As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _Stop As C1.Win.C1Input.C1Button
    Friend WithEvents _Pausa As C1.Win.C1Input.C1Button
    Friend WithEvents _Next As C1.Win.C1Input.C1Button
    Friend WithEvents _Back As C1.Win.C1Input.C1Button
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents Pro As DevExpress.XtraEditors.ProgressBarControl
    Public WithEvents _wmp_PREVIEW As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents _track_BAR As System.Windows.Forms.TrackBar
End Class
