namespace Econobuy_desktop
{
    partial class Avaliar_Pedido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNota = new System.Windows.Forms.Label();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.cbNota = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMsgAdm = new System.Windows.Forms.RichTextBox();
            this.lbStatusPedido = new System.Windows.Forms.Label();
            this.txtDescRem = new System.Windows.Forms.RichTextBox();
            this.lbAvCli = new System.Windows.Forms.Label();
            this.BtnPedRem = new System.Windows.Forms.Button();
            this.txtAvCli = new System.Windows.Forms.RichTextBox();
            this.txtDescAvMer = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDescAvMer);
            this.groupBox1.Controls.Add(this.lbNota);
            this.groupBox1.Controls.Add(this.btnAvaliar);
            this.groupBox1.Controls.Add(this.cbNota);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avalie o pedido";
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNota.Location = new System.Drawing.Point(507, 44);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(0, 20);
            this.lbNota.TabIndex = 3;
            this.lbNota.Visible = false;
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAvaliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.Location = new System.Drawing.Point(472, 91);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(127, 34);
            this.btnAvaliar.TabIndex = 2;
            this.btnAvaliar.Text = "Enviar Avaliação";
            this.btnAvaliar.UseVisualStyleBackColor = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // cbNota
            // 
            this.cbNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNota.FormattingEnabled = true;
            this.cbNota.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0"});
            this.cbNota.Location = new System.Drawing.Point(495, 44);
            this.cbNota.Name = "cbNota";
            this.cbNota.Size = new System.Drawing.Size(77, 24);
            this.cbNota.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMsgAdm);
            this.groupBox2.Controls.Add(this.lbStatusPedido);
            this.groupBox2.Controls.Add(this.txtDescRem);
            this.groupBox2.Controls.Add(this.lbAvCli);
            this.groupBox2.Controls.Add(this.BtnPedRem);
            this.groupBox2.Controls.Add(this.txtAvCli);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avaliação do cliente";
            // 
            // txtMsgAdm
            // 
            this.txtMsgAdm.Location = new System.Drawing.Point(444, 162);
            this.txtMsgAdm.Name = "txtMsgAdm";
            this.txtMsgAdm.Size = new System.Drawing.Size(215, 82);
            this.txtMsgAdm.TabIndex = 6;
            this.txtMsgAdm.Text = "";
            this.txtMsgAdm.Visible = false;
            // 
            // lbStatusPedido
            // 
            this.lbStatusPedido.AutoSize = true;
            this.lbStatusPedido.Location = new System.Drawing.Point(441, 137);
            this.lbStatusPedido.Name = "lbStatusPedido";
            this.lbStatusPedido.Size = new System.Drawing.Size(114, 16);
            this.lbStatusPedido.TabIndex = 5;
            this.lbStatusPedido.Text = "Status do Pedido:";
            this.lbStatusPedido.Visible = false;
            // 
            // txtDescRem
            // 
            this.txtDescRem.Location = new System.Drawing.Point(18, 134);
            this.txtDescRem.Name = "txtDescRem";
            this.txtDescRem.Size = new System.Drawing.Size(371, 110);
            this.txtDescRem.TabIndex = 4;
            this.txtDescRem.Text = "Caso ache a avaliação injusta, preencha este campo com o motivo e envie para um a" +
    "dministrador avaliar o caso";
            // 
            // lbAvCli
            // 
            this.lbAvCli.AutoSize = true;
            this.lbAvCli.Location = new System.Drawing.Point(459, 64);
            this.lbAvCli.Name = "lbAvCli";
            this.lbAvCli.Size = new System.Drawing.Size(75, 16);
            this.lbAvCli.TabIndex = 3;
            this.lbAvCli.Text = "Avaliação: ";
            // 
            // BtnPedRem
            // 
            this.BtnPedRem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPedRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedRem.Location = new System.Drawing.Point(444, 169);
            this.BtnPedRem.Name = "BtnPedRem";
            this.BtnPedRem.Size = new System.Drawing.Size(127, 44);
            this.BtnPedRem.TabIndex = 2;
            this.BtnPedRem.Text = "Enviar Pedido de Remoção";
            this.BtnPedRem.UseVisualStyleBackColor = false;
            this.BtnPedRem.Click += new System.EventHandler(this.BtnPedRem_Click);
            // 
            // txtAvCli
            // 
            this.txtAvCli.Location = new System.Drawing.Point(18, 19);
            this.txtAvCli.Name = "txtAvCli";
            this.txtAvCli.ReadOnly = true;
            this.txtAvCli.Size = new System.Drawing.Size(371, 110);
            this.txtAvCli.TabIndex = 0;
            this.txtAvCli.Text = "Avaliação do cliente";
            // 
            // txtDescAvMer
            // 
            this.txtDescAvMer.Location = new System.Drawing.Point(18, 29);
            this.txtDescAvMer.Name = "txtDescAvMer";
            this.txtDescAvMer.Size = new System.Drawing.Size(371, 96);
            this.txtDescAvMer.TabIndex = 7;
            this.txtDescAvMer.Text = "";
            // 
            // Avaliar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Avaliar_Pedido";
            this.Text = "Visualiza_avaliacao_mercado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Visualiza_avaliacao_mercado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.ComboBox cbNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnPedRem;
        private System.Windows.Forms.RichTextBox txtAvCli;
        private System.Windows.Forms.RichTextBox txtDescRem;
        private System.Windows.Forms.Label lbAvCli;
        private System.Windows.Forms.Label lbStatusPedido;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.RichTextBox txtMsgAdm;
        private System.Windows.Forms.RichTextBox txtDescAvMer;
    }
}