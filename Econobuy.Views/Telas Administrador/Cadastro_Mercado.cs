using Econobuy.Entities;
using Econobuy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econobuy
{
    public partial class Cadastro_Mercado : Form
    {
        int mer_id;
        int user = 0;
        string img;

        MercadoModel merm = new MercadoModel();
        EnderecoModel endm = new EnderecoModel();

        public Cadastro_Mercado(int id, int user_type)
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            if (id != 0) fillForEdit(id, user_type);
        }

        private void fillForEdit(int id, int user_type)
        {
            btnCadastrar.Text = "Alterar";
            DataTable info = new DataTable();
            info = merm.selecionarParaEdicao(id);
            txtRazSoc.Text = info.Rows[0]["Razão_Social"].ToString();
            txtCPNJ.Text = info.Rows[0]["CPNJ"].ToString();
            txtCEP.Text = info.Rows[0]["CEP"].ToString();
            txtBairro.Text = info.Rows[0]["Bairro"].ToString();
            txtCidade.Text = info.Rows[0]["Cidade"].ToString();
            txtEstado.Text = info.Rows[0]["Estado"].ToString();
            txtEnd.Text = info.Rows[0]["Logradouro"].ToString();
            txtNum.Text = info.Rows[0]["Número"].ToString();
            txtEmail.Text = info.Rows[0]["Email"].ToString();
            txtTel1.Text = info.Rows[0]["tel1"].ToString();
            txtTel2.Text = info.Rows[0]["tel2"].ToString();
            byte[] img = merm.selecionaImagemParaEdicao(id);
            if (img != null)
            {
                MemoryStream mstream = new MemoryStream(img);
                pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
            }
            if (id != 0 && user_type == 1)
            {
                user = user_type;
                mer_id = id;
                txtUser.Enabled = false;
                txtSenha.Enabled = false;
                txtTel1.Enabled = false;
                txtTel2.Enabled = false;
                txtEmail.Enabled = false;
            }
            else if (id != 0 && user_type == 2)
            {
                user = user_type;
                mer_id = id;
                txtRazSoc.Enabled = false;
                txtCPNJ.Enabled = false;
                txtCEP.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtEstado.Enabled = false;
                txtEnd.Enabled = false;
                txtNum.Enabled = false;
                btnValidar.Enabled = false;
                txtUser.Text = info.Rows[0]["username"].ToString();
                txtSenha.Text = info.Rows[0]["senha"].ToString();
            }
        }

        private bool checkFilledSpaces()
        {
            bool var = true;
            if (txtRazSoc.Text == "" || txtUser.Text == "" || txtSenha.Text == "" || txtEmail.Text == "" ||
                txtTel1.Text == "" || txtEnd.Text == "" || txtCEP.Text == "" || txtCPNJ.Text == "" || txtCidade.Text == "" ||
                txtNum.Text == "" || txtEstado.Text == "" || lbValidEmail.Text != ""
                ) var = false;
            else if (validaEmail(txtEmail.Text) == false || validaSenha(txtSenha.Text) == false) var = false;
            return var;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (checkFilledSpaces() || user != 0)
            {
                byte[] image_byte = null;
                if (!string.IsNullOrEmpty(img))
                {
                    FileStream fstream = new FileStream(this.img, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fstream);

                    image_byte = br.ReadBytes((int)fstream.Length);
                }
                Mercado mer = new Mercado()
                {
                    Id = 0,
                    Name = txtRazSoc.Text,
                    User = txtUser.Text,
                    Senha = txtSenha.Text,
                    Cpnj = txtCPNJ.Text,
                    Email = txtEmail.Text, 
                    Imagem_Mercado = image_byte
                };
                Endereco end = new Endereco()
                {
                    Id = 0,
                    Logradouro = txtEnd.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Numero = txtNum.Text,
                    CEP = txtCEP.Text,
                    Uf = txtEstado.Text,
                    Cell = txtTel1.Text,
                    Tel = txtTel2.Text
                };
                if (merm.verificaUsuarioDisponivel(mer.User) && user != 2) MessageBox.Show("Nome de usuário já cadastrado, insira novo nome");
                else
                {
                    if (user == 0)
                    {
                        end.Id = endm.inserirEnderecoMercado(end);
                        mer.Id = merm.inserirMercado(mer, end.Id);
                        if (mer.Id != 0) MessageBox.Show("Cadastrado com sucesso!");
                        else MessageBox.Show("Problema ao cadastrar, verifique os campos novamente");
                    }
                    else if(user == 1)
                    {
                        if (merm.alterarMercadoAdmin(mer_id, mer, end)) MessageBox.Show("Cadastrado com sucesso!");
                        else MessageBox.Show("Problema ao alterar, verifique os campos novamente");
                    }
                    else
                    {
                        if (merm.alterarMercado(mer_id, mer, end)) MessageBox.Show("Cadastrado com sucesso!");
                        else MessageBox.Show("Problema ao alterar, verifique os campos novamente");
                    }
                }
            }
            else { MessageBox.Show("Preencha todos os campos obrigatórios"); }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            validaCEP();
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
            txtEnd.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtEnd.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtNum.Enabled = false;
            try
            {
                var ws = new Econobuy_desktop.WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(txtCEP.Text);
                txtEnd.Text = resposta.end;
                txtBairro.Text = resposta.bairro;
                txtCidade.Text = resposta.cidade;
                txtEstado.Text = resposta.uf;
                if (txtEnd.Text == "") txtEnd.Enabled = true;
                if (txtBairro.Text == "") txtBairro.Enabled = true;
                if (txtCidade.Text == "") txtCidade.Enabled = true;
                if (txtEstado.Text == "") txtEstado.Enabled = true;
                txtNum.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CEP não encontrado");
            }
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|" +
                "PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img = dialog.FileName.ToString();
                pictureBox1.ImageLocation = img;
            }
        }
    }
}
