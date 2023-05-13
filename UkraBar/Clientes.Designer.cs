namespace UkraBar
{
    partial class Clientes
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
            this.BoxCliente = new System.Windows.Forms.TextBox();
            this.EntratCliente = new System.Windows.Forms.Button();
            this.BtnPular = new System.Windows.Forms.Button();
            this.TimerAviso = new System.Windows.Forms.Timer(this.components);
            this.pbFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxCliente
            // 
            this.BoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCliente.Location = new System.Drawing.Point(474, 408);
            this.BoxCliente.MaxLength = 11;
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Size = new System.Drawing.Size(419, 22);
            this.BoxCliente.TabIndex = 52;
            this.BoxCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EntratCliente
            // 
            this.EntratCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EntratCliente.FlatAppearance.BorderSize = 0;
            this.EntratCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntratCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntratCliente.ForeColor = System.Drawing.Color.White;
            this.EntratCliente.Location = new System.Drawing.Point(571, 467);
            this.EntratCliente.Name = "EntratCliente";
            this.EntratCliente.Size = new System.Drawing.Size(232, 54);
            this.EntratCliente.TabIndex = 54;
            this.EntratCliente.Text = "Entrar";
            this.EntratCliente.UseVisualStyleBackColor = false;
            this.EntratCliente.Click += new System.EventHandler(this.EntratCliente_Click);
            // 
            // BtnPular
            // 
            this.BtnPular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPular.FlatAppearance.BorderSize = 0;
            this.BtnPular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPular.ForeColor = System.Drawing.Color.White;
            this.BtnPular.Location = new System.Drawing.Point(1092, 683);
            this.BtnPular.Name = "BtnPular";
            this.BtnPular.Size = new System.Drawing.Size(157, 54);
            this.BtnPular.TabIndex = 55;
            this.BtnPular.Text = "Pular";
            this.BtnPular.UseVisualStyleBackColor = false;
            this.BtnPular.Click += new System.EventHandler(this.BtnPular_Click);
            // 
            // TimerAviso
            // 
            this.TimerAviso.Interval = 1000;
            this.TimerAviso.Tick += new System.EventHandler(this.TimerAviso_Tick);
            // 
            // pbFundo
            // 
            this.pbFundo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Image = global::UkraBar.Properties.Resources.sale__2_;
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(1270, 749);
            this.pbFundo.TabIndex = 51;
            this.pbFundo.TabStop = false;
            this.pbFundo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 749);
            this.Controls.Add(this.BtnPular);
            this.Controls.Add(this.EntratCliente);
            this.Controls.Add(this.BoxCliente);
            this.Controls.Add(this.pbFundo);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.TextBox BoxCliente;
        private System.Windows.Forms.Button EntratCliente;
        private System.Windows.Forms.Button BtnPular;
        private System.Windows.Forms.Timer TimerAviso;
    }
}