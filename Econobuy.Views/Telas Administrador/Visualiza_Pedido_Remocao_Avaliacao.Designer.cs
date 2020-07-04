namespace Econobuy_desktop
{
    partial class Visualiza_Pedido_Remocao_Avaliacao
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
            this.txtDescAv = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNota = new System.Windows.Forms.Label();
            this.lbNomeAv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNomePed = new System.Windows.Forms.Label();
            this.txtDescRem = new System.Windows.Forms.RichTextBox();
            this.txtMsgAdm = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReprovar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescAv
            // 
            this.txtDescAv.Location = new System.Drawing.Point(6, 53);
            this.txtDescAv.Name = "txtDescAv";
            this.txtDescAv.ReadOnly = true;
            this.txtDescAv.Size = new System.Drawing.Size(239, 96);
            this.txtDescAv.TabIndex = 0;
            this.txtDescAv.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNota);
            this.groupBox1.Controls.Add(this.lbNomeAv);
            this.groupBox1.Controls.Add(this.txtDescAv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avaliação";
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(251, 53);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(43, 16);
            this.lbNota.TabIndex = 4;
            this.lbNota.Text = "Nota: ";
            // 
            // lbNomeAv
            // 
            this.lbNomeAv.AutoSize = true;
            this.lbNomeAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAv.Location = new System.Drawing.Point(6, 25);
            this.lbNomeAv.Name = "lbNomeAv";
            this.lbNomeAv.Size = new System.Drawing.Size(86, 16);
            this.lbNomeAv.TabIndex = 3;
            this.lbNomeAv.Text = "Requisitante:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNomePed);
            this.groupBox2.Controls.Add(this.txtDescRem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 166);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido de Remoção";
            // 
            // lbNomePed
            // 
            this.lbNomePed.AutoSize = true;
            this.lbNomePed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePed.Location = new System.Drawing.Point(6, 25);
            this.lbNomePed.Name = "lbNomePed";
            this.lbNomePed.Size = new System.Drawing.Size(86, 16);
            this.lbNomePed.TabIndex = 3;
            this.lbNomePed.Text = "Requisitante:";
            // 
            // txtDescRem
            // 
            this.txtDescRem.Location = new System.Drawing.Point(6, 53);
            this.txtDescRem.Name = "txtDescRem";
            this.txtDescRem.ReadOnly = true;
            this.txtDescRem.Size = new System.Drawing.Size(337, 96);
            this.txtDescRem.TabIndex = 0;
            this.txtDescRem.Text = "";
            // 
            // txtMsgAdm
            // 
            this.txtMsgAdm.Location = new System.Drawing.Point(9, 32);
            this.txtMsgAdm.Name = "txtMsgAdm";
            this.txtMsgAdm.Size = new System.Drawing.Size(347, 96);
            this.txtMsgAdm.TabIndex = 4;
            this.txtMsgAdm.Text = "Escreva sua mensagem aqui";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReprovar);
            this.groupBox3.Controls.Add(this.btnAprovar);
            this.groupBox3.Controls.Add(this.txtMsgAdm);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 144);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Responder Pedido";
            // 
            // btnReprovar
            // 
            this.btnReprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprovar.Location = new System.Drawing.Point(476, 92);
            this.btnReprovar.Name = "btnReprovar";
            this.btnReprovar.Size = new System.Drawing.Size(146, 36);
            this.btnReprovar.TabIndex = 6;
            this.btnReprovar.Text = "Reprovar pedido";
            this.btnReprovar.UseVisualStyleBackColor = false;
            this.btnReprovar.Click += new System.EventHandler(this.btnReprovar_Click);
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.Location = new System.Drawing.Point(476, 32);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(146, 36);
            this.btnAprovar.TabIndex = 5;
            this.btnAprovar.Text = "Aprovar pedido";
            this.btnAprovar.UseVisualStyleBackColor = false;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // Visualiza_Pedido_Remocao_Avaliacao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 370);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Visualiza_Pedido_Remocao_Avaliacao";
            this.Text = "Visualiza_pedido_remocao_admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescAv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Label lbNomeAv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNomePed;
        private System.Windows.Forms.RichTextBox txtDescRem;
        private System.Windows.Forms.RichTextBox txtMsgAdm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReprovar;
        private System.Windows.Forms.Button btnAprovar;
    }
}