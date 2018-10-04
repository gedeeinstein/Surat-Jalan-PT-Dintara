<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarangUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarangUpdate))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GB11 = New System.Windows.Forms.GroupBox()
        Me.btnMerk = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cariBrand = New System.Windows.Forms.Button()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.cariKategori = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDepth = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtHPP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMerk = New System.Windows.Forms.TextBox()
        Me.txtKodeMerk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtKodeGol = New System.Windows.Forms.TextBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_info = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Cyan
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(544, 551)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEdit.Size = New System.Drawing.Size(77, 42)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Update"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(113, 25)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(159, 20)
        Me.txtKodeBarang.TabIndex = 1
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(113, 49)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(350, 20)
        Me.txtNamaBarang.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Barang"
        '
        'DGBarang
        '
        Me.DGBarang.AllowUserToAddRows = False
        Me.DGBarang.AllowUserToDeleteRows = False
        Me.DGBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(12, 264)
        Me.DGBarang.Name = "DGBarang"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBarang.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGBarang.RowHeadersWidth = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DGBarang.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBarang.Size = New System.Drawing.Size(1327, 269)
        Me.DGBarang.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(729, 551)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Button1.Size = New System.Drawing.Size(77, 42)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Batal"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Magenta
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.MintCream
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(636, 551)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(77, 42)
        Me.btnTambah.TabIndex = 38
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'GB11
        '
        Me.GB11.BackColor = System.Drawing.Color.CadetBlue
        Me.GB11.Controls.Add(Me.btnMerk)
        Me.GB11.Controls.Add(Me.Label16)
        Me.GB11.Controls.Add(Me.cariBrand)
        Me.GB11.Controls.Add(Me.txtKet)
        Me.GB11.Controls.Add(Me.cariKategori)
        Me.GB11.Controls.Add(Me.Label15)
        Me.GB11.Controls.Add(Me.txtHeight)
        Me.GB11.Controls.Add(Me.txtHargaJual)
        Me.GB11.Controls.Add(Me.Label14)
        Me.GB11.Controls.Add(Me.Label10)
        Me.GB11.Controls.Add(Me.txtDepth)
        Me.GB11.Controls.Add(Me.txtStok)
        Me.GB11.Controls.Add(Me.Label13)
        Me.GB11.Controls.Add(Me.Label9)
        Me.GB11.Controls.Add(Me.txtWidth)
        Me.GB11.Controls.Add(Me.txtHPP)
        Me.GB11.Controls.Add(Me.Label8)
        Me.GB11.Controls.Add(Me.Label7)
        Me.GB11.Controls.Add(Me.txtMerk)
        Me.GB11.Controls.Add(Me.txtKodeMerk)
        Me.GB11.Controls.Add(Me.Label3)
        Me.GB11.Controls.Add(Me.txtKategori)
        Me.GB11.Controls.Add(Me.txtKodeGol)
        Me.GB11.Controls.Add(Me.txtNamaBarang)
        Me.GB11.Controls.Add(Me.txtKodeBarang)
        Me.GB11.Controls.Add(Me.Label2)
        Me.GB11.Controls.Add(Me.Label1)
        Me.GB11.Cursor = System.Windows.Forms.Cursors.Default
        Me.GB11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GB11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB11.ForeColor = System.Drawing.Color.GhostWhite
        Me.GB11.Location = New System.Drawing.Point(12, 41)
        Me.GB11.Name = "GB11"
        Me.GB11.Size = New System.Drawing.Size(1327, 217)
        Me.GB11.TabIndex = 37
        Me.GB11.TabStop = False
        '
        'btnMerk
        '
        Me.btnMerk.BackColor = System.Drawing.Color.White
        Me.btnMerk.FlatAppearance.BorderSize = 0
        Me.btnMerk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMerk.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.btnMerk.Image = CType(resources.GetObject("btnMerk.Image"), System.Drawing.Image)
        Me.btnMerk.Location = New System.Drawing.Point(414, 100)
        Me.btnMerk.Name = "btnMerk"
        Me.btnMerk.Size = New System.Drawing.Size(49, 20)
        Me.btnMerk.TabIndex = 48
        Me.btnMerk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMerk.UseMnemonic = False
        Me.btnMerk.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label16.Location = New System.Drawing.Point(479, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 17)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Ket"
        '
        'cariBrand
        '
        Me.cariBrand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cariBrand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cariBrand.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cariBrand.FlatAppearance.BorderSize = 0
        Me.cariBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cariBrand.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.cariBrand.Image = CType(resources.GetObject("cariBrand.Image"), System.Drawing.Image)
        Me.cariBrand.Location = New System.Drawing.Point(276, 103)
        Me.cariBrand.Name = "cariBrand"
        Me.cariBrand.Size = New System.Drawing.Size(21, 0)
        Me.cariBrand.TabIndex = 40
        Me.cariBrand.UseMnemonic = False
        Me.cariBrand.UseVisualStyleBackColor = False
        '
        'txtKet
        '
        Me.txtKet.Location = New System.Drawing.Point(532, 100)
        Me.txtKet.Multiline = True
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(185, 98)
        Me.txtKet.TabIndex = 46
        '
        'cariKategori
        '
        Me.cariKategori.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cariKategori.FlatAppearance.BorderSize = 0
        Me.cariKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cariKategori.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.cariKategori.Image = CType(resources.GetObject("cariKategori.Image"), System.Drawing.Image)
        Me.cariKategori.Location = New System.Drawing.Point(414, 73)
        Me.cariKategori.Name = "cariKategori"
        Me.cariKategori.Size = New System.Drawing.Size(49, 20)
        Me.cariKategori.TabIndex = 39
        Me.cariKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cariKategori.UseMnemonic = False
        Me.cariKategori.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label15.Location = New System.Drawing.Point(479, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Height"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(532, 74)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(185, 20)
        Me.txtHeight.TabIndex = 44
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(113, 152)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(159, 20)
        Me.txtHargaJual.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label14.Location = New System.Drawing.Point(479, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 17)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Depth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label10.Location = New System.Drawing.Point(16, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Harga Jual"
        '
        'txtDepth
        '
        Me.txtDepth.Location = New System.Drawing.Point(532, 49)
        Me.txtDepth.Name = "txtDepth"
        Me.txtDepth.Size = New System.Drawing.Size(185, 20)
        Me.txtDepth.TabIndex = 42
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(113, 178)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(159, 20)
        Me.txtStok.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label13.Location = New System.Drawing.Point(479, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 17)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Width"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label9.Location = New System.Drawing.Point(16, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Stok"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(532, 25)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(185, 20)
        Me.txtWidth.TabIndex = 40
        '
        'txtHPP
        '
        Me.txtHPP.Location = New System.Drawing.Point(113, 126)
        Me.txtHPP.Name = "txtHPP"
        Me.txtHPP.Size = New System.Drawing.Size(159, 20)
        Me.txtHPP.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label8.Location = New System.Drawing.Point(16, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "HPP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label7.Location = New System.Drawing.Point(16, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Merk/Brand"
        '
        'txtMerk
        '
        Me.txtMerk.Location = New System.Drawing.Point(202, 100)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(206, 20)
        Me.txtMerk.TabIndex = 11
        '
        'txtKodeMerk
        '
        Me.txtKodeMerk.Location = New System.Drawing.Point(113, 100)
        Me.txtKodeMerk.Name = "txtKodeMerk"
        Me.txtKodeMerk.Size = New System.Drawing.Size(83, 20)
        Me.txtKodeMerk.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label3.Location = New System.Drawing.Point(16, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kategori"
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(202, 74)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(206, 20)
        Me.txtKategori.TabIndex = 6
        '
        'txtKodeGol
        '
        Me.txtKodeGol.Location = New System.Drawing.Point(113, 74)
        Me.txtKodeGol.Name = "txtKodeGol"
        Me.txtKodeGol.Size = New System.Drawing.Size(83, 20)
        Me.txtKodeGol.TabIndex = 5
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(12, 551)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(408, 26)
        Me.txtCari.TabIndex = 19
        Me.txtCari.WordWrap = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label11.Location = New System.Drawing.Point(9, 580)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cari Barang"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 7.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label12.Location = New System.Drawing.Point(74, 580)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(199, 14)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Ketikan Nama barang Untuk Melakukan Pencarian"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(134, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(99, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(380, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(426, 551)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 25)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'label_info
        '
        Me.label_info.AutoSize = True
        Me.label_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_info.ForeColor = System.Drawing.Color.LawnGreen
        Me.label_info.Location = New System.Drawing.Point(12, 9)
        Me.label_info.Name = "label_info"
        Me.label_info.Size = New System.Drawing.Size(0, 29)
        Me.label_info.TabIndex = 39
        Me.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(288, 583)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 40
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(288, 606)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 41
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(288, 629)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 42
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'FrmBarangUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1352, 653)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.label_info)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GB11)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.txtCari)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBarangUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Kategori"
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB11.ResumeLayout(False)
        Me.GB11.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents GB11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeGol As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMerk As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeMerk As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHPP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDepth As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtKet As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cariKategori As System.Windows.Forms.Button
    Friend WithEvents cariBrand As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMerk As System.Windows.Forms.Button
    Friend WithEvents label_info As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
End Class
