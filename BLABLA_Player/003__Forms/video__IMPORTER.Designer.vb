<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class video__IMPORTER
    Inherits DevExpress.XtraEditors.XtraForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    '''
    Private Sub InitializeComponent()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me._gdv__Database = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me._gdv__Files = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.frm__Panel__buttons = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.labelControl = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataLayoutControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me._gdv__Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gdv__Files, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataLayoutControl1
        '
        Me.dataLayoutControl1.AllowCustomization = False
        Me.dataLayoutControl1.Controls.Add(Me.PanelControl1)
        Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 30)
        Me.dataLayoutControl1.Name = "dataLayoutControl1"
        Me.dataLayoutControl1.Root = Me.layoutControlGroup1
        Me.dataLayoutControl1.Size = New System.Drawing.Size(1312, 730)
        Me.dataLayoutControl1.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me._gdv__Database)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me._gdv__Files)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1288, 706)
        Me.PanelControl1.TabIndex = 4
        '
        '_gdv__Database
        '
        Me._gdv__Database.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._gdv__Database.Location = New System.Drawing.Point(624, 27)
        Me._gdv__Database.MainView = Me.GridView2
        Me._gdv__Database.Name = "_gdv__Database"
        Me._gdv__Database.Size = New System.Drawing.Size(659, 674)
        Me._gdv__Database.TabIndex = 284
        Me._gdv__Database.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me._gdv__Database
        Me.GridView2.Name = "GridView2"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(624, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl2.TabIndex = 283
        Me.LabelControl2.Text = "Archivos agregados"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 16)
        Me.LabelControl1.TabIndex = 282
        Me.LabelControl1.Text = "Archivos por agregar"
        '
        '_gdv__Files
        '
        Me._gdv__Files.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._gdv__Files.Location = New System.Drawing.Point(5, 27)
        Me._gdv__Files.MainView = Me.GridView1
        Me._gdv__Files.Name = "_gdv__Files"
        Me._gdv__Files.Size = New System.Drawing.Size(613, 674)
        Me._gdv__Files.TabIndex = 281
        Me._gdv__Files.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me._gdv__Files
        Me.GridView1.Name = "GridView1"
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.layoutControlGroup1.Name = "Root"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(1312, 730)
        Me.layoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1292, 710)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frm__Panel__buttons
        '
        Me.frm__Panel__buttons.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.frm__Panel__buttons.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.frm__Panel__buttons.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.frm__Panel__buttons.AppearanceButton.Hovered.Options.UseBackColor = True
        Me.frm__Panel__buttons.AppearanceButton.Hovered.Options.UseFont = True
        Me.frm__Panel__buttons.AppearanceButton.Hovered.Options.UseForeColor = True
        Me.frm__Panel__buttons.AppearanceButton.Normal.FontSizeDelta = -1
        Me.frm__Panel__buttons.AppearanceButton.Normal.Options.UseFont = True
        Me.frm__Panel__buttons.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.frm__Panel__buttons.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.frm__Panel__buttons.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.frm__Panel__buttons.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.frm__Panel__buttons.AppearanceButton.Pressed.Options.UseFont = True
        Me.frm__Panel__buttons.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.frm__Panel__buttons.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        WindowsUIButtonImageOptions1.Image = Global.MYCA__Player.My.Resources.Resources.add_32x32
        WindowsUIButtonImageOptions1.ImageUri.Uri = "Save;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions2.Image = Global.MYCA__Player.My.Resources.Resources.refresh_32x32
        WindowsUIButtonImageOptions2.ImageUri.Uri = "Reset;Size32x32;GrayScaled"
        WindowsUIButtonImageOptions3.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled"
        Me.frm__Panel__buttons.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Importar", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.frm__Panel__buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.frm__Panel__buttons.EnableImageTransparency = True
        Me.frm__Panel__buttons.ForeColor = System.Drawing.Color.White
        Me.frm__Panel__buttons.Location = New System.Drawing.Point(0, 760)
        Me.frm__Panel__buttons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.frm__Panel__buttons.MaximumSize = New System.Drawing.Size(0, 60)
        Me.frm__Panel__buttons.MinimumSize = New System.Drawing.Size(60, 60)
        Me.frm__Panel__buttons.Name = "frm__Panel__buttons"
        Me.frm__Panel__buttons.Size = New System.Drawing.Size(1312, 60)
        Me.frm__Panel__buttons.TabIndex = 3
        Me.frm__Panel__buttons.Text = "windowsUIButtonPanelMain"
        Me.frm__Panel__buttons.UseButtonBackgroundImages = False
        '
        'labelControl
        '
        Me.labelControl.AllowHtmlString = True
        Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labelControl.Appearance.Options.UseFont = True
        Me.labelControl.Appearance.Options.UseForeColor = True
        Me.labelControl.Appearance.Options.UseTextOptions = True
        Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelControl.Location = New System.Drawing.Point(0, 0)
        Me.labelControl.Name = "labelControl"
        Me.labelControl.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.labelControl.Size = New System.Drawing.Size(1312, 30)
        Me.labelControl.TabIndex = 1
        Me.labelControl.Text = "Importador de Videos"
        '
        'video__IMPORTER
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(1312, 820)
        Me.Controls.Add(Me.dataLayoutControl1)
        Me.Controls.Add(Me.labelControl)
        Me.Controls.Add(Me.frm__Panel__buttons)
        Me.Name = "video__IMPORTER"
        CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataLayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me._gdv__Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gdv__Files, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Private WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents frm__Panel__buttons As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Private WithEvents labelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _gdv__Files As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents _gdv__Database As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
