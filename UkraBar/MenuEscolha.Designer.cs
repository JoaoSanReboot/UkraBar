namespace UkraBar
{
    partial class MenuEscolha
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
            this.BtnSobremesas = new System.Windows.Forms.PictureBox();
            this.BtnBebidas = new System.Windows.Forms.PictureBox();
            this.BtnPratos = new System.Windows.Forms.PictureBox();
            this.BtnSanduba = new System.Windows.Forms.PictureBox();
            this.TelaFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSobremesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSanduba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSobremesas
            // 
            this.BtnSobremesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSobremesas.Image = global::UkraBar.Properties.Resources.BtnSobremesas;
            this.BtnSobremesas.Location = new System.Drawing.Point(972, 349);
            this.BtnSobremesas.Name = "BtnSobremesas";
            this.BtnSobremesas.Size = new System.Drawing.Size(325, 299);
            this.BtnSobremesas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnSobremesas.TabIndex = 4;
            this.BtnSobremesas.TabStop = false;
            // 
            // BtnBebidas
            // 
            this.BtnBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBebidas.Image = global::UkraBar.Properties.Resources.BtnBebidas;
            this.BtnBebidas.Location = new System.Drawing.Point(680, 350);
            this.BtnBebidas.Name = "BtnBebidas";
            this.BtnBebidas.Size = new System.Drawing.Size(292, 297);
            this.BtnBebidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnBebidas.TabIndex = 3;
            this.BtnBebidas.TabStop = false;
            // 
            // BtnPratos
            // 
            this.BtnPratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPratos.Image = global::UkraBar.Properties.Resources.BtnPratos;
            this.BtnPratos.Location = new System.Drawing.Point(392, 355);
            this.BtnPratos.Name = "BtnPratos";
            this.BtnPratos.Size = new System.Drawing.Size(266, 285);
            this.BtnPratos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPratos.TabIndex = 2;
            this.BtnPratos.TabStop = false;
            // 
            // BtnSanduba
            // 
            this.BtnSanduba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSanduba.Image = global::UkraBar.Properties.Resources.BtnSandubas;
            this.BtnSanduba.Location = new System.Drawing.Point(78, 356);
            this.BtnSanduba.Name = "BtnSanduba";
            this.BtnSanduba.Size = new System.Drawing.Size(294, 290);
            this.BtnSanduba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnSanduba.TabIndex = 1;
            this.BtnSanduba.TabStop = false;
            // 
            // TelaFundo
            // 
            this.TelaFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TelaFundo.Image = global::UkraBar.Properties.Resources.sale__1___1_;
            this.TelaFundo.Location = new System.Drawing.Point(0, 0);
            this.TelaFundo.Name = "TelaFundo";
            this.TelaFundo.Size = new System.Drawing.Size(1370, 673);
            this.TelaFundo.TabIndex = 0;
            this.TelaFundo.TabStop = false;
            // 
            // MenuEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 673);
            this.Controls.Add(this.BtnSobremesas);
            this.Controls.Add(this.BtnBebidas);
            this.Controls.Add(this.BtnPratos);
            this.Controls.Add(this.BtnSanduba);
            this.Controls.Add(this.TelaFundo);
            this.Name = "MenuEscolha";
            this.Text = "Cardapio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BtnSobremesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSanduba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelaFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TelaFundo;
        private System.Windows.Forms.PictureBox BtnSanduba;
        private System.Windows.Forms.PictureBox BtnPratos;
        private System.Windows.Forms.PictureBox BtnBebidas;
        private System.Windows.Forms.PictureBox BtnSobremesas;
    }
}