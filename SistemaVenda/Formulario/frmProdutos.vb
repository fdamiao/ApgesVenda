Public Class frmProdutos
    Dim si As New sistemaintegradovdEntities()

    Private Sub Listar()
        Produtos_tbBindingSource.DataSource = si.produtos_tb.ToList()
        CategoriatbBindingSource.DataSource = si.categoria_tb.ToList()
    End Sub

    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cadastrar()
    End Sub

    Private Sub Limpar()
        TextBox2.Clear()
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Cadastrar()
        Try
            Dim pd As New produtos_tb()
            pd.idCategoria = idCategoria
            pd.Produto_Nome = TextBox2.Text
            pd.Produto_Cod_Barra = TextBox1.Text
            pd.Produto_Referencia = TextBox3.Text
            pd.Produto_Stoque = Integer.Parse(NumericUpDown1.Text)
            pd.Produto_Unidade = ComboBox1.Text
            pd.Produto_Val_Comp = Decimal.Parse(TextBox4.Text)
            pd.Produto_Val_Venda = Decimal.Parse(TextBox5.Text)
            si.produtos_tb.Add(pd)
            si.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Produto Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Listar()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Dim idCategoria As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim abr As New frmCategoria()
            abr.ShowDialog()
            Listar()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            idCategoria = Integer.Parse(ComboBox2.SelectedValue.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class
