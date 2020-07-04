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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;
using Spire.Pdf;
using Spire.Pdf.Annotations;
using Spire.Pdf.Widget;


namespace Econobuy_desktop.Telas_Mercado
{
    public partial class Relatorios : Form
    {
        int content = 0;
        int type = 0;
        DataTable dt = new DataTable();

        public Relatorios()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnTipos2.Visible = true;
            btnTipo1.Text = "Cadastrados";
            btnTipo2.Size = new Size(109, 33);
            btnTipo2.Text = "Vendidos";
            btnTipo3.Location = new Point(6, 92);
            btnTipo3.Size = new Size(109, 55);
            btnTipo3.Text = "A ser entregue";
            content = 1;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            pnTipos2.Visible = true;
            btnTipo1.Text = "Em aguardo";
            btnTipo2.Size = new Size(109, 33);
            btnTipo2.Text = "Entregues";
            btnTipo3.Location = new Point(6, 92);
            btnTipo3.Text = "Todos";
            btnTipo3.Size = new Size(109, 33);
            content = 2;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnTipos2.Visible = true;
            btnTipo1.Text = "Em aguardo";
            btnTipo2.Size = new Size(109, 55);
            btnTipo2.Text = "Pedido entregue";
            btnTipo3.Location = new Point(6, 115);
            btnTipo3.Text = "Todos";
            btnTipo3.Size = new Size(109, 33);
            content = 3;
        }

        private void preencherDataGrid(int type)
        {
            MercadoModel mer = new MercadoModel();
            if (content == 1)
            {
                dt = mer.relatorioProdutos(Econobuy.Login.user_id, type);
                dataGridView1.DataSource = dt;
            }
            else if (content == 2)
            {
                dt = mer.relatorioPedidos(Econobuy.Login.user_id, type);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count > 0) dataGridView1.Columns["COD"].Visible = false;
            }
            else
            {
                dt = mer.relatorioClientes(Econobuy.Login.user_id, type);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnTipo1_Click(object sender, EventArgs e)
        {
            if (content == 1)
            {
                type = 0;
                preencherDataGrid(type);
            }
            else if (content == 2)
            {
                type = 1;
                preencherDataGrid(type);
            }
            else
            {
                type = 1;
                preencherDataGrid(type);
            }
        }

        private void btnTipo2_Click(object sender, EventArgs e)
        {
            if (content == 1)
            {
                type = 1;
                preencherDataGrid(type);
            }
            else if (content == 2)
            {
                type = 2;
                preencherDataGrid(type);
            }
            else
            {
                type = 2;
                preencherDataGrid(type);
            }
        }

        private void btnTipo3_Click(object sender, EventArgs e)
        {
            if (content == 1)
            {
                type = 2;
                preencherDataGrid(type);
            }
            else if (content == 2)
            {
                type = 0;
                preencherDataGrid(type);
            }
            else
            {
                type = 0;
                preencherDataGrid(type);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                criarPDF(sfd.FileName);
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string printPath = Path.GetTempFileName();
            criarPDF(printPath);
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
           
            doc.LoadFromFile(printPath);
         
            PrintDialog dialogPrint = new PrintDialog();
            dialogPrint.AllowPrintToFile = true;
            dialogPrint.AllowSomePages = true;
            dialogPrint.PrinterSettings.MinimumPage = 1;
            dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
            dialogPrint.PrinterSettings.FromPage = 1;
            dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;
            
            if (dialogPrint.ShowDialog() == DialogResult.OK)
            {
                doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
                doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
                doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;
                PrintDocument printDoc = doc.PrintDocument;
                printDoc.Print();
            }

        }

        private void criarPDF(string path)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\GONIME\source\repos\Econobuy\Econobuy.Views\Repositório\Logo.png");
            img.ScaleAbsolute(50, 50);
            img.Alignment = Element.ALIGN_TOP;
            doc.Add(img);
            Paragraph titulo = new Paragraph();
            titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 40);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("\n\nRelatório Econobuy\n\n\n");
            doc.Add(titulo);
            Paragraph subtitulo = new Paragraph();
            subtitulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 30);
            subtitulo.Alignment = Element.ALIGN_CENTER;
            if (content == 1 && type == 0)
            {
                subtitulo.Add("Relatório de produtos cadastrados\n\n\n\n\n");
            }
            else if (content == 1 && type == 1)
            {
                subtitulo.Add("Relatório de produtos Vendidos\n\n\n\n\n");
            }
            else if (content == 1 && type == 2)
            {
                subtitulo.Add("Relatório de produtos a serem entregues\n\n\n\n\n");
            }
            else if (content == 2 && type == 0)
            {
                subtitulo.Add("Relatório de pedidos em aguardo\n\n\n\n\n");
            }
            else if (content == 2 && type == 1)
            {
                subtitulo.Add("Relatório de pedidos entregues\n\n\n\n\n");
            }
            else if (content == 2 && type == 2)
            {
                subtitulo.Add("Relatório de todos os pedidos\n\n\n\n\n");
            }
            else if (content == 3 && type == 0)
            {
                subtitulo.Add("Relatório de clientes aguardando aprovação\n\n\n\n\n");
            }
            else if (content == 3 && type == 1)
            {
                subtitulo.Add("Relatório de clientes com pedido entregue\n\n\n\n\n");
            }
            else if (content == 3 && type == 0)
            {
                subtitulo.Add("Relatório de todos os clientes\n\n\n\n\n");
            }
            doc.Add(subtitulo);
            PdfPTable table = new PdfPTable(dt.Columns.Count);

            table.WidthPercentage = 100;
            PdfPCell cell = new PdfPCell(new Phrase("Products"));
            iTextSharp.text.Font fnt = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8);
            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, fnt));
            }

            foreach (DataRow r in dt.Rows)
            {
                for (int i = 0; i <= cell.Colspan-1; i++)
                {
                    table.AddCell(new Phrase(r[i].ToString(), fnt));
                }
            }
            doc.Add(table); PrintDialog dialogPrint = new PrintDialog();
            doc.Close();
        }
    }
}
