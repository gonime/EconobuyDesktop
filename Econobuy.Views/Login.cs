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
using Econobuy.Models;
using Econobuy_desktop;

namespace Econobuy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            CenterToScreen();
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cbMercado.Checked = !cbAdmin.Checked;
        }

        private void cbMercado_CheckedChanged(object sender, EventArgs e)
        {
            cbAdmin.Checked = !cbMercado.Checked;
        }

        public static int user_id = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (cbAdmin.Checked)
            {
                Administrador user = new Administrador
                {
                    User = txtUser.Text,
                    Senha = txtSenha.Text
                };
                AdministradorModel login = new AdministradorModel();
                int id = login.acessarAdmin(user);
                if (id == 0)
                {
                    txtMensagem.Text = "Login ou senha incorretos!";
                }
                else
                {
                    user_id = id;
                    this.Hide();
                    Menu_Administrador menu = new Menu_Administrador();
                    menu.ShowDialog();
                }
            }
            else if (cbMercado.Checked)
            {
                Mercado user = new Mercado
                {
                    User = txtUser.Text,
                    Senha = txtSenha.Text
                };
                MercadoModel login = new MercadoModel();
                int id = login.acessarMercado(user);
                if (id == 0)
                {
                    txtMensagem.Text = "Login ou senha incorretos!";
                }
                else
                {
                    user_id = id;
                    this.Hide();
                    Menu_Mercado menu = new Menu_Mercado();
                    menu.ShowDialog();
                }
            }
            else
            {
                txtMensagem.Text = "Selecione um tipo de usuário";
            }
        }

        private void lbEsqSenha_Click(object sender, EventArgs e)
        {
            RecuperarSenha tela = new RecuperarSenha();
            tela.ShowDialog();
        }

        private void lbEsqSenha_MouseHover(object sender, EventArgs e)
        {
            lbEsqSenha.Font = new Font(lbEsqSenha.Font.Name, lbEsqSenha.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lbEsqSenha_MouseLeave(object sender, EventArgs e)
        {
            lbEsqSenha.Font = new Font(lbEsqSenha.Font.Name, lbEsqSenha.Font.SizeInPoints, FontStyle.Regular);
        }
    }
}