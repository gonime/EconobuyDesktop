using Econobuy;
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
    public partial class Consulta_Produtos : Form
    {

        public Consulta_Produtos()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            panel1.Size = this.Size;
        }

        
        ProdutoModel pro = new ProdutoModel();

        private void Visualiza_produtos_mercado_Load(object sender, EventArgs e)
        {
            preencherDataGrid();
        }

        int product_id = 0;
        int active = 0;
        int trad_active = 0;

        private void preencherDataGrid()
        {
            DataTable dt = new DataTable();
            dt = pro.visualizarProdutosMercado(Econobuy.Login.user_id);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0) dataGridView1.Columns["Registro"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) {
                active = 0;
                trad_active = 0;
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            product_id = Convert.ToInt32(selectedRow.Cells[0].Value);
            active = Convert.ToInt32(selectedRow.Cells[5].Value);
            trad_active = Convert.ToInt32(selectedRow.Cells[4].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (product_id == 0) { }
            else
            {
                Cadastro_Produto cad = new Cadastro_Produto(product_id);
                panel1.Visible = true;
                cad.TopLevel = false;
                if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
                panel1.Controls.Add(cad);
                cad.FormBorderStyle = FormBorderStyle.None;
                cad.Show();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (product_id == 0) { }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este produto?\nEsta operação é irreversível",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pro.deletarProduto(product_id);
                    preencherDataGrid();
                }
            }
        }

        private void btnAtivarTrad_Click(object sender, EventArgs e)
        {
            if (product_id == 0) { }
            else if(trad_active == 1)
            {
                pro.desativarModoTradProduto(product_id);
                preencherDataGrid();
            }
            else{
                pro.ativarModoTradProduto(product_id);
                preencherDataGrid();
            }
        }

        private void btnAtivar1_Click(object sender, EventArgs e)
        {
            if (product_id == 0) { }
            else if(active == 1)
            {

                pro.desativarProduto(product_id);
                preencherDataGrid();
            }
            else{
                pro.ativarProduto(product_id);
                preencherDataGrid();
            }
        }

        private void textPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (cbPesquisar.Text == "") { }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                string.Format(cbPesquisar.Text + " LIKE '{0}%' OR " + cbPesquisar.Text + " LIKE '% {0}%'", textPesquisar.Text);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            product_id = Convert.ToInt32(selectedRow.Cells[0].Value);
            Cadastro_Produto cad = new Cadastro_Produto(product_id);
            panel1.Visible = true;
            cad.TopLevel = false;
            if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(cad);
            cad.FormBorderStyle = FormBorderStyle.None;
            cad.Show();
        }
        
    }
}
