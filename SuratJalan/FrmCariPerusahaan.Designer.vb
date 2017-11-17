<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariPerusahaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCariPerusahaan))
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.lbl_totalperusahaan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariPerusahaan = New System.Windows.Forms.TextBox()
        Me.DGPerusahaan = New System.Windows.Forms.DataGridView()
        Me.RbPenerima = New System.Windows.Forms.RadioButton()
        Me.RbNoOrder = New System.Windows.Forms.RadioButton()
        Me.RbNama = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGPerusahaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(851, 414)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 39)
        Me.btnBatal.TabIndex = 25
        Me.btnBatal.Text = "Tutup"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnPilih
        '
        Me.btnPilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.Location = New System.Drawing.Point(770, 414)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(75, 39)
        Me.btnPilih.TabIndex = 24
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'lbl_totalperusahaan
        '
        Me.lbl_totalperusahaan.AutoSize = True
        Me.lbl_totalperusahaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalperusahaan.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbl_totalperusahaan.Location = New System.Drawing.Point(212, 430)
        Me.lbl_totalperusahaan.Name = "lbl_totalperusahaan"
        Me.lbl_totalperusahaan.Size = New System.Drawing.Size(14, 13)
        Me.lbl_totalperusahaan.TabIndex = 23
        Me.lbl_totalperusahaan.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(5, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Jumlah Data Order/Penawaran"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(944, 77)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cari Data Tujuan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCariPerusahaan
        '
        Me.txtCariPerusahaan.Location = New System.Drawing.Point(528, 30)
        Me.txtCariPerusahaan.Name = "txtCariPerusahaan"
        Me.txtCariPerusahaan.Size = New System.Drawing.Size(290, 20)
        Me.txtCariPerusahaan.TabIndex = 20
        '
        'DGPerusahaan
        '
        Me.DGPerusahaan.AllowUserToAddRows = False
        Me.DGPerusahaan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGPerusahaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPerusahaan.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGPerusahaan.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DGPerusahaan.Location = New System.Drawing.Point(8, 168)
        Me.DGPerusahaan.Name = "DGPerusahaan"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPerusahaan.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGPerusahaan.RowHeadersWidth = 10
        Me.DGPerusahaan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGPerusahaan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGPerusahaan.Size = New System.Drawing.Size(924, 231)
        Me.DGPerusahaan.TabIndex = 19
        '
        'RbPenerima
        '
        Me.RbPenerima.AutoSize = True
        Me.RbPenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPenerima.ForeColor = System.Drawing.Color.Cornsilk
        Me.RbPenerima.Location = New System.Drawing.Point(141, 31)
        Me.RbPenerima.Name = "RbPenerima"
        Me.RbPenerima.Size = New System.Drawing.Size(77, 17)
        Me.RbPenerima.TabIndex = 28
        Me.RbPenerima.TabStop = True
        Me.RbPenerima.Text = "&Penerima"
        Me.RbPenerima.UseVisualStyleBackColor = True
        '
        'RbNoOrder
        '
        Me.RbNoOrder.AutoSize = True
        Me.RbNoOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoOrder.ForeColor = System.Drawing.Color.Cornsilk
        Me.RbNoOrder.Location = New System.Drawing.Point(224, 31)
        Me.RbNoOrder.Name = "RbNoOrder"
        Me.RbNoOrder.Size = New System.Drawing.Size(76, 17)
        Me.RbNoOrder.TabIndex = 27
        Me.RbNoOrder.TabStop = True
        Me.RbNoOrder.Text = "&No Order"
        Me.RbNoOrder.UseVisualStyleBackColor = True
        '
        'RbNama
        '
        Me.RbNama.AutoSize = True
        Me.RbNama.Checked = True
        Me.RbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNama.ForeColor = System.Drawing.Color.Cornsilk
        Me.RbNama.Location = New System.Drawing.Point(7, 31)
        Me.RbNama.Name = "RbNama"
        Me.RbNama.Size = New System.Drawing.Size(128, 17)
        Me.RbNama.TabIndex = 26
        Me.RbNama.TabStop = True
        Me.RbNama.Text = "&Nama Perusahaan"
        Me.RbNama.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RbNoOrder)
        Me.GroupBox1.Controls.Add(Me.RbPenerima)
        Me.GroupBox1.Controls.Add(Me.RbNama)
        Me.GroupBox1.Controls.Add(Me.txtCariPerusahaan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Location = New System.Drawing.Point(8, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(924, 68)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(824, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmCariPerusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(944, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.lbl_totalperusahaan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGPerusahaan)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCariPerusahaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Data Customer"
        CType(Me.DGPerusahaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents lbl_totalperusahaan As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariPerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents DGPerusahaan As System.Windows.Forms.DataGridView
    Friend WithEvents RbPenerima As System.Windows.Forms.RadioButton
    Friend WithEvents RbNoOrder As System.Windows.Forms.RadioButton
    Friend WithEvents RbNama As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
