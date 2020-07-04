using Econobuy.Entities;
using Econobuy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econobuy
{
    public partial class Cadastro_Admin : Form
    {
        public Cadastro_Admin()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Administrador menu = new Menu_Administrador();
            menu.ShowDialog();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (checkFilledSpaces())
            {
                Administrador adm = new Administrador()
                {
                    Id = 0,
                    Name = txtNome.Text,
                    User = txtUser.Text,
                    Senha = txtSenha.Text,
                    Email = txtEmail.Text,
                    Cadastro_administrador = cbCadastroAdministrador.Checked,
                    Cadastro_mercado = cbCadastroMercado.Checked,
                    Consulta_mercado = cbConsultaMercado.Checked,
                    Remover_avaliacao = cbRemocaoAvaliacao.Checked
                };
                Endereco end = new Endereco()
                {
                    Id = 0,
                    Cell = txtTel1.Text,
                    CEP = txtCEP.Text,
                    Uf = txtEstado.Text,
                    Cidade = txtCidade.Text,
                    Logradouro = txtLogradouro.Text
                };
                AdministradorModel admm = new AdministradorModel();
                EnderecoModel endm = new EnderecoModel();
                if (admm.verificaUsuarioDisponivel(adm.User)) MessageBox.Show("Nome de usuário já cadastrado, insira novo nome");
                else
                {
                    end.Id = endm.inserirEnderecoAdministrador(end);
                    adm.Id = admm.inserirAdministrador(adm, end.Id);
                    if (adm.Id != 0) MessageBox.Show("Cadastrado com sucesso!");
                    else MessageBox.Show("Problema ao cadastrar, verifique os campos novamente");
                }
            }
            else MessageBox.Show("Preencha todos os campos de cadastro!");
        }

        private bool checkFilledSpaces()
        {
            bool var = true;
            if (txtCEP.Text == "" || txtCidade.Text == "" || txtEmail.Text == "" || txtEstado.Text == "" ||
                txtLogradouro.Text == "" || txtNome.Text == "" || txtSenha.Text == ""
                || txtTel1.Text == "" || txtUser.Text == "") var = false;
            return var;
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

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (!validaSenha(txtSenha.Text)) lbValidSenha.Text = "A senha deve conter pelo menos 8 caracteres com letras e números";
            else lbValidSenha.Text = "";
        }

        private bool validaSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha) || senha.Length < 8) return false;
            else if (!Regex.IsMatch(senha, @"\d") || (!Regex.IsMatch(senha, "[a-zA-Z]"))) return false;
            else return true;
        }

        public void validaCEP()
        {
            txtLogradouro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtLogradouro.Enabled = false;
            try
            {
                var ws = new Econobuy_desktop.WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(txtCEP.Text);
                txtLogradouro.Text = resposta.end;
                txtCidade.Text = resposta.cidade;
                txtEstado.Text = resposta.uf;
                if (txtLogradouro.Text == "") txtLogradouro.Enabled = true;
                if (txtCidade.Text == "") txtCidade.Enabled = true;
                if (txtEstado.Text == "") txtEstado.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CEP não encontrado");
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            validaCEP();
        }
    }
}
