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
    public partial class Consulta_Avaliações : Form
    {
        int ped_id = 0;

        public Consulta_Avaliações()
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            preencherDataGrid();
            panel1.Size = this.Size;
        }

        private void preencherDataGrid()
        {
            MercadoModel mer = new MercadoModel();
            DataTable dt = new DataTable();
            dt = mer.verAvalicoesClientes(Econobuy.Login.user_id);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0) dataGridView1.Columns["codigo"].Visible = false;
        }

        private void textPesquisar_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("Cliente LIKE '{0}%' OR Cliente LIKE '% {0}%'", textPesquisar.Text);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            ped_id = Convert.ToInt32(selectedRow.Cells[0].Value);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            ped_id = Convert.ToInt32(selectedRow.Cells[0].Value);
            Visualizar_Pedido cad = new Visualizar_Pedido(ped_id);
            panel1.Visible = true;
            cad.TopLevel = false;
            if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(cad);
            cad.FormBorderStyle = FormBorderStyle.None;
            cad.Show();
        }

        private void btnVisualizarPedido_Click(object sender, EventArgs e)
        {
            if (ped_id != 0)
            {
                Visualizar_Pedido cad = new Visualizar_Pedido(ped_id);
                panel1.Visible = true;
                cad.TopLevel = false;
                if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
                panel1.Controls.Add(cad);
                cad.FormBorderStyle = FormBorderStyle.None;
                cad.Show();
            }
        }

        private void btnVisualizarAvaliacao_Click(object sender, EventArgs e)
        {
            Avaliar_Pedido cad = new Avaliar_Pedido(ped_id);
            panel1.Visible = true;
            cad.TopLevel = false;
            if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(cad);
            cad.FormBorderStyle = FormBorderStyle.None;
            cad.Show();
        }
    }
}
