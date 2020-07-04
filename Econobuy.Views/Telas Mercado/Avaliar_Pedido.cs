using Econobuy.Models;
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
    public partial class Avaliar_Pedido : Form
    {
        int num_ped;
        MercadoModel mer = new MercadoModel();

        public Avaliar_Pedido(int ped_id)
        {
            InitializeComponent();


            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            num_ped = ped_id;
            if(mer.verificaSeJaFoiAvaliado(num_ped)) preencherAvaliacaoMercado();
            else 
            { 
                txtDescAvMer.ReadOnly = false;
                txtDescAvMer.Enabled = true;
            }
            if (mer.verificaSeExistePedidoDeRemocao(num_ped)) preencherPedidoDeRemocao();  
            
        }

        public void preencherPedidoDeRemocao()
        {
            DataTable dt = mer.verPedidoDeRemocao(num_ped);
            txtDescRem.Text = dt.Rows[0]["Msg_mer"].ToString();
            string status = dt.Rows[0]["Stat"].ToString();
            lbStatusPedido.Text = "Status: " + status;
            lbStatusPedido.Visible = true;
            txtDescRem.ReadOnly = true;
            BtnPedRem.Visible = false;
            if (Equals(status, "Em análise") == false)
            {
                txtMsgAdm.Text = dt.Rows[0]["Msg_adm"].ToString();
                txtMsgAdm.Visible = true;
            }
        }

        public void preencherAvaliacaoMercado()
        {
            DataTable dt = mer.preencheAvaliacaoCliente(num_ped);
            txtDescAvMer.Text = dt.Rows[0]["Descricao"].ToString();
            lbNota.Text = "Avaliação: " + dt.Rows[0]["Nota"].ToString();
            txtDescAvMer.ReadOnly = true;
            cbNota.Visible = false;
            lbNota.Visible = true;
        }

        public void preencherAvaliacaoCliente()
        {
            DataTable dt = mer.verAvCliente(num_ped);
            if (dt.Rows.Count > 0)
            {
                lbAvCli.Text = "Nota: " + dt.Rows[0]["Nota"].ToString();
                txtAvCli.Text = dt.Rows[0]["Descricao"].ToString();
            }
            else
            {
                lbAvCli.Text = "";
                txtAvCli.Text = "Pedido Ainda não avaliado";
                txtDescAvMer.Enabled = false;
                BtnPedRem.Enabled = false;
            }
        } 

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            if (Equals(cbNota.Text, "") == false)
            {
                bool var = mer.avaliarPedido(num_ped, Convert.ToDouble(cbNota.Text), txtDescAvMer.Text);
                if (var) MessageBox.Show("Avaliação Cadastrada");
            }
        }

        private void BtnPedRem_Click(object sender, EventArgs e)
        {
            bool var = mer.inserirPedidoDeRemocao(num_ped, txtDescRem.Text);
            if (var) MessageBox.Show("Pedido enviado");
        }

        private void Visualiza_avaliacao_mercado_Load(object sender, EventArgs e)
        {
            preencherAvaliacaoCliente();
        }
    }
}
