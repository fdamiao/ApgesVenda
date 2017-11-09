Public Class frmRelatorioVenda
    Dim si As New sistemaintegradovdEntities()
    Public Property idVenda As Integer

    Private Sub frmRelatorioVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        produtos_tbBindingSource.DataSource = si.detalhes_produto.Where(Function(d) d.idVenda = idVenda).ToList()
        venda_tbBindingSource.DataSource = si.venda_tb.Where(Function(d) d.idVenda = idVenda).ToList()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class