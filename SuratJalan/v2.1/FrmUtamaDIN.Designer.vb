﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtamaDIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loged_in = New System.Windows.Forms.Label()
        Me.welcome_lbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnCariPerusahaan = New System.Windows.Forms.Button()
        Me.txtKodePerusahaan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPerusahaan = New System.Windows.Forms.TextBox()
        Me.cmbPerusahaan = New System.Windows.Forms.ComboBox()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPelanggan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NoSurat = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtQtyBeliCust = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStokGudang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.txtMerkBarang = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtKodeLokasi = New System.Windows.Forms.TextBox()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGBarangKirim = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGBarangKirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(956, 93)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Surat Jalan PT. Dapur Inspirasi Nusantara"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkMagenta
        Me.PictureBox1.Image = Global.SuratJalan.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'loged_in
        '
        Me.loged_in.AutoSize = True
        Me.loged_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loged_in.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.loged_in.Location = New System.Drawing.Point(94, 103)
        Me.loged_in.Name = "loged_in"
        Me.loged_in.Size = New System.Drawing.Size(27, 13)
        Me.loged_in.TabIndex = 24
        Me.loged_in.Text = "user"
        '
        'welcome_lbl
        '
        Me.welcome_lbl.AutoSize = True
        Me.welcome_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.welcome_lbl.Location = New System.Drawing.Point(5, 103)
        Me.welcome_lbl.Name = "welcome_lbl"
        Me.welcome_lbl.Size = New System.Drawing.Size(83, 13)
        Me.welcome_lbl.TabIndex = 23
        Me.welcome_lbl.Text = "Selamat Datang"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(901, 158)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAlamat.Location = New System.Drawing.Point(70, 103)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(326, 49)
        Me.txtAlamat.TabIndex = 6
        '
        'btnCariPerusahaan
        '
        Me.btnCariPerusahaan.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnCariPerusahaan.FlatAppearance.BorderSize = 0
        Me.btnCariPerusahaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariPerusahaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariPerusahaan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCariPerusahaan.Location = New System.Drawing.Point(402, 49)
        Me.btnCariPerusahaan.Name = "btnCariPerusahaan"
        Me.btnCariPerusahaan.Size = New System.Drawing.Size(45, 20)
        Me.btnCariPerusahaan.TabIndex = 3
        Me.btnCariPerusahaan.Text = "Cari"
        Me.btnCariPerusahaan.UseVisualStyleBackColor = False
        '
        'txtKodePerusahaan
        '
        Me.txtKodePerusahaan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtKodePerusahaan.Location = New System.Drawing.Point(70, 77)
        Me.txtKodePerusahaan.Name = "txtKodePerusahaan"
        Me.txtKodePerusahaan.ReadOnly = True
        Me.txtKodePerusahaan.Size = New System.Drawing.Size(76, 20)
        Me.txtKodePerusahaan.TabIndex = 4
        Me.txtKodePerusahaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(546, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Att"
        '
        'txtPerusahaan
        '
        Me.txtPerusahaan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPerusahaan.Location = New System.Drawing.Point(146, 77)
        Me.txtPerusahaan.Name = "txtPerusahaan"
        Me.txtPerusahaan.ReadOnly = True
        Me.txtPerusahaan.Size = New System.Drawing.Size(250, 20)
        Me.txtPerusahaan.TabIndex = 5
        '
        'cmbPerusahaan
        '
        Me.cmbPerusahaan.FormattingEnabled = True
        Me.cmbPerusahaan.Location = New System.Drawing.Point(70, 49)
        Me.cmbPerusahaan.Name = "cmbPerusahaan"
        Me.cmbPerusahaan.Size = New System.Drawing.Size(326, 21)
        Me.cmbPerusahaan.TabIndex = 2
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Enabled = False
        Me.txtNoSurat.Location = New System.Drawing.Point(70, 21)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.Size = New System.Drawing.Size(326, 20)
        Me.txtNoSurat.TabIndex = 1
        '
        'txtNoOrder
        '
        Me.txtNoOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNoOrder.Location = New System.Drawing.Point(575, 103)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.ReadOnly = True
        Me.txtNoOrder.Size = New System.Drawing.Size(304, 20)
        Me.txtNoOrder.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kepada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(507, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No. Order"
        '
        'txtPelanggan
        '
        Me.txtPelanggan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPelanggan.Enabled = False
        Me.txtPelanggan.Location = New System.Drawing.Point(575, 47)
        Me.txtPelanggan.MaxLength = 75
        Me.txtPelanggan.Name = "txtPelanggan"
        Me.txtPelanggan.ReadOnly = True
        Me.txtPelanggan.Size = New System.Drawing.Size(304, 20)
        Me.txtPelanggan.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(516, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'NoSurat
        '
        Me.NoSurat.AutoSize = True
        Me.NoSurat.BackColor = System.Drawing.SystemColors.Control
        Me.NoSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoSurat.ForeColor = System.Drawing.Color.Black
        Me.NoSurat.Location = New System.Drawing.Point(3, 24)
        Me.NoSurat.Name = "NoSurat"
        Me.NoSurat.Size = New System.Drawing.Size(61, 13)
        Me.NoSurat.TabIndex = 6
        Me.NoSurat.Text = "No. Surat"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(575, 74)
        Me.DateTimePicker1.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(304, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(537, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Telp"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(575, 21)
        Me.TextBox1.MaxLength = 75
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(304, 20)
        Me.TextBox1.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.txtQtyBeliCust)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtStokGudang)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblStok)
        Me.GroupBox2.Controls.Add(Me.txtMerkBarang)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtKodeLokasi)
        Me.GroupBox2.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox2.Controls.Add(Me.btnPilih)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBarang)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(901, 78)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'txtQtyBeliCust
        '
        Me.txtQtyBeliCust.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtQtyBeliCust.Location = New System.Drawing.Point(593, 47)
        Me.txtQtyBeliCust.Name = "txtQtyBeliCust"
        Me.txtQtyBeliCust.ReadOnly = True
        Me.txtQtyBeliCust.Size = New System.Drawing.Size(77, 20)
        Me.txtQtyBeliCust.TabIndex = 65
        Me.txtQtyBeliCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(526, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Qty Order"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStokGudang
        '
        Me.txtStokGudang.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtStokGudang.Location = New System.Drawing.Point(70, 47)
        Me.txtStokGudang.Name = "txtStokGudang"
        Me.txtStokGudang.ReadOnly = True
        Me.txtStokGudang.Size = New System.Drawing.Size(76, 20)
        Me.txtStokGudang.TabIndex = 63
        Me.txtStokGudang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(174, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Merk"
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStok.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStok.Location = New System.Drawing.Point(8, 50)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(56, 13)
        Me.lblStok.TabIndex = 60
        Me.lblStok.Text = "Stok Brg"
        Me.lblStok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMerkBarang
        '
        Me.txtMerkBarang.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMerkBarang.Location = New System.Drawing.Point(215, 47)
        Me.txtMerkBarang.Name = "txtMerkBarang"
        Me.txtMerkBarang.ReadOnly = True
        Me.txtMerkBarang.Size = New System.Drawing.Size(181, 20)
        Me.txtMerkBarang.TabIndex = 61
        Me.txtMerkBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambah.Location = New System.Drawing.Point(815, 20)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(64, 20)
        Me.btnTambah.TabIndex = 24
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(521, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Kode Area"
        '
        'txtKodeLokasi
        '
        Me.txtKodeLokasi.Location = New System.Drawing.Point(593, 21)
        Me.txtKodeLokasi.Name = "txtKodeLokasi"
        Me.txtKodeLokasi.Size = New System.Drawing.Size(77, 20)
        Me.txtKodeLokasi.TabIndex = 21
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtKodeBarang.Location = New System.Drawing.Point(70, 21)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.ReadOnly = True
        Me.txtKodeBarang.Size = New System.Drawing.Size(76, 20)
        Me.txtKodeBarang.TabIndex = 20
        Me.txtKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnPilih.FlatAppearance.BorderSize = 0
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPilih.Location = New System.Drawing.Point(402, 21)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(45, 20)
        Me.btnPilih.TabIndex = 19
        Me.btnPilih.TabStop = False
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtQty.Location = New System.Drawing.Point(737, 21)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(72, 20)
        Me.txtQty.TabIndex = 14
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(674, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Qty Kirim"
        '
        'txtBarang
        '
        Me.txtBarang.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBarang.Location = New System.Drawing.Point(146, 21)
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.ReadOnly = True
        Me.txtBarang.Size = New System.Drawing.Size(250, 20)
        Me.txtBarang.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(17, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Barang"
        '
        'DGBarangKirim
        '
        Me.DGBarangKirim.AllowUserToAddRows = False
        Me.DGBarangKirim.AllowUserToDeleteRows = False
        Me.DGBarangKirim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGBarangKirim.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBarangKirim.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGBarangKirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBarangKirim.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGBarangKirim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGBarangKirim.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGBarangKirim.Location = New System.Drawing.Point(8, 367)
        Me.DGBarangKirim.Name = "DGBarangKirim"
        Me.DGBarangKirim.ReadOnly = True
        Me.DGBarangKirim.RowHeadersWidth = 5
        Me.DGBarangKirim.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGBarangKirim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBarangKirim.Size = New System.Drawing.Size(901, 275)
        Me.DGBarangKirim.TabIndex = 27
        '
        'FrmUtamaDIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 707)
        Me.Controls.Add(Me.DGBarangKirim)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.loged_in)
        Me.Controls.Add(Me.welcome_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUtamaDIN"
        Me.Text = "FrmUtamaDIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGBarangKirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents loged_in As System.Windows.Forms.Label
    Friend WithEvents welcome_lbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnCariPerusahaan As System.Windows.Forms.Button
    Friend WithEvents txtKodePerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents cmbPerusahaan As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NoSurat As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtQtyBeliCust As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtStokGudang As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Public WithEvents txtMerkBarang As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKodeLokasi As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DGBarangKirim As System.Windows.Forms.DataGridView
End Class