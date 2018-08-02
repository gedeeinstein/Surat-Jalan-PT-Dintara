<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKategori))
        Me.DGKategori = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamaKategori = New System.Windows.Forms.TextBox()
        Me.txtKodeKategori = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSatuanKode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGKategori
        '
        Me.DGKategori.AllowUserToAddRows = False
        Me.DGKategori.AllowUserToDeleteRows = False
        Me.DGKategori.BackgroundColor = System.Drawing.Color.White
        Me.DGKategori.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGKategori.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGKategori.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGKategori.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGKategori.Location = New System.Drawing.Point(12, 191)
        Me.DGKategori.Name = "DGKategori"
        Me.DGKategori.RowHeadersWidth = 5
        Me.DGKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGKategori.Size = New System.Drawing.Size(328, 224)
        Me.DGKategori.TabIndex = 0
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.SuratJalan.My.Resources.Resources.icons8_add_24
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 421)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 38)
        Me.btnTambah.TabIndex = 1
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.SuratJalan.My.Resources.Resources.edit_button_20
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(93, 421)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btnEdit.Size = New System.Drawing.Size(75, 38)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SuratJalan.My.Resources.Resources.icons8_Close_Window_24
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(265, 421)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = Global.SuratJalan.My.Resources.Resources.remove_button_20
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(184, 421)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnHapus.Size = New System.Drawing.Size(75, 38)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.txtNamaKategori)
        Me.GroupBox1.Controls.Add(Me.txtKodeKategori)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblSatuanKode)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 94)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit/Tambah Kategori"
        '
        'txtNamaKategori
        '
        Me.txtNamaKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtNamaKategori.Location = New System.Drawing.Point(89, 55)
        Me.txtNamaKategori.Name = "txtNamaKategori"
        Me.txtNamaKategori.Size = New System.Drawing.Size(228, 20)
        Me.txtNamaKategori.TabIndex = 3
        '
        'txtKodeKategori
        '
        Me.txtKodeKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeKategori.Location = New System.Drawing.Point(89, 29)
        Me.txtKodeKategori.Name = "txtKodeKategori"
        Me.txtKodeKategori.Size = New System.Drawing.Size(228, 20)
        Me.txtKodeKategori.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Kategori"
        '
        'lblSatuanKode
        '
        Me.lblSatuanKode.AutoSize = True
        Me.lblSatuanKode.Location = New System.Drawing.Point(6, 32)
        Me.lblSatuanKode.Name = "lblSatuanKode"
        Me.lblSatuanKode.Size = New System.Drawing.Size(74, 13)
        Me.lblSatuanKode.TabIndex = 0
        Me.lblSatuanKode.Text = "Kode Kategori"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 79)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "KATEGORI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(352, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DGKategori)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kategori Barang"
        CType(Me.DGKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Public WithEvents DGKategori As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaKategori As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSatuanKode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
