using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Econobuy.Entities;
using Econobuy.Models;
using Econobuy_desktop;
using System.IO;
using Econobuy_desktop.Telas_Mercado;

namespace Econobuy
{
    public partial class Menu_Mercado : Form
    {
        int mer_id;
        public Menu_Mercado()
        {
            InitializeComponent();

            mer_id = Login.user_id;
            MercadoModel m = new MercadoModel();
            lbNomeMercado.Text = m.consultarNomeMercado(mer_id);
            lbPedido.Text = m.contaPedidosEmAguardo(mer_id).ToString();
            byte[] img = m.selecionaImagemParaEdicao(mer_id);
            if (img != null)
            {
                MemoryStream mstream = new MemoryStream(img);
                pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
            }
        }

        public void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            Cadastro_Produto tela = new Cadastro_Produto(0);
            abrirPainel(tela);
        }

        private void btnConsulMercado_Click(object sender, EventArgs e)
        {
            Relatorios tela = new Relatorios();
            abrirPainel(tela);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Consulta_Pedidos tela = new Consulta_Pedidos();
            abrirPainel(tela);
        }

        private void btnConsulProduto_Click(object sender, EventArgs e)
        {
            Consulta_Produtos tela = new Consulta_Produtos();
            abrirPainel(tela);
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            Consulta_Avaliações tela = new Consulta_Avaliações();
            abrirPainel(tela);
        }

        public void abrirPainel(Form tela)
        {
            tela.TopLevel = false;
            if (pnPrincipal.Controls.Count != 0) pnPrincipal.Controls.RemoveAt(0);
            pnPrincipal.Controls.Add(tela);
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnAlteraUsuário_Click(object sender, EventArgs e)
        {
            Cadastro_Mercado tela = new Cadastro_Mercado(mer_id, 2);
            abrirPainel(tela);
        }
    }
}
