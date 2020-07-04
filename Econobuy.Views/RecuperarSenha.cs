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
    public partial class RecuperarSenha : Form
    {
        MercadoModel m = new MercadoModel();
        AdministradorModel a = new AdministradorModel();
        public RecuperarSenha()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!validaEmail(txtEmail.Text)) lbValidEmail.Text = "Insira um e-mail válido";
            else lbValidEmail.Text = "";
        }

        private bool validaEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains(".")) return false;
            string[] campos = email.Split('@');
            if (campos.Length != 2) return false;
            if (campos[0].Length < 3) return false;
            if (!campos[1].Contains(".")) return false;
            campos = campos[1].Split('.');
            if (campos[0].Length < 3) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validaEmail(txtEmail.Text)) 
            {
                if (m.recuperarSenha(txtEmail.Text)) MessageBox.Show("Seus dados de acesso foram enviados para seu e-mail");
                else if (a.recuperarSenha(txtEmail.Text)) MessageBox.Show("Seus dados de acesso foram enviados para seu e-mail");
                else
                {
                    MessageBox.Show("E-mail não encontrado no sistema");
                }
            }
            else { lbValidEmail.Text = "Insira um e-mail válido"; }
        }
    }
}
