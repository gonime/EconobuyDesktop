namespace Econobuy_desktop
{
    partial class Consulta_Avaliações
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
            this.btnVisualizarPedido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVisualizarAvaliacao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Pesquisar por nome:";
            // 
            // textPesquisar
            // 
            this.textPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisar.Location = new System.Drawing.Point(150, 9);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(405, 22);
            this.textPesquisar.TabIndex = 35;
            this.textPesquisar.TextChanged += new System.EventHandler(this.textPesquisar_TextChanged);
            // 
            // btnVisualizarPedido
            // 
            this.btnVisualizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVisualizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarPedido.Location = new System.Drawing.Point(423, 40);
            this.btnVisualizarPedido.Name = "btnVisualizarPedido";
            this.btnVisualizarPedido.Size = new System.Drawing.Size(132, 51);
            this.btnVisualizarPedido.TabIndex = 33;
            this.btnVisualizarPedido.Text = "Visualizar Pedido";
            this.btnVisualizarPedido.UseVisualStyleBackColor = false;
            this.btnVisualizarPedido.Click += new System.EventHandler(this.btnVisualizarPedido_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(402, 377);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnVisualizarAvaliacao
            // 
            this.btnVisualizarAvaliacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVisualizarAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAvaliacao.Location = new System.Drawing.Point(423, 97);
            this.btnVisualizarAvaliacao.Name = "btnVisualizarAvaliacao";
            this.btnVisualizarAvaliacao.Size = new System.Drawing.Size(132, 51);
            this.btnVisualizarAvaliacao.TabIndex = 37;
            this.btnVisualizarAvaliacao.Text = "Visualizar Avaliação";
            this.btnVisualizarAvaliacao.UseVisualStyleBackColor = false;
            this.btnVisualizarAvaliacao.Click += new System.EventHandler(this.btnVisualizarAvaliacao_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 510);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // Consulta_Avaliações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVisualizarAvaliacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPesquisar);
            this.Controls.Add(this.btnVisualizarPedido);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consulta_Avaliações";
            this.Text = "Avaliacao_cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.Button btnVisualizarPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVisualizarAvaliacao;
        private System.Windows.Forms.Panel panel1;
    }
}