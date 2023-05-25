namespace UkraBar
{
    partial class _NomeCliente
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnNome = new System.Windows.Forms.Button();
            this.BoxNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::UkraBar.Properties.Resources.ComoDeseja;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 749);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnNome
            // 
            this.BtnNome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNome.FlatAppearance.BorderSize = 0;
            this.BtnNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnNome.Location = new System.Drawing.Point(581, 467);
            this.BtnNome.Name = "BtnNome";
            this.BtnNome.Size = new System.Drawing.Size(180, 76);
            this.BtnNome.TabIndex = 2;
            this.BtnNome.Text = "Avançar";
            this.BtnNome.UseVisualStyleBackColor = false;
            this.BtnNome.Click += new System.EventHandler(this.BtnNome_Click);
            // 
            // BoxNome
            // 
            this.BoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNome.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNome.Location = new System.Drawing.Point(449, 384);
            this.BoxNome.MaxLength = 60;
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(482, 28);
            this.BoxNome.TabIndex = 3;
            this.BoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _NomeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.BtnNome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "_NomeCliente";
            this.Text = "_NomeCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnNome;
        private System.Windows.Forms.TextBox BoxNome;
    }
}