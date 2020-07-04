namespace Econobuy_desktop.Telas_Mercado
{
    partial class Relatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnTipos1 = new System.Windows.Forms.Panel();
            this.pnTipos2 = new System.Windows.Forms.Panel();
            this.btnTipo3 = new System.Windows.Forms.Button();
            this.btnTipo2 = new System.Windows.Forms.Button();
            this.btnTipo1 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnTipos1.SuspendLayout();
            this.pnTipos2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filtros:";
            this.label1.Visible = false;
            // 
            // textPesquisar
            // 
            this.textPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisar.Location = new System.Drawing.Point(412, 19);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(486, 22);
            this.textPesquisar.TabIndex = 35;
            this.textPesquisar.Visible = false;
            // 
            // cbPesquisar
            // 
            this.cbPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPesquisar.FormattingEnabled = true;
            this.cbPesquisar.Items.AddRange(new object[] {
            "Cliente",
            "Cidade",
            "Status",
            "Logradouro"});
            this.cbPesquisar.Location = new System.Drawing.Point(285, 19);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(121, 24);
            this.cbPesquisar.TabIndex = 34;
            this.cbPesquisar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 377);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(11, 53);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(85, 33);
            this.btnProdutos.TabIndex = 38;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(11, 92);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(85, 33);
            this.btnPedidos.TabIndex = 39;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(11, 13);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(85, 33);
            this.btnClientes.TabIndex = 40;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnTipos1
            // 
            this.pnTipos1.Controls.Add(this.btnProdutos);
            this.pnTipos1.Controls.Add(this.btnClientes);
            this.pnTipos1.Controls.Add(this.btnPedidos);
            this.pnTipos1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTipos1.Location = new System.Drawing.Point(0, 0);
            this.pnTipos1.Name = "pnTipos1";
            this.pnTipos1.Size = new System.Drawing.Size(102, 496);
            this.pnTipos1.TabIndex = 41;
            // 
            // pnTipos2
            // 
            this.pnTipos2.Controls.Add(this.btnTipo3);
            this.pnTipos2.Controls.Add(this.btnTipo2);
            this.pnTipos2.Controls.Add(this.btnTipo1);
            this.pnTipos2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTipos2.Location = new System.Drawing.Point(102, 0);
            this.pnTipos2.Name = "pnTipos2";
            this.pnTipos2.Size = new System.Drawing.Size(120, 496);
            this.pnTipos2.TabIndex = 42;
            this.pnTipos2.Visible = false;
            // 
            // btnTipo3
            // 
            this.btnTipo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTipo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipo3.Location = new System.Drawing.Point(6, 92);
            this.btnTipo3.Name = "btnTipo3";
            this.btnTipo3.Size = new System.Drawing.Size(109, 33);
            this.btnTipo3.TabIndex = 40;
            this.btnTipo3.UseVisualStyleBackColor = false;
            this.btnTipo3.Click += new System.EventHandler(this.btnTipo3_Click);
            // 
            // btnTipo2
            // 
            this.btnTipo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipo2.Location = new System.Drawing.Point(6, 53);
            this.btnTipo2.Name = "btnTipo2";
            this.btnTipo2.Size = new System.Drawing.Size(109, 33);
            this.btnTipo2.TabIndex = 38;
            this.btnTipo2.UseVisualStyleBackColor = false;
            this.btnTipo2.Click += new System.EventHandler(this.btnTipo2_Click);
            // 
            // btnTipo1
            // 
            this.btnTipo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipo1.Location = new System.Drawing.Point(6, 13);
            this.btnTipo1.Name = "btnTipo1";
            this.btnTipo1.Size = new System.Drawing.Size(109, 33);
            this.btnTipo1.TabIndex = 39;
            this.btnTipo1.UseVisualStyleBackColor = false;
            this.btnTipo1.Click += new System.EventHandler(this.btnTipo1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(765, 406);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 33);
            this.btnSalvar.TabIndex = 43;
            this.btnSalvar.Text = "Salvar Relatório";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(612, 406);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 33);
            this.btnPrint.TabIndex = 44;
            this.btnPrint.Text = "Imprimir Relatório";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 496);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnTipos2);
            this.Controls.Add(this.pnTipos1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPesquisar);
            this.Controls.Add(this.cbPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Relatorios";
            this.Text = "Relatórios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnTipos1.ResumeLayout(false);
            this.pnTipos2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnTipos1;
        private System.Windows.Forms.Panel pnTipos2;
        private System.Windows.Forms.Button btnTipo2;
        private System.Windows.Forms.Button btnTipo1;
        private System.Windows.Forms.Button btnTipo3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPrint;
    }
}