using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gescom.Data_Model;
using MetroFramework.Controls;
using System.IO;
using System.Drawing.Printing;

namespace Gescom
{
    public partial class frm_veda_rapida : MetroFramework.Forms.MetroForm
    {
        Decimal valr = 0;
        private Sistemaintegrado pos;
       private MetroButton but;
       // private BindingList<vendas_Produto> produtos = new BindingList<vendas_Produto>();
       // private integ
       public Decimal re = 0;
       private string InfoEmpre = "Fanco teste";
       private string emailEmpre = "franco@gmail.com";
       private string Contacto = "82145626";
       private string Nuit = "1245";
        public frm_veda_rapida()
        {
            InitializeComponent();
        }
        private int idventasgo;

        public int Idventasgo
        {
            get { return idventasgo; }
            set { idventasgo = value; }
        }

        private void preechertab()
        {
            var cate = pos.Categorias_prod.ToList();
            foreach (var cat in cate)
            {

                tabControl1.TabPages.Add(cat.categoria_nome.ToString());

            }
        }//preencaher as tabs
        private void addicionapronatab()
        {
            int i = 1;
            foreach (TabPage tb in tabControl1.TabPages)
            {

                var capa = pos.Categorias_prod.Where(n => n.categoria_nome.Equals(tb.Text)).FirstOrDefault();//prencher as tabes pelo id da categoria
                i = capa.id_catego;
                // MessageBox.Show("ok " +tb.Text);
                var filtraprod = pos.Produtos_integ.Where(r => r.pro_categoid == i).ToList();


                FlowLayoutPanel flo = new FlowLayoutPanel();
                flo.Dock = DockStyle.Fill;
                flo.BackColor = Color.White;
                foreach (Produtos_integ pd in filtraprod)
                {

                    //byte[] logos = pd.logo;
                    //MemoryStream ms = new MemoryStream(logos);

                    but = new MetroButton();
                    but.Text = pd.pro_nome + " (" + pd.pro_stoque + ")";
                    //  but.Image.Size =new Size ( 80,40);
                    but.ForeColor = Color.White;
                    but.Font = new Font(but.Font.FontFamily, 12);
                    but.Image = Properties.Resources.images;
                   // but.Theme = "TelerikMetroBlue";
                    but.Size = new Size(130, 60);
                    but.Tag = pd;

                    but.Click += AtulizarListadeprodutos;
                    flo.Controls.Add(but);
                   // ms.Close();
                }
                tb.Controls.Add(flo);

            }

        }//priencar o produtor por categoria

        void AtulizarListadeprodutos(object sender, EventArgs e)//introduzir na grid
        {
            MetroButton buts = (MetroButton)sender;
            Produtos_integ pr = (Produtos_integ)buts.Tag;
            if (pr.pro_stoque > 0)
            {
                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["id", row].Value = pr.id_produto;
                dataGridView1["Nomeprodutos", row].Value = pr.pro_nome;
                dataGridView1["PrexoVenda", row].Value = pr.pro_val_venda;

                if (!radQuantidade.Text.Trim().Equals(""))
                {
                    int saldo = int.Parse(pr.pro_stoque.ToString()) - int.Parse(radQuantidade.Text);
                    dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = radQuantidade.Text;
                    prexototal(radQuantidade.Text,decimal.Parse ( pr.pro_val_venda.ToString()));
                }
                else
                {
                    int saldo = int.Parse(pr.pro_stoque.ToString()) - 1;
                    dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = 1;
                    prexototal("1", pr.pro_stoque);
                }
                dataGridView1["Valors", row].Value = re;
              //  produtos.Add(pr);
                calcura();
                dataGridView1.Refresh();
                radQuantidade.Text = "1";
            }

        }
        public void prexototal(string valor, decimal pvendass)
        {
            try
            {
                re = Convert.ToDecimal(valor) * Convert.ToDecimal(pvendass);

            }
            catch
            {
                MessageBox.Show("informe o produto");

            }
        }
        private void calcura()
        {
            try
            {
                valr = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    valr += Convert.ToDecimal(dataGridView1[5, i].Value);//* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);

                }

               radValor.Text = Convert.ToString(valr);
            }
            catch (SystemException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void frm_veda_rapida_Load(object sender, EventArgs e)
        {
            pos = new Sistemaintegrado();
            preechertab();
            addicionapronatab();
            metroTextBox1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Visible = true;
        }

        private void metroTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.Text = metroTextBox1.Text;
                metroTextBox1.Visible = false;

            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                calcura();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radValor.Text.Trim().Equals(""))
            {
                frm_tela_saida tela = new frm_tela_saida();
                tela.radValor.Text = radValor.Text;
                tela.pagfeito += tela_pagfeito;
                tela.ShowDialog();
            }
            else
            { 
          //  mess
                MessageBox.Show("Nenhum produto vendido");
                    
            }
        }

