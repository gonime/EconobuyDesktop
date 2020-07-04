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
    public partial class Consulta_Pedidos_Remocao_Avaliacao : Form
    {
        AdministradorModel adm = new AdministradorModel();
        int ped_id;

        public Consulta_Pedidos_Remocao_Avaliacao()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            preencherDataGrid();

            panel1.Size = this.Size;
        }

        private void txtPesquisarMercado_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("Mercado LIKE '{0}%' OR Mercado LIKE '% {0}%'", txtPesquisarMercado.Text);
        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("Cliente LIKE '{0}%' OR Cliente LIKE '% {0}%'", txtPesquisarCliente.Text);
        }

        private void preencherDataGrid()
        {
            DataTable dt = new DataTable();
            dt = adm.verPedidosRemocaoMercado();
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0) dataGridView1.Columns["codigo"].Visible = false;
            dataGridView1.Font = new Font("MicrosoftSansSerif", 10);
            DataTable dt2 = new DataTable();
            dt2 = adm.verPedidosRemocaoCliente();
            dataGridView2.DataSource = dt2;
            if (dt2.Rows.Count > 0) dataGridView2.Columns["codigo"].Visible = false;
            dataGridView2.Font = new Font("MicrosoftSansSerif", 10);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(ped_id != 0)
            {
                Visualiza_Pedido_Remocao_Avaliacao cad = new Visualiza_Pedido_Remocao_Avaliacao(ped_id, 1);
                panel1.Visible = true;
                cad.TopLevel = false;
                if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
                panel1.Controls.Add(cad);
                cad.FormBorderStyle = FormBorderStyle.None;
                cad.Show();
            }
        }

        private void btnVisualizar2_Click(object sender, EventArgs e)
        {
            if (ped_id != 0)
            {
                Visualiza_Pedido_Remocao_Avaliacao cad = new Visualiza_Pedido_Remocao_Avaliacao(ped_id, 2);
                panel1.Visible = true;
                cad.TopLevel = false;
                if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
                panel1.Controls.Add(cad);
                cad.FormBorderStyle = FormBorderStyle.None;
                cad.Show();
            }
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
            Visualiza_Pedido_Remocao_Avaliacao cad = new Visualiza_Pedido_Remocao_Avaliacao(ped_id, 1);
            panel1.Visible = true;
            cad.TopLevel = false;
            if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(cad);
            cad.FormBorderStyle = FormBorderStyle.None;
            cad.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            ped_id = Convert.ToInt32(selectedRow.Cells[0].Value);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            ped_id = Convert.ToInt32(selectedRow.Cells[0].Value);
            Visualiza_Pedido_Remocao_Avaliacao cad = new Visualiza_Pedido_Remocao_Avaliacao(ped_id, 2);
            panel1.Visible = true;
            cad.TopLevel = false;
            if (panel1.Controls.Count != 0) panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(cad);
            cad.FormBorderStyle = FormBorderStyle.None;
            cad.Show();
        }
    }
}
