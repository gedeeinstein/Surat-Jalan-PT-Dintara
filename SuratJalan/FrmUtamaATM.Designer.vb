<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtamaATM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtamaATM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPelanggan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.NoSurat = New System.Windows.Forms.Label()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnCariPerusahaan = New System.Windows.Forms.Button()
        Me.txtKodePerusahaan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPerusahaan = New System.Windows.Forms.TextBox()
        Me.cmbPerusahaan = New System.Windows.Forms.ComboBox()
        Me.DGBarangKirim = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_TotalBarang = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loged_in = New System.Windows.Forms.Label()
        Me.welcome_lbl = New System.Windows.Forms.Label()
        Me.btnTambahUser = New System.Windows.Forms.Button()
        Me.btnMasterSurat = New System.Windows.Forms.Button()
        Me.btnFrmDIN = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ig = New System.Windows.Forms.LinkLabel()
        Me.fb = New System.Windows.Forms.LinkLabel()
        Me.twitt = New System.Windows.Forms.LinkLabel()
        Me.gplus = New System.Windows.Forms.LinkLabel()
        Me.gmail = New System.Windows.Forms.LinkLabel()
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r
        Me.outlook = New System.Windows.Forms.PictureBox()
        Me.gmail2 = New System.Windows.Forms.PictureBox()
        Me.maps = New System.Windows.Forms.PictureBox()
        Me.whatsapp = New System.Windows.Forms.PictureBox()
        Me.gplus2 = New System.Windows.Forms.PictureBox()
        Me.twitter = New System.Windows.Forms.PictureBox()
        Me.fb2 = New System.Windows.Forms.PictureBox()
        Me.instagram = New System.Windows.Forms.PictureBox()
        Me.linkedin = New System.Windows.Forms.PictureBox()
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGBarangKirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.outlook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.whatsapp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gplus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.twitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.instagram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkedin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1366, 93)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Surat Jalan CV"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kepada"
        '
        'txtPelanggan
        '
        Me.txtPelanggan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPelanggan.Enabled = False
        Me.txtPelanggan.Location = New System.Drawing.Point(593, 21)
        Me.txtPelanggan.MaxLength = 75
        Me.txtPelanggan.Name = "txtPelanggan"
        Me.txtPelanggan.ReadOnly = True
        Me.txtPelanggan.Size = New System.Drawing.Size(239, 20)
        Me.txtPelanggan.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(534, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(593, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(239, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'NoSurat
        '
        Me.NoSurat.AutoSize = True
        Me.NoSurat.BackColor = System.Drawing.SystemColors.Control
        Me.NoSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoSurat.ForeColor = System.Drawing.Color.Black
        Me.NoSurat.Location = New System.Drawing.Point(6, 24)
        Me.NoSurat.Name = "NoSurat"
        Me.NoSurat.Size = New System.Drawing.Size(61, 13)
        Me.NoSurat.TabIndex = 6
        Me.NoSurat.Text = "No. Surat"
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Enabled = False
        Me.txtNoSurat.Location = New System.Drawing.Point(70, 21)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.Size = New System.Drawing.Size(326, 20)
        Me.txtNoSurat.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(525, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No. Order"
        '
        'txtNoOrder
        '
        Me.txtNoOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNoOrder.Location = New System.Drawing.Point(593, 77)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.ReadOnly = True
        Me.txtNoOrder.Size = New System.Drawing.Size(239, 20)
        Me.txtNoOrder.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.btnCariPerusahaan)
        Me.GroupBox1.Controls.Add(Me.txtKodePerusahaan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPerusahaan)
        Me.GroupBox1.Controls.Add(Me.cmbPerusahaan)
        Me.GroupBox1.Controls.Add(Me.txtNoSurat)
        Me.GroupBox1.Controls.Add(Me.txtNoOrder)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NoSurat)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(8, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 144)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAlamat.Location = New System.Drawing.Point(70, 103)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(326, 20)
        Me.txtAlamat.TabIndex = 22
        '
        'btnCariPerusahaan
        '
        Me.btnCariPerusahaan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCariPerusahaan.Location = New System.Drawing.Point(402, 48)
        Me.btnCariPerusahaan.Name = "btnCariPerusahaan"
        Me.btnCariPerusahaan.Size = New System.Drawing.Size(45, 21)
        Me.btnCariPerusahaan.TabIndex = 21
        Me.btnCariPerusahaan.Text = "Cari"
        Me.btnCariPerusahaan.UseVisualStyleBackColor = True
        '
        'txtKodePerusahaan
        '
        Me.txtKodePerusahaan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtKodePerusahaan.Location = New System.Drawing.Point(70, 77)
        Me.txtKodePerusahaan.Name = "txtKodePerusahaan"
        Me.txtKodePerusahaan.ReadOnly = True
        Me.txtKodePerusahaan.Size = New System.Drawing.Size(76, 20)
        Me.txtKodePerusahaan.TabIndex = 21
        Me.txtKodePerusahaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(498, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Att / Penerima"
        '
        'txtPerusahaan
        '
        Me.txtPerusahaan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPerusahaan.Location = New System.Drawing.Point(146, 77)
        Me.txtPerusahaan.Name = "txtPerusahaan"
        Me.txtPerusahaan.ReadOnly = True
        Me.txtPerusahaan.Size = New System.Drawing.Size(250, 20)
        Me.txtPerusahaan.TabIndex = 12
        '
        'cmbPerusahaan
        '
        Me.cmbPerusahaan.FormattingEnabled = True
        Me.cmbPerusahaan.Location = New System.Drawing.Point(70, 49)
        Me.cmbPerusahaan.Name = "cmbPerusahaan"
        Me.cmbPerusahaan.Size = New System.Drawing.Size(326, 21)
        Me.cmbPerusahaan.TabIndex = 10
        '
        'DGBarangKirim
        '
        Me.DGBarangKirim.AllowUserToAddRows = False
        Me.DGBarangKirim.AllowUserToDeleteRows = False
        Me.DGBarangKirim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGBarangKirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarangKirim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGBarangKirim.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGBarangKirim.Location = New System.Drawing.Point(8, 339)
        Me.DGBarangKirim.Name = "DGBarangKirim"
        Me.DGBarangKirim.ReadOnly = True
        Me.DGBarangKirim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBarangKirim.Size = New System.Drawing.Size(840, 192)
        Me.DGBarangKirim.TabIndex = 11
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(8, 548)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(113, 49)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSimpan.Location = New System.Drawing.Point(8, 549)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(114, 49)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "&Save"
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txtBarang
        '
        Me.txtBarang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBarang.Location = New System.Drawing.Point(146, 17)
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.ReadOnly = True
        Me.txtBarang.Size = New System.Drawing.Size(250, 20)
        Me.txtBarang.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox2.Controls.Add(Me.btnPilih)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBarang)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(840, 52)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(653, 15)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(54, 23)
        Me.btnTambah.TabIndex = 21
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        Me.btnTambah.Visible = False
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtKodeBarang.Location = New System.Drawing.Point(70, 17)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.ReadOnly = True
        Me.txtKodeBarang.Size = New System.Drawing.Size(76, 20)
        Me.txtKodeBarang.TabIndex = 20
        Me.txtKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(402, 15)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(49, 23)
        Me.btnPilih.TabIndex = 19
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(593, 17)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(54, 20)
        Me.txtQty.TabIndex = 14
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(533, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.Label8.Location = New System.Drawing.Point(0, 687)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)

        Me.Label8.Location = New System.Drawing.Point(0, 746)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1366, 22)

<<<<<<< HEAD
=======
=======
        Me.Label8.Location = New System.Drawing.Point(0, 687)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "By I Gede Adi Putra"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'btnLogOut
        '
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnLogOut.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), System.Drawing.Image)
        Me.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.Location = New System.Drawing.Point(367, 548)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(114, 49)
        Me.btnLogOut.TabIndex = 15
        Me.btnLogOut.Text = "&Logout"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.btnLogOut.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogOut.Location = New System.Drawing.Point(368, 549)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(114, 49)
        Me.btnLogOut.TabIndex = 15
        Me.btnLogOut.Text = "&Logout"
        '>>>>>>> 0c8872419d27b663d61ea23e1dee09e2a17994f8
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Maroon
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKeluar.Location = New System.Drawing.Point(487, 548)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnKeluar.Size = New System.Drawing.Size(114, 49)
        Me.btnKeluar.TabIndex = 16
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.btnKeluar.BackColor = System.Drawing.Color.DarkRed
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKeluar.Location = New System.Drawing.Point(488, 549)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(114, 49)
        Me.btnKeluar.TabIndex = 16
        Me.btnKeluar.Text = "&Exit App"
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(656, 558)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 25)
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(657, 549)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 49)
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total Barang :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_TotalBarang
        '
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.Label_TotalBarang.AutoSize = True
        Me.Label_TotalBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalBarang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_TotalBarang.Location = New System.Drawing.Point(811, 552)
        Me.Label_TotalBarang.Name = "Label_TotalBarang"
        Me.Label_TotalBarang.Size = New System.Drawing.Size(29, 31)
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.Label_TotalBarang.BackColor = System.Drawing.Color.Transparent
        Me.Label_TotalBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalBarang.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_TotalBarang.Location = New System.Drawing.Point(803, 549)
        Me.Label_TotalBarang.Name = "Label_TotalBarang"
        Me.Label_TotalBarang.Size = New System.Drawing.Size(37, 49)

