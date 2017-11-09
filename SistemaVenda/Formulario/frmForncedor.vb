Public Class frmForncedor
    Dim si As New sistemaintegradovdEntities()
    Private Sub Listar()
        Fonecedor_tbBindingSource.DataSource = si.fonecedor_tb.ToList()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Fonecedor_tbBindingSource.AddNew()
    End Sub
    Private Sub Cadastrar()
        Try
            Dim fn As New fonecedor_tb()
            fn.Contacto = ContactoTextBox.Text
            fn.Data_Fornecedor = DateAndTime.Now.Date
            fn.Email = EmailTextBox.Text
            fn.FonecedorCod = FonecedorCodTextBox.Text
            fn.NomeFonecedor = NomeFonecedorTextBox.Text
            fn.Nuit = NuitTextBox.Text
            si.fonecedor_tb.Add(fn)
            si.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Fornecedor Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Listar()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub frmForncedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cadastrar()

    End Sub
End Class