namespace UkraBar
{
    partial class PainelAdm
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnProduto = new System.Windows.Forms.Button();
            this.BtnClientesView = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.pCadastro = new System.Windows.Forms.Panel();
            this.BtnFuncionario = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelSair = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pCadastro.SuspendLayout();
            this.PanelSair.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Controls.Add(this.BtnProduto);
            this.pMenu.Controls.Add(this.BtnClientesView);
            this.pMenu.Controls.Add(this.BtnCadastrar);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1370, 84);
            this.pMenu.TabIndex = 1;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelMenu_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::UkraBar.Properties.Resources.admIMAGE22;
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnProduto
            // 
            this.BtnProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProduto.AutoSize = true;
            this.BtnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProduto.FlatAppearance.BorderSize = 0;
            this.BtnProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProduto.Location = new System.Drawing.Point(759, 18);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Size = new System.Drawing.Size(187, 63);
            this.BtnProduto.TabIndex = 3;
            this.BtnProduto.Text = "Produtos";
            this.BtnProduto.UseVisualStyleBackColor = false;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            this.BtnProduto.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.BtnProduto.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // BtnClientesView
            // 
            this.BtnClientesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClientesView.AutoSize = true;
            this.BtnClientesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnClientesView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientesView.FlatAppearance.BorderSize = 0;
            this.BtnClientesView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnClientesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientesView.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientesView.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClientesView.Location = new System.Drawing.Point(555, 18);
            this.BtnClientesView.Name = "BtnClientesView";
            this.BtnClientesView.Size = new System.Drawing.Size(187, 63);
            this.BtnClientesView.TabIndex = 2;
            this.BtnClientesView.Text = "Clientes";
            this.BtnClientesView.UseVisualStyleBackColor = false;
            this.BtnClientesView.Click += new System.EventHandler(this.BtnClientesView_Click);
            this.BtnClientesView.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.BtnClientesView.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrar.AutoSize = true;
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCadastrar.Image = global::UkraBar.Properties.Resources.expand_arrow_24px;
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.Location = new System.Drawing.Point(333, 17);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnCadastrar.Size = new System.Drawing.Size(197, 63);
            this.BtnCadastrar.TabIndex = 0;
            this.BtnCadastrar.Text = "   Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.button1_Click);
            this.BtnCadastrar.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.BtnCadastrar.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // pCadastro
            // 
            this.pCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCadastro.AutoSize = true;
            this.pCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pCadastro.Controls.Add(this.BtnFuncionario);
            this.pCadastro.Controls.Add(this.BtnProdutos);
            this.pCadastro.Location = new System.Drawing.Point(330, 84);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(203, 130);
            this.pCadastro.TabIndex = 8;
            this.pCadastro.Visible = false;
            this.pCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pCadastro_Paint);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFuncionario.AutoSize = true;
            this.BtnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(210)))), ((int)(((byte)(2)))));
            this.BtnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFuncionario.Location = new System.Drawing.Point(3, 62);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Size = new System.Drawing.Size(197, 65);
            this.BtnFuncionario.TabIndex = 8;
            this.BtnFuncionario.Text = "Funcionário";
            this.BtnFuncionario.UseVisualStyleBackColor = false;
            this.BtnFuncionario.Click += new System.EventHandler(this.button12_Click);
            this.BtnFuncionario.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.BtnFuncionario.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProdutos.AutoSize = true;
            this.BtnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(210)))), ((int)(((byte)(2)))));
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProdutos.Location = new System.Drawing.Point(3, 0);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(197, 62);
            this.BtnProdutos.TabIndex = 6;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = false;
            this.BtnProdutos.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 665);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1360, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 665);
            this.panel2.TabIndex = 10;
            // 
            // PanelSair
            // 
            this.PanelSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSair.AutoSize = true;
            this.PanelSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.PanelSair.Controls.Add(this.BtnSair);
            this.PanelSair.Location = new System.Drawing.Point(38, 84);
            this.PanelSair.Name = "PanelSair";
            this.PanelSair.Size = new System.Drawing.Size(256, 66);
            this.PanelSair.TabIndex = 11;
            this.PanelSair.Visible = false;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Red;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSair.Location = new System.Drawing.Point(4, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(249, 62);
            this.BtnSair.TabIndex = 12;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PainelAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::UkraBar.Properties.Resources.FundoFinal;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PanelSair);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pCadastro);
            this.Controls.Add(this.pMenu);
            this.Name = "PainelAdm";
            this.Text = "PainelAdm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pCadastro.ResumeLayout(false);
            this.pCadastro.PerformLayout();
            this.PanelSair.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button BtnClientesView;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnFuncionario;
        private System.Windows.Forms.Button BtnProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelSair;
        private System.Windows.Forms.Button BtnSair;
    }
}