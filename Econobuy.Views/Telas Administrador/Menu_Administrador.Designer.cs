namespace Econobuy
{
    partial class Menu_Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Administrador));
            this.btnCadastroAdmin = new System.Windows.Forms.Button();
            this.btnCadastroMercado = new System.Windows.Forms.Button();
            this.btnConsulMercado = new System.Windows.Forms.Button();
            this.lbNomeAdmin = new System.Windows.Forms.Label();
            this.btnPedidoRemocao = new System.Windows.Forms.Button();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSlide.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastroAdmin
            // 
            this.btnCadastroAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCadastroAdmin.FlatAppearance.BorderSize = 0;
            this.btnCadastroAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastroAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroAdmin.Name = "btnCadastroAdmin";
            this.btnCadastroAdmin.Size = new System.Drawing.Size(169, 56);
            this.btnCadastroAdmin.TabIndex = 4;
            this.btnCadastroAdmin.Text = "Cadastro de usuário para administrador";
            this.btnCadastroAdmin.UseVisualStyleBackColor = false;
            this.btnCadastroAdmin.Click += new System.EventHandler(this.btnCadastroAdmin_Click);
            // 
            // btnCadastroMercado
            // 
            this.btnCadastroMercado.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroMercado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroMercado.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnCadastroMercado.FlatAppearance.BorderSize = 0;
            this.btnCadastroMercado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastroMercado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroMercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroMercado.Location = new System.Drawing.Point(0, 113);
            this.btnCadastroMercado.Name = "btnCadastroMercado";
            this.btnCadastroMercado.Size = new System.Drawing.Size(169, 57);
            this.btnCadastroMercado.TabIndex = 3;
            this.btnCadastroMercado.Text = "Cadastro de usuário para mercado";
            this.btnCadastroMercado.UseVisualStyleBackColor = false;
            this.btnCadastroMercado.Click += new System.EventHandler(this.btnCadastroMercado_Click);
            // 
            // btnConsulMercado
            // 
            this.btnConsulMercado.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulMercado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulMercado.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnConsulMercado.FlatAppearance.BorderSize = 0;
            this.btnConsulMercado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsulMercado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulMercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulMercado.Location = new System.Drawing.Point(0, 56);
            this.btnConsulMercado.Name = "btnConsulMercado";
            this.btnConsulMercado.Size = new System.Drawing.Size(169, 57);
            this.btnConsulMercado.TabIndex = 2;
            this.btnConsulMercado.Text = "Consulta de usuários de mercados";
            this.btnConsulMercado.UseVisualStyleBackColor = false;
            this.btnConsulMercado.Click += new System.EventHandler(this.btnConsulMercado_Click);
            // 
            // lbNomeAdmin
            // 
            this.lbNomeAdmin.AutoEllipsis = true;
            this.lbNomeAdmin.AutoSize = true;
            this.lbNomeAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNomeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbNomeAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAdmin.ForeColor = System.Drawing.Color.Black;
            this.lbNomeAdmin.Location = new System.Drawing.Point(12, 9);
            this.lbNomeAdmin.Name = "lbNomeAdmin";
            this.lbNomeAdmin.Size = new System.Drawing.Size(142, 25);
            this.lbNomeAdmin.TabIndex = 22;
            this.lbNomeAdmin.Text = "Administrador";
            // 
            // btnPedidoRemocao
            // 
            this.btnPedidoRemocao.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoRemocao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidoRemocao.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPedidoRemocao.FlatAppearance.BorderSize = 0;
            this.btnPedidoRemocao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPedidoRemocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoRemocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoRemocao.Location = new System.Drawing.Point(0, 170);
            this.btnPedidoRemocao.Name = "btnPedidoRemocao";
            this.btnPedidoRemocao.Size = new System.Drawing.Size(169, 57);
            this.btnPedidoRemocao.TabIndex = 1;
            this.btnPedidoRemocao.Text = "Pedidos de Remoção de avaliação";
            this.btnPedidoRemocao.UseVisualStyleBackColor = false;
            this.btnPedidoRemocao.Click += new System.EventHandler(this.btnPedidoRemocao_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPrincipal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPrincipal.Location = new System.Drawing.Point(169, 44);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1213, 525);
            this.pnPrincipal.TabIndex = 29;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(2)))));
            this.panelSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSlide.Controls.Add(this.btnPedidoRemocao);
            this.panelSlide.Controls.Add(this.btnCadastroMercado);
            this.panelSlide.Controls.Add(this.btnConsulMercado);
            this.panelSlide.Controls.Add(this.btnLogout);
            this.panelSlide.Controls.Add(this.btnCadastroAdmin);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSlide.Location = new System.Drawing.Point(0, 44);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(169, 525);
            this.panelSlide.TabIndex = 31;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 468);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 57);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(2)))));
            this.panel2.Controls.Add(this.lbNomeAdmin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 44);
            this.panel2.TabIndex = 0;
            // 
            // Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(244)))), ((int)(((byte)(126)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 569);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Administrador";
            this.Text = "Menu_Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSlide.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroAdmin;
        private System.Windows.Forms.Button btnCadastroMercado;
        private System.Windows.Forms.Button btnConsulMercado;
        private System.Windows.Forms.Label lbNomeAdmin;
        private System.Windows.Forms.Button btnPedidoRemocao;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel panelSlide;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
    }
}