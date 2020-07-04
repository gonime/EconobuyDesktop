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

namespace Econobuy_desktop.Telas_Mercado
{
    public partial class Consulta_Cliente : Form
    {

        MercadoModel mer = new MercadoModel();
        public Consulta_Cliente(int cli_id, string cliente)
        {
            InitializeComponent();

            preencherTela(cli_id, cliente);
        }

        private void preencherTela(int cli_id, string cliente)
        {
            label1.Text = cliente;
            label2.Text = "Avaliação: " + mer.consultarAvCliente(cli_id).ToString();
            DataTable avaliacoes = new DataTable();
            avaliacoes = mer.consultarCliente(cli_id);
            dataGridView1.DataSource = avaliacoes; 
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
