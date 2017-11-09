<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorioVenda
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.produtos_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.venda_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.produtos_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venda_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DadosProdutos"
        ReportDataSource1.Value = Me.produtos_tbBindingSource
        ReportDataSource2.Name = "DadosVenda"
        ReportDataSource2.Value = Me.venda_tbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVenda.reportVenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(23, 78)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(772, 502)
        Me.ReportViewer1.TabIndex = 0
        '
        'produtos_tbBindingSource
        '
        Me.produtos_tbBindingSource.DataMember = "detalhes_produto"
        Me.produtos_tbBindingSource.DataSource = GetType(SistemaVenda.produtos_tb)
        '
        'venda_tbBindingSource
        '
        Me.venda_tbBindingSource.DataSource = GetType(SistemaVenda.venda_tb)
        '
        'frmRelatorioVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 606)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmRelatorioVenda"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "frmRelatorioVenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.produtos_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venda_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents produtos_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents venda_tbBindingSource As System.Windows.Forms.BindingSource
End Class