<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.Label_TotalBarang.TabIndex = 18
        Me.Label_TotalBarang.Text = "0"
        Me.Label_TotalBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnReset.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(247, 549)
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.Location = New System.Drawing.Point(248, 549)

<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnReset.Size = New System.Drawing.Size(114, 49)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "&Reset"
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.SandyBrown
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(127, 548)
<<<<<<< HEAD
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBatal.Location = New System.Drawing.Point(128, 549)

=======
<<<<<<< HEAD
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBatal.Location = New System.Drawing.Point(128, 549)

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnBatal.Size = New System.Drawing.Size(114, 49)
        Me.btnBatal.TabIndex = 20
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText

        Me.btnBatal.Text = "&Cancel"
<<<<<<< HEAD
=======
=======
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGreen
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = Global.SuratJalan.My.Resources.Resources.CV_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'loged_in
        '
        Me.loged_in.AutoSize = True
        Me.loged_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loged_in.Location = New System.Drawing.Point(94, 105)
        Me.loged_in.Name = "loged_in"
        Me.loged_in.Size = New System.Drawing.Size(27, 13)
        Me.loged_in.TabIndex = 24
        Me.loged_in.Text = "user"
        '
        'welcome_lbl
        '
        Me.welcome_lbl.AutoSize = True
        Me.welcome_lbl.Location = New System.Drawing.Point(5, 105)
        Me.welcome_lbl.Name = "welcome_lbl"
        Me.welcome_lbl.Size = New System.Drawing.Size(83, 13)
        Me.welcome_lbl.TabIndex = 23
        Me.welcome_lbl.Text = "Selamat Datang"
        '
        'btnTambahUser
        '
        Me.btnTambahUser.BackColor = System.Drawing.Color.DarkGreen
        Me.btnTambahUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahUser.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTambahUser.Location = New System.Drawing.Point(974, 356)
        Me.btnTambahUser.Name = "btnTambahUser"
        Me.btnTambahUser.Size = New System.Drawing.Size(224, 97)
        Me.btnTambahUser.TabIndex = 28
        Me.btnTambahUser.Text = "TAMBAH USER"
        Me.btnTambahUser.UseVisualStyleBackColor = False
        '
        'btnMasterSurat
        '
        Me.btnMasterSurat.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMasterSurat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasterSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterSurat.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMasterSurat.Location = New System.Drawing.Point(974, 152)
        Me.btnMasterSurat.Name = "btnMasterSurat"
        Me.btnMasterSurat.Size = New System.Drawing.Size(224, 97)
        Me.btnMasterSurat.TabIndex = 27
        Me.btnMasterSurat.Text = "MASTER SURAT"
        Me.btnMasterSurat.UseVisualStyleBackColor = False
        '
        'btnFrmDIN
        '
        Me.btnFrmDIN.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnFrmDIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFrmDIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmDIN.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFrmDIN.Location = New System.Drawing.Point(974, 253)
        Me.btnFrmDIN.Name = "btnFrmDIN"
        Me.btnFrmDIN.Size = New System.Drawing.Size(224, 97)
        Me.btnFrmDIN.TabIndex = 26
        Me.btnFrmDIN.Text = "SURAT JALAN DINTARA"
        Me.btnFrmDIN.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(854, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 47)
        Me.Label11.TabIndex = 29
        Me.Label11.Visible = False
        '
        'ig
        '
        Me.ig.BackColor = System.Drawing.SystemColors.Control
        Me.ig.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ig.Image = CType(resources.GetObject("ig.Image"), System.Drawing.Image)
        Me.ig.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.ig.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ig.LinkVisited = True
        Me.ig.Location = New System.Drawing.Point(1109, 664)
        Me.ig.Name = "ig"
        Me.ig.Size = New System.Drawing.Size(40, 40)
        Me.ig.TabIndex = 30
        Me.ig.Text = "            "
        Me.ig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fb
        '
        Me.fb.BackColor = System.Drawing.SystemColors.Control
        Me.fb.ForeColor = System.Drawing.Color.Coral
        Me.fb.Image = CType(resources.GetObject("fb.Image"), System.Drawing.Image)
        Me.fb.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.fb.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.fb.LinkVisited = True
        Me.fb.Location = New System.Drawing.Point(1155, 664)
        Me.fb.Name = "fb"
        Me.fb.Size = New System.Drawing.Size(40, 40)
        Me.fb.TabIndex = 31
        Me.fb.Text = "            "
        Me.fb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'twitt
        '
        Me.twitt.BackColor = System.Drawing.SystemColors.Control
        Me.twitt.Image = CType(resources.GetObject("twitt.Image"), System.Drawing.Image)
        Me.twitt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.twitt.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.twitt.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.twitt.LinkVisited = True
        Me.twitt.Location = New System.Drawing.Point(1201, 664)
        Me.twitt.Name = "twitt"
        Me.twitt.Size = New System.Drawing.Size(40, 40)
        Me.twitt.TabIndex = 32
        Me.twitt.Text = "        "
        Me.twitt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gplus
        '
        Me.gplus.BackColor = System.Drawing.SystemColors.Control
        Me.gplus.Image = CType(resources.GetObject("gplus.Image"), System.Drawing.Image)
        Me.gplus.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.gplus.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.gplus.LinkVisited = True
        Me.gplus.Location = New System.Drawing.Point(1247, 664)
        Me.gplus.Name = "gplus"
        Me.gplus.Size = New System.Drawing.Size(40, 40)
        Me.gplus.TabIndex = 33
        Me.gplus.Text = "            "
        '
        'gmail
        '
        Me.gmail.BackColor = System.Drawing.SystemColors.Control
        Me.gmail.Image = CType(resources.GetObject("gmail.Image"), System.Drawing.Image)
        Me.gmail.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.gmail.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.gmail.LinkVisited = True
        Me.gmail.Location = New System.Drawing.Point(1293, 664)
        Me.gmail.Name = "gmail"
        Me.gmail.Size = New System.Drawing.Size(40, 40)
        Me.gmail.TabIndex = 34
        Me.gmail.Text = "                  "
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r
        'outlook
        '
        Me.outlook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.outlook.Image = Global.SuratJalan.My.Resources.Resources.outlook
        Me.outlook.Location = New System.Drawing.Point(1334, 736)
        Me.outlook.Name = "outlook"
        Me.outlook.Size = New System.Drawing.Size(32, 32)
        Me.outlook.TabIndex = 51
        Me.outlook.TabStop = False
        '
        'gmail
        '
        Me.gmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gmail.Image = Global.SuratJalan.My.Resources.Resources.gmail
        Me.gmail.Location = New System.Drawing.Point(1296, 736)
        Me.gmail.Name = "gmail"
        Me.gmail.Size = New System.Drawing.Size(32, 32)
        Me.gmail.TabIndex = 50
        Me.gmail.TabStop = False
        '
        'maps
        '
        Me.maps.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maps.Image = Global.SuratJalan.My.Resources.Resources.placeholder__1_
        Me.maps.Location = New System.Drawing.Point(1258, 736)
        Me.maps.Name = "maps"
        Me.maps.Size = New System.Drawing.Size(32, 32)
        Me.maps.TabIndex = 49
        Me.maps.TabStop = False
        '
        'whatsapp
        '
        Me.whatsapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.whatsapp.Image = Global.SuratJalan.My.Resources.Resources.whatsapp
        Me.whatsapp.Location = New System.Drawing.Point(1220, 736)
        Me.whatsapp.Name = "whatsapp"
        Me.whatsapp.Size = New System.Drawing.Size(32, 32)
        Me.whatsapp.TabIndex = 48
        Me.whatsapp.TabStop = False
        '
        'gplus
        '
        Me.gplus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gplus.Image = Global.SuratJalan.My.Resources.Resources.google_plus
        Me.gplus.Location = New System.Drawing.Point(1144, 736)
        Me.gplus.Name = "gplus"
        Me.gplus.Size = New System.Drawing.Size(32, 32)
        Me.gplus.TabIndex = 47
        Me.gplus.TabStop = False
        '
        'twitter
        '
        Me.twitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.twitter.Image = CType(resources.GetObject("twitter.Image"), System.Drawing.Image)
        Me.twitter.Location = New System.Drawing.Point(1106, 736)
        Me.twitter.Name = "twitter"
        Me.twitter.Size = New System.Drawing.Size(32, 32)
        Me.twitter.TabIndex = 46
        Me.twitter.TabStop = False
        '
        'fb
        '
        Me.fb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fb2.ErrorImage = CType(resources.GetObject("fb.ErrorImage"), System.Drawing.Image)
        Me.fb.Image = Global.SuratJalan.My.Resources.Resources.facebook
        Me.fb2.InitialImage = CType(resources.GetObject("fb.InitialImage"), System.Drawing.Image)
        Me.fb.Location = New System.Drawing.Point(1068, 736)
        Me.fb.Name = "fb"
        Me.fb.Size = New System.Drawing.Size(32, 32)
        Me.fb.TabIndex = 45
        Me.fb.TabStop = False
        '
        'instagram
        '
        Me.instagram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.instagram.Image = Global.SuratJalan.My.Resources.Resources.instagram
        Me.instagram.Location = New System.Drawing.Point(1030, 736)
        Me.instagram.Name = "instagram"
        Me.instagram.Size = New System.Drawing.Size(32, 32)
        Me.instagram.TabIndex = 44
        Me.instagram.TabStop = False
        '
        'linkedin
        '
        Me.linkedin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkedin.Image = Global.SuratJalan.My.Resources.Resources.linkedin
        Me.linkedin.Location = New System.Drawing.Point(1182, 736)
        Me.linkedin.Name = "linkedin"
        Me.linkedin.Size = New System.Drawing.Size(32, 32)
        Me.linkedin.TabIndex = 43
        Me.linkedin.TabStop = False

