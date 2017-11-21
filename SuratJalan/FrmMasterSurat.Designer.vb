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
        Me.GBDataKaryawan = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAtt = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.txtPerusahaan = New System.Windows.Forms.TextBox()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGMasterSurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPencarian.SuspendLayout()
        Me.GBDataKaryawan.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGMasterSurat
        '
        Me.DGMasterSurat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMasterSurat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGMasterSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMasterSurat.Location = New System.Drawing.Point(445, 157)
        Me.DGMasterSurat.Name = "DGMasterSurat"
        Me.DGMasterSurat.Size = New System.Drawing.Size(766, 201)
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
        Me.GBPencarian.Controls.Add(Me.txtCari)
        Me.GBPencarian.Controls.Add(Me.Label8)
        Me.GBPencarian.Controls.Add(Me.cmbCari)
        Me.GBPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPencarian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GBPencarian.Location = New System.Drawing.Point(445, 99)
        Me.GBPencarian.Name = "GBPencarian"
        Me.GBPencarian.Size = New System.Drawing.Size(766, 50)
        Me.GBPencarian.TabIndex = 30
        Me.GBPencarian.TabStop = False
        Me.GBPencarian.Text = "Cari Data"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(241, 18)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(519, 20)
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
        'cmbCari
        '
        Me.cmbCari.DropDownHeight = 150
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.IntegralHeight = False
        Me.cmbCari.ItemHeight = 13
        Me.cmbCari.Items.AddRange(New Object() {"Nomor Order", "Nama Perusahaan"})
        Me.cmbCari.Location = New System.Drawing.Point(101, 18)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(134, 21)
        Me.cmbCari.TabIndex = 2
        '
        'GBDataKaryawan
        '
        Me.GBDataKaryawan.BackColor = System.Drawing.Color.DarkCyan
        Me.GBDataKaryawan.Controls.Add(Me.Label6)
        Me.GBDataKaryawan.Controls.Add(Me.TextBox1)
        Me.GBDataKaryawan.Controls.Add(Me.txtUser)
        Me.GBDataKaryawan.Controls.Add(Me.txtNoOrder)
        Me.GBDataKaryawan.Controls.Add(Me.Label5)
        Me.GBDataKaryawan.Controls.Add(Me.Label9)
        Me.GBDataKaryawan.Controls.Add(Me.txtAtt)
        Me.GBDataKaryawan.Controls.Add(Me.txtTanggal)
        Me.GBDataKaryawan.Controls.Add(Me.txtPerusahaan)
        Me.GBDataKaryawan.Controls.Add(Me.txtNoSurat)
        Me.GBDataKaryawan.Controls.Add(Me.Label4)
        Me.GBDataKaryawan.Controls.Add(Me.Label3)
        Me.GBDataKaryawan.Controls.Add(Me.Label2)
        Me.GBDataKaryawan.Controls.Add(Me.Label1)
        Me.GBDataKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBDataKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDataKaryawan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GBDataKaryawan.Location = New System.Drawing.Point(6, 99)
        Me.GBDataKaryawan.Name = "GBDataKaryawan"
        Me.GBDataKaryawan.Size = New System.Drawing.Size(432, 259)
        Me.GBDataKaryawan.TabIndex = 31
        Me.GBDataKaryawan.TabStop = False
        Me.GBDataKaryawan.Text = "Data Karyawan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Alamat Perushaan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 185)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 55)
        Me.TextBox1.TabIndex = 21
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(163, 159)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(230, 20)
        Me.txtUser.TabIndex = 20
        '
        'txtNoOrder
        '
        Me.txtNoOrder.Location = New System.Drawing.Point(163, 133)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.Size = New System.Drawing.Size(230, 20)
        Me.txtNoOrder.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "User"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tanggal Surat"
        '
        'txtAtt
        '
        Me.txtAtt.Location = New System.Drawing.Point(163, 81)
        Me.txtAtt.Name = "txtAtt"
        Me.txtAtt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAtt.Size = New System.Drawing.Size(230, 20)
        Me.txtAtt.TabIndex = 10
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(163, 107)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(230, 20)
        Me.txtTanggal.TabIndex = 3
        '
        'txtPerusahaan
        '
        Me.txtPerusahaan.Location = New System.Drawing.Point(163, 55)
        Me.txtPerusahaan.Name = "txtPerusahaan"
        Me.txtPerusahaan.Size = New System.Drawing.Size(230, 20)
        Me.txtPerusahaan.TabIndex = 1
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Location = New System.Drawing.Point(163, 30)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.ReadOnly = True
        Me.txtNoSurat.Size = New System.Drawing.Size(230, 20)
        Me.txtNoSurat.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Att"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Perusahaan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Surat"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(445, 368)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(766, 201)
        Me.DataGridView1.TabIndex = 32
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Crimson
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBatal.Image = Global.SuratJalan.My.Resources.Resources.close_20
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(219, 21)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnBatal.Size = New System.Drawing.Size(100, 50)
        Me.btnBatal.TabIndex = 36
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = Global.SuratJalan.My.Resources.Resources.save__save_as_icon_icon__2_
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(7, 21)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(100, 50)
        Me.btnSimpan.TabIndex = 35
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHapus.Image = Global.SuratJalan.My.Resources.Resources.remove_button_20
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(325, 21)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 50)
        Me.btnHapus.TabIndex = 34
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.SuratJalan.My.Resources.Resources.edit_button_20
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(113, 21)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEdit.Size = New System.Drawing.Size(100, 50)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 87)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(5, 517)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(433, 55)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Cari data berdasarkan kriteria yang diinginkan." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Setelah data ditampilkan klik 2 " & _
            "kali pada data yang diinginkan." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data hanya bisa di edit adalah data yang di loa" & _
            "d pada field di atas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.UseCompatibleTextRendering = True
        '
        'FrmMasterSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1220, 581)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GBDataKaryawan)
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
        Me.GBDataKaryawan.ResumeLayout(False)
        Me.GBDataKaryawan.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents GBDataKaryawan As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAtt As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtPerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
