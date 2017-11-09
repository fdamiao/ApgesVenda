Public Class frmCategoria
    Dim si As New sistemaintegradovdEntities()

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        Categoria_tbBindingSource.DataSource = si.categoria_tb.ToList()
    End Sub

    Private Sub CadastrarCategoria()
        Dim ct As New categoria_tb()
        ct.DescricaoCategoria = DescricaoCategoriaTextBox.Text
        ct.NomeCategoria = NomeCategoriaTextBox.Text
        ct.ControleStock = ComboBox1.Text.ToString()
        si.categoria_tb.Add(ct)
        si.SaveChanges()
        MetroFramework.MetroMessageBox.Show(Me, "Categoria Cadastrada com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Categoria_tbBindingSource.DataSource = si.categoria_tb.ToList()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        CadastrarCategoria()
    End Sub
End Class