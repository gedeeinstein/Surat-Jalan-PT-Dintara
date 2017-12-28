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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterSurat))
        Me.DGMasterSurat = New System.Windows.Forms.DataGridView()
        Me.title = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GBPencarian = New System.Windows.Forms.GroupBox()
        Me.rb_nama_perusahaan = New System.Windows.Forms.RadioButton()
        Me.rb_no_order = New System.Windows.Forms.RadioButton()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGDetailsMasterSurat = New System.Windows.Forms.DataGridView()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.rb_nosurat = New System.Windows.Forms.RadioButton()
        Me.rb_nopenawaran = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGMasterSurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPencarian.SuspendLayout()
        CType(Me.DGDetailsMasterSurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGMasterSurat
        '
        Me.DGMasterSurat.AllowUserToAddRows = False
        Me.DGMasterSurat.AllowUserToDeleteRows = False
        Me.DGMasterSurat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMasterSurat.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMasterSurat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGMasterSurat.Location = New System.Drawing.Point(19, 177)
        Me.DGMasterSurat.Name = "DGMasterSurat"
        Me.DGMasterSurat.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMasterSurat.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGMasterSurat.RowHeadersWidth = 4
        Me.DGMasterSurat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMasterSurat.Size = New System.Drawing.Size(1192, 201)
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
        Me.title.Size = New System.Drawing.Size(1220, 96)
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
        Me.btnClose.Location = New System.Drawing.Point(1183, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(37, 37)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'GBPencarian
        '
        Me.GBPencarian.BackColor = System.Drawing.Color.DarkCyan
        Me.GBPencarian.Controls.Add(Me.rb_nama_perusahaan)
        Me.GBPencarian.Controls.Add(Me.rb_no_order)
        Me.GBPencarian.Controls.Add(Me.txtCari)
        Me.GBPencarian.Controls.Add(Me.Label8)
        Me.GBPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPencarian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GBPencarian.Location = New System.Drawing.Point(19, 99)
        Me.GBPencarian.Name = "GBPencarian"
        Me.GBPencarian.Size = New System.Drawing.Size(1192, 50)
        Me.GBPencarian.TabIndex = 30
        Me.GBPencarian.TabStop = False
        Me.GBPencarian.Text = "Cari Data"
        '
        'rb_nama_perusahaan
        '
        Me.rb_nama_perusahaan.AutoSize = True
        Me.rb_nama_perusahaan.Location = New System.Drawing.Point(242, 19)
        Me.rb_nama_perusahaan.Name = "rb_nama_perusahaan"
        Me.rb_nama_perusahaan.Size = New System.Drawing.Size(128, 17)
        Me.rb_nama_perusahaan.TabIndex = 18
        Me.rb_nama_perusahaan.Text = "Nama Perusahaan"
        Me.rb_nama_perusahaan.UseVisualStyleBackColor = True
        '
        'rb_no_order
        '
        Me.rb_no_order.AutoSize = True
        Me.rb_no_order.Checked = True
        Me.rb_no_order.Location = New System.Drawing.Point(106, 19)
        Me.rb_no_order.Name = "rb_no_order"
        Me.rb_no_order.Size = New System.Drawing.Size(76, 17)
        Me.rb_no_order.TabIndex = 17
        Me.rb_no_order.TabStop = True
        Me.rb_no_order.Text = "No Order"
        Me.rb_no_order.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(422, 18)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(764, 20)
        Me.txtCari.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Berdasarkan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGDetailsMasterSurat
        '
        Me.DGDetailsMasterSurat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGDetailsMasterSurat.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDetailsMasterSurat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGDetailsMasterSurat.Location = New System.Drawing.Point(19, 416)
        Me.DGDetailsMasterSurat.Name = "DGDetailsMasterSurat"
        Me.DGDetailsMasterSurat.RowHeadersWidth = 4
        Me.DGDetailsMasterSurat.Size = New System.Drawing.Size(1192, 201)
        Me.DGDetailsMasterSurat.TabIndex = 32
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Crimson
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBatal.Image = Global.SuratJalan.My.Resources.Resources.close_20
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(125, 629)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnBatal.Size = New System.Drawing.Size(100, 50)
        Me.btnBatal.TabIndex = 36
        Me.btnBatal.Text = "Keluar"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.SuratJalan.My.Resources.Resources.Print_font_awesome_svg
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(19, 629)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnPrint.Size = New System.Drawing.Size(100, 50)
        Me.btnPrint.TabIndex = 35
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHapus.Image = Global.SuratJalan.My.Resources.Resources.remove_button_20
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(665, 629)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 50)
        Me.btnHapus.TabIndex = 34
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnHapus.UseVisualStyleBackColor = False
        Me.btnHapus.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.SuratJalan.My.Resources.Resources.edit_button_20
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(547, 629)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEdit.Size = New System.Drawing.Size(100, 50)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(16, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "History Surat Jalan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(16, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Barang Sudah Terkirim"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(934, 642)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Total Barang Terkirim"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(1120, 642)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 23)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNoOrder
        '
        Me.txtNoOrder.Location = New System.Drawing.Point(231, 390)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.ReadOnly = True
        Me.txtNoOrder.Size = New System.Drawing.Size(188, 20)
        Me.txtNoOrder.TabIndex = 41
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Location = New System.Drawing.Point(425, 389)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.ReadOnly = True
        Me.txtNoSurat.Size = New System.Drawing.Size(188, 20)
        Me.txtNoSurat.TabIndex = 42
        '
        'rb_nosurat
        '
        Me.rb_nosurat.AutoSize = True
        Me.rb_nosurat.Checked = True
        Me.rb_nosurat.ForeColor = System.Drawing.Color.FloralWhite
        Me.rb_nosurat.Location = New System.Drawing.Point(30, 17)
        Me.rb_nosurat.Name = "rb_nosurat"
        Me.rb_nosurat.Size = New System.Drawing.Size(95, 17)
        Me.rb_nosurat.TabIndex = 43
        Me.rb_nosurat.TabStop = True
        Me.rb_nosurat.Text = "No Surat Jalan"
        Me.rb_nosurat.UseVisualStyleBackColor = True
        '
        'rb_nopenawaran
        '
        Me.rb_nopenawaran.AutoSize = True
        Me.rb_nopenawaran.ForeColor = System.Drawing.Color.FloralWhite
        Me.rb_nopenawaran.Location = New System.Drawing.Point(165, 17)
        Me.rb_nopenawaran.Name = "rb_nopenawaran"
        Me.rb_nopenawaran.Size = New System.Drawing.Size(96, 17)
        Me.rb_nopenawaran.TabIndex = 44
        Me.rb_nopenawaran.Text = "No Penawaran"
        Me.rb_nopenawaran.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_nosurat)
        Me.GroupBox1.Controls.Add(Me.rb_nopenawaran)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Location = New System.Drawing.Point(231, 629)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 50)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Berdasarkan"
        '
        'FrmMasterSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1220, 691)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNoSurat)
        Me.Controls.Add(Me.txtNoOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.DGDetailsMasterSurat)
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
        CType(Me.DGDetailsMasterSurat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGMasterSurat As System.Windows.Forms.DataGridView
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GBPencarian As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DGDetailsMasterSurat As System.Windows.Forms.DataGridView
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rb_nama_perusahaan As System.Windows.Forms.RadioButton
    Friend WithEvents rb_no_order As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents rb_nosurat As System.Windows.Forms.RadioButton
    Friend WithEvents rb_nopenawaran As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
