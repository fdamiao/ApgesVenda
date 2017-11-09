Public Class frmTipoUsuario
    Dim si As New sistemaintegradovdEntities()
    Private Sub Cadastrar()
        Try
            Dim sv As New tipousuario_tb()
            Dim procura As Object = si.tipousuario_tb.Where(Function(d) d.NomeTipoUsuario = NomeTipoUsuarioTextBox.Text).Count()
            If procura = 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "Tipo de usuario ja existente!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                sv.NivelPermissao = NivelPermissaoTextBox.Text
                sv.NomeTipoUsuario = NomeTipoUsuarioTextBox.Text
                si.tipousuario_tb.Add(sv)
                si.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tipousuario_tbBindingSource.DataSource = si.tipousuario_tb.ToList()
            End If

           
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub frmTipoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeTipoUsuarioTextBox.SelectedIndex = 0
        Tipousuario_tbBindingSource.DataSource = si.tipousuario_tb.ToList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cadastrar()
    End Sub
End Class