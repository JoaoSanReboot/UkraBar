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
            this.BtnCpfCad = new System.Windows.Forms.Button();
            this.BoxCpf = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelCpfNota = new System.Windows.Forms.Panel();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnNao = new System.Windows.Forms.Button();
            this.PanelCpfNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCpfCad
            // 
            this.BtnCpfCad.BackColor = System.Drawing.Color.Green;
            this.BtnCpfCad.FlatAppearance.BorderSize = 0;
            this.BtnCpfCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCpfCad.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCpfCad.ForeColor = System.Drawing.Color.White;
            this.BtnCpfCad.Location = new System.Drawing.Point(595, 483);
            this.BtnCpfCad.Name = "BtnCpfCad";
            this.BtnCpfCad.Size = new System.Drawing.Size(167, 64);
            this.BtnCpfCad.TabIndex = 1;
            this.BtnCpfCad.Text = "AVANÇAR";
            this.BtnCpfCad.UseVisualStyleBackColor = false;
            this.BtnCpfCad.Click += new System.EventHandler(this.BtnCpfCad_Click);
            // 
            // BoxCpf
            // 
            this.BoxCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCpf.Location = new System.Drawing.Point(477, 416);
            this.BoxCpf.MaxLength = 11;
            this.BoxCpf.Name = "BoxCpf";
            this.BoxCpf.Size = new System.Drawing.Size(415, 28);
            this.BoxCpf.TabIndex = 4;
            this.BoxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxCpf.TextChanged += new System.EventHandler(this.BoxCpf_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 5;
            // 
            // PanelCpfNota
            // 
            this.PanelCpfNota.BackgroundImage = global::UkraBar.Properties.Resources.NotaCpf;
            this.PanelCpfNota.Controls.Add(this.BtnSim);
            this.PanelCpfNota.Controls.Add(this.BtnNao);
            this.PanelCpfNota.Location = new System.Drawing.Point(301, 251);
            this.PanelCpfNota.Name = "PanelCpfNota";
            this.PanelCpfNota.Size = new System.Drawing.Size(775, 429);
            this.PanelCpfNota.TabIndex = 3;
            // 
            // BtnSim
            // 
            this.BtnSim.BackColor = System.Drawing.Color.Green;
            this.BtnSim.FlatAppearance.BorderSize = 0;
            this.BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSim.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSim.Location = new System.Drawing.Point(76, 197);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(260, 74);
            this.BtnSim.TabIndex = 2;
            this.BtnSim.Text = "SIM";
            this.BtnSim.UseVisualStyleBackColor = false;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // BtnNao
            // 
            this.BtnNao.BackColor = System.Drawing.Color.Red;
            this.BtnNao.FlatAppearance.BorderSize = 0;
            this.BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNao.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnNao.Location = new System.Drawing.Point(432, 197);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(260, 74);
            this.BtnNao.TabIndex = 1;
            this.BtnNao.Text = "NÃO";
            this.BtnNao.UseVisualStyleBackColor = false;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UkraBar.Properties.Resources.FundoCpf;
            this.ClientSize = new System.Drawing.Size(1270, 749);
            this.Controls.Add(this.PanelCpfNota);
            this.Controls.Add(this.BtnCpfCad);
            this.Controls.Add(this.BoxCpf);
            this.Controls.Add(this.panel1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.PanelCpfNota.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCpfCad;
        private System.Windows.Forms.Panel PanelCpfNota;
        private System.Windows.Forms.Button BtnNao;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.TextBox BoxCpf;
        private System.Windows.Forms.Panel panel1;
    }
}