<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        '
        'FrmUtamaATM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.ClientSize = New System.Drawing.Size(1333, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.gmail)
        Me.Controls.Add(Me.gplus)
        Me.Controls.Add(Me.twitt)
        Me.Controls.Add(Me.fb)
        Me.Controls.Add(Me.ig)
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.outlook)
        Me.Controls.Add(Me.gmail)
        Me.Controls.Add(Me.maps)
        Me.Controls.Add(Me.whatsapp)
        Me.Controls.Add(Me.gplus)
        Me.Controls.Add(Me.twitter)
        Me.Controls.Add(Me.fb)
        Me.Controls.Add(Me.instagram)
        Me.Controls.Add(Me.linkedin)

<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnTambahUser)
        Me.Controls.Add(Me.btnMasterSurat)
        Me.Controls.Add(Me.btnFrmDIN)
        Me.Controls.Add(Me.loged_in)
        Me.Controls.Add(Me.welcome_lbl)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label_TotalBarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGBarangKirim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUtamaATM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surat Jalan Versi 0.2.2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGBarangKirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.outlook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.whatsapp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gplus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.twitter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.instagram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkedin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents NoSurat As System.Windows.Forms.Label
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGBarangKirim As System.Windows.Forms.DataGridView
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPerusahaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label_TotalBarang As System.Windows.Forms.Label
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents txtKodePerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCariPerusahaan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents loged_in As System.Windows.Forms.Label
    Friend WithEvents welcome_lbl As System.Windows.Forms.Label
    Friend WithEvents btnTambahUser As System.Windows.Forms.Button
    Friend WithEvents btnMasterSurat As System.Windows.Forms.Button
    Friend WithEvents btnFrmDIN As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ig As System.Windows.Forms.LinkLabel
    Friend WithEvents fb As System.Windows.Forms.LinkLabel
    Friend WithEvents twitt As System.Windows.Forms.LinkLabel
    Friend WithEvents gplus As System.Windows.Forms.LinkLabel
    Friend WithEvents gmail As System.Windows.Forms.LinkLabel
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of bc499d9... r

    Friend WithEvents outlook As System.Windows.Forms.PictureBox
    Friend WithEvents gmail2 As System.Windows.Forms.PictureBox
    Friend WithEvents maps As System.Windows.Forms.PictureBox
    Friend WithEvents whatsapp As System.Windows.Forms.PictureBox
    Friend WithEvents gplus2 As System.Windows.Forms.PictureBox
    Friend WithEvents twitter As System.Windows.Forms.PictureBox
    Friend WithEvents fb2 As System.Windows.Forms.PictureBox
    Friend WithEvents instagram As System.Windows.Forms.PictureBox
    Friend WithEvents linkedin As System.Windows.Forms.PictureBox
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 9f1b10c... Merge branch 'master' of https://github.com/gedeeinstein/Surat-Jalan-PT-Dintara
>>>>>>> parent of bc499d9... r
End Class
