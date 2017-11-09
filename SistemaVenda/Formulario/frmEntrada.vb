Imports System.Security.Cryptography
Imports System.Text

Public Class frmEntrada
    Dim si As New sistemaintegradovdEntities()
    Dim codigo As String

    Private Shared Function Encrypt(value As String) As String
        Using md5 As New MD5CryptoServiceProvider()
            Dim utf8 As New UTF8Encoding()
            Dim data As Byte() = md5.ComputeHash(utf8.GetBytes(value))
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Private Sub Entrada()
        Try
            codigo = Encrypt(txtSenha.Text)
            Dim procura As Object = (From d In si.usuario_tb Where d.NomeUsuario.Equals(txtUsuario.Text) AndAlso d.SenhaUsuario.Equals(codigo) Select d).Count()
            If procura = 1 Then
                Dim pegaut As Object = (From d In si.usuario_tb Select d).FirstOrDefault()
                Dim idTipoUsuario As Integer = pegaut.idTipoUsuario.ToString()
                Dim leva As Object = si.tipousuario_tb.Where(Function(d) d.idTipoUsuario.Equals(idTipoUsuario)).FirstOrDefault()

                Dim abrir As New frmPrincipal()
                abrir.idUsuario = pegaut.idUsuario.ToString()
                abrir.Label2.Text = pegaut.NomeUsuario.ToString()
                abrir.Label3.Text = leva.NomeTipoUsuario.ToString()
                abrir.ShowDialog()
                txtSenha.Clear()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Usuario ou Senha Incorreta!", "Error Tente Novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtSenha.Clear()
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Entrada()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class