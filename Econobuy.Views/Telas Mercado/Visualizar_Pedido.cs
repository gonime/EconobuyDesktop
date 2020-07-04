using Econobuy.Models;
using Econobuy_desktop.Telas_Mercado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econobuy_desktop
{
    public partial class Visualizar_Pedido : Form
    {
        int num_ped;
        int cli_id;
        MercadoModel mer = new MercadoModel();

        public Visualizar_Pedido(int ped_id)
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            num_ped = ped_id;

            panel1.Size = this.Size;
        }

        private void Visualiza_pedido_unico_Load(object sender, EventArgs e)
        {
            preencherCampos(num_ped);
        }

        public void preencherCampos(int num_ped)
        {
            DataTable dt = new DataTable();
            dt = mer.selecionaPedidoUnico(num_ped);
            cli_id = Convert.ToInt32(dt.Rows[0]["Cod"]);
            lbCliente.Text = "Cliente: " + dt.Rows[0]["Cliente"].ToString();
            lbData.Text = "Data: " + dt.Rows[0]["Data_ped"].ToString();
            lbStatus.Text = "Status: " + dt.Rows[0]["Status_pedido"].ToString();
            lbCEP.Text = "CEP: " + dt.Rows[0]["CEP"].ToString();
            lbValor.Text = "Valor: " + dt.Rows[0]["Valor"].ToString();
            lbCidade.Text = "Cidade: " + dt.Rows[0]["Cidade"].ToString();
            lbAvCliente.Text = "Avaliação do Cliente: " + dt.Rows[0]["Av"].ToString();
            if (Equals(dt.Rows[0]["Bairro"].ToString(), "") == false) lbBairro.Text = "Bairro " + dt.Rows[0]["Bairro"].ToString();
            else lbBairro.Text = "Bairro: " + "Bairro não fornecido";
            if (Equals(dt.Rows[0]["Status_pedido"].ToString(), "Aguardando") == true)
            {
                lbAvaliacao.Text = "Avaliação: Ainda não avaliado";
                btnAvaliar.Enabled = false;
            }
            else if (Equals(dt.Rows[0]["Status_pedido"].ToString(), "Reprovado") == true)
            {
                lbAvaliacao.Text = "Avaliação: Pedido reprovado";
                btnAprovar.Enabled = false;
                btnReprovar.Enabled = false;
                btnAvaliar.Enabled = false;
                txtMsg.ReadOnly = true;
            }
            else
            {
                double nota = mer.verAvaliacao(num_ped);
                if (nota != -1) lbAvaliacao.Text = "Avaliação: " + nota.ToString();
                else lbAvaliacao.Text = "Avaliação: Ainda não avaliado";
                if (Equals(dt.Rows[0]["Status_pedido"].ToString(), "Entregue")) btnAvaliar.Enabled = true;
                else btnAvaliar.Enabled = false;
                preencherCamposPedidoAprovado();
                btnAprovar.Enabled = false;
                btnReprovar.Enabled = false;
                txtMsg.ReadOnly = true;
            }
            DataTable itens = new DataTable();
            itens = mer.selecionaItensPedido(num_ped);
            dataGridView1.DataSource = itens;
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            string msg = mer.aprovaPedido(num_ped, txtMsg.Text);
            if (Equals(msg, "Erro") == false)
            {
                preencherCampos(num_ped);
                MessageBox.Show("Pedido Aprovado");
                preencherCamposPedidoAprovado();
                txtMsg.Text = msg;
            }
            btnAprovar.Enabled = false;
            btnReprovar.Enabled = false;
            txtMsg.ReadOnly = true;
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            string msg = mer.reprovaPedido(num_ped, txtMsg.Text);
            if (Equals(msg,"Erro") == false)
            {
                preencherCampos(num_ped);
                MessageBox.Show("Pedido Reprovado");
                txtMsg.Text = msg;
            }
            btnAprovar.Enabled = false;
            btnReprovar.Enabled = false;
            txtMsg.ReadOnly = true;
        }

        public void preencherCamposPedidoAprovado()
        {
            DataTable dt = mer.pedidoAprovado(num_ped);
            lbEmail.Text = "E-mail: " + dt.Rows[0]["Email"].ToString();
            lbTel1.Text = "Telefone 1: " + dt.Rows[0]["Cell"].ToString();
            lbTel1.Visible = true;
            if(dt.Rows[0]["Tel"].ToString() != "") lbTel2.Text = "Telefone 2:" + dt.Rows[0]["Tel"].ToString();
            lbTel2.Visible = true;
            lbLog.Text = "Logradouro: " + dt.Rows[0]["Log"].ToString() + ", " + dt.Rows[0]["Num"].ToString();
            if (Equals(dt.Rows[0]["Compl"].ToString(), "") == false)
            {
                lbCompl.Text = "Complemento: " + dt.Rows[0]["Compl"].ToString();
                lbCompl.Visible = true;
            }
            if (Equals(dt.Rows[0]["Msg"].ToString(), "") == false)
            {
                txtMsg.Text = dt.Rows[0]["Msg"].ToString();
            }
            else txtMsg.Text = "";
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            Avaliar_Pedido cad = new Avaliar_Pedido(num_ped);
            panel1.Visible = true;
            cad.TopLevel = false;
            if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(cad);
            cad.FormBorderStyle = FormBorderStyle.None;
            cad.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Consulta_Cliente cad = new Consulta_Cliente(cli_id, lbCliente.Text);
            cad.ShowDialog();
        }

        private void txtMsg_Enter(object sender, EventArgs e)
        {
            lbPlaceholder.Text = "";
        }
    }
}
