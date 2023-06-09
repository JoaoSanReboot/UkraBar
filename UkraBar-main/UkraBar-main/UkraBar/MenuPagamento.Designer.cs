namespace UkraBar
{
    partial class MenuPagamento
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
            this.BtnPix = new System.Windows.Forms.Button();
            this.BtnCartao = new System.Windows.Forms.Button();
            this.BtnDinheiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPix
            // 
            this.BtnPix.BackColor = System.Drawing.Color.Green;
            this.BtnPix.FlatAppearance.BorderSize = 0;
            this.BtnPix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPix.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPix.ForeColor = System.Drawing.Color.White;
            this.BtnPix.Location = new System.Drawing.Point(163, 500);
            this.BtnPix.Name = "BtnPix";
            this.BtnPix.Size = new System.Drawing.Size(180, 76);
            this.BtnPix.TabIndex = 0;
            this.BtnPix.Text = "Selecionar";
            this.BtnPix.UseVisualStyleBackColor = false;
            this.BtnPix.Click += new System.EventHandler(this.BtnPix_Click);
            // 
            // BtnCartao
            // 
            this.BtnCartao.BackColor = System.Drawing.Color.Green;
            this.BtnCartao.FlatAppearance.BorderSize = 0;
            this.BtnCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCartao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCartao.ForeColor = System.Drawing.Color.White;
            this.BtnCartao.Location = new System.Drawing.Point(594, 500);
            this.BtnCartao.Name = "BtnCartao";
            this.BtnCartao.Size = new System.Drawing.Size(180, 76);
            this.BtnCartao.TabIndex = 1;
            this.BtnCartao.Text = "Selecionar";
            this.BtnCartao.UseVisualStyleBackColor = false;
            this.BtnCartao.Click += new System.EventHandler(this.BtnCartao_Click);
            // 
            // BtnDinheiro
            // 
            this.BtnDinheiro.BackColor = System.Drawing.Color.Green;
            this.BtnDinheiro.FlatAppearance.BorderSize = 0;
            this.BtnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDinheiro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDinheiro.ForeColor = System.Drawing.Color.White;
            this.BtnDinheiro.Location = new System.Drawing.Point(1026, 500);
            this.BtnDinheiro.Name = "BtnDinheiro";
            this.BtnDinheiro.Size = new System.Drawing.Size(180, 76);
            this.BtnDinheiro.TabIndex = 2;
            this.BtnDinheiro.Text = "Selecionar";
            this.BtnDinheiro.UseVisualStyleBackColor = false;
            this.BtnDinheiro.Click += new System.EventHandler(this.BtnDinheiro_Click);
            // 
            // MenuPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UkraBar.Properties.Resources.Pagamento;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BtnDinheiro);
            this.Controls.Add(this.BtnCartao);
            this.Controls.Add(this.BtnPix);
            this.Name = "MenuPagamento";
            this.Text = "MenuPagamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPix;
        private System.Windows.Forms.Button BtnCartao;
        private System.Windows.Forms.Button BtnDinheiro;
    }
}