<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTambahUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTambahUser))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Exit_Label = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtNamaLengkap = New System.Windows.Forms.TextBox()
        Me.GBTombol = New System.Windows.Forms.GroupBox()
        Me.GBDataKaryawan = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_level = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Tgl_Update = New System.Windows.Forms.DateTimePicker()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtID_User = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_User = New System.Windows.Forms.DataGridView()
        Me.cmbCari = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.GBPencarian = New System.Windows.Forms.GroupBox()
        Me.GBTombol.SuspendLayout()
        Me.GBDataKaryawan.SuspendLayout()
        CType(Me.DG_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPencarian.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SeaGreen
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1220, 96)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Data User"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Exit_Label
        '
        Me.Exit_Label.AutoSize = True
        Me.Exit_Label.BackColor = System.Drawing.Color.Red
        Me.Exit_Label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exit_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Exit_Label.Location = New System.Drawing.Point(1188, 0)
        Me.Exit_Label.Name = "Exit_Label"
        Me.Exit_Label.Padding = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Exit_Label.Size = New System.Drawing.Size(32, 27)
        Me.Exit_Label.TabIndex = 26
        Me.Exit_Label.Text = "X"
        Me.Exit_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.Control
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Image = Global.SuratJalan.My.Resources.Resources.close_20
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBatal.Location = New System.Drawing.Point(227, 19)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnBatal.Size = New System.Drawing.Size(88, 40)
        Me.btnBatal.TabIndex = 20
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.Control
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Image = Global.SuratJalan.My.Resources.Resources.remove_button_20
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHapus.Location = New System.Drawing.Point(338, 19)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(88, 40)
        Me.btnHapus.TabIndex = 18
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.SuratJalan.My.Resources.Resources.edit_button_20
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(117, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEdit.Size = New System.Drawing.Size(88, 40)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Control
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = Global.SuratJalan.My.Resources.Resources.save__save_as_icon_icon__2_
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSimpan.Location = New System.Drawing.Point(6, 19)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(88, 40)
        Me.btnSimpan.TabIndex = 19
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txtNamaLengkap
        '
        Me.txtNamaLengkap.Location = New System.Drawing.Point(163, 115)
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.Size = New System.Drawing.Size(230, 20)
        Me.txtNamaLengkap.TabIndex = 3
        '
        'GBTombol
        '
        Me.GBTombol.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GBTombol.Controls.Add(Me.btnBatal)
        Me.GBTombol.Controls.Add(Me.btnSimpan)
        Me.GBTombol.Controls.Add(Me.btnHapus)
        Me.GBTombol.Controls.Add(Me.btnEdit)
        Me.GBTombol.Location = New System.Drawing.Point(7, 329)
        Me.GBTombol.Name = "GBTombol"
        Me.GBTombol.Size = New System.Drawing.Size(432, 72)
        Me.GBTombol.TabIndex = 28
        Me.GBTombol.TabStop = False
        '
        'GBDataKaryawan
        '
        Me.GBDataKaryawan.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GBDataKaryawan.Controls.Add(Me.TextBox1)
        Me.GBDataKaryawan.Controls.Add(Me.Label5)
        Me.GBDataKaryawan.Controls.Add(Me.cmb_level)
        Me.GBDataKaryawan.Controls.Add(Me.Label9)
        Me.GBDataKaryawan.Controls.Add(Me.txtPassword)
        Me.GBDataKaryawan.Controls.Add(Me.Tgl_Update)
        Me.GBDataKaryawan.Controls.Add(Me.txtNamaLengkap)
        Me.GBDataKaryawan.Controls.Add(Me.txtUsername)
        Me.GBDataKaryawan.Controls.Add(Me.txtID_User)
        Me.GBDataKaryawan.Controls.Add(Me.Label4)
        Me.GBDataKaryawan.Controls.Add(Me.Label3)
        Me.GBDataKaryawan.Controls.Add(Me.Label2)
        Me.GBDataKaryawan.Controls.Add(Me.Label1)
        Me.GBDataKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBDataKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDataKaryawan.ForeColor = System.Drawing.Color.White
        Me.GBDataKaryawan.Location = New System.Drawing.Point(6, 99)
        Me.GBDataKaryawan.Name = "GBDataKaryawan"
        Me.GBDataKaryawan.Size = New System.Drawing.Size(432, 224)
        Me.GBDataKaryawan.TabIndex = 27
        Me.GBDataKaryawan.TabStop = False
        Me.GBDataKaryawan.Text = "Data Karyawan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 194)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 20)
        Me.TextBox1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Level User"
        '
        'cmb_level
        '
        Me.cmb_level.DropDownHeight = 150
        Me.cmb_level.FormattingEnabled = True
        Me.cmb_level.IntegralHeight = False
        Me.cmb_level.ItemHeight = 13
        Me.cmb_level.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmb_level.Location = New System.Drawing.Point(163, 167)
        Me.cmb_level.Name = "cmb_level"
        Me.cmb_level.Size = New System.Drawing.Size(230, 21)
        Me.cmb_level.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nama Lengkap"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(163, 88)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(230, 20)
        Me.txtPassword.TabIndex = 10
        '
        'Tgl_Update
        '
        Me.Tgl_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tgl_Update.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Tgl_Update.Location = New System.Drawing.Point(163, 141)
        Me.Tgl_Update.Name = "Tgl_Update"
        Me.Tgl_Update.Size = New System.Drawing.Size(230, 20)
        Me.Tgl_Update.TabIndex = 9
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(163, 59)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(230, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtID_User
        '
        Me.txtID_User.Location = New System.Drawing.Point(163, 30)
        Me.txtID_User.Name = "txtID_User"
        Me.txtID_User.ReadOnly = True
        Me.txtID_User.Size = New System.Drawing.Size(230, 20)
        Me.txtID_User.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID User"
        '
        'DG_User
        '
        Me.DG_User.AllowUserToAddRows = False
        Me.DG_User.AllowUserToDeleteRows = False
        Me.DG_User.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_User.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_User.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_User.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_User.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DG_User.Location = New System.Drawing.Point(445, 190)
        Me.DG_User.Name = "DG_User"
        Me.DG_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_User.Size = New System.Drawing.Size(766, 211)
        Me.DG_User.TabIndex = 30
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
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(271, 34)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(489, 20)
        Me.txtCari.TabIndex = 9
        '
        'GBPencarian
        '
        Me.GBPencarian.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GBPencarian.Controls.Add(Me.txtCari)
        Me.GBPencarian.Controls.Add(Me.Label8)
        Me.GBPencarian.Controls.Add(Me.cmbCari)
        Me.GBPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPencarian.ForeColor = System.Drawing.Color.White
        Me.GBPencarian.Location = New System.Drawing.Point(445, 99)
        Me.GBPencarian.Name = "GBPencarian"
        Me.GBPencarian.Size = New System.Drawing.Size(766, 79)
        Me.GBPencarian.TabIndex = 29
        Me.GBPencarian.TabStop = False
        Me.GBPencarian.Text = "Cari Data"
        '
        'FrmTambahUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1220, 435)
        Me.Controls.Add(Me.GBPencarian)
        Me.Controls.Add(Me.DG_User)
        Me.Controls.Add(Me.GBTombol)
        Me.Controls.Add(Me.GBDataKaryawan)
        Me.Controls.Add(Me.Exit_Label)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTambahUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah User Aplikasi"
        Me.GBTombol.ResumeLayout(False)
        Me.GBDataKaryawan.ResumeLayout(False)
        Me.GBDataKaryawan.PerformLayout()
        CType(Me.DG_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPencarian.ResumeLayout(False)
        Me.GBPencarian.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Exit_Label As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtNamaLengkap As System.Windows.Forms.TextBox
    Friend WithEvents GBTombol As System.Windows.Forms.GroupBox
    Friend WithEvents GBDataKaryawan As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtID_User As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tgl_Update As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_level As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DG_User As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCari As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents GBPencarian As System.Windows.Forms.GroupBox
End Class
