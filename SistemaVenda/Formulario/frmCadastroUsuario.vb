Imports System.Security.Cryptography
Imports System.Text

Public Class frmCadastroUsuario
    Dim si As New sistemaintegradovdEntities()


    Dim idTipoUsuario As Integer
    Private Sub IdTipoUsuarioTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdTipoUsuarioTextBox.SelectedIndexChanged
        Try
            idTipoUsuario = Integer.Parse(IdTipoUsuarioTextBox.SelectedValue.ToString())
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmCadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipousuariotbBindingSource.DataSource = si.tipousuario_tb.ToList()
        Usuario_tbBindingSource.DataSource = si.usuario_tb.ToList()
    End Sub
    Private Sub CadastrarUsuario()
        Try
            Dim sv As New usuario_tb()
            Dim verifica As Object = si.usuario_tb.Where(Function(d) d.NomeUsuario = NomeUsuarioTextBox.Text).Count()
            If verifica = 1 Then
                MetroFramework.MetroMessageBox.Show(Me, "Nome do usuario Ja existente, Por favor Escolha Outro Nome!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                sv.DataNascimento = DataNascimentoDateTimePicker.Text
                sv.idTipoUsuario = idTipoUsuario
                sv.NomeCompleto = NomeCompletoTextBox.Text
                sv.NomeUsuario = NomeUsuarioTextBox.Text
                sv.SenhaUsuario = Encrypt(SenhaUsuarioTextBox.Text)
                si.usuario_tb.Add(sv)
                si.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Usuario Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Usuario_tbBindingSource.DataSource = si.usuario_tb.ToList()
            End If

        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CadastrarUsuario()
    End Sub

    Private Shared Function Encrypt(value As String) As String
        Using md5 As New MD5CryptoServiceProvider()
            Dim utf8 As New UTF8Encoding()
            Dim data As Byte() = md5.ComputeHash(utf8.GetBytes(value))
            Return Convert.ToBase64String(data)
        End Using
    End Function
    Dim codigo As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim ab As New frmTipoUsuario()
            ab.ShowDialog()
            TipousuariotbBindingSource.DataSource = si.tipousuario_tb.ToList()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Usuario_tbBindingSource.AddNew()
        NomeCompletoTextBox.Clear()
        NomeUsuarioTextBox.Clear()
        SenhaUsuarioTextBox.Clear()

    End Sub
End Class