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
            this.BtnNome = new System.Windows.Forms.Button();
            this.BoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnNome
            // 
            this.BtnNome.BackColor = System.Drawing.Color.Green;
            this.BtnNome.FlatAppearance.BorderSize = 0;
            this.BtnNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNome.ForeColor = System.Drawing.Color.White;
            this.BtnNome.Location = new System.Drawing.Point(581, 474);
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
            this.BoxNome.Location = new System.Drawing.Point(491, 407);
            this.BoxNome.MaxLength = 60;
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(387, 28);
            this.BoxNome.TabIndex = 3;
            this.BoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _NomeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UkraBar.Properties.Resources.ComoDesejaSer;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.BtnNome);
            this.Name = "_NomeCliente";
            this.Text = "_NomeCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnNome;
        private System.Windows.Forms.TextBox BoxNome;
    }
}