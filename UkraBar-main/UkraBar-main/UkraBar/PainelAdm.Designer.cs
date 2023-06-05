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
            this.BtnVoltarADM = new System.Windows.Forms.Button();
            this.BtnDescontosView = new System.Windows.Forms.Button();
            this.BtnClientesView = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pCadastro = new System.Windows.Forms.Panel();
            this.BtnFuncionario = new System.Windows.Forms.Button();
            this.BtnDesconto = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.pbFundoAdm = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundoAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pMenu.Controls.Add(this.BtnVoltarADM);
            this.pMenu.Controls.Add(this.BtnDescontosView);
            this.pMenu.Controls.Add(this.BtnClientesView);
            this.pMenu.Controls.Add(this.BtnCadastrar);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1028, 80);
            this.pMenu.TabIndex = 1;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelMenu_Paint);
            // 
            // BtnVoltarADM
            // 
            this.BtnVoltarADM.BackColor = System.Drawing.Color.Crimson;
            this.BtnVoltarADM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarADM.FlatAppearance.BorderSize = 0;
            this.BtnVoltarADM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnVoltarADM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltarADM.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarADM.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVoltarADM.Location = new System.Drawing.Point(31, 15);
            this.BtnVoltarADM.Name = "BtnVoltarADM";
            this.BtnVoltarADM.Size = new System.Drawing.Size(115, 50);
            this.BtnVoltarADM.TabIndex = 9;
            this.BtnVoltarADM.Text = "Voltar";
            this.BtnVoltarADM.UseVisualStyleBackColor = false;
            this.BtnVoltarADM.Click += new System.EventHandler(this.voltar1_Click);
            // 
            // BtnDescontosView
            // 
            this.BtnDescontosView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnDescontosView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDescontosView.FlatAppearance.BorderSize = 0;
            this.BtnDescontosView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnDescontosView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescontosView.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescontosView.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDescontosView.Location = new System.Drawing.Point(658, 15);
            this.BtnDescontosView.Name = "BtnDescontosView";
            this.BtnDescontosView.Size = new System.Drawing.Size(187, 62);
            this.BtnDescontosView.TabIndex = 3;
            this.BtnDescontosView.Text = "Descontos";
            this.BtnDescontosView.UseVisualStyleBackColor = false;
            this.BtnDescontosView.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.BtnDescontosView.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // BtnClientesView
            // 
            this.BtnClientesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnClientesView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientesView.FlatAppearance.BorderSize = 0;
            this.BtnClientesView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnClientesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientesView.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientesView.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClientesView.Location = new System.Drawing.Point(442, 16);
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
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCadastrar.Image = global::UkraBar.Properties.Resources.expand_arrow_24px;
            this.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastrar.Location = new System.Drawing.Point(226, 16);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnCadastrar.Size = new System.Drawing.Size(187, 63);
            this.BtnCadastrar.TabIndex = 0;
            this.BtnCadastrar.Text = "   Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.button1_Click);
            this.BtnCadastrar.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.BtnCadastrar.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1018, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 529);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 529);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 529);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pCadastro
            // 
            this.pCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pCadastro.Controls.Add(this.BtnFuncionario);
            this.pCadastro.Controls.Add(this.BtnDesconto);
            this.pCadastro.Controls.Add(this.BtnProdutos);
            this.pCadastro.Location = new System.Drawing.Point(226, 80);
            this.pCadastro.Name = "pCadastro";
            this.pCadastro.Size = new System.Drawing.Size(187, 182);
            this.pCadastro.TabIndex = 8;
            this.pCadastro.Visible = false;
            this.pCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pCadastro_Paint);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(210)))), ((int)(((byte)(2)))));
            this.BtnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFuncionario.Location = new System.Drawing.Point(0, 117);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Size = new System.Drawing.Size(187, 65);
            this.BtnFuncionario.TabIndex = 8;
            this.BtnFuncionario.Text = "Funcionário";
            this.BtnFuncionario.UseVisualStyleBackColor = false;
            this.BtnFuncionario.Click += new System.EventHandler(this.button12_Click);
            this.BtnFuncionario.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.BtnFuncionario.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // BtnDesconto
            // 
            this.BtnDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDesconto.FlatAppearance.BorderSize = 0;
            this.BtnDesconto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(210)))), ((int)(((byte)(2)))));
            this.BtnDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesconto.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDesconto.Location = new System.Drawing.Point(0, 59);
            this.BtnDesconto.Name = "BtnDesconto";
            this.BtnDesconto.Size = new System.Drawing.Size(187, 62);
            this.BtnDesconto.TabIndex = 7;
            this.BtnDesconto.Text = "Descontos";
            this.BtnDesconto.UseVisualStyleBackColor = false;
            this.BtnDesconto.Click += new System.EventHandler(this.button9_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(210)))), ((int)(((byte)(2)))));
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 0);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(187, 62);
            this.BtnProdutos.TabIndex = 6;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = false;
            this.BtnProdutos.Click += new System.EventHandler(this.button10_Click);
            // 
            // pbFundoAdm
            // 
            this.pbFundoAdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundoAdm.Image = global::UkraBar.Properties.Resources.TelaFundo;
            this.pbFundoAdm.Location = new System.Drawing.Point(0, 0);
            this.pbFundoAdm.Name = "pbFundoAdm";
            this.pbFundoAdm.Size = new System.Drawing.Size(1028, 609);
            this.pbFundoAdm.TabIndex = 9;
            this.pbFundoAdm.TabStop = false;
            this.pbFundoAdm.Click += new System.EventHandler(this.pbFundoAdm_Click);
            // 
            // PainelAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pCadastro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pbFundoAdm);
            this.Name = "PainelAdm";
            this.Text = "PainelAdm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFundoAdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDescontosView;
        private System.Windows.Forms.Button BtnClientesView;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Panel pCadastro;
        private System.Windows.Forms.Button BtnDesconto;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnFuncionario;
        private System.Windows.Forms.Button BtnVoltarADM;
        private System.Windows.Forms.PictureBox pbFundoAdm;
    }
}