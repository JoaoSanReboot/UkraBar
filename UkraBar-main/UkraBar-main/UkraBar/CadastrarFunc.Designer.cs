namespace UkraBar
{
    partial class CadastrarFunc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SideBarTime = new System.Windows.Forms.Timer(this.components);
            this.NovoFuncTimer = new System.Windows.Forms.Timer(this.components);
            this.BoxcEmail = new System.Windows.Forms.TextBox();
            this.BoxcSenha = new System.Windows.Forms.TextBox();
            this.BoxcNome = new System.Windows.Forms.TextBox();
            this.BoxcId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.LayoutFundoDT = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEditarFundo = new System.Windows.Forms.Panel();
            this.BtnPincel = new System.Windows.Forms.Button();
            this.lblEmailF = new System.Windows.Forms.Label();
            this.BoxdEmailF = new System.Windows.Forms.TextBox();
            this.lblSenhaF = new System.Windows.Forms.Label();
            this.lblNomeF = new System.Windows.Forms.Label();
            this.BoxdNomeF = new System.Windows.Forms.TextBox();
            this.BoxdSenhaF = new System.Windows.Forms.TextBox();
            this.lblIdF = new System.Windows.Forms.Label();
            this.BoxdIdF = new System.Windows.Forms.TextBox();
            this.panelFundoDT = new System.Windows.Forms.Panel();
            this.DTgridClientes = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paneltopbar = new System.Windows.Forms.Panel();
            this.MinimizarJanela = new System.Windows.Forms.Button();
            this.MaximizarJanela = new System.Windows.Forms.Button();
            this.FecharJanelaF = new System.Windows.Forms.Button();
            this.BarSideTop = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.lblFunc = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BoxBuscar = new System.Windows.Forms.TextBox();
            this.FundoPesquisar = new System.Windows.Forms.PictureBox();
            this.sideBarMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.panelShowConfig = new System.Windows.Forms.Panel();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovoFunc = new System.Windows.Forms.Button();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnConfigurações = new System.Windows.Forms.Button();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.PanelCadastrarFunc = new System.Windows.Forms.Panel();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelAviso.SuspendLayout();
            this.LayoutFundoDT.SuspendLayout();
            this.panelEditarFundo.SuspendLayout();
            this.panelFundoDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTgridClientes)).BeginInit();
            this.paneltopbar.SuspendLayout();
            this.BarSideTop.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPesquisar)).BeginInit();
            this.sideBarMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panelShowConfig.SuspendLayout();
            this.PanelCadastrarFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarTime
            // 
            this.SideBarTime.Interval = 10;
            this.SideBarTime.Tick += new System.EventHandler(this.SideBarTime_Tick);
            // 
            // NovoFuncTimer
            // 
            this.NovoFuncTimer.Interval = 5;
            this.NovoFuncTimer.Tick += new System.EventHandler(this.NovoFuncTimer_Tick);
            // 
            // BoxcEmail
            // 
            this.BoxcEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxcEmail.Location = new System.Drawing.Point(61, 322);
            this.BoxcEmail.MaxLength = 60;
            this.BoxcEmail.Name = "BoxcEmail";
            this.BoxcEmail.Size = new System.Drawing.Size(250, 29);
            this.BoxcEmail.TabIndex = 9;
            // 
            // BoxcSenha
            // 
            this.BoxcSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxcSenha.Location = new System.Drawing.Point(61, 235);
            this.BoxcSenha.MaxLength = 30;
            this.BoxcSenha.Name = "BoxcSenha";
            this.BoxcSenha.Size = new System.Drawing.Size(250, 29);
            this.BoxcSenha.TabIndex = 7;
            // 
            // BoxcNome
            // 
            this.BoxcNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxcNome.Location = new System.Drawing.Point(61, 148);
            this.BoxcNome.MaxLength = 50;
            this.BoxcNome.Name = "BoxcNome";
            this.BoxcNome.Size = new System.Drawing.Size(250, 29);
            this.BoxcNome.TabIndex = 3;
            // 
            // BoxcId
            // 
            this.BoxcId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxcId.Location = new System.Drawing.Point(61, 67);
            this.BoxcId.MaxLength = 1000;
            this.BoxcId.Name = "BoxcId";
            this.BoxcId.Size = new System.Drawing.Size(51, 29);
            this.BoxcId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(61, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 21);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(61, 124);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 21);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(58, 299);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 21);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // panelAviso
            // 
            this.panelAviso.BackColor = System.Drawing.Color.Red;
            this.panelAviso.Controls.Add(this.lblAviso);
            this.panelAviso.Location = new System.Drawing.Point(112, 78);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Size = new System.Drawing.Size(136, 19);
            this.panelAviso.TabIndex = 6;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Black;
            this.lblAviso.Location = new System.Drawing.Point(-1, 4);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(138, 12);
            this.lblAviso.TabIndex = 5;
            this.lblAviso.Text = "Recomendado não usar";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(61, 214);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 21);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha:";
            // 
            // LayoutFundoDT
            // 
            this.LayoutFundoDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.LayoutFundoDT.Controls.Add(this.panelEditarFundo);
            this.LayoutFundoDT.Controls.Add(this.panelFundoDT);
            this.LayoutFundoDT.Location = new System.Drawing.Point(268, 155);
            this.LayoutFundoDT.Name = "LayoutFundoDT";
            this.LayoutFundoDT.Size = new System.Drawing.Size(982, 561);
            this.LayoutFundoDT.TabIndex = 45;
            // 
            // panelEditarFundo
            // 
            this.panelEditarFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelEditarFundo.Controls.Add(this.BtnPincel);
            this.panelEditarFundo.Controls.Add(this.lblEmailF);
            this.panelEditarFundo.Controls.Add(this.BoxdEmailF);
            this.panelEditarFundo.Controls.Add(this.lblSenhaF);
            this.panelEditarFundo.Controls.Add(this.lblNomeF);
            this.panelEditarFundo.Controls.Add(this.BoxdNomeF);
            this.panelEditarFundo.Controls.Add(this.BoxdSenhaF);
            this.panelEditarFundo.Controls.Add(this.lblIdF);
            this.panelEditarFundo.Controls.Add(this.BoxdIdF);
            this.panelEditarFundo.Location = new System.Drawing.Point(3, 3);
            this.panelEditarFundo.MaximumSize = new System.Drawing.Size(979, 101);
            this.panelEditarFundo.MinimumSize = new System.Drawing.Size(979, 0);
            this.panelEditarFundo.Name = "panelEditarFundo";
            this.panelEditarFundo.Size = new System.Drawing.Size(979, 0);
            this.panelEditarFundo.TabIndex = 0;
            // 
            // BtnPincel
            // 
            this.BtnPincel.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnPincel.FlatAppearance.BorderSize = 0;
            this.BtnPincel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPincel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPincel.ForeColor = System.Drawing.Color.White;
            this.BtnPincel.Image = global::UkraBar.Properties.Resources.pencil_24px;
            this.BtnPincel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPincel.Location = new System.Drawing.Point(893, 28);
            this.BtnPincel.Name = "BtnPincel";
            this.BtnPincel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnPincel.Size = new System.Drawing.Size(65, 59);
            this.BtnPincel.TabIndex = 46;
            this.BtnPincel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPincel.UseVisualStyleBackColor = false;
            this.BtnPincel.Click += new System.EventHandler(this.BtnPincel_Click_1);
            // 
            // lblEmailF
            // 
            this.lblEmailF.AutoSize = true;
            this.lblEmailF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailF.ForeColor = System.Drawing.Color.White;
            this.lblEmailF.Location = new System.Drawing.Point(729, 18);
            this.lblEmailF.Name = "lblEmailF";
            this.lblEmailF.Size = new System.Drawing.Size(53, 21);
            this.lblEmailF.TabIndex = 45;
            this.lblEmailF.Text = "Email";
            // 
            // BoxdEmailF
            // 
            this.BoxdEmailF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxdEmailF.Location = new System.Drawing.Point(633, 42);
            this.BoxdEmailF.MaxLength = 100;
            this.BoxdEmailF.Name = "BoxdEmailF";
            this.BoxdEmailF.Size = new System.Drawing.Size(245, 29);
            this.BoxdEmailF.TabIndex = 45;
            // 
            // lblSenhaF
            // 
            this.lblSenhaF.AutoSize = true;
            this.lblSenhaF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaF.ForeColor = System.Drawing.Color.White;
            this.lblSenhaF.Location = new System.Drawing.Point(466, 17);
            this.lblSenhaF.Name = "lblSenhaF";
            this.lblSenhaF.Size = new System.Drawing.Size(57, 21);
            this.lblSenhaF.TabIndex = 9;
            this.lblSenhaF.Text = "Senha";
            // 
            // lblNomeF
            // 
            this.lblNomeF.AutoSize = true;
            this.lblNomeF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeF.ForeColor = System.Drawing.Color.White;
            this.lblNomeF.Location = new System.Drawing.Point(209, 17);
            this.lblNomeF.Name = "lblNomeF";
            this.lblNomeF.Size = new System.Drawing.Size(57, 21);
            this.lblNomeF.TabIndex = 7;
            this.lblNomeF.Text = "Nome";
            // 
            // BoxdNomeF
            // 
            this.BoxdNomeF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxdNomeF.Location = new System.Drawing.Point(115, 41);
            this.BoxdNomeF.MaxLength = 100;
            this.BoxdNomeF.Name = "BoxdNomeF";
            this.BoxdNomeF.Size = new System.Drawing.Size(245, 29);
            this.BoxdNomeF.TabIndex = 6;
            // 
            // BoxdSenhaF
            // 
            this.BoxdSenhaF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxdSenhaF.Location = new System.Drawing.Point(374, 41);
            this.BoxdSenhaF.MaxLength = 100;
            this.BoxdSenhaF.Name = "BoxdSenhaF";
            this.BoxdSenhaF.Size = new System.Drawing.Size(245, 29);
            this.BoxdSenhaF.TabIndex = 8;
            // 
            // lblIdF
            // 
            this.lblIdF.AutoSize = true;
            this.lblIdF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdF.ForeColor = System.Drawing.Color.White;
            this.lblIdF.Location = new System.Drawing.Point(45, 17);
            this.lblIdF.Name = "lblIdF";
            this.lblIdF.Size = new System.Drawing.Size(25, 21);
            this.lblIdF.TabIndex = 5;
            this.lblIdF.Text = "Id";
            // 
            // BoxdIdF
            // 
            this.BoxdIdF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxdIdF.Location = new System.Drawing.Point(28, 41);
            this.BoxdIdF.MaxLength = 100;
            this.BoxdIdF.Name = "BoxdIdF";
            this.BoxdIdF.Size = new System.Drawing.Size(59, 29);
            this.BoxdIdF.TabIndex = 4;
            // 
            // panelFundoDT
            // 
            this.panelFundoDT.Controls.Add(this.DTgridClientes);
            this.panelFundoDT.Location = new System.Drawing.Point(3, 9);
            this.panelFundoDT.Name = "panelFundoDT";
            this.panelFundoDT.Size = new System.Drawing.Size(979, 552);
            this.panelFundoDT.TabIndex = 1;
            // 
            // DTgridClientes
            // 
            this.DTgridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTgridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTgridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTgridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DTgridClientes.ColumnHeadersHeight = 30;
            this.DTgridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTgridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTgridClientes.DefaultCellStyle = dataGridViewCellStyle10;
            this.DTgridClientes.GridColor = System.Drawing.Color.Black;
            this.DTgridClientes.Location = new System.Drawing.Point(3, 3);
            this.DTgridClientes.Name = "DTgridClientes";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DTgridClientes.RowHeadersWidth = 51;
            this.DTgridClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DTgridClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTgridClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DTgridClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.DTgridClientes.RowTemplate.Height = 30;
            this.DTgridClientes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DTgridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTgridClientes.Size = new System.Drawing.Size(973, 546);
            this.DTgridClientes.TabIndex = 30;
            this.DTgridClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DTgridClientes_CellMouseClick);
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
            this.paneltopbar.TabIndex = 46;
            // 
            // MinimizarJanela
            // 
            this.MinimizarJanela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MinimizarJanela.FlatAppearance.BorderSize = 0;
            this.MinimizarJanela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MinimizarJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizarJanela.Image = global::UkraBar.Properties.Resources.minimize_window_24px;
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
            this.MaximizarJanela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MaximizarJanela.FlatAppearance.BorderSize = 0;
            this.MaximizarJanela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MaximizarJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizarJanela.Image = global::UkraBar.Properties.Resources.maximize_window_24px;
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
            this.FecharJanelaF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FecharJanelaF.FlatAppearance.BorderSize = 0;
            this.FecharJanelaF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FecharJanelaF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FecharJanelaF.Image = global::UkraBar.Properties.Resources.close_window_24px1;
            this.FecharJanelaF.Location = new System.Drawing.Point(1336, 9);
            this.FecharJanelaF.Name = "FecharJanelaF";
            this.FecharJanelaF.Size = new System.Drawing.Size(25, 25);
            this.FecharJanelaF.TabIndex = 0;
            this.FecharJanelaF.Text = "       ";
            this.FecharJanelaF.UseVisualStyleBackColor = false;
            this.FecharJanelaF.Click += new System.EventHandler(this.FecharJanelaF_Click_1);
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
            this.BarSideTop.TabIndex = 48;
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLabel.Controls.Add(this.lblFunc);
            this.panelLabel.Location = new System.Drawing.Point(3, 3);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(287, 61);
            this.panelLabel.TabIndex = 39;
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.ForeColor = System.Drawing.Color.White;
            this.lblFunc.Location = new System.Drawing.Point(9, 20);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFunc.Size = new System.Drawing.Size(262, 21);
            this.lblFunc.TabIndex = 0;
            this.lblFunc.Text = "CRUD | Cofigurações de Funcionário";
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
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::UkraBar.Properties.Resources.search_more_24px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxBuscar.Location = new System.Drawing.Point(21, 20);
            this.BoxBuscar.Name = "BoxBuscar";
            this.BoxBuscar.Size = new System.Drawing.Size(253, 19);
            this.BoxBuscar.TabIndex = 29;
            this.BoxBuscar.Tag = "";
            // 
            // FundoPesquisar
            // 
            this.FundoPesquisar.Image = global::UkraBar.Properties.Resources.BoxBranca;
            this.FundoPesquisar.Location = new System.Drawing.Point(3, 7);
            this.FundoPesquisar.Name = "FundoPesquisar";
            this.FundoPesquisar.Size = new System.Drawing.Size(292, 47);
            this.FundoPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FundoPesquisar.TabIndex = 33;
            this.FundoPesquisar.TabStop = false;
            // 
            // sideBarMenu
            // 
            this.sideBarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sideBarMenu.Controls.Add(this.panelMenu);
            this.sideBarMenu.Controls.Add(this.panelShowConfig);
            this.sideBarMenu.Controls.Add(this.BtnSobre);
            this.sideBarMenu.Controls.Add(this.BtnVoltar);
            this.sideBarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarMenu.Location = new System.Drawing.Point(0, 39);
            this.sideBarMenu.MaximumSize = new System.Drawing.Size(226, 749);
            this.sideBarMenu.MinimumSize = new System.Drawing.Size(76, 0);
            this.sideBarMenu.Name = "sideBarMenu";
            this.sideBarMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sideBarMenu.Size = new System.Drawing.Size(76, 710);
            this.sideBarMenu.TabIndex = 47;
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
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
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
            this.pbMenu.Location = new System.Drawing.Point(17, 37);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(30, 28);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click_1);
            // 
            // panelShowConfig
            // 
            this.panelShowConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelShowConfig.Controls.Add(this.BtnEditar);
            this.panelShowConfig.Controls.Add(this.BtnNovoFunc);
            this.panelShowConfig.Controls.Add(this.BtnDeletar);
            this.panelShowConfig.Controls.Add(this.BtnConfigurações);
            this.panelShowConfig.Location = new System.Drawing.Point(3, 125);
            this.panelShowConfig.MaximumSize = new System.Drawing.Size(223, 200);
            this.panelShowConfig.MinimumSize = new System.Drawing.Size(223, 50);
            this.panelShowConfig.Name = "panelShowConfig";
            this.panelShowConfig.Size = new System.Drawing.Size(223, 50);
            this.panelShowConfig.TabIndex = 45;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Image = global::UkraBar.Properties.Resources.pencil_24px;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(1, 150);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEditar.Size = new System.Drawing.Size(231, 50);
            this.BtnEditar.TabIndex = 43;
            this.BtnEditar.Text = "                    Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnNovoFunc
            // 
            this.BtnNovoFunc.BackColor = System.Drawing.Color.Green;
            this.BtnNovoFunc.FlatAppearance.BorderSize = 0;
            this.BtnNovoFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovoFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoFunc.ForeColor = System.Drawing.Color.White;
            this.BtnNovoFunc.Image = global::UkraBar.Properties.Resources.add_30px;
            this.BtnNovoFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovoFunc.Location = new System.Drawing.Point(1, 52);
            this.BtnNovoFunc.Name = "BtnNovoFunc";
            this.BtnNovoFunc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnNovoFunc.Size = new System.Drawing.Size(229, 50);
            this.BtnNovoFunc.TabIndex = 40;
            this.BtnNovoFunc.Text = "               Novo Funcionário";
            this.BtnNovoFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovoFunc.UseVisualStyleBackColor = false;
            this.BtnNovoFunc.Click += new System.EventHandler(this.BtnNovoFunc_Click_1);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Red;
            this.BtnDeletar.FlatAppearance.BorderSize = 0;
            this.BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.ForeColor = System.Drawing.Color.White;
            this.BtnDeletar.Image = global::UkraBar.Properties.Resources.trash_26px;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeletar.Location = new System.Drawing.Point(1, 102);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnDeletar.Size = new System.Drawing.Size(223, 50);
            this.BtnDeletar.TabIndex = 41;
            this.BtnDeletar.Text = "                  Deletar";
            this.BtnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeletar.UseVisualStyleBackColor = false;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click_1);
            // 
            // BtnConfigurações
            // 
            this.BtnConfigurações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnConfigurações.FlatAppearance.BorderSize = 0;
            this.BtnConfigurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfigurações.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfigurações.ForeColor = System.Drawing.Color.White;
            this.BtnConfigurações.Image = global::UkraBar.Properties.Resources.engineering_30px;
            this.BtnConfigurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfigurações.Location = new System.Drawing.Point(0, 0);
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
            this.BtnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSobre.ForeColor = System.Drawing.Color.White;
            this.BtnSobre.Image = global::UkraBar.Properties.Resources.info_24px;
            this.BtnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.Location = new System.Drawing.Point(3, 181);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnSobre.Size = new System.Drawing.Size(223, 50);
            this.BtnSobre.TabIndex = 38;
            this.BtnSobre.Text = "                  Sobre";
            this.BtnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.UseVisualStyleBackColor = false;
            this.BtnSobre.Click += new System.EventHandler(this.BtnSobre_Click_1);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVoltar.AutoSize = true;
            this.BtnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.Image = global::UkraBar.Properties.Resources.reply_arrow_24px;
            this.BtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar.Location = new System.Drawing.Point(3, 237);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnVoltar.Size = new System.Drawing.Size(223, 50);
            this.BtnVoltar.TabIndex = 39;
            this.BtnVoltar.Text = "                  Voltar";
            this.BtnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // PanelCadastrarFunc
            // 
            this.PanelCadastrarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelCadastrarFunc.Controls.Add(this.BtnSalvar);
            this.PanelCadastrarFunc.Controls.Add(this.BoxcEmail);
            this.PanelCadastrarFunc.Controls.Add(this.BoxcSenha);
            this.PanelCadastrarFunc.Controls.Add(this.BoxcId);
            this.PanelCadastrarFunc.Controls.Add(this.lblEmail);
            this.PanelCadastrarFunc.Controls.Add(this.BoxcNome);
            this.PanelCadastrarFunc.Controls.Add(this.lblNome);
            this.PanelCadastrarFunc.Controls.Add(this.panelAviso);
            this.PanelCadastrarFunc.Controls.Add(this.lblSenha);
            this.PanelCadastrarFunc.Controls.Add(this.pbFechar);
            this.PanelCadastrarFunc.Controls.Add(this.lblId);
            this.PanelCadastrarFunc.Location = new System.Drawing.Point(269, 156);
            this.PanelCadastrarFunc.MaximumSize = new System.Drawing.Size(982, 560);
            this.PanelCadastrarFunc.MinimumSize = new System.Drawing.Size(0, 560);
            this.PanelCadastrarFunc.Name = "PanelCadastrarFunc";
            this.PanelCadastrarFunc.Size = new System.Drawing.Size(0, 560);
            this.PanelCadastrarFunc.TabIndex = 49;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Image = global::UkraBar.Properties.Resources.Checkmark_24px;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvar.Location = new System.Drawing.Point(62, 424);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.BtnSalvar.Size = new System.Drawing.Size(250, 50);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "                        Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // pbFechar
            // 
            this.pbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFechar.Image = global::UkraBar.Properties.Resources.X_Key_50px;
            this.pbFechar.Location = new System.Drawing.Point(936, 4);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(40, 40);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFechar.TabIndex = 0;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click_1);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImageColumn1.FillWeight = 167.1073F;
            this.dataGridViewImageColumn1.HeaderText = "CEditar";
            this.dataGridViewImageColumn1.Image = global::UkraBar.Properties.Resources.pencil_16px;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 237;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 102.4358F;
            this.dataGridViewImageColumn2.HeaderText = "Deletar";
            this.dataGridViewImageColumn2.Image = global::UkraBar.Properties.Resources.trash_16px;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 236;
            // 
            // CadastrarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UkraBar.Properties.Resources.FundoFinal;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PanelCadastrarFunc);
            this.Controls.Add(this.BarSideTop);
            this.Controls.Add(this.sideBarMenu);
            this.Controls.Add(this.paneltopbar);
            this.Controls.Add(this.LayoutFundoDT);
            this.Name = "CadastrarFunc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Painel de Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarFunc_Load);
            this.panelAviso.ResumeLayout(false);
            this.panelAviso.PerformLayout();
            this.LayoutFundoDT.ResumeLayout(false);
            this.panelEditarFundo.ResumeLayout(false);
            this.panelEditarFundo.PerformLayout();
            this.panelFundoDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTgridClientes)).EndInit();
            this.paneltopbar.ResumeLayout(false);
            this.BarSideTop.ResumeLayout(false);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FundoPesquisar)).EndInit();
            this.sideBarMenu.ResumeLayout(false);
            this.sideBarMenu.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panelShowConfig.ResumeLayout(false);
            this.PanelCadastrarFunc.ResumeLayout(false);
            this.PanelCadastrarFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SideBarTime;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Timer NovoFuncTimer;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox BoxcEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox BoxcSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel panelAviso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox BoxcId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox pbFechar;
        private System.Windows.Forms.TextBox BoxcNome;
        private System.Windows.Forms.FlowLayoutPanel LayoutFundoDT;
        private System.Windows.Forms.Panel panelEditarFundo;
        private System.Windows.Forms.Button BtnPincel;
        private System.Windows.Forms.Label lblEmailF;
        private System.Windows.Forms.TextBox BoxdEmailF;
        private System.Windows.Forms.Label lblSenhaF;
        private System.Windows.Forms.TextBox BoxdSenhaF;
        private System.Windows.Forms.Label lblNomeF;
        private System.Windows.Forms.TextBox BoxdNomeF;
        private System.Windows.Forms.Label lblIdF;
        private System.Windows.Forms.TextBox BoxdIdF;
        private System.Windows.Forms.Panel panelFundoDT;
        private System.Windows.Forms.Panel paneltopbar;
        private System.Windows.Forms.FlowLayoutPanel BarSideTop;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox BoxBuscar;
        private System.Windows.Forms.PictureBox FundoPesquisar;
        private System.Windows.Forms.FlowLayoutPanel sideBarMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Panel panelShowConfig;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovoFunc;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnConfigurações;
        private System.Windows.Forms.Button BtnSobre;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button FecharJanelaF;
        private System.Windows.Forms.Button MinimizarJanela;
        private System.Windows.Forms.Button MaximizarJanela;
        private System.Windows.Forms.Panel PanelCadastrarFunc;
        private System.Windows.Forms.DataGridView DTgridClientes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
    }
}