Public Class frmRequizitarProd
    Dim si As New sistemaintegradovdEntities()
    Dim idProduto As Integer
    Dim valorProduto As Decimal
    Dim Referenca As String



    Dim valr As Decimal = 0
    Public re As Decimal = 0
    Private valpro As Decimal = 0
    Private idpdidos As Integer


    Private Sub frmRequizitarProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        autoCompleteProdutoNome()
        autoCompleteFornecedor()

    End Sub
    Private Sub autoCompleteProdutoNome()
        Dim cl As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        si = New sistemaintegradovdEntities()
        Dim pro As Object = (From d In si.produtos_tb).ToList()

        For Each item As Object In pro
            cl.Add(item.Produto_Nome.ToString())
            txtPesquisaProduto.AutoCompleteCustomSource = cl
        Next

    End Sub
    Private Sub autoCompleteFornecedor()
        Dim cl As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        si = New sistemaintegradovdEntities()
        Dim pro As Object = (From d In si.fonecedor_tb).ToList()

        For Each item As Object In pro
            cl.Add(item.NomeFonecedor.ToString())
            TextBox1.AutoCompleteCustomSource = cl
        Next

    End Sub
    Dim ValorCompras As Decimal
    Private Sub txtPesquisaProduto_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProduto.TextChanged
        Try

            If (txtPesquisaProduto.Text.Equals("")) Then
                Return
            Else

                Dim nclient As Object = (From d In si.produtos_tb Where d.Produto_Nome.Equals(txtPesquisaProduto.Text)).Count()
                If nclient <> 0 Then
                    Dim clien As Object = (From d In si.produtos_tb Where d.Produto_Nome.Equals(txtPesquisaProduto.Text)).FirstOrDefault()
                    idProduto = clien.idProdutos.ToString()

                    valorProduto = Decimal.Parse(clien.Produto_Val_Venda.ToString())
                    ValorCompras = Decimal.Parse(clien.Produto_Val_Comp.ToString())
                    Label7.Text = clien.Produto_Nome.ToString()
                    Label12.Text = clien.Produto_Stoque.ToString()
                    Label6.Text = clien.Produto_Val_Venda.ToString()
                    txtValorVenda.Text = valorProduto
                    txtValorCompra.Text = ValorCompras
                End If
            End If
        Catch ex As Exception
            Return
        End Try

    End Sub
    Dim Totals As Decimal
    Private Sub txtQuantidade_ValueChanged(sender As Object, e As EventArgs)
        Try
            Totals = txtQuantidade.Text * valorProduto
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub calcura()
        Try
            Try
                valr = 0
                For i As Integer = 0 To DataGridView1.RowCount - 1

                    valr += Convert.ToDecimal(DataGridView1(4, i).Value)
                Next

                txtTotal.Text = valr

            Catch es As Exception
                MessageBox.Show(es.Message)
            End Try


        Catch ex As Exception

        End Try
    End Sub

    Private Function novopedido() As entradaproduto_tb
        Try
            If Not TextBox2.Text.Equals("") Then
                Dim rt As New Random()
                Dim ped As New entradaproduto_tb()
                Dim countidp = si.entradaproduto_tb.Count()
                idpdidos = +countidp + 1
                ped.Comentario = TextBox2.Text
                ped.DataEntrada = DateAndTime.Now
                ped.DataRecebimento = DateAndTime.Now
                ped.idFornecedor = idFornecedor
                ped.ValorRequizicao = txtTotal.Text

                si.entradaproduto_tb.Add(ped)
                si.SaveChanges()
                idpdidos = ped.idEntradaProduto
                '   guardar id do pedido
                Return ped
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Por Favor insira algum comentario! \n Obrigado!", "Comentario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Problemas Contacte o Administrador Por Favor! :" & ex.Message, "Contacte ao Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Nothing
    End Function

 
    Public Sub adicionaritem()
        Try

            Dim idpdido = novopedido()
            For i As Integer = 0 To DataGridView1.RowCount - 1


                Dim idvenda As Integer = Convert.ToInt16(idpdido.idEntradaProduto)
                Dim quant As Integer = Convert.ToInt16(DataGridView1(3, i).Value)

                If quant <> 0 Then
                    Dim nome As [String] = Convert.ToString(DataGridView1(1, i).Value)

                    Dim prexo As [Decimal] = Convert.ToDecimal(DataGridView1(2, i).Value)
                    Dim idpro As Integer = Convert.ToInt16(DataGridView1(5, i).Value)

                    Dim total As [Decimal] = Convert.ToDecimal(DataGridView1(4, i).Value)

                    Dim ValorCompra As Decimal = Convert.ToDecimal(DataGridView1(6, i).Value)
                    Dim ValorVendasf As Decimal = Convert.ToDecimal(DataGridView1(7, i).Value)
                    Dim dte As New detalhes_entradaprodu()
                    dte.idProduto = idpro
                    dte.Produto_Nome = nome
                    dte.ValorVenda = ValorVendasf
                    dte.idEntradaProduto = idvenda
                    dte.Produto_Total = total
                    dte.Produto_Preco = prexo
                    dte.Produto_Quantidade = quant
                    dte.ValorCompra = ValorCompra
                    si.detalhes_entradaprodu.Add(dte)
                    si.SaveChanges()


                    destruirstok(idpro, quant, ValorVendasf, ValorCompra)
                End If
            Next
            MetroFramework.MetroMessageBox.Show(Me, "Actualizacao dos Produtos Efectuada Com Sucesso!", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch es As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Problemas, por favor Contacte ao Administrador: !" & es.Message, "Contacte ao Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub destruirstok(idproduto As Integer, saldo As Integer, novo As Decimal, comp As Decimal)

        Try
            Dim emp = si.produtos_tb.Where(Function(d) d.idProdutos = idproduto).FirstOrDefault()
            Dim idCateg As Integer = emp.idCategoria.ToString
            Dim leva = si.categoria_tb.Where(Function(d) d.idCategoria = idCateg).FirstOrDefault()


            Dim py = si.produtos_tb.Where(Function(p) p.idProdutos = idproduto).FirstOrDefault()
            py.Produto_Val_Comp = comp
            py.Produto_Val_Venda = novo
            py.Produto_Stoque += saldo
            si.SaveChanges()


        Catch ex As Exception

            MetroFramework.MetroMessageBox.Show(Me, "Nao foi possivel atualizar o estoke", "Stock ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try


    End Sub


    Dim idFornecedor As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try

            If (TextBox1.Text.Equals("")) Then
                Return
            Else

                Dim nclient As Object = (From d In si.fonecedor_tb Where d.NomeFonecedor.Equals(TextBox1.Text)).Count()
                If nclient <> 0 Then
                    Dim clien As Object = (From d In si.fonecedor_tb Where d.NomeFonecedor.Equals(TextBox1.Text)).FirstOrDefault()
                    idFornecedor = clien.idFonecedor_tb.ToString()

                    lblContacto.Text = clien.Contacto.ToString()
                    lbNomeFornecedor.Text = clien.NomeFonecedor.ToString()
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim abr As New frmForncedor()
            abr.ShowDialog()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.Delete Then
            calcura()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            adicionaritem()
            DataGridView1.Rows.Clear()
            calcura()
            DataGridView1.Refresh()
            txtTotal.Text = ""
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub txtQuantidade_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQuantidade.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try

                Dim valorTotal As Decimal = Totals
                Dim Quanty As Integer = txtQuantidade.Text
                Dim Designacao As String = txtPesquisaProduto.Text
                Dim idProdRow = idProduto
                Dim ValorVendass As Decimal = Decimal.Parse(txtValorVenda.Text)
                Dim ValorCOmpra As Decimal = Decimal.Parse(txtValorCompra.Text)
                valorTotal = Quanty * ValorCOmpra
                DataGridView1.Rows.Add()
                Dim row As Integer = 0
                row = DataGridView1.Rows.Count - 2
                DataGridView1("Preco", row).Value = (ValorCOmpra).ToString()
                DataGridView1("Produtos", row).Value = (Designacao).ToString()
                DataGridView1("Quantidade", row).Value = (Quanty).ToString()
                DataGridView1("Total", row).Value = (valorTotal).ToString()
                DataGridView1("idProd", row).Value = (idProdRow).ToString()
                DataGridView1("ValorCompra", row).Value = (ValorCOmpra).ToString()
                DataGridView1("ValorVenda", row).Value = (ValorVendass).ToString()
                txtValorVenda.Text = ""
                txtQuantidade.Text = ""
                txtPesquisaProduto.Text = ""
                txtBarcode.Text = ""
                txtValorCompra.Text = ""
                txtValorVenda.Text = ""
                Me.ActiveControl = txtPesquisaProduto
                calcura()
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub
End Class