using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gescom.Data_Model;
using MetroFramework;

namespace Gescom
{
    public partial class frm_Venda : MetroFramework.Forms.MetroForm
    {
        private Sistemaintegrado si;
        Decimal valr = 0;
        public Decimal re = 0;
        private decimal valpro = 0;
        private int idcaixa = Properties.Settings.Default.idcaixa;
        private int idclient = 0;
        private int idpdidos;
        public int Idclient
        {
            get { return idclient; }
            set { idclient = value; }
        }
        //private string emailEmpre;
        //private string Contacto;
        //private string Nuit;
        public frm_Venda()
        {
            InitializeComponent();
            autocomplet();
            autocompliteprodut();
            prencher_f_Pagamento();
            autocompletrefencia();
            
        }
        void vercli(int idcli)
        {
            if (idcli > 0)
            {
                var cli = si.Cliente_Inte.Where(id => id.cliente_Id == idcli).FirstOrDefault();
                //labnclient.Text = cli.Nome_cli.ToString();
                //labcontact.Text = cli.Contacto_cli.ToString();
                txtClient.Text = cli.Nome_cli.ToString();
                
            }
        }
        //buscar cliente
        void autocomplet()
        {
            
            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            si = new Sistemaintegrado();
            var pro = si.Cliente_Inte.ToList();
            foreach (var item in pro)
            {

                cl.Add( item.Nome_cli.ToString()  );
            }
            txtClient.AutoCompleteCustomSource = cl;

        }

