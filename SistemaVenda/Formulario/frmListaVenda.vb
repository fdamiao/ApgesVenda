Public Class frmListaVenda
    Dim si As New sistemaintegradovdEntities()
    Dim idVenda As Integer

    Private Sub Venda_tbDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Venda_tbDataGridView.CellClick
        Try
            idVenda = Integer.Parse(Venda_tbDataGridView.CurrentRow.Cells(0).Value.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        Try
            Dim abr As New frmRelatorioVenda()
            If idVenda <> 0 Then
                abr.idVenda = idVenda
                abr.ShowDialog()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmListaVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Venda_tbBindingSource.DataSource = si.venda_tb.ToList()
    End Sub
End Class