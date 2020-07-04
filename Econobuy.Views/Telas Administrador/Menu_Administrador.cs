using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Econobuy.Entities;
using System.Data.SqlClient;
using Econobuy.Models;
using Econobuy_desktop;

namespace Econobuy
{
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador()
        {
            InitializeComponent();
            Administrador u = new Administrador()
            {
                Id = Login.user_id,
            };
            AdministradorModel m = new AdministradorModel();
            lbNomeAdmin.Text = m.consultarNomeAdmin(u);
            checkPermissoes(m.verificarPermissoes(u.Id)); 
        }

        
        private void btnConsulMercado_Click(object sender, EventArgs e)
        {
            Consulta_Usuarios_Mercados tela = new Consulta_Usuarios_Mercados();
            abrirPainel(tela);
        }

        private void btnCadastroMercado_Click(object sender, EventArgs e)
        {
            Cadastro_Mercado tela = new Cadastro_Mercado(0, 0);
            abrirPainel(tela);
        }

        private void btnPedidoRemocao_Click(object sender, EventArgs e)
        {
            Consulta_Pedidos_Remocao_Avaliacao tela = new Consulta_Pedidos_Remocao_Avaliacao();
            abrirPainel(tela);
        }

        private void btnCadastroAdmin_Click(object sender, EventArgs e)
        {
            Cadastro_Admin tela = new Cadastro_Admin();
            abrirPainel(tela);
        }

        public void checkPermissoes(int[] permissoes)
        {
            if (permissoes[0] == 0) btnCadastroMercado.Enabled = false;
            if (permissoes[1] == 0) btnCadastroAdmin.Enabled = false;
            if (permissoes[2] == 0) btnConsulMercado.Enabled = false;
            if (permissoes[3] == 0) btnPedidoRemocao.Enabled = false;
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

    }
}
