Imports System.IO

Public Class frmCadastroEmpresa
    Dim si As New sistemaintegradovdEntities()

    Private Sub Cadastrar()
        Try
            If Label1.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Insira imagem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ep As New empresa_tb()
                ep.ContactoEmpresa = ContactoTextBox.Text
                ep.EmailEmpresa = EmailTextBox.Text
                ep.NomeEmpresa = NomeEmpresaTextBox.Text
                ep.NuitEmpresa = NuitEmpresaTextBox.Text
                ep.LogoTipo = ConvertImageToBinary(PictureBox1.Image)
                ep.FileName = Label1.Text
                ep.LocalizacaoEmpresa = LocalizacaoEmpresaTextBox.Text
                si.empresa_tb.Add(ep)
                si.SaveChanges()
                MetroFramework.MetroMessageBox.Show(Me, "Empresa Cadastrada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function ConvertImageToBinary(img As Image) As Byte()
        Using ms As New MemoryStream()


            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
            'Dim mas As New MemoryStream()
            'img.Save(mas, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Return mas.ToArray()

        End Using

    End Function

    Dim filename As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastrar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim opena As New OpenFileDialog()
            opena.Filter = "JPG|*.jpg|PNG|*.png"
            opena.ValidateNames = True
            opena.Multiselect = False

            If opena.ShowDialog = Windows.Forms.DialogResult.OK Then
                filename = opena.FileName
                Label1.Text = filename
                PictureBox1.Image = Image.FromFile(filename)
            End If

        Catch ex As Exception
            Return
        End Try
    End Sub
End Class