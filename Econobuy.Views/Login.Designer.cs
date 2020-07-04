namespace Econobuy
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtMensagem = new System.Windows.Forms.Label();
            this.lbEsqSenha = new System.Windows.Forms.Label();
            this.gbUserType = new System.Windows.Forms.GroupBox();
            this.cbMercado = new System.Windows.Forms.CheckBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMensagem.AutoSize = true;
            this.txtMensagem.BackColor = System.Drawing.Color.Transparent;
            this.txtMensagem.ForeColor = System.Drawing.Color.Red;
            this.txtMensagem.Location = new System.Drawing.Point(29, 103);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(0, 13);
            this.txtMensagem.TabIndex = 15;
            // 
            // lbEsqSenha
            // 
            this.lbEsqSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEsqSenha.AutoSize = true;
            this.lbEsqSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbEsqSenha.ForeColor = System.Drawing.Color.Blue;
            this.lbEsqSenha.Location = new System.Drawing.Point(278, 98);
            this.lbEsqSenha.Name = "lbEsqSenha";
            this.lbEsqSenha.Size = new System.Drawing.Size(127, 13);
            this.lbEsqSenha.TabIndex = 14;
            this.lbEsqSenha.Text = "Esqueci meu login/senha";
            this.lbEsqSenha.Click += new System.EventHandler(this.lbEsqSenha_Click);
            this.lbEsqSenha.MouseLeave += new System.EventHandler(this.lbEsqSenha_MouseLeave);
            this.lbEsqSenha.MouseHover += new System.EventHandler(this.lbEsqSenha_MouseHover);
            // 
            // gbUserType
            // 
            this.gbUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbUserType.BackColor = System.Drawing.Color.Transparent;
            this.gbUserType.Controls.Add(this.cbMercado);
            this.gbUserType.Controls.Add(this.cbAdmin);
            this.gbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserType.Location = new System.Drawing.Point(18, 119);
            this.gbUserType.Name = "gbUserType";
            this.gbUserType.Size = new System.Drawing.Size(384, 94);
            this.gbUserType.TabIndex = 12;
            this.gbUserType.TabStop = false;
            this.gbUserType.Text = "Tipo de usuário";
            // 
            // cbMercado
            // 
            this.cbMercado.AutoSize = true;
            this.cbMercado.Location = new System.Drawing.Point(217, 43);
            this.cbMercado.Name = "cbMercado";
            this.cbMercado.Size = new System.Drawing.Size(138, 35);
            this.cbMercado.TabIndex = 1;
            this.cbMercado.Text = "Mercado";
            this.cbMercado.UseVisualStyleBackColor = true;
            this.cbMercado.CheckedChanged += new System.EventHandler(this.cbMercado_CheckedChanged);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(11, 43);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(200, 35);
            this.cbAdmin.TabIndex = 0;
            this.cbAdmin.Text = "Administrador";
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.CheckedChanged += new System.EventHandler(this.cbAdmin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(166, 57);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(236, 38);
            this.txtSenha.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(166, 9);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(236, 38);
            this.txtUser.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(165, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 50);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(2)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 284);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lbEsqSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gbUserType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.gbUserType.ResumeLayout(false);
            this.gbUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMensagem;
        private System.Windows.Forms.Label lbEsqSenha;
        private System.Windows.Forms.GroupBox gbUserType;
        private System.Windows.Forms.CheckBox cbMercado;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
    }
}

