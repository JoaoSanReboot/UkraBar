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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sideBarMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.DTgridCarrinho = new System.Windows.Forms.DataGridView();
            this.DTgridCarrinho2 = new System.Windows.Forms.DataGridView();
            this.sideBarMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTgridCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTgridCarrinho2)).BeginInit();
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
            // DTgridCarrinho
            // 
            this.DTgridCarrinho.AllowUserToAddRows = false;
            this.DTgridCarrinho.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTgridCarrinho.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTgridCarrinho.GridColor = System.Drawing.Color.Black;
            this.DTgridCarrinho.Location = new System.Drawing.Point(297, 101);
            this.DTgridCarrinho.Name = "DTgridCarrinho";
            this.DTgridCarrinho.ReadOnly = true;
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
            this.DTgridCarrinho.Size = new System.Drawing.Size(328, 576);
            this.DTgridCarrinho.TabIndex = 30;
            // 
            // DTgridCarrinho2
            // 
            this.DTgridCarrinho2.AllowUserToAddRows = false;
            this.DTgridCarrinho2.AllowUserToDeleteRows = false;
            this.DTgridCarrinho2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTgridCarrinho2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTgridCarrinho2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridCarrinho2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTgridCarrinho2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTgridCarrinho2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridCarrinho2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DTgridCarrinho2.ColumnHeadersHeight = 30;
            this.DTgridCarrinho2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTgridCarrinho2.DefaultCellStyle = dataGridViewCellStyle5;
            this.DTgridCarrinho2.GridColor = System.Drawing.Color.Black;
            this.DTgridCarrinho2.Location = new System.Drawing.Point(625, 101);
            this.DTgridCarrinho2.Name = "DTgridCarrinho2";
            this.DTgridCarrinho2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTgridCarrinho2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DTgridCarrinho2.RowHeadersWidth = 51;
            this.DTgridCarrinho2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DTgridCarrinho2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DTgridCarrinho2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTgridCarrinho2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DTgridCarrinho2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.DTgridCarrinho2.RowTemplate.Height = 30;
            this.DTgridCarrinho2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DTgridCarrinho2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTgridCarrinho2.Size = new System.Drawing.Size(609, 576);
            this.DTgridCarrinho2.TabIndex = 50;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.DTgridCarrinho2);
            this.Controls.Add(this.DTgridCarrinho);
            this.Controls.Add(this.sideBarMenu);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sideBarMenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTgridCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTgridCarrinho2)).EndInit();
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
        private System.Windows.Forms.DataGridView DTgridCarrinho;
        private System.Windows.Forms.DataGridView DTgridCarrinho2;
    }
}