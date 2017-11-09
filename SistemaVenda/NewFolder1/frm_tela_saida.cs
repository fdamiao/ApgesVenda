using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gescom.Data_Model;
using System.Drawing.Printing;

namespace Gescom
{
    public partial class frm_tela_saida : MetroFramework.Forms.MetroForm
    {
        public delegate void pagamentoevent(object sender, pagamentoeventargs e);
        public event pagamentoevent pagfeito;
        private int Id;
        public int idcli = 1;
        public int pag = 1;

       
        public Sistemaintegrado  pos;
        public frm_tela_saida()
        {
            InitializeComponent();
            prencher_f_Pagamento();
        }
        private decimal total;
        public class pagamentoeventargs : EventArgs
        {
            private bool resposta;

            public bool Resposta
            {
                get { return resposta; }
                set { resposta = value; }
            }

            private int idvenda;

            public int Idvenda
            {
                get { return idvenda; }
                set { idvenda = value; }
            }
          

        }
        //efectuar venda
        private void textvpago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

               
            }
        }

        private void textvpago_TextChanged(object sender, EventArgs e)
        {
            if (textvpago.Text != "")
            {
               // troc.Text = (Decimal.Parse(radTextBoxControl2.Text) - Decimal.Parse(radTextBoxControl1.Text)).ToString();

                var troco = decimal.Parse(textvpago.Text) - decimal.Parse(radValor.Text);
                textroco.Text = troco.ToString("#.##");
            }
        }

        private void frm_tela_saida_Load(object sender, EventArgs e)
        {
            total = decimal.Parse(radValor.Text );
        }

        private void radValor_TextChanged(object sender, EventArgs e)
        {
            var des = total - decimal.Parse(radValor.Text);
            textdesc.Text = des.ToString();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var meodpaga = metroComboBox1.SelectedItem.ToString();
            if (meodpaga.Equals("Credido"))
            {
                MessageBox.Show("Nao paga nada");
            }
        }
        void prencher_f_Pagamento()
        {

            pos = new Sistemaintegrado();

            metroComboBox1.DataSource = pos.forma_pagamento.ToList();
            metroComboBox1.DisplayMember = "Formapag";
            metroComboBox1.ValueMember = "id_formapa";
        }
        //efectuar venda
        private void button1_Click(object sender, EventArgs e)
        {
            pos = new Sistemaintegrado();
            novopedido();
            pagfeito(this, new pagamentoeventargs() { Resposta = true, Idvenda = Id });
            this.Dispose();
        }
        //criar novo pedido
        private void novopedido()
        {
            try
            {
                if (!textvpago.Text.Equals(""))
                {
                    var countidp = pos.pedidos_inetg.Count();
                    Id = countidp + 1;
                    Random rt = new Random();
                    pedidos_inetg ped = new pedidos_inetg();
                    ped.id_Pedidos = countidp + 1;
                    ped.Ped_Datare = DateTime.Now;
                    ped.ped_usuario = 1;
                    ped.ped_client = 2;
                    ped.ped_valor = decimal.Parse(total.ToString());
                    ped.ped_faturado = "Sim";
                    ped.ped_fecho = "Sim";
                    ped.ped_numero = rt.Next(99999).ToString();
                    ped.ped_for_pagam = 1;
                    ped.ped_total_iva= decimal.Parse(total.ToString());
                    ped.ped_val_iva = 0;



                    pos.pedidos_inetg.Add(ped);
                    pos.SaveChanges();
                    //registrat detalhes de pagamento
                    reg_deta_pagameto();
                   
                    
                    
                }
                else
                {


                    MessageBox.Show("nenhum cliente escolhido");

                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Problemas contacte ao administrador " + ex.Message);

            }
            
        }
        //registrat pagamentos
        void reg_deta_pagameto()
        {
            try
            {
                
                var regispar = registrarparcela();
                //se o somatorio de valor a dinheir mai o valor a chequ for maior ou igual o valor por pagar
                //  var verpag = decimal.Parse(textvpago.Text) + decimal.Parse(textcheque.Text);
                    pos = new Sistemaintegrado();
               

                    deta_pag_parcel_pedidos pagparc = new deta_pag_parcel_pedidos();
                    pagparc.id_ped_parcela = regispar.id_Parcelas;
                    pagparc.Val_dinheiro = decimal.Parse(textvpago.Text) + 0;//palor pag na caixa dinheiro vivo
                    pagparc.val_cheque =  0;
                    pagparc.descont_par = decimal.Parse(textdesc.Text) + 0;
                    pagparc.data_paga_detal = DateTime.Now;
                    pos.deta_pag_parcel_pedidos.Add(pagparc);

                pos.SaveChanges();

            }
            catch (SystemException x)
            {
                MessageBox.Show(x.Message);
            }

        }

        //efectuar regitro de parcelas
        pedido_parcela registrarparcela()
        {
            pos = new Sistemaintegrado();
            pedido_parcela par = null;
            var valestenso ="";
            var tipo = estencao.TipoValorExtenso.Monetario;
                valestenso = estencao.toExtenso(total, tipo);
            try
            {
                //veficar os dados dos campos

                double cheque = double.Parse(textvpago .Text);
           
            //decimal total = decimal.Parse(textTotal.Text);
            double vpado =  cheque;
            double qufalta = (double)total - vpado;
            // se o valor pagor pago for menor que o valor a pagar deve colocar em divida ou cancelar o faturamento
            if (qufalta > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "O valor pago é menor que o valor a pagar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                return null;
            }
            else
            {
                //contar quantas parcelas existem
                int idpar = pos.pedido_parcela.Count();
                par = new pedido_parcela();
                par.id_Parcelas = idpar + 1;//acrescentar a nova
                par.idpedido = Id;
                par.stato_parceala = "Pago";//o estado da parcela pode ser  pago ou em divida
                par.Valor_f_parc = 0;//valor da parcela que falta
                par.valor_parcela = decimal.Parse(total.ToString());//o valor por pagar
                par.data_venci_parcela = DateTime.Now;//data provisora de pagamento
                par.Data_Pagamento_parc = DateTime.Now;//data do pagamento da parcela
                par.Extenco_valor = valestenso;

               
               
               
                // ped.ped_faturado = "Sim";




                pos.pedido_parcela.Add(par);
                    pos.SaveChanges();
            }



           
        }
            catch(SystemException x)
            {
                MessageBox.Show(x.Message);
            }
              return par;
        }
        pedido_parcela registrarparcelaBanido()
        {
            pedido_parcela par = null;
            try
            {
                //veficar os dados dos campos


                pos = new Sistemaintegrado();
           
            int idpar = pos.pedido_parcela.Count();
          par = new pedido_parcela();
             par.id_Parcelas = idpar;
                par.idpedido = Id;
           
            par.stato_parceala = "Pago";//o estado da parcela pode ser  pago ou em divida
            par.Valor_f_parc = 0;//valor da parcela que falta
            par.valor_parcela = decimal.Parse(total.ToString ());//o valor por pagar
            par.data_venci_parcela = DateTime.Now;//data provisora de pagamento
            par.Data_Pagamento_parc = DateTime.Now;//data do pagamento da parcela

            pos.pedido_parcela.Add(par);
                pos.SaveChanges();
           
        }
            catch(SystemException x)
            {
                MessageBox.Show(x.Message);
            }
     return par;
}

        

        
    }
}
