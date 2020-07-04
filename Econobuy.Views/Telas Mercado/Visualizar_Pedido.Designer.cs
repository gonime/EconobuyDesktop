namespace Econobuy_desktop
{
    partial class Visualizar_Pedido
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
            this.lbAvCliente = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lbAvaliacao = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReprovar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTel2 = new System.Windows.Forms.Label();
            this.lbTel1 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbCompl = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.lbPlaceholder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbAvCliente);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.lbAvaliacao);
            this.groupBox1.Controls.Add(this.lbValor);
            this.groupBox1.Controls.Add(this.btnAvaliar);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.lbBairro);
            this.groupBox1.Controls.Add(this.lbCidade);
            this.groupBox1.Controls.Add(this.lbCEP);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.lbCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido";
            // 
            // lbAvCliente
            // 
            this.lbAvCliente.AutoSize = true;
            this.lbAvCliente.Location = new System.Drawing.Point(333, 24);
            this.lbAvCliente.Name = "lbAvCliente";
            this.lbAvCliente.Size = new System.Drawing.Size(135, 16);
            this.lbAvCliente.TabIndex = 21;
            this.lbAvCliente.Text = "Avaliação do Cliente:";
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(544, 18);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(107, 28);
            this.btnCliente.TabIndex = 20;
            this.btnCliente.Text = "Ver Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lbAvaliacao
            // 
            this.lbAvaliacao.AutoSize = true;
            this.lbAvaliacao.Location = new System.Drawing.Point(333, 96);
            this.lbAvaliacao.Name = "lbAvaliacao";
            this.lbAvaliacao.Size = new System.Drawing.Size(72, 16);
            this.lbAvaliacao.TabIndex = 6;
            this.lbAvaliacao.Text = "Avaliação:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(333, 73);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(43, 16);
            this.lbValor.TabIndex = 5;
            this.lbValor.Text = "Valor:";
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAvaliar.Enabled = false;
            this.btnAvaliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.Location = new System.Drawing.Point(544, 90);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(107, 28);
            this.btnAvaliar.TabIndex = 15;
            this.btnAvaliar.Text = "Avaliar Pedido";
            this.btnAvaliar.UseVisualStyleBackColor = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(333, 48);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(51, 16);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status: ";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(16, 119);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(47, 16);
            this.lbBairro.TabIndex = 4;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(16, 96);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(55, 16);
            this.lbCidade.TabIndex = 3;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(16, 73);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(38, 16);
            this.lbCEP.TabIndex = 2;
            this.lbCEP.Text = "CEP:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(16, 48);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(40, 16);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data:";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(16, 24);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(52, 16);
            this.lbCliente.TabIndex = 0;
            this.lbCliente.Text = "Cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnReprovar
            // 
            this.btnReprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprovar.Location = new System.Drawing.Point(588, 411);
            this.btnReprovar.Name = "btnReprovar";
            this.btnReprovar.Size = new System.Drawing.Size(75, 23);
            this.btnReprovar.TabIndex = 10;
            this.btnReprovar.Text = "Reprovar";
            this.btnReprovar.UseVisualStyleBackColor = false;
            this.btnReprovar.Click += new System.EventHandler(this.btnReprovar_Click);
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.Location = new System.Drawing.Point(588, 382);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(75, 23);
            this.btnAprovar.TabIndex = 9;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = false;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lbTel2);
            this.groupBox2.Controls.Add(this.lbTel1);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 78);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(559, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Comentário";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbTel2
            // 
            this.lbTel2.AutoSize = true;
            this.lbTel2.Location = new System.Drawing.Point(251, 48);
            this.lbTel2.Name = "lbTel2";
            this.lbTel2.Size = new System.Drawing.Size(0, 16);
            this.lbTel2.TabIndex = 2;
            this.lbTel2.Visible = false;
            // 
            // lbTel1
            // 
            this.lbTel1.AutoSize = true;
            this.lbTel1.Location = new System.Drawing.Point(16, 48);
            this.lbTel1.Name = "lbTel1";
            this.lbTel1.Size = new System.Drawing.Size(75, 16);
            this.lbTel1.TabIndex = 1;
            this.lbTel1.Text = "Telefone 1:";
            this.lbTel1.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(16, 24);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(305, 16);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Aprove o pedido para ver informações de contato";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lbCompl);
            this.groupBox3.Controls.Add(this.lbLog);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 78);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(559, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver Comentário";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbCompl
            // 
            this.lbCompl.AutoSize = true;
            this.lbCompl.Location = new System.Drawing.Point(16, 48);
            this.lbCompl.Name = "lbCompl";
            this.lbCompl.Size = new System.Drawing.Size(98, 16);
            this.lbCompl.TabIndex = 1;
            this.lbCompl.Text = "Complemento: ";
            this.lbCompl.Visible = false;
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(16, 24);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(223, 16);
            this.lbLog.TabIndex = 0;
            this.lbLog.Text = "Aprove o pedido para ver endereço";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 496);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(519, 172);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(312, 149);
            this.txtMsg.TabIndex = 11;
            this.txtMsg.Text = "";
            this.txtMsg.Enter += new System.EventHandler(this.txtMsg_Enter);
            // 
            // lbPlaceholder
            // 
            this.lbPlaceholder.AutoSize = true;
            this.lbPlaceholder.BackColor = System.Drawing.Color.White;
            this.lbPlaceholder.Location = new System.Drawing.Point(527, 175);
            this.lbPlaceholder.Name = "lbPlaceholder";
            this.lbPlaceholder.Size = new System.Drawing.Size(294, 13);
            this.lbPlaceholder.TabIndex = 20;
            this.lbPlaceholder.Text = "Envie uma mensagem para seu cliente utilizando este campo";
            // 
            // Visualizar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAprovar);
            this.Controls.Add(this.btnReprovar);
            this.Controls.Add(this.lbPlaceholder);
            this.Controls.Add(this.txtMsg);
            this.Name = "Visualizar_Pedido";
            this.Text = "Visualiza_pedido_unico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Visualiza_pedido_unico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbAvaliacao;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.Button btnReprovar;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTel2;
        private System.Windows.Forms.Label lbTel1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbCompl;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lbAvCliente;
        private System.Windows.Forms.Label lbPlaceholder;
    }
}