        void autocompletrefencia()
        {

            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            si = new Sistemaintegrado();
            var pro = si.Produtos_integ.ToList();
            foreach (var item in pro)
            {

                cl.Add(item.pro_referencia.ToString());
            }
            textBox2.AutoCompleteCustomSource = cl;

        }
       
    
    //calculr o total do produto pela quantidade
         void prexototal(string valor, decimal pvendass)
        {
            try
            {
                //buscar valor apatir da caixa de texto de preco unitario
                if (!textpUnit.Text .Equals(""))
                {

                    re = Convert.ToDecimal(valor) * Convert.ToDecimal(textpUnit.Text);
                }
                else {

                    MessageBox.Show("informe o  preco unitario");
                }

            }
            catch
            {
                MessageBox.Show("informe o produto");

            }
        }
       // obter o subtolta da venda
        private void calcura()
        {
            try
            {
                valr = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    valr += Convert.ToDecimal(dataGridView1[6, i].Value);//* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);

                }

                double subtotal = double.Parse(valr.ToString());
                //calcular o total
                double total = 1.17 * double.Parse(valr.ToString());
                //calcular o iva
                double iva = 0.17 * double.Parse(valr.ToString());
                if (checkBox1.Checked == true)
                {
                    textsub.Text = subtotal.ToString();
                    texiva.Text = iva.ToString();
                    textTotal.Text = Convert.ToString(total);
                }
                else
                {
                    textsub.Text = subtotal.ToString();
                    texiva.Text = "0";
                    textTotal.Text = Convert.ToString(subtotal);
                
                }
            }
            catch (SystemException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        // eliminar o produto na grid
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                calcura();
            }
        }
        //fazer busca pelo codigo de barra
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Procurarporbar(textBox2.Text);
                    //radTextBox1.Text = "";
                    //radTextBox1.Focus();
                    //radQuantidade.Text = "";
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }

    
    }

        private void Procurarporbar(string barcodigo)
        {
            si = new Sistemaintegrado();
            int ver;
            ver = si.Produtos_integ.Where(r => r.pro_cod_Bara.Equals(barcodigo)).Count();
            if (ver == 1)
            {

                var pr = si.Produtos_integ.Where(r => r.pro_cod_Bara .Equals(barcodigo)).FirstOrDefault();
                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["id", row].Value = pr.id_produto;
                dataGridView1["Nomeprodutos", row].Value = pr.pro_nome;
                dataGridView1["PrexoVenda", row].Value = pr.pro_val_venda;

                if (!txtQuantidade.Text.Trim().Equals(""))
                {
                    int saldo = int.Parse(pr.pro_stoque.ToString()) - int.Parse(txtQuantidade.Text);
                    dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = txtQuantidade.Text;
                    prexototal(txtQuantidade.Text, decimal.Parse( pr.pro_val_venda.ToString()));
                }
                else
                {
                    int saldo = int.Parse(pr.pro_stoque.ToString()) - 1;
                    dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = 1;
                    prexototal("1", decimal.Parse( pr.pro_val_venda.ToString()));
                }
                dataGridView1["Valors", row].Value = re;
                // produtos.Add(pr);
                calcura();
                dataGridView1.Refresh();
                // radTextBox1.Text = "";
                // radTextBox1.Focus();
            }


            else
            {

                MessageBox.Show("Produto nao registrado");
                return;
            }
        }
        //preencher os dados do cliente nas labels
        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            var nclien = si.Cliente_Inte.Where(c => c.Nome_cli.Equals(txtClient.Text)).Count();
            if (nclien !=0)
            {
                var clien = si.Cliente_Inte.Where(c => c.Nome_cli.Equals(txtClient.Text)).FirstOrDefault();
                labnclient.Text = clien.Nome_cli.ToString();
                labcontact.Text = clien.Contacto_cli.ToString();
                idclient = clien.cliente_Id;
                labsegu.Text = clien.Seguradora.ToString();
            }
            else
            { 
            return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //procura automatica de produto apartir do textbox
        void autocompliteprodut()
        {

            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            si = new Sistemaintegrado();
            var pro = si.Produtos_integ.ToList();
            foreach (var item in pro)
            {

                cl.Add(item.pro_nome.ToString());
            }
            textpro_nome.AutoCompleteCustomSource = cl;
        }

        private void textvpago_TextChanged(object sender, EventArgs e)
        {
            //var troco=decimal.Parse(textvpago.Text)-decimal.Parse(textTotal.Text);
            //textroco.Text = troco.ToString("#.##");
            
        }
        //calcular desconto
        private void textdesc_TextChanged(object sender, EventArgs e)
        {
            //if (textdesc.Text == "")
            //{ return; }
            //else
            //{
            //    var valto = decimal.Parse(textTotal.Text) - decimal.Parse(textdesc.Text);
            //    var valdes = decimal.Parse(textvpago.Text) - valto;
            //    textroco.Text = valdes.ToString();

            //}
        }
        void prencher_f_Pagamento()
        {


            metroComboBox1.DataSource = si.forma_pagamento.ToList();
            metroComboBox1.DisplayMember = "Formapag";
            metroComboBox1.ValueMember = "id_formapa";
        }

        //criar novo pedido
    private  pedidos_inetg novopedido()
        {
            try
            {
                if (!txtClient.Text.Equals(""))
                {
                    Random rt = new Random();
                    pedidos_inetg ped = new pedidos_inetg();
                    var countidp = si.pedidos_inetg.Count();
                    
                    ped.id_Pedidos =+countidp+1;
                    ped.Ped_Datare = DateTime.Now;
                    ped.ped_usuario = idcaixa;
                    ped.ped_client = idclient;
                    ped.ped_valor = decimal.Parse(textsub.Text);
                    ped.ped_faturado = "Nao";
                    ped.ped_fecho = "Nao";
                    ped.ped_numero = "00"+countidp;
                    ped.ped_for_pagam =int.Parse ( metroComboBox1.SelectedValue .ToString ());
                    ped.ped_obs = textcomentarios.Text;
                    //buscar o valor d subtotal e incluir o iva
                    var tipo = estencao.TipoValorExtenso.Monetario;
                    //  var vtop=ped.
                   
                   ped.Extenco_valor = estencao.toExtenso(Convert.ToDouble(textTotal.Text), tipo);
                    ped.ped_val_iva = decimal.Parse(texiva.Text);
                    //total a pagar
                   // double total_iva = 1.17 * double.Parse(textsub.Text);
                    ped.ped_total_iva = decimal.Parse(textTotal.Text );



                    si.pedidos_inetg.Add(ped);
                    si.SaveChanges();
                    idpdidos = ped.id_Pedidos;//guardar id do pedido
                    return ped;
                }
                else
                {


                    MessageBox.Show("nenhum cliente escolhido");

                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Problemas contacte ao administrador "+ex.Message);
            
            }
        return null;
        }
        //adicionar item na tabela pedidos_item
        public void adicionaritem()
        {
            try
            {

                //buscar o pedido feito recentimente
                var idpdido = novopedido();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {


                    int idvenda = Convert.ToInt16(idpdido.id_Pedidos);
                    int quant = Convert.ToInt16(dataGridView1[4, i].Value);
                    if (quant != 0)
                    {   var refe= dataGridView1[1, i].Value.ToString();
                        String nome = Convert.ToString(dataGridView1[2, i].Value);
                        
                        Decimal prexo = Convert.ToDecimal(dataGridView1[3, i].Value);
                        int idpro = Convert.ToInt16(dataGridView1[0, i].Value);//obter o numero do Produto (ID)
                       // DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                      //  int stok = Convert.ToInt32(dataGridView1[5, i].Value);

                        ///iserir dados na tabela item pedidos
                        pedidos_items deta = new pedidos_items()
                        {
                            item_pedido = idvenda,
                            item_qty = quant,
                                                  
                            item_preco = total,
                            item_produ = idpro,
                            referencias_ped=refe,
                            item_pUnite = prexo
                            

                        };
                       si.pedidos_items.Add(deta);
                        si.SaveChanges();
                        
                       // destruirstok(idpro, stok);

                    }
                   
                } 
               
                    frm_facturas fr = new frm_facturas();
                    fr.IdsPedido = idpdido.id_Pedidos;
                    fr.Show();
                //imprimirreceita();

                // imprimir(Idventasgo );
                // imprimir(Idventasgo);
               
            }
            catch (SystemException es)
            {
                MessageBox.Show("Problema " + es.Message);
               // MetroMessageBox.Show()
            }


        }
       
        //comando para realizar a venda
        private void button4_Click(object sender, EventArgs e)
        {
           // salvar os dados na base de dados
                adicionaritem();
            // efectura o facturamento


                //limpar a grelha
                dataGridView1.Rows.Clear();
                //recalcular
                calcura();
                dataGridView1.Refresh();
           // }
        }

        //buscar pelo nome do produto
        private void Procurarpornome(string nomepro)
        {
            si = new Sistemaintegrado();
            int ver;
            ver = si.Produtos_integ.Where(r => r.pro_nome.Contains(nomepro)).Count();
            if (ver == 1)
            {
                


                var pr = si.Produtos_integ.Where(r => r.pro_nome.Equals(nomepro)).FirstOrDefault();
               
                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["id", row].Value = pr.id_produto;
                dataGridView1["refer", row].Value = textBox2.Text;
                dataGridView1["Nomeprodutos", row].Value = pr.pro_nome;
                dataGridView1["PrexoVenda", row].Value = textpUnit.Text;

                if (!txtQuantidade.Text.Trim().Equals(""))
                {
                    int saldo = int.Parse(pr.pro_stoque.ToString()) - int.Parse(txtQuantidade.Text);
                    dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = txtQuantidade.Text;
                    prexototal(txtQuantidade.Text, decimal.Parse(pr.pro_val_venda.ToString()));
                }
                else
                {
                    int saldo = int.Parse(pr.pro_stoque.ToString()) - 1;
                    dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = 1;
                    prexototal("1", decimal.Parse(pr.pro_val_venda.ToString()));
                }
                dataGridView1["Valors", row].Value = re;
                // produtos.Add(pr);
                calcura();
                dataGridView1.Refresh();
                // radTextBox1.Text = "";
                // radTextBox1.Focus();
            }


            else
            {

            DialogResult resp=MessageBox.Show("Produto nao registrado \n gostaria de o registrar","Novo Produto",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Produtos_integ pr = new Produtos_integ();

                pr.pro_nome = textpro_nome.Text;
                pr.pro_val_venda = decimal.Parse(textpUnit.Text);
                pr.pro_referencia = textBox2.Text;
                pr.pro_categoid = 1;
                si.Produtos_integ.Add(pr);
                si.SaveChanges();
                Procurarpornome(textpro_nome.Text);

            }
                
             
            }
        }

        private void textpro_nome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Procurarpornome(textpro_nome.Text);
                    //radTextBox1.Text = "";
                    //radTextBox1.Focus();
                    txtQuantidade.Text = "1";
                    textpUnit.Text = "";
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                calcura();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {



                        int quant = Convert.ToInt16(dataGridView1[4, i].Value);
                        if (quant != 0)
                        {


                            Decimal prexo = Convert.ToDecimal(dataGridView1[3, i].Value);


                            // Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                            dataGridView1[6, i].Value = quant * prexo;
                        }

                    }
                    calcura();
                }
                catch (Exception ex)
                {
                    return;

                }
            }
        }

        private void frm_Venda_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            vercaixa();
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    Procurarpornome(textpro_nome.Text);
                    //radTextBox1.Text = "";
                    //radTextBox1.Focus();
                    txtQuantidade.Text = "";
                    textpro_nome.Text = "";
                    textpUnit.Text = "";
                  //  textObs.Text = "";
                    this.ActiveControl = textpro_nome;
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void textpro_nome_TextChanged(object sender, EventArgs e)
        {
            var npro = si.Produtos_integ.Where(c => c.pro_nome.Equals(textpro_nome.Text)).Count();
            if (npro != 0)
            {
                var prod = si.Produtos_integ.Where(c => c.pro_nome.Equals(textpro_nome.Text)).FirstOrDefault();
                textpUnit.Text = prod.pro_val_venda.ToString();
               // textBox2.Text = prod.pro_referencia.ToString();
               // idclient = clien.cliente_Id;
            }
            else
            {

                textpUnit.Text = "";
                textBox2.Text ="";
                return;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //autocompletrefencia();
        }
        private void vercaixa()
        {
            var ver = si.Caixa.Where(c => c.caixaestado.Equals("Aberto") && c.caixa_user == idcaixa).Count();
            if (ver <= 0)
            {
                DialogResult d = MessageBox.Show("Encontra-se com servicos fechados /n gostaria de abrir ?", "Abertura de tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    frm_abrircaixa f = new frm_abrircaixa();
                    f.ShowDialog();

                }
                return;
            }
            else { 
            
            
            }
            
        
        }
        private void textpUnit_Leave(object sender, EventArgs e)
        {
            //Double value;
            //if (Double.TryParse(textpUnit.Text, out value))
            //    textpUnit.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //else
            //    textpUnit.Text = String.Empty;
        }

       
        private void textTotal_Leave(object sender, EventArgs e)
        {
            textTotal.Text = Convert.ToDouble(textTotal.Text).ToString("F");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                calcura();
            }
            else
            {
               
                texiva.Text ="0";
                textTotal.Text = textsub.Text;
            
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adicionaritemfactura();
            updatepedido();
            frm_facturasf t = new frm_facturasf();
            t.IdsPedido = idpdidos;
            t.ShowDialog();
            frm_lanc_factura lac = new frm_lanc_factura();
            lac.Idcli = idclient;
            lac.ShowDialog();
            dataGridView1.Rows.Clear();
            //recalcular
            calcura();
            dataGridView1.Refresh();
        }
        void updatepedido()
        {
            si = new Sistemaintegrado();
            pedidos_inetg ped = si.pedidos_inetg.Where(p => p.id_Pedidos == idpdidos).FirstOrDefault();
            if (!ped.ped_faturado.Equals("Sim"))
            {

                ped.nparcelas = 1;
                ped.ped_faturado = "Sim";
                ped.ped_fecho = "Nao";
                ped.ped_obs = textcomentarios.Text;

                // nocas o do valor ser descontado/ alterado
                ped.ped_total_iva = Convert.ToDecimal(textTotal.Text);

                // registrarparcela();

                // reg_deta_pagameto();
                si.SaveChanges();
                MessageBox.Show("operacao realizada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String modo = metroComboBox1.SelectedItem.ToString();
              //  view_pedidosDataGridView.DataSource = si.View_pedidos.Where(d => d.ped_faturado.Equals(modo)).ToList();
            }
            else
            {
                MessageBox.Show("o pedido ja foi facturado");
            }

        }

        //adicionar item na tabela pedidos_item
        public void adicionaritemfactura()
        {
            try
            {

                //buscar o pedido feito recentimente
                var idpdido = novopedido();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {


                    int idvenda = Convert.ToInt16(idpdido.id_Pedidos);
                    int quant = Convert.ToInt16(dataGridView1[4, i].Value);
                    if (quant != 0)
                    {
                        var refe = dataGridView1[1, i].Value.ToString();
                        String nome = Convert.ToString(dataGridView1[2, i].Value);

                        Decimal prexo = Convert.ToDecimal(dataGridView1[3, i].Value);
                        int idpro = Convert.ToInt16(dataGridView1[0, i].Value);//obter o numero do Produto (ID)
                        // DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        Decimal total = Convert.ToDecimal(dataGridView1[6, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                          int stok = Convert.ToInt32(dataGridView1[4, i].Value);

                        ///iserir dados na tabela item pedidos
                        pedidos_items deta = new pedidos_items()
                        {
                            item_pedido = idvenda,
                            item_qty = quant,

                            item_preco = total,
                            item_produ = idpro,
                            referencias_ped = refe,
                            item_pUnite = prexo


                        };
                        si.pedidos_items.Add(deta);
                        si.SaveChanges();

                       destruirstok(idpro, stok);

                    }

                }

                //frm_facturas fr = new frm_facturas();
                //fr.IdsPedido = idpdido.id_Pedidos;
                //fr.Show();
                //imprimirreceita();

                // imprimir(Idventasgo );
                // imprimir(Idventasgo);

            }
            catch (SystemException es)
            {
                MessageBox.Show("Problema " + es.Message);
                // MetroMessageBox.Show()
            }


        }



        public void destruirstok(int idproduto, int saldo)
        {

            try
            {
                //verficar se o produto esta permitido a ser controlado ou nao
                var emp = si.View_Produtos.Where(s => s.id_produto == idproduto).FirstOrDefault();
                if (emp.controlStock.Trim().Equals("Sim"))
                {
                    //se o produto estiver permitido sera retirado a aquantidade vendida
                    var py = si.Produtos_integ.Where(p => p.id_produto == idproduto).FirstOrDefault();

                    py.pro_stoque -= saldo;
                    si.SaveChanges();
                }
                else if (emp.controlStock.Equals("Nao"))
                {
                    //caso contrario nada se faz

                }
                //  int saldo = int.Parse(quantidadeRadTextBox.Text) - int.Parse(radTextBox3.Text);

            }
            catch
            {

                MessageBox.Show("Nao foi possivel atualizar o estoke");
            }


        }//retirar a Quantidade no stock

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }





}
