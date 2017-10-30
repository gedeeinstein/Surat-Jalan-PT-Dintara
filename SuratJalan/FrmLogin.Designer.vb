<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BtnConfig = New System.Windows.Forms.Button()
        Me.lbl_constatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_saveuserpass = New System.Windows.Forms.CheckBox()
        Me.cb_saveuser = New System.Windows.Forms.CheckBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbATM = New System.Windows.Forms.RadioButton()
        Me.rbDIN = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnConfig
        '
        Me.BtnConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnConfig.FlatAppearance.BorderSize = 0
        Me.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfig.Location = New System.Drawing.Point(222, 258)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(95, 23)
        Me.BtnConfig.TabIndex = 23
        Me.BtnConfig.Text = "Config"
        Me.BtnConfig.UseVisualStyleBackColor = False
        '
        'lbl_constatus
        '
        Me.lbl_constatus.AutoSize = True
        Me.lbl_constatus.ForeColor = System.Drawing.Color.Red
        Me.lbl_constatus.Location = New System.Drawing.Point(96, 295)
        Me.lbl_constatus.Name = "lbl_constatus"
        Me.lbl_constatus.Size = New System.Drawing.Size(25, 13)
        Me.lbl_constatus.TabIndex = 22
        Me.lbl_constatus.Text = "Null"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Status Koneksi :"
        '
        'cb_saveuserpass
        '
        Me.cb_saveuserpass.AutoSize = True
        Me.cb_saveuserpass.Enabled = False
        Me.cb_saveuserpass.Location = New System.Drawing.Point(12, 206)
        Me.cb_saveuserpass.Name = "cb_saveuserpass"
        Me.cb_saveuserpass.Size = New System.Drawing.Size(110, 17)
        Me.cb_saveuserpass.TabIndex = 19
        Me.cb_saveuserpass.Text = "Simpan Password"
        Me.cb_saveuserpass.UseVisualStyleBackColor = True
        '
        'cb_saveuser
        '
        Me.cb_saveuser.AutoSize = True
        Me.cb_saveuser.Location = New System.Drawing.Point(12, 185)
        Me.cb_saveuser.Name = "cb_saveuser"
        Me.cb_saveuser.Size = New System.Drawing.Size(112, 17)
        Me.cb_saveuser.TabIndex = 18
        Me.cb_saveuser.Text = "Simpan Username"
        Me.cb_saveuser.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(113, 258)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(103, 23)
        Me.BtnCancel.TabIndex = 22
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BtnReset.FlatAppearance.BorderSize = 0
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Location = New System.Drawing.Point(12, 258)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(95, 23)
        Me.BtnReset.TabIndex = 21
        Me.BtnReset.Text = "Reconnect"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Location = New System.Drawing.Point(12, 229)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(305, 23)
        Me.BtnLogin.TabIndex = 20
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(88, 130)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(229, 20)
        Me.txtpassword.TabIndex = 15
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(88, 78)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(229, 20)
        Me.txtusername.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Username :"
        '
        'rbATM
        '
        Me.rbATM.AutoSize = True
        Me.rbATM.Location = New System.Drawing.Point(126, 162)
        Me.rbATM.Name = "rbATM"
        Me.rbATM.Size = New System.Drawing.Size(48, 17)
        Me.rbATM.TabIndex = 16
        Me.rbATM.Text = "ATM"
        Me.rbATM.UseVisualStyleBackColor = True
        '
        'rbDIN
        '
        Me.rbDIN.AutoSize = True
        Me.rbDIN.Checked = True
        Me.rbDIN.Location = New System.Drawing.Point(207, 162)
        Me.rbDIN.Name = "rbDIN"
        Me.rbDIN.Size = New System.Drawing.Size(44, 17)
        Me.rbDIN.TabIndex = 17
        Me.rbDIN.TabStop = True
        Me.rbDIN.Text = "DIN"
        Me.rbDIN.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaGreen
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 62)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "LOGIN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNama.Location = New System.Drawing.Point(88, 104)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(229, 20)
        Me.txtNama.TabIndex = 28
        Me.txtNama.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(329, 315)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbDIN)
        Me.Controls.Add(Me.rbATM)
        Me.Controls.Add(Me.BtnConfig)
        Me.Controls.Add(Me.lbl_constatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_saveuserpass)
        Me.Controls.Add(Me.cb_saveuser)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnConfig As System.Windows.Forms.Button
    Friend WithEvents lbl_constatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_saveuserpass As System.Windows.Forms.CheckBox
    Friend WithEvents cb_saveuser As System.Windows.Forms.CheckBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbATM As System.Windows.Forms.RadioButton
    Friend WithEvents rbDIN As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox

End Class
