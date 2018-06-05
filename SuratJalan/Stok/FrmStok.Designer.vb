<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStok
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
        Me.ListBarang = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListBarang
        '
        Me.ListBarang.CheckBoxes = True
        Me.ListBarang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.ListBarang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBarang.FullRowSelect = True
        Me.ListBarang.GridLines = True
        Me.ListBarang.HoverSelection = True
        Me.ListBarang.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListBarang.Location = New System.Drawing.Point(0, 258)
        Me.ListBarang.Name = "ListBarang"
        Me.ListBarang.Size = New System.Drawing.Size(1305, 289)
        Me.ListBarang.TabIndex = 0
        Me.ListBarang.UseCompatibleStateImageBehavior = False
        Me.ListBarang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "KD BRG"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "KD GOL"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "KD MERK"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "NAMA"
        Me.ColumnHeader4.Width = 321
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "KET"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "HPP"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "HPP AWAL"
        Me.ColumnHeader7.Width = 79
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "QTY"
        Me.ColumnHeader8.Width = 44
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "QTY AWAL"
        Me.ColumnHeader9.Width = 76
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "HARGA JUAL"
        Me.ColumnHeader10.Width = 98
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "STOK MIN"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SERVIS"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "W"
        Me.ColumnHeader13.Width = 25
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "D"
        Me.ColumnHeader14.Width = 25
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "H"
        Me.ColumnHeader15.Width = 25
        '
        'FrmStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1305, 547)
        Me.Controls.Add(Me.ListBarang)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Barang Masuk"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBarang As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
End Class
