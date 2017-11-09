Imports System.IO

Public Class frmVenda
    Dim si As New sistemaintegradovdEntities()

    Dim valr As Decimal = 0
    Public re As Decimal = 0
    Private valpro As Decimal = 0
    Private idpdidos As Integer





    Private Sub autoCompleteProdutoNome()
        Dim cl As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        si = New sistemaintegradovdEntities()
        Dim pro As Object = (From d In si.produtos_tb).ToList()

        For Each item As Object In pro
            cl.Add(item.Produto_Nome.ToString())
            txtDesignacao.AutoCompleteCustomSource = cl
        Next

    End Sub
    Private Sub autoCompleteProdutoRef()
        Dim cl As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        si = New sistemaintegradovdEntities()
        Dim pro As Object = (From d In si.produtos_tb).ToList()

        For Each item As Object In pro
            cl.Add(item.Produto_Referencia.ToString())
            txtRefer.AutoCompleteCustomSource = cl
        Next

    End Sub




    Public Sub prexototal(ByVal valor As String, ByVal pvendass As Decimal)
        Try
            If Not txtTotal.Text.Equals("") Then
                re = Decimal.Parse(valor) * Decimal.Parse(txtTotal.Text)

            Else
                MsgBox("informe o  preco unitario")
            End If
        Catch ex As Exception
            MsgBox("informe o produto")
        End Try
    End Sub


    Private Sub calcura()
        Try
            Try
                valr = 0
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    '* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                    valr += Convert.ToDecimal(DataGridView1(4, i).Value)
                Next

                Dim subtotal As Double = Double.Parse(valr.ToString())
                'calcular o total
                Dim total As Double = 1.17 * Double.Parse(valr.ToString())
                'calcular o iva
                Dim iva As Double = 0.17 * Double.Parse(valr.ToString())
                If ckIva.Checked = True Then
                    txtSubTotal.Text = subtotal.ToString()
                    txtIva.Text = iva.ToString()
                    txtTotakValor.Text = Convert.ToString(total)
                Else
                    txtSubTotal.Text = subtotal.ToString()
                    txtIva.Text = "0"

                    txtTotakValor.Text = Convert.ToString(subtotal)
                End If
            Catch es As Exception
                MessageBox.Show(es.Message)
            End Try


        Catch ex As Exception

        End Try
    End Sub
    Public Property idUsuario As Integer
    Private Function novopedido() As venda_tb
        Try
            If Not TextBox1.Text.Equals("") Then
                Dim rt As New Random()
                Dim ped As New venda_tb()
                Dim countidp = si.venda_tb.Count()

                ped.NPedido = +countidp + 1
                ped.Data_Venda = DateTime.Now
                ped.idUsuario = idUsuario
                ped.Subtotal_Venda = Decimal.Parse(txtSubTotal.Text)
                ped.Total_Venda = Decimal.Parse(txtTotakValor.Text)
                ped.Iva_Venda = Decimal.Parse(txtIva.Text)
                ped.Comentario = TextBox1.Text
                ped.FormaPagamento = cmbFormaPagamento.Text
                ped.Data = DateAndTime.Now

                si.venda_tb.Add(ped)
                si.SaveChanges()
                idpdidos = ped.idVenda
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

            'buscar o pedido feito recentimente
            Dim idpdido = novopedido()
            For i As Integer = 0 To dataGridView1.RowCount - 1


                Dim idvenda As Integer = Convert.ToInt16(idpdido.idVenda)
                Dim quant As Integer = Convert.ToInt16(DataGridView1(3, i).Value)

                If quant <> 0 Then
                    Dim refe = DataGridView1(0, i).Value.ToString()
                    Dim nome As [String] = Convert.ToString(DataGridView1(1, i).Value)

                    Dim prexo As [Decimal] = Convert.ToDecimal(DataGridView1(2, i).Value)
                    Dim idpro As Integer = Convert.ToInt16(DataGridView1(5, i).Value)

                    Dim total As [Decimal] = Convert.ToDecimal(DataGridView1(4, i).Value)


                    Dim dte As New detalhes_produto()
                    dte.idProd = idpro
                    dte.ProdutoNome = nome
                    dte.idVenda = idvenda
                    dte.Pro_Tt = total
                    dte.Prod_Preco = prexo
                    dte.Prod_Qty = quant
                    dte.Prod_Referencia = refe
                    si.detalhes_produto.Add(dte)
                    si.SaveChanges()

			
                    destruirstok(idpro, quant)
                End If
            Next
            MetroFramework.MetroMessageBox.Show(Me, "Venda Efectuada Com Sucesso, apos a mensagem imprima a factura!", "Venda ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '  Dim fr As New frm_facturas()
            ' fr.IdsPedido = idpdido.id_Pedidos
            'imprimirreceita();

            ' imprimir(Idventasgo );
            ' imprimir(Idventasgo);

            '  fr.Show()
            Dim fr As New frmRelatorioVenda()
            fr.idVenda = idpdido.idVenda
            fr.ShowDialog()
        Catch es As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Problemas, por favor Contacte ao Administrador: !" & es.Message, "Contacte ao Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

























    Dim idProduto As Integer
    Dim valorProduto As Decimal
    Dim Referenca As String
    Private Sub txtDesignacao_TextChanged(sender As Object, e As EventArgs) Handles txtDesignacao.TextChanged
        Try

            If (txtDesignacao.Text.Equals("")) Then
                Return
            Else

                Dim nclient As Object = (From d In si.produtos_tb Where d.Produto_Nome.Equals(txtDesignacao.Text)).Count()
                If nclient <> 0 Then
                    Dim clien = (From d In si.produtos_tb Where d.Produto_Nome.Equals(txtDesignacao.Text)).FirstOrDefault()
                    idProduto = clien.idProdutos.ToString()

                    valorProduto = Decimal.Parse(clien.Produto_Val_Venda.ToString())
                    txtTotal.Text = valorProduto
                    Referenca = clien.Produto_Referencia.ToString()
                    txtRefer.Text = Referenca

                    Label7.Text = clien.Produto_Nome.ToString()
                    Label11.Text = clien.Produto_Referencia.ToString()
                    Label12.Text = clien.Produto_Stoque.ToString()
                    Label6.Text = clien.Produto_Val_Venda.ToString()

                End If
            End If
        Catch ex As Exception
            Return
        End Try

    End Sub

    Public Function ConvertBinaryToImage(data As Byte()) As Image
        Using ms As New MemoryStream(data)
            Return Image.FromStream(ms)
        End Using
    End Function
    Private Sub ProcuraEmpresa()
        Try

            Dim prouc As Object = (From d In si.empresa_tb).FirstOrDefault()
            PictureBox7.Image = ConvertBinaryToImage(prouc.LogoTipo)
            NomeEmpresaLabel1.Text = prouc.NomeEmpresa.ToString()
            ToolStripStatusLabel2.Text = prouc.LocalizacaoEmpresa.ToString()
            EmailLabel1.Text = prouc.EmailEmpresa.ToString()
            ContactoLabel1.Text = prouc.ContactoEmpresa.ToString()
            NuitEmpresaLabel1.Text = prouc.NuitEmpresa.ToString()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub frmVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoCompleteProdutoNome()
        autoCompleteProdutoRef()
        cmbFormaPagamento.SelectedIndex = 0
        ProcuraEmpresa()
    End Sub




    Private Sub txtRefer_TextChanged(sender As Object, e As EventArgs) Handles txtRefer.TextChanged
        Try

            If (txtRefer.Text.Equals("")) Then
                Return
            Else

                Dim nclient As Object = (From d In si.produtos_tb Where d.Produto_Referencia.Equals(txtRefer.Text)).Count()
                If nclient <> 0 Then
                    Dim clien As Object = (From d In si.produtos_tb Where d.Produto_Referencia.Equals(txtRefer.Text)).FirstOrDefault()
                    idProduto = clien.idProdutos.ToString()
                    txtDesignacao.Text = clien.Produto_Nome.ToString()
                    valorProduto = Decimal.Parse(clien.Produto_Val_Venda.ToString())
                    txtTotal.Text = valorProduto
                    Referenca = clien.Produto_Referencia.ToString()
                    txtRefer.Text = Referenca

                    Label7.Text = clien.Produto_Nome.ToString()
                    Label11.Text = clien.Produto_Referencia.ToString()
                    Label12.Text = clien.Produto_Stoque.ToString()
                    Label6.Text = clien.Produto_Val_Venda.ToString()
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.Delete Then
            calcura()
        ElseIf e.KeyCode = Keys.Enter Then
            Try
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    Dim quant As Integer = Convert.ToInt16(DataGridView1(3, i).Value)
                    If quant <> 0 Then
                        Dim prexo As [Decimal] = Convert.ToDecimal(DataGridView1(2, i).Value)
                        DataGridView1(4, i).Value = quant * prexo
                    End If
                Next
                calcura()
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            adicionaritem()
            DataGridView1.Rows.Clear()
            calcura()
            DataGridView1.Refresh()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub ckIva_CheckedChanged(sender As Object, e As EventArgs) Handles ckIva.CheckedChanged
        If ckIva.Checked = True Then
            calcura()
        Else
            txtIva.Text = "0"
            txtTotakValor.Text = txtSubTotal.Text
        End If
    End Sub




    Public Sub destruirstok(idproduto As Integer, saldo As Integer)

        Try
            Dim emp = si.produtos_tb.Where(Function(d) d.idProdutos = idproduto).FirstOrDefault()
            Dim idCateg As Integer = emp.idCategoria.ToString
            Dim leva = si.categoria_tb.Where(Function(d) d.idCategoria = idCateg).FirstOrDefault()

            If leva.ControleStock.Trim().Equals("SIM") Then
                Dim py = si.produtos_tb.Where(Function(p) p.idProdutos = idproduto).FirstOrDefault()
                py.Produto_Stoque -= saldo
                si.SaveChanges()
            ElseIf leva.ControleStock.Equals("Nao") Then
            End If
        Catch ex As Exception

            MetroFramework.MetroMessageBox.Show(Me, "Nao foi possivel atualizar o estoke", "Stock ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try


    End Sub
    Private Sub InserirNagrid()
        Try
            Dim Refrencia As String = txtRefer.Text
            Dim valorTotal As Decimal = Decimal.Parse(txtTotal.Text)
            Dim Quanty As Integer = txtQty.Text
            Dim Designacao As String = txtDesignacao.Text
            Dim idProdRow = idProduto


            DataGridView1.Rows.Add()
            Dim row As Integer = 0
            row = DataGridView1.Rows.Count - 2
            DataGridView1("Referencia", row).Value = (Refrencia).ToString()
            DataGridView1("Desginacao", row).Value = (Designacao).ToString()
            DataGridView1("Quantidade", row).Value = (Quanty).ToString()
            DataGridView1("Total", row).Value = (valorTotal).ToString()
            DataGridView1("idProdut", row).Value = (idProdRow).ToString()
            DataGridView1("Prec_Unt", row).Value = (valorProduto).ToString()
            calcura()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub txtQty_KeyUp_1(sender As Object, e As KeyEventArgs) Handles txtQty.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                InserirNagrid()
                txtQty.Text = ""
                txtDesignacao.Text = ""
                txtTotal.Text = ""
                txtRefer.Text = ""
                Me.ActiveControl = txtDesignacao
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtDesignacao_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDesignacao.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                txtQty.Text = "1"
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Try
            txtTotal.Text = txtQty.Text * valorProduto
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub txtRefer_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRefer.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                txtQty.Text = "1"
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub
End Class