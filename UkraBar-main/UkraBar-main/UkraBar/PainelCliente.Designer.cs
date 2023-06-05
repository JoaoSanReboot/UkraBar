namespace UkraBar
{
    partial class PainelCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarSideTop = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BoxBuscar = new System.Windows.Forms.TextBox();
            this.FundoPesquisar = new System.Windows.Forms.PictureBox();
            this.sideBarMenuD = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.panelShowConfig = new System.Windows.Forms.Panel();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnConfigurações = new System.Windows.Forms.Button();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.paneltopbar = new System.Windows.Forms.Panel();
            this.MinimizarJanela = new System.Windows.Forms.Button();
            this.MaximizarJanela = new System.Windows.Forms.Button();
            this.FecharJanelaF = new System.Windows.Forms.Button();
            this.LayoutFundoDT = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEditarFundo = new System.Windows.Forms.Panel();
            this.lblCarrinhoC = new System.Windows.Forms.Label();
            this.BoxdCarrinhoC = new System.Windows.Forms.TextBox();
            this.BtnPincel = new System.Windows.Forms.Button();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.lblCpfC = new System.Windows.Forms.Label();
            this.BoxdCpfC = new System.Windows.Forms.TextBox();
            this.BoxdNomeC = new System.Windows.Forms.TextBox();
            this.lblIdP = new System.Windows.Forms.Label();
            this.BoxdIdC = new System.Windows.Forms.TextBox();
            this.panelFundoDT = new System.Windows.Forms.Panel();
            this.DTgridClie = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TimerSideBar = new System.Windows.Forms.Timer(this.components);
            this.TelaFundo = new System.Windows.Forms.PictureBox();
            this.BarSideTop.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPesquisar)).BeginInit();
            this.sideBarMenuD.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panelShowConfig.SuspendLayout();
            this.paneltopbar.SuspendLayout();
            this.LayoutFundoDT.SuspendLayout();
            this.panelEditarFundo.SuspendLayout();
            this.panelFundoDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTgridClie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // BarSideTop
            // 
            this.BarSideTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BarSideTop.Controls.Add(this.panelLabel);
            this.BarSideTop.Controls.Add(this.panelBuscar);
            this.BarSideTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarSideTop.Location = new System.Drawing.Point(76, 39);
            this.BarSideTop.Name = "BarSideTop";
            this.BarSideTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BarSideTop.Size = new System.Drawing.Size(1294, 64);
            this.BarSideTop.TabIndex = 54;
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLabel.Controls.Add(this.lblCliente);
            this.panelLabel.Location = new System.Drawing.Point(3, 3);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(287, 61);
            this.panelLabel.TabIndex = 39;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCliente.Location = new System.Drawing.Point(23, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliente.Size = new System.Drawing.Size(242, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CRUD | Configurações do Cliente ";
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.BoxBuscar);
            this.panelBuscar.Controls.Add(this.FundoPesquisar);
            this.panelBuscar.Location = new System.Drawing.Point(296, 3);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(454, 61);
            this.panelBuscar.TabIndex = 40;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::UkraBar.Properties.Resources.search_more_24px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(301, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnBuscar.Size = new System.Drawing.Size(150, 46);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "      Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BoxBuscar
            // 
            this.BoxBuscar.BackColor = System.Drawing.Color.White;
            this.BoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxBuscar.Location = new System.Drawing.Point(21, 20);
            this.BoxBuscar.Name = "BoxBuscar";
            this.BoxBuscar.Size = new System.Drawing.Size(253, 19);
            this.BoxBuscar.TabIndex = 29;
            this.BoxBuscar.Tag = "";
            // 
            // FundoPesquisar
            // 
            this.FundoPesquisar.Image = global::UkraBar.Properties.Resources.BoxBranca;
            this.FundoPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FundoPesquisar.Location = new System.Drawing.Point(3, 7);
            this.FundoPesquisar.Name = "FundoPesquisar";
            this.FundoPesquisar.Size = new System.Drawing.Size(292, 47);
            this.FundoPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FundoPesquisar.TabIndex = 33;
            this.FundoPesquisar.TabStop = false;
            // 
            // sideBarMenuD
            // 
            this.sideBarMenuD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sideBarMenuD.Controls.Add(this.panelMenu);
            this.sideBarMenuD.Controls.Add(this.panelShowConfig);
            this.sideBarMenuD.Controls.Add(this.BtnSobre);
            this.sideBarMenuD.Controls.Add(this.BtnAjuda);
            this.sideBarMenuD.Controls.Add(this.BtnVoltar);
            this.sideBarMenuD.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarMenuD.Location = new System.Drawing.Point(0, 39);
            this.sideBarMenuD.MaximumSize = new System.Drawing.Size(226, 749);
            this.sideBarMenuD.MinimumSize = new System.Drawing.Size(76, 749);
            this.sideBarMenuD.Name = "sideBarMenuD";
            this.sideBarMenuD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sideBarMenuD.Size = new System.Drawing.Size(76, 749);
            this.sideBarMenuD.TabIndex = 53;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.lblMenu);
            this.panelMenu.Controls.Add(this.pbMenu);
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(222, 116);
            this.panelMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMenu.Location = new System.Drawing.Point(94, 40);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(50, 21);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // pbMenu
            // 
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenu.Image = global::UkraBar.Properties.Resources.squared_menu_24px;
            this.pbMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbMenu.Location = new System.Drawing.Point(17, 37);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(30, 28);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // panelShowConfig
            // 
            this.panelShowConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelShowConfig.Controls.Add(this.BtnDeletar);
            this.panelShowConfig.Controls.Add(this.BtnEditar);
            this.panelShowConfig.Controls.Add(this.BtnConfigurações);
            this.panelShowConfig.Location = new System.Drawing.Point(3, 125);
            this.panelShowConfig.MaximumSize = new System.Drawing.Size(223, 150);
            this.panelShowConfig.MinimumSize = new System.Drawing.Size(223, 50);
            this.panelShowConfig.Name = "panelShowConfig";
            this.panelShowConfig.Size = new System.Drawing.Size(223, 50);
            this.panelShowConfig.TabIndex = 45;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Red;
            this.BtnDeletar.FlatAppearance.BorderSize = 0;
            this.BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDeletar.ForeColor = System.Drawing.Color.White;
            this.BtnDeletar.Image = global::UkraBar.Properties.Resources.trash_26px;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeletar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDeletar.Location = new System.Drawing.Point(0, 50);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnDeletar.Size = new System.Drawing.Size(228, 50);
            this.BtnDeletar.TabIndex = 41;
            this.BtnDeletar.Text = "                  Deletar";
            this.BtnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeletar.UseVisualStyleBackColor = false;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Image = global::UkraBar.Properties.Resources.pencil_24px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEditar.Location = new System.Drawing.Point(-8, 100);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEditar.Size = new System.Drawing.Size(231, 50);
            this.BtnEditar.TabIndex = 43;
            this.BtnEditar.Text = "                    Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnConfigurações
            // 
            this.BtnConfigurações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnConfigurações.FlatAppearance.BorderSize = 0;
            this.BtnConfigurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfigurações.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnConfigurações.ForeColor = System.Drawing.Color.White;
            this.BtnConfigurações.Image = global::UkraBar.Properties.Resources.engineering_30px;
            this.BtnConfigurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfigurações.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConfigurações.Location = new System.Drawing.Point(2, 0);
            this.BtnConfigurações.Name = "BtnConfigurações";
            this.BtnConfigurações.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConfigurações.Size = new System.Drawing.Size(223, 50);
            this.BtnConfigurações.TabIndex = 38;
            this.BtnConfigurações.Text = "                  Configurações";
            this.BtnConfigurações.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfigurações.UseVisualStyleBackColor = false;
            this.BtnConfigurações.Click += new System.EventHandler(this.BtnConfigurações_Click);
            // 
            // BtnSobre
            // 
            this.BtnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnSobre.FlatAppearance.BorderSize = 0;
            this.BtnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSobre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSobre.ForeColor = System.Drawing.Color.White;
            this.BtnSobre.Image = global::UkraBar.Properties.Resources.info_24px;
            this.BtnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSobre.Location = new System.Drawing.Point(3, 181);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnSobre.Size = new System.Drawing.Size(223, 50);
            this.BtnSobre.TabIndex = 38;
            this.BtnSobre.Text = "                  Sobre";
            this.BtnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.UseVisualStyleBackColor = false;
            this.BtnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnAjuda.FlatAppearance.BorderSize = 0;
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjuda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAjuda.ForeColor = System.Drawing.Color.White;
            this.BtnAjuda.Image = global::UkraBar.Properties.Resources.ask_question_24px;
            this.BtnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjuda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAjuda.Location = new System.Drawing.Point(3, 237);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnAjuda.Size = new System.Drawing.Size(223, 50);
            this.BtnAjuda.TabIndex = 38;
            this.BtnAjuda.Text = "                  Ajuda";
            this.BtnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjuda.UseVisualStyleBackColor = false;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Image = global::UkraBar.Properties.Resources.reply_arrow_24px;
            this.BtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnVoltar.Location = new System.Drawing.Point(3, 293);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnVoltar.Size = new System.Drawing.Size(223, 50);
            this.BtnVoltar.TabIndex = 39;
            this.BtnVoltar.Text = "                  Voltar";
            this.BtnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // paneltopbar
            // 
            this.paneltopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.paneltopbar.Controls.Add(this.MinimizarJanela);
            this.paneltopbar.Controls.Add(this.MaximizarJanela);
            this.paneltopbar.Controls.Add(this.FecharJanelaF);
            this.paneltopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltopbar.Location = new System.Drawing.Point(0, 0);
            this.paneltopbar.Name = "paneltopbar";
            this.paneltopbar.Size = new System.Drawing.Size(1370, 39);
            this.paneltopbar.TabIndex = 52;
            // 
            // MinimizarJanela
            // 
            this.MinimizarJanela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarJanela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MinimizarJanela.FlatAppearance.BorderSize = 0;
            this.MinimizarJanela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MinimizarJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizarJanela.Image = global::UkraBar.Properties.Resources.minimize_window_24px;
            this.MinimizarJanela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinimizarJanela.Location = new System.Drawing.Point(1274, 9);
            this.MinimizarJanela.Name = "MinimizarJanela";
            this.MinimizarJanela.Size = new System.Drawing.Size(25, 25);
            this.MinimizarJanela.TabIndex = 2;
            this.MinimizarJanela.Text = "       ";
            this.MinimizarJanela.UseVisualStyleBackColor = false;
            this.MinimizarJanela.Click += new System.EventHandler(this.MinimizarJanela_Click);
            // 
            // MaximizarJanela
            // 
            this.MaximizarJanela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarJanela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MaximizarJanela.FlatAppearance.BorderSize = 0;
            this.MaximizarJanela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MaximizarJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizarJanela.Image = global::UkraBar.Properties.Resources.maximize_window_24px;
            this.MaximizarJanela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizarJanela.Location = new System.Drawing.Point(1305, 9);
            this.MaximizarJanela.Name = "MaximizarJanela";
            this.MaximizarJanela.Size = new System.Drawing.Size(25, 25);
            this.MaximizarJanela.TabIndex = 1;
            this.MaximizarJanela.Text = "       ";
            this.MaximizarJanela.UseVisualStyleBackColor = false;
            this.MaximizarJanela.Click += new System.EventHandler(this.MaximizarJanela_Click);
            // 
            // FecharJanelaF
            // 
            this.FecharJanelaF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FecharJanelaF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FecharJanelaF.FlatAppearance.BorderSize = 0;
            this.FecharJanelaF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FecharJanelaF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FecharJanelaF.Image = global::UkraBar.Properties.Resources.close_window_24px1;
            this.FecharJanelaF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FecharJanelaF.Location = new System.Drawing.Point(1336, 9);
            this.FecharJanelaF.Name = "FecharJanelaF";
            this.FecharJanelaF.Size = new System.Drawing.Size(25, 25);
            this.FecharJanelaF.TabIndex = 0;
            this.FecharJanelaF.Text = "       ";
            this.FecharJanelaF.UseVisualStyleBackColor = false;
            this.FecharJanelaF.Click += new System.EventHandler(this.FecharJanelaF_Click);
            // 
            // LayoutFundoDT
            // 
            this.LayoutFundoDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutFundoDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.LayoutFundoDT.Controls.Add(this.panelEditarFundo);
            this.LayoutFundoDT.Controls.Add(this.panelFundoDT);
            this.LayoutFundoDT.Location = new System.Drawing.Point(275, 164);
            this.LayoutFundoDT.Name = "LayoutFundoDT";
            this.LayoutFundoDT.Size = new System.Drawing.Size(964, 562);
            this.LayoutFundoDT.TabIndex = 55;
            // 
            // panelEditarFundo
            // 
            this.panelEditarFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelEditarFundo.Controls.Add(this.lblCarrinhoC);
            this.panelEditarFundo.Controls.Add(this.BoxdCarrinhoC);
            this.panelEditarFundo.Controls.Add(this.BtnPincel);
            this.panelEditarFundo.Controls.Add(this.lblNomeC);
            this.panelEditarFundo.Controls.Add(this.lblCpfC);
            this.panelEditarFundo.Controls.Add(this.BoxdCpfC);
            this.panelEditarFundo.Controls.Add(this.BoxdNomeC);
            this.panelEditarFundo.Controls.Add(this.lblIdP);
            this.panelEditarFundo.Controls.Add(this.BoxdIdC);
            this.panelEditarFundo.Location = new System.Drawing.Point(3, 3);
            this.panelEditarFundo.MaximumSize = new System.Drawing.Size(979, 103);
            this.panelEditarFundo.MinimumSize = new System.Drawing.Size(979, 0);
            this.panelEditarFundo.Name = "panelEditarFundo";
            this.panelEditarFundo.Size = new System.Drawing.Size(979, 0);
            this.panelEditarFundo.TabIndex = 0;
            // 
            // lblCarrinhoC
            // 
            this.lblCarrinhoC.AutoSize = true;
            this.lblCarrinhoC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarrinhoC.ForeColor = System.Drawing.Color.White;
            this.lblCarrinhoC.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lblCarrinhoC.Location = new System.Drawing.Point(661, 17);
            this.lblCarrinhoC.Name = "lblCarrinhoC";
            this.lblCarrinhoC.Size = new System.Drawing.Size(76, 21);
            this.lblCarrinhoC.TabIndex = 48;
            this.lblCarrinhoC.Text = "Carrinho";
            // 
            // BoxdCarrinhoC
            // 
            this.BoxdCarrinhoC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BoxdCarrinhoC.Location = new System.Drawing.Point(580, 42);
            this.BoxdCarrinhoC.MaxLength = 100;
            this.BoxdCarrinhoC.Name = "BoxdCarrinhoC";
            this.BoxdCarrinhoC.Size = new System.Drawing.Size(238, 29);
            this.BoxdCarrinhoC.TabIndex = 47;
            // 
            // BtnPincel
            // 
            this.BtnPincel.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnPincel.FlatAppearance.BorderSize = 0;
            this.BtnPincel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPincel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPincel.ForeColor = System.Drawing.Color.White;
            this.BtnPincel.Image = global::UkraBar.Properties.Resources.pencil_24px;
            this.BtnPincel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPincel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnPincel.Location = new System.Drawing.Point(855, 25);
            this.BtnPincel.Name = "BtnPincel";
            this.BtnPincel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnPincel.Size = new System.Drawing.Size(59, 59);
            this.BtnPincel.TabIndex = 46;
            this.BtnPincel.Text = "                  Editar";
            this.BtnPincel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPincel.UseVisualStyleBackColor = false;
            this.BtnPincel.Click += new System.EventHandler(this.BtnPincel_Click);
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNomeC.ForeColor = System.Drawing.Color.White;
            this.lblNomeC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeC.Location = new System.Drawing.Point(382, 18);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(139, 21);
            this.lblNomeC.TabIndex = 9;
            this.lblNomeC.Text = "Nome do Cliente";
            // 
            // lblCpfC
            // 
            this.lblCpfC.AutoSize = true;
            this.lblCpfC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCpfC.ForeColor = System.Drawing.Color.White;
            this.lblCpfC.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lblCpfC.Location = new System.Drawing.Point(167, 18);
            this.lblCpfC.Name = "lblCpfC";
            this.lblCpfC.Size = new System.Drawing.Size(118, 21);
            this.lblCpfC.TabIndex = 7;
            this.lblCpfC.Text = "Cpf do Cliente";
            // 
            // BoxdCpfC
            // 
            this.BoxdCpfC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BoxdCpfC.Location = new System.Drawing.Point(131, 41);
            this.BoxdCpfC.MaxLength = 100;
            this.BoxdCpfC.Name = "BoxdCpfC";
            this.BoxdCpfC.Size = new System.Drawing.Size(190, 29);
            this.BoxdCpfC.TabIndex = 6;
            // 
            // BoxdNomeC
            // 
            this.BoxdNomeC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BoxdNomeC.Location = new System.Drawing.Point(336, 42);
            this.BoxdNomeC.MaxLength = 100;
            this.BoxdNomeC.Name = "BoxdNomeC";
            this.BoxdNomeC.Size = new System.Drawing.Size(231, 29);
            this.BoxdNomeC.TabIndex = 8;
            // 
            // lblIdP
            // 
            this.lblIdP.AutoSize = true;
            this.lblIdP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdP.ForeColor = System.Drawing.Color.White;
            this.lblIdP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIdP.Location = new System.Drawing.Point(72, 17);
            this.lblIdP.Name = "lblIdP";
            this.lblIdP.Size = new System.Drawing.Size(25, 21);
            this.lblIdP.TabIndex = 5;
            this.lblIdP.Text = "Id";
            // 
            // BoxdIdC
            // 
            this.BoxdIdC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BoxdIdC.Location = new System.Drawing.Point(55, 41);
            this.BoxdIdC.MaxLength = 100;
            this.BoxdIdC.Name = "BoxdIdC";
            this.BoxdIdC.Size = new System.Drawing.Size(59, 29);
            this.BoxdIdC.TabIndex = 4;
            // 
            // panelFundoDT
            // 
            this.panelFundoDT.Controls.Add(this.DTgridClie);
            this.panelFundoDT.Location = new System.Drawing.Point(3, 9);
            this.panelFundoDT.Name = "panelFundoDT";
            this.panelFundoDT.Size = new System.Drawing.Size(979, 552);
            this.panelFundoDT.TabIndex = 1;
            // 
            // DTgridClie
            // 
            this.DTgridClie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTgridClie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTgridClie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridClie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTgridClie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTgridClie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridClie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTgridClie.ColumnHeadersHeight = 30;
            this.DTgridClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTgridClie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTgridClie.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTgridClie.GridColor = System.Drawing.Color.Black;
            this.DTgridClie.Location = new System.Drawing.Point(3, 0);
            this.DTgridClie.Name = "DTgridClie";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridClie.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DTgridClie.RowHeadersWidth = 51;
            this.DTgridClie.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DTgridClie.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridClie.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTgridClie.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DTgridClie.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.DTgridClie.RowTemplate.Height = 30;
            this.DTgridClie.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DTgridClie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTgridClie.Size = new System.Drawing.Size(958, 549);
            this.DTgridClie.TabIndex = 29;
            this.DTgridClie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DTgridClie_CellMouseClick);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckBox.FillWeight = 30.45685F;
            this.CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBox.HeaderText = "Selecionar";
            this.CheckBox.MinimumWidth = 6;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 70;
            // 
            // TimerSideBar
            // 
            this.TimerSideBar.Interval = 10;
            this.TimerSideBar.Tick += new System.EventHandler(this.TimerSideBar_Tick_1);
            // 
            // TelaFundo
            // 
            this.TelaFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TelaFundo.Image = global::UkraBar.Properties.Resources.TelaFundo;
            this.TelaFundo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TelaFundo.Location = new System.Drawing.Point(0, 0);
            this.TelaFundo.Name = "TelaFundo";
            this.TelaFundo.Size = new System.Drawing.Size(1370, 749);
            this.TelaFundo.TabIndex = 56;
            this.TelaFundo.TabStop = false;
            // 
            // PainelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.LayoutFundoDT);
            this.Controls.Add(this.BarSideTop);
            this.Controls.Add(this.sideBarMenuD);
            this.Controls.Add(this.paneltopbar);
            this.Controls.Add(this.TelaFundo);
            this.Name = "PainelCliente";
            this.Text = "PainelCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PainelCliente_Load);
            this.BarSideTop.ResumeLayout(false);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPesquisar)).EndInit();
            this.sideBarMenuD.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panelShowConfig.ResumeLayout(false);
            this.paneltopbar.ResumeLayout(false);
            this.LayoutFundoDT.ResumeLayout(false);
            this.panelEditarFundo.ResumeLayout(false);
            this.panelEditarFundo.PerformLayout();
            this.panelFundoDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTgridClie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BarSideTop;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox BoxBuscar;
        private System.Windows.Forms.PictureBox FundoPesquisar;
        private System.Windows.Forms.FlowLayoutPanel sideBarMenuD;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Panel panelShowConfig;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnConfigurações;
        private System.Windows.Forms.Button BtnSobre;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Panel paneltopbar;
        private System.Windows.Forms.Button MinimizarJanela;
        private System.Windows.Forms.Button MaximizarJanela;
        private System.Windows.Forms.Button FecharJanelaF;
        private System.Windows.Forms.FlowLayoutPanel LayoutFundoDT;
        private System.Windows.Forms.Panel panelEditarFundo;
        private System.Windows.Forms.Label lblCarrinhoC;
        private System.Windows.Forms.TextBox BoxdCarrinhoC;
        private System.Windows.Forms.Button BtnPincel;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Label lblCpfC;
        private System.Windows.Forms.TextBox BoxdCpfC;
        private System.Windows.Forms.TextBox BoxdNomeC;
        private System.Windows.Forms.Label lblIdP;
        private System.Windows.Forms.TextBox BoxdIdC;
        private System.Windows.Forms.Panel panelFundoDT;
        private System.Windows.Forms.DataGridView DTgridClie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.Timer TimerSideBar;
        private System.Windows.Forms.PictureBox TelaFundo;
    }
}