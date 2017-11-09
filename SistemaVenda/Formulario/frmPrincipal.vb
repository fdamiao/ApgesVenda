Imports System.IO

Public Class frmPrincipal
    Dim si As New sistemaintegradovdEntities()
    Public Property idUsuario As Integer
    Public Function ConvertBinaryToImage(data As Byte()) As Image
        Using ms As New MemoryStream(data)
            Return Image.FromStream(ms)
        End Using
    End Function
    Private Sub ProcuraEmpresa()
        Try
            Dim procura As Object = (From d In si.empresa_tb Select d).Count()
            If procura = 1 Then

                Dim prouc As Object = (From d In si.empresa_tb).FirstOrDefault()
                PictureBox1.Image = ConvertBinaryToImage(prouc.LogoTipo)
                NomeEmpresaLabel1.Text = prouc.NomeEmpresa.ToString()
                Label1.Text = prouc.LocalizacaoEmpresa.ToString()
                EmailLabel1.Text = prouc.EmailEmpresa.ToString()
                ContactoLabel1.Text = prouc.ContactoEmpresa.ToString()
                NuitEmpresaLabel1.Text = prouc.NuitEmpresa.ToString()
            Else
                Dim abrir As New frmCadastroEmpresa()
                abrir.ShowDialog()

            End If
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProcuraEmpresa()
        buscarTotais()
    End Sub

    Private Sub buscarTotais()
        Try
            Dim buscaTotalProduto As Object = si.produtos_tb.Count()
            Label9.Text = buscaTotalProduto.ToString()
            Dim buscaTotalUsuario As Object = si.usuario_tb.Count()
            Label11.Text = buscaTotalUsuario.ToString()
            Dim buscaTotalVendas As Object = si.venda_tb.Where(Function(d) d.Data = DateAndTime.Now).Count()
            Label6.Text = buscaTotalVendas.ToString()
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim abr As New frmVenda()
            abr.ToolStripStatusLabel1.Text = Label2.Text
            abr.idUsuario = idUsuario
            abr.ShowDialog()
            buscarTotais()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim abr As New frmProdutos()
            abr.ShowDialog()
            buscarTotais()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim abr As New frmRequizitarProd()
            abr.ShowDialog()
        Catch ex As Exception
            buscarTotais()
            Return
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim abr As New frmListaVenda()
            abr.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class