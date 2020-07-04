using Econobuy;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econobuy_desktop
{
    public partial class Cadastro_Produto : Form
    {
        int produto_id;
        string img = null;

        public Cadastro_Produto(int prod_id)
        {
            InitializeComponent();
            FillComboCategoria01();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            AplicarEventos(textValor);

            produto_id = prod_id;
            if (prod_id != 0)
            {
                buttonCadastrar.Text = "Alterar";
                DataTable info = new DataTable();
                ProdutoModel pro = new ProdutoModel();
                info = pro.trazerInformacoes(prod_id);
                textNome.Text = info.Rows[0]["nome"].ToString();
                textValor.Text = info.Rows[0]["valor"].ToString();
                textDescricao.Text = info.Rows[0]["descricao"].ToString();
                textCodigo.Text = info.Rows[0]["mer"].ToString();
                comboCategoria.Text = info.Rows[0]["cat01"].ToString();
                comboCategoria2.Text = info.Rows[0]["cat02"].ToString();
                comboCategoria3.Text = info.Rows[0]["cat03"].ToString();
                comboCategoria.Enabled = false;
                comboCategoria2.Enabled = false;
                comboCategoria3.Enabled = false;
                if (Convert.ToBoolean(info.Rows[0]["trad"])) cbAtivarTradicional.Checked = true;
                byte[] img = pro.buscarImagem(prod_id);
                if(img != null)
                {
                    MemoryStream mstream = new MemoryStream(img);
                    pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                } 
            }
        }

        private void FillComboCategoria01()
        {
            ProdutoModel pro = new ProdutoModel();
            List<string> categorias = new List<string>();
            categorias = pro.trazerCategoria01();
            foreach(string categoria in categorias)
            {
                comboCategoria.Items.Add(categoria);
            }
        }

        private void FillComboCategoria02(string cat)
        {
            comboCategoria2.Items.Clear();
            ProdutoModel pro = new ProdutoModel();
            List<string> categorias = new List<string>();
            categorias = pro.trazerCategoria02(pro.trazerCategoria01ID(cat));
            foreach (string categoria in categorias)
            {
                comboCategoria2.Items.Add(categoria);
            }
        }

        private void FillComboCategoria03(string cat)
        {
            comboCategoria3.Items.Clear();
            ProdutoModel pro = new ProdutoModel();
            List<string> categorias = new List<string>();
            categorias = pro.trazerCategoria03(pro.trazerCategoria02ID(cat));
            foreach (string categoria in categorias)
            {
                comboCategoria3.Items.Add(categoria);
            }
        }
        

        private void comboCategoria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCategoria3.Text = "";
            FillComboCategoria03(comboCategoria2.Text);
            comboCategoria3.Enabled = true;
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCategoria2.Text = "";
            FillComboCategoria02(comboCategoria.Text);
            comboCategoria2.Enabled = true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (checaCamposPreenchidos())
            {
                byte[] image_byte = null;
                if (img != null)
                {
                    FileStream fstream = new FileStream(this.img, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fstream);
                    image_byte = br.ReadBytes((int)fstream.Length);

                }
                Produto p = new Produto()
                {
                    Nome = textNome.Text,
                    Descricao = textDescricao.Text,
                    Valor_unidade = Convert.ToDecimal(textValor.Text),
                    Codigo_estoque = textCodigo.Text,
                    Categoria01 = comboCategoria.Text,
                    Categoria02 = comboCategoria2.Text,
                    Categoria03 = comboCategoria3.Text,
                    Trad_active = cbAtivarTradicional.Checked,
                    Imagem_produto = image_byte,
                    Cat01ID = 0,
                    Cat02ID = 0,
                    Cat03ID = 0,
                    ProdID = 0
                };
                ProdutoModel pro = new ProdutoModel();
                if (produto_id != 0) { if (pro.alterarProduto(p, produto_id))
                    {
                        MessageBox.Show("Alterado com sucesso");
                        this.Hide();
                    }
                }
                else if(pro.inserirProduto(p, Login.user_id)) MessageBox.Show("Cadastrado com sucesso");
            }
            else MessageBox.Show("Preencha todos os campos!");
        }

        private bool checaCamposPreenchidos()
        {
            bool var = false;
            if (textNome.Text == "" || textDescricao.Text == "" || textValor.Text == "0,00" || textCodigo.Text == "" || comboCategoria.Text == ""
                || comboCategoria2.Text == "" || comboCategoria3.Text == "") var = false;
            else var = true;
            return var;
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox textValor = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
               e.Handled = true;
            }
        }

        private void AplicarEventos(TextBox textValor)
        {
            textValor.KeyPress += ApenasValorNumerico;
        }

        public static void textValorMask(ref TextBox txt)
        {
            string n = string.Empty;
            try
            {
                double v = 0;
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals("")) n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0") n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception ex)
            {

            }
        }

        private void textValor_TextChanged(object sender, EventArgs e)
        {
            textValorMask(ref textValor);
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|" +
                "PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                img = dialog.FileName.ToString();
                pictureBox1.ImageLocation = img;
            }
        }
    }
}
