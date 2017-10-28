<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterSurat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterSurat))
        Me.DGMasterSurat = New System.Windows.Forms.DataGridView()
        CType(Me.DGMasterSurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGMasterSurat
        '
        Me.DGMasterSurat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMasterSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMasterSurat.Location = New System.Drawing.Point(2, 13)
        Me.DGMasterSurat.Name = "DGMasterSurat"
        Me.DGMasterSurat.Size = New System.Drawing.Size(789, 318)
        Me.DGMasterSurat.TabIndex = 0
        '
        'FrmMasterSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 517)
        Me.Controls.Add(Me.DGMasterSurat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMasterSurat"
        Me.Text = "Master Surat"
        CType(Me.DGMasterSurat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGMasterSurat As System.Windows.Forms.DataGridView
End Class
