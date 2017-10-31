<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterSurat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterSurat))
        Me.DGMasterSurat = New System.Windows.Forms.DataGridView()
        Me.title = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GBPencarian = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCari = New System.Windows.Forms.ComboBox()
        CType(Me.DGMasterSurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPencarian.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGMasterSurat
        '
        Me.DGMasterSurat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMasterSurat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGMasterSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMasterSurat.Location = New System.Drawing.Point(375, 162)
        Me.DGMasterSurat.Name = "DGMasterSurat"
        Me.DGMasterSurat.Size = New System.Drawing.Size(660, 173)
        Me.DGMasterSurat.TabIndex = 0
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.title.Dock = System.Windows.Forms.DockStyle.Top
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(0, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(1047, 68)
        Me.title.TabIndex = 1
        Me.title.Text = "Riwayat Surat Jalan"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.title.UseCompatibleTextRendering = True
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(1010, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(37, 37)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GBPencarian
        '
        Me.GBPencarian.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GBPencarian.Controls.Add(Me.txtCari)
        Me.GBPencarian.Controls.Add(Me.Label8)
        Me.GBPencarian.Controls.Add(Me.cmbCari)
        Me.GBPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPencarian.ForeColor = System.Drawing.Color.White
        Me.GBPencarian.Location = New System.Drawing.Point(144, 77)
        Me.GBPencarian.Name = "GBPencarian"
        Me.GBPencarian.Size = New System.Drawing.Size(891, 79)
        Me.GBPencarian.TabIndex = 30
        Me.GBPencarian.TabStop = False
        Me.GBPencarian.Text = "Cari Data"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(271, 34)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(489, 20)
        Me.txtCari.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Berdasarkan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCari
        '
        Me.cmbCari.DropDownHeight = 150
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.IntegralHeight = False
        Me.cmbCari.ItemHeight = 13
        Me.cmbCari.Items.AddRange(New Object() {"Nama Karyawan", "Username", "ID"})
        Me.cmbCari.Location = New System.Drawing.Point(131, 33)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(134, 21)
        Me.cmbCari.TabIndex = 2
        '
        'FrmMasterSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1047, 517)
        Me.Controls.Add(Me.GBPencarian)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.DGMasterSurat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FrmMasterSurat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Surat"
        CType(Me.DGMasterSurat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPencarian.ResumeLayout(False)
        Me.GBPencarian.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGMasterSurat As System.Windows.Forms.DataGridView
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GBPencarian As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCari As System.Windows.Forms.ComboBox
End Class
