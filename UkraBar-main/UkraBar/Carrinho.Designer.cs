namespace UkraBar
{
    partial class Carrinho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sideBarMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
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
            this.DTgridCarrinho = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sideBarMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.LayoutFundoDT.SuspendLayout();
            this.panelEditarFundo.SuspendLayout();
            this.panelFundoDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTgridCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarMenu
            // 
            this.sideBarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sideBarMenu.Controls.Add(this.panelMenu);
            this.sideBarMenu.Controls.Add(this.BtnSobre);
            this.sideBarMenu.Controls.Add(this.BtnAjuda);
            this.sideBarMenu.Controls.Add(this.BtnVoltar);
            this.sideBarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarMenu.Location = new System.Drawing.Point(0, 0);
            this.sideBarMenu.MaximumSize = new System.Drawing.Size(226, 749);
            this.sideBarMenu.MinimumSize = new System.Drawing.Size(76, 749);
            this.sideBarMenu.Name = "sideBarMenu";
            this.sideBarMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sideBarMenu.Size = new System.Drawing.Size(226, 749);
            this.sideBarMenu.TabIndex = 49;
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
            this.BtnSobre.Location = new System.Drawing.Point(3, 125);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnSobre.Size = new System.Drawing.Size(223, 50);
            this.BtnSobre.TabIndex = 38;
            this.BtnSobre.Text = "                  Sobre";
            this.BtnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.UseVisualStyleBackColor = false;
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnAjuda.FlatAppearance.BorderSize = 0;
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjuda.ForeColor = System.Drawing.Color.White;
            this.BtnAjuda.Image = global::UkraBar.Properties.Resources.ask_question_24px;
            this.BtnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjuda.Location = new System.Drawing.Point(3, 181);
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
            // 
            // LayoutFundoDT
            // 
            this.LayoutFundoDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutFundoDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.LayoutFundoDT.Controls.Add(this.panelEditarFundo);
            this.LayoutFundoDT.Controls.Add(this.panelFundoDT);
            this.LayoutFundoDT.Location = new System.Drawing.Point(241, 125);
            this.LayoutFundoDT.Name = "LayoutFundoDT";
            this.LayoutFundoDT.Size = new System.Drawing.Size(982, 561);
            this.LayoutFundoDT.TabIndex = 51;
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
            this.panelEditarFundo.MaximumSize = new System.Drawing.Size(979, 103);
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
            this.BtnPincel.Location = new System.Drawing.Point(895, 26);
            this.BtnPincel.Name = "BtnPincel";
            this.BtnPincel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnPincel.Size = new System.Drawing.Size(59, 59);
            this.BtnPincel.TabIndex = 46;
            this.BtnPincel.Text = "                  Editar";
            this.BtnPincel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPincel.UseVisualStyleBackColor = false;
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
            this.panelFundoDT.Controls.Add(this.DTgridCarrinho);
            this.panelFundoDT.Location = new System.Drawing.Point(3, 9);
            this.panelFundoDT.Name = "panelFundoDT";
            this.panelFundoDT.Size = new System.Drawing.Size(979, 552);
            this.panelFundoDT.TabIndex = 1;
            // 
            // DTgridCarrinho
            // 
            this.DTgridCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTgridCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTgridCarrinho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTgridCarrinho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTgridCarrinho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridCarrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTgridCarrinho.ColumnHeadersHeight = 30;
            this.DTgridCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTgridCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTgridCarrinho.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTgridCarrinho.GridColor = System.Drawing.Color.Black;
            this.DTgridCarrinho.Location = new System.Drawing.Point(3, 3);
            this.DTgridCarrinho.Name = "DTgridCarrinho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridCarrinho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DTgridCarrinho.RowHeadersWidth = 51;
            this.DTgridCarrinho.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DTgridCarrinho.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridCarrinho.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTgridCarrinho.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DTgridCarrinho.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.DTgridCarrinho.RowTemplate.Height = 30;
            this.DTgridCarrinho.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DTgridCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTgridCarrinho.Size = new System.Drawing.Size(973, 546);
            this.DTgridCarrinho.TabIndex = 30;
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
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.LayoutFundoDT);
            this.Controls.Add(this.sideBarMenu);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sideBarMenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.LayoutFundoDT.ResumeLayout(false);
            this.panelEditarFundo.ResumeLayout(false);
            this.panelEditarFundo.PerformLayout();
            this.panelFundoDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTgridCarrinho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sideBarMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Button BtnSobre;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.FlowLayoutPanel LayoutFundoDT;
        private System.Windows.Forms.Panel panelEditarFundo;
        private System.Windows.Forms.Button BtnPincel;
        private System.Windows.Forms.Label lblEmailF;
        private System.Windows.Forms.TextBox BoxdEmailF;
        private System.Windows.Forms.Label lblSenhaF;
        private System.Windows.Forms.Label lblNomeF;
        private System.Windows.Forms.TextBox BoxdNomeF;
        private System.Windows.Forms.TextBox BoxdSenhaF;
        private System.Windows.Forms.Label lblIdF;
        private System.Windows.Forms.TextBox BoxdIdF;
        private System.Windows.Forms.Panel panelFundoDT;
        private System.Windows.Forms.DataGridView DTgridCarrinho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
    }
}