        void tela_pagfeito(object sender, frm_tela_saida.pagamentoeventargs e)
        {
            if (e.Resposta == true)
            {
                // MessageBox.Show("Opa good");
                //MessageBox.Show("" + e.Idvenda);
                buscaor(e.Idvenda);
                dataGridView1.Rows.Clear();
                calcura();
                dataGridView1.Refresh();

            }
            else
            {
                MessageBox.Show("Sem sucesso");

            }
        }
        public void buscaor(int idvend)
        {
            try
            {
                // pos = new OnlineVendasEntities();
               pedidos_inetg vp = pos.pedidos_inetg.Where(i => i.id_Pedidos == idvend).FirstOrDefault();
                int idpar = pos.pedidos_items.Count();
                //  MessageBox.Show("op " + Convert.ToInt16(vp.idVenda));
              //  idventasgo = vp.id_Pedidos;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {


                    int idvenda = Convert.ToInt16(Idventasgo);
                    int quant = Convert.ToInt16(dataGridView1[3, i].Value);
                    if (quant != 0)
                    {
                        String nome = Convert.ToString(dataGridView1[1, i].Value);
                        Decimal prexo = Convert.ToDecimal(dataGridView1[2, i].Value);
                        int idpro = Convert.ToInt16(dataGridView1[0, i].Value);//obter o numero do Produto (ID)
                        DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        Decimal total = Convert.ToDecimal(dataGridView1[5, i].Value); //* Convert.ToDecimal(detalhes_de_VendaDataGridView[3, 1].Value);
                        int stok = Convert.ToInt32(dataGridView1[3, i].Value);

                        ///MessageBox.Show(idpro.ToString ()+"  " + stok.ToString () );
                        pedidos_items deta = new pedidos_items()
                        {
                            itme_id = idpar,
                            item_pedido = idvend,
                            item_qty = quant,
                            item_produ = idpro,
                            item_preco = total,
                                                     
                           

                        };
                        pos.pedidos_items.Add(deta);
                        pos.SaveChanges();

                        destruirstok(idpro, stok);

                    }
                }
               // imprimirreceita();
                frm_repor_vendarapida fr = new frm_repor_vendarapida();
                fr.Idfact = idvend;
                fr.Show();

                // imprimir(Idventasgo );
                // imprimir(Idventasgo);

            }
            catch (SyntaxErrorException es)
            {
                MessageBox.Show("Problema " + es.Message);

            }


        }// salvar os dados na base de dados

        private void Procurarporbar(string barcodigo)
        {

            int ver;
            ver = pos.Produtos_integ.Where(r => r.pro_cod_Bara == barcodigo).Count();
            if (ver == 1)
            {

                var pr = pos.Produtos_integ.Where(r => r.pro_cod_Bara== barcodigo).FirstOrDefault();
                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;
                dataGridView1["id", row].Value = pr.id_produto;
                dataGridView1["Nomeprodutos", row].Value = pr.pro_nome;
                dataGridView1["PrexoVenda", row].Value = pr.pro_val_venda;

                if (!radQuantidade.Text.Trim().Equals(""))
                {
                    int saldo = int.Parse(pr.pro_stoque.ToString()) - int.Parse(radQuantidade.Text);
                    dataGridView1["saldose", row].Value = saldo;
                    dataGridView1["Quantidade", row].Value = radQuantidade.Text;
                    prexototal(radQuantidade.Text,decimal.Parse ( pr.pro_val_venda.ToString()));
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

                MessageBox.Show("Produto nao registrado");
                return;
            }


        }

        private void textBarcod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Procurarporbar(textBarcod.Text);

            }
        }

        public void destruirstok(int idproduto, int saldo)
        {

            try
            {
                //verficar se o produto esta permitido a ser controlado ou nao
                var emp = pos.View_Produtos.Where(s => s.id_produto == idproduto).FirstOrDefault();
                if (emp.controlStock.Trim().Equals("Sim"))
                {
                    //se o produto estiver permitido sera retirado a aquantidade vendida
                    var py = pos.Produtos_integ.Where(p => p.id_produto == idproduto).FirstOrDefault();

                    py.pro_stoque -= saldo;
                    pos.SaveChanges();
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


        //iprimir recibo
        private void imprimirreceita()
        {

            PrintDialog prin = new PrintDialog();
            PrintDocument pridoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            prin.Document = pridoc;
            prin.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;


            pridoc.DefaultPageSettings.PaperSize.Width = 520;

            pridoc.PrintPage += pridoc_PrintPage;
            DialogResult res = prin.ShowDialog();
            if (res == DialogResult.OK)
            {
                //  MessageBox.Show("Problema vou imprimir");
                pridoc.Print();

            }
        }
        //folha de impressao
        void pridoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var caiza = pos.Utilizadores.Where(r => r.id__utilizador == 1).FirstOrDefault();
            Graphics grafco = e.Graphics;
            float fontHeight = Font.GetHeight();
            int star = 50;
            int fim = 55;
            int ofcet = 40;
            Font font = new Font("Arial Narrow", 12);






            grafco.DrawString(InfoEmpre, new Font("Arial Narrow", 14), new SolidBrush(Color.Black), star, star + ofcet);

            //grafco.DrawString("Cell  :" + Contacto, new Font("Arial Narrow", 10), new SolidBrush(Color.Black), star, fim + ofcet + 15);

            //  grafco.DrawString("Email :" + emailEmpre, new Font("Arial Narrow", 10), new SolidBrush(Color.Black), star, fim + ofcet + 30);

            //  grafco.DrawString("Niut  :" + Nuit, new Font("Arial Narrow", 10), new SolidBrush(Color.Black), star, fim + ofcet + 45);


            ofcet = ofcet + 20;
            grafco.DrawString("Nuit :" + Nuit.ToString(),
                     new Font("Arial Narrow", 12),
                     new SolidBrush(Color.Black), star, star + ofcet);
            ofcet = ofcet + 20;
            grafco.DrawString("Cell :" + Contacto,
                     new Font("Arial Narrow", 12),
                     new SolidBrush(Color.Black), star, star + ofcet);
            // grafco.DrawString("Venda N :" +Idventasgo , new Font("Arial Narrow", 12), new SolidBrush(Color.Black), star, fim + ofcet + 60);
            ofcet = ofcet + 20;
            grafco.DrawString("Ticket Date :" + DateTime.Now.ToShortDateString(),
                     new Font("Arial Narrow", 12),
                     new SolidBrush(Color.Black), star, star + ofcet);
            ofcet = ofcet + 20;
            grafco.DrawString("Venda No:" + +Idventasgo,
                     new Font("Arial Narrow", 14),
                     new SolidBrush(Color.Black), star, star + ofcet);
            ofcet = ofcet + 20;
            String underLine = "--------------------------------------------------------";
            grafco.DrawString(underLine, new Font("Arial Narrow", 10),
                     new SolidBrush(Color.Black), star, star + ofcet);
            ofcet = ofcet + 10;
            //  String lista = "quant" + "  " + " Descricao" + "  " + "Valor";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {


                int idvenda = Convert.ToInt16(Idventasgo);
                int quant = Convert.ToInt16(dataGridView1[3, i].Value);
                if (quant != 0)
                {
                    String nome = Convert.ToString(dataGridView1[1, i].Value).PadRight(30);
                    Decimal prexo = Convert.ToDecimal(dataGridView1[2, i].Value);
                    int idpro = Convert.ToInt16(dataGridView1[0, i].Value);
                    DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    Decimal total = Convert.ToDecimal(dataGridView1[5, i].Value);

                    String listadevendas = quant + "  " + nome + "  :" + total + " Mzn";
                    grafco.DrawString(listadevendas, new Font("Arial Narrow", 12),
                     new SolidBrush(Color.Black), star, star + ofcet);
                    ofcet += (int)FontHeight + 5;
                    //MessageBox.Show("Problema vou imprimir");
                }
            }
            ofcet = ofcet + 10;
            grafco.DrawString(underLine, new Font("Arial Narrow", 10),
                     new SolidBrush(Color.Black), star, star + ofcet);

            ofcet = ofcet + 20;
            grafco.DrawString("Total pago ".PadRight(30) + valr + " Mzn", font, new SolidBrush(Color.Black), star, fim + ofcet);
            // grafco.DrawString("Data ".PadRight(30) +DateTime .UtcNow .Date.ToShortDateString () , font, new SolidBrush(Color.Black), star, fim + ofcet+15);
            ofcet = ofcet + 20;
            grafco.DrawString("Caixa :" + caiza.nome_utiliza,
                     new Font("Arial Narrow", 12),
                     new SolidBrush(Color.Black), star, star + ofcet);
        }

    }
}
