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
    public partial class Consulta_Usuarios_Mercados : Form
    {
        int mer_id = 0;
        int end_id = 0;
        int active = 0;

        public Consulta_Usuarios_Mercados()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            panel1.Size = this.Size;
        }

        private void Consulta_usuario_mercado_Load(object sender, EventArgs e)
        {
            preencherDataGrid();
        }

        private void preencherDataGrid()
        {
            MercadoModel mer = new MercadoModel();
            DataTable dt = new DataTable();
            dt = mer.trazerInformacoes();
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns["mer_cod"].Visible = false;
                dataGridView1.Columns["en_cod"].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            mer_id = Convert.ToInt32(selectedRow.Cells[0].Value);
            end_id = Convert.ToInt32(selectedRow.Cells[1].Value);
            active = Convert.ToInt32(selectedRow.Cells[2].Value);
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

        private void btnAtivar1_Click(object sender, EventArgs e)
        {
            if (mer_id == 0) { }
            else
            {
                MercadoModel mer = new MercadoModel();
                if (active == 0) mer.ativarMercado(mer_id);
                else mer.desativarMercado(mer_id);
                preencherDataGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (mer_id == 0) { }
            else
            {
                Cadastro_Mercado cad = new Cadastro_Mercado(mer_id, 1);
                panel1.Visible = true;
                cad.TopLevel = false;
                if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
                panel1.Controls.Add(cad);
                cad.FormBorderStyle = FormBorderStyle.None;
                cad.Show();
            }
        }
    }
}
