<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_totalbarang = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "No Order"
        '
        'txtNoOrder
        '
        Me.txtNoOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtNoOrder.Location = New System.Drawing.Point(77, 12)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.ReadOnly = True
        Me.txtNoOrder.Size = New System.Drawing.Size(159, 20)
        Me.txtNoOrder.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(444, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "null"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(220, 435)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Jumlah Barang Yang Akan / Telah  Terkirim "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_totalbarang
        '
        Me.lbl_totalbarang.AutoSize = True
        Me.lbl_totalbarang.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalbarang.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalbarang.Location = New System.Drawing.Point(149, 435)
        Me.lbl_totalbarang.Name = "lbl_totalbarang"
        Me.lbl_totalbarang.Size = New System.Drawing.Size(23, 13)
        Me.lbl_totalbarang.TabIndex = 23
        Me.lbl_totalbarang.Text = "null"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Jumlah Pesanan Barang"
        '
        'DGBarang
        '
        Me.DGBarang.AllowUserToAddRows = False
        Me.DGBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGBarang.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DGBarang.Location = New System.Drawing.Point(9, 38)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBarang.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGBarang.RowHeadersWidth = 10
        Me.DGBarang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBarang.Size = New System.Drawing.Size(1159, 269)
        Me.DGBarang.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(263, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Cari Barang"
        '
        'txtCari
        '
        Me.txtCari.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCari.Location = New System.Drawing.Point(331, 12)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.ReadOnly = True
        Me.txtCari.Size = New System.Drawing.Size(159, 20)
        Me.txtCari.TabIndex = 27
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Location = New System.Drawing.Point(1083, 408)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(85, 40)
        Me.btnBatal.TabIndex = 29
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 457)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_totalbarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoOrder)
        Me.Name = "FrmBarang"
        Me.Text = "Form B arang"
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalbarang As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
