<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCariBarang))
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_totalbarang = New System.Windows.Forms.Label()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGBarang
        '
        Me.DGBarang.AllowUserToAddRows = False
        Me.DGBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGBarang.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DGBarang.Location = New System.Drawing.Point(12, 116)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBarang.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGBarang.RowHeadersWidth = 10
        Me.DGBarang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBarang.Size = New System.Drawing.Size(1159, 239)
        Me.DGBarang.TabIndex = 12
        '
        'txtNoOrder
        '
        Me.txtNoOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNoOrder.Location = New System.Drawing.Point(973, 86)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.ReadOnly = True
        Me.txtNoOrder.Size = New System.Drawing.Size(198, 20)
        Me.txtNoOrder.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(904, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "No Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(9, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Jumlah Pesanan Barang"
        '
        'lbl_totalbarang
        '
        Me.lbl_totalbarang.AutoSize = True
        Me.lbl_totalbarang.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_totalbarang.Location = New System.Drawing.Point(149, 386)
        Me.lbl_totalbarang.Name = "lbl_totalbarang"
        Me.lbl_totalbarang.Size = New System.Drawing.Size(23, 13)
        Me.lbl_totalbarang.TabIndex = 16
        Me.lbl_totalbarang.Text = "null"
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.Snow
        Me.btnPilih.FlatAppearance.BorderSize = 0
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Location = New System.Drawing.Point(986, 372)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(85, 40)
        Me.btnPilih.TabIndex = 17
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Snow
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Location = New System.Drawing.Point(1086, 372)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(85, 40)
        Me.btnBatal.TabIndex = 18
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1183, 78)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Pilih Barang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1183, 424)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.lbl_totalbarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoOrder)
        Me.Controls.Add(Me.DGBarang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCariBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Data Barang "
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalbarang As System.Windows.Forms.Label
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
