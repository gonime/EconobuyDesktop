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
    public partial class Visualiza_Pedido_Remocao_Avaliacao : Form
    {
        AdministradorModel adm = new AdministradorModel();
        int num_ped;
        int user;

        public Visualiza_Pedido_Remocao_Avaliacao(int ped_id, int ped_type)
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            preenchercampos(ped_id, ped_type);
            num_ped = ped_id;
            user = ped_type;
        }

        public void preenchercampos(int ped_id, int ped_type)
        {
            DataTable dt = new DataTable();
            if (ped_type == 1)
            {
                dt = adm.preencherPedidoRemocaoMercado(ped_id);
            }
            else
            {
                dt = adm.preencherPedidoRemocaoCliente(ped_id);
            }
            lbNomePed.Text = "Requisitante: " + dt.Rows[0]["requerente"].ToString();
            lbNomeAv.Text = "Avaliador: " + dt.Rows[0]["avaliador"].ToString();
            txtDescAv.Text = dt.Rows[0]["av_desc"].ToString();
            txtDescRem.Text = dt.Rows[0]["Msg_user"].ToString();
            lbNota.Text = "Nota: " + dt.Rows[0]["Nota"].ToString();
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            if (user == 2) { if (adm.aprovarPedidoRemocaoCliente(num_ped, txtMsgAdm.Text)) MessageBox.Show("Pedido aprovado"); }
            else if (adm.aprovarPedidoRemocaoMercado(num_ped, txtMsgAdm.Text)) MessageBox.Show("Pedido aprovado");
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            if (user == 2) { if (adm.reprovarPedidoRemocaoCliente(num_ped, txtMsgAdm.Text)) MessageBox.Show("Pedido reprovado"); }
            else if (adm.reprovarPedidoRemocaoMercado(num_ped, txtMsgAdm.Text)) MessageBox.Show("Pedido reprovado");
        }
    }
}
