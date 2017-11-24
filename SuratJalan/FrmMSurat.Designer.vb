<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMSurat
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBDataKaryawan.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GBDataKaryawan.Location = New System.Drawing.Point(15, 55)
        Me.GBDataKaryawan.Name = "GBDataKaryawan"
        Me.GBDataKaryawan.Size = New System.Drawing.Size(432, 259)
        Me.GBDataKaryawan.TabIndex = 32
        Me.GBDataKaryawan.TabStop = False
        Me.GBDataKaryawan.Text = "Data Surat"
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
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(12, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(433, 55)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Cari data berdasarkan kriteria yang diinginkan." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Setelah data ditampilkan klik 2 " & _
            "kali pada data yang diinginkan." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data hanya bisa di edit adalah data yang di loa" & _
            "d pada field di atas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.UseCompatibleTextRendering = True
        '
        'FrmMSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 446)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GBDataKaryawan)
        Me.Name = "FrmMSurat"
        Me.Text = "FrmMSurat"
        Me.GBDataKaryawan.ResumeLayout(False)
        Me.GBDataKaryawan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBDataKaryawan As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
