namespace UkraBar
{
    partial class CadastrarDesc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nome_desc = new System.Windows.Forms.Label();
            this.Porcentagem_desc = new System.Windows.Forms.Label();
            this.descricao_desc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cadastrar_desc = new System.Windows.Forms.Button();
            this.voltar_desc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(650, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Nome_desc
            // 
            this.Nome_desc.AutoSize = true;
            this.Nome_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_desc.Location = new System.Drawing.Point(646, 167);
            this.Nome_desc.Name = "Nome_desc";
            this.Nome_desc.Size = new System.Drawing.Size(62, 24);
            this.Nome_desc.TabIndex = 1;
            this.Nome_desc.Text = "Nome";
            // 
            // Porcentagem_desc
            // 
            this.Porcentagem_desc.AutoSize = true;
            this.Porcentagem_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcentagem_desc.Location = new System.Drawing.Point(647, 246);
            this.Porcentagem_desc.Name = "Porcentagem_desc";
            this.Porcentagem_desc.Size = new System.Drawing.Size(123, 24);
            this.Porcentagem_desc.TabIndex = 2;
            this.Porcentagem_desc.Text = "Porcentagem";
            this.Porcentagem_desc.Click += new System.EventHandler(this.label2_Click);
            // 
            // descricao_desc
            // 
            this.descricao_desc.AutoSize = true;
            this.descricao_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_desc.Location = new System.Drawing.Point(647, 309);
            this.descricao_desc.Name = "descricao_desc";
            this.descricao_desc.Size = new System.Drawing.Size(94, 24);
            this.descricao_desc.TabIndex = 3;
            this.descricao_desc.Text = "Descrição";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(650, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(650, 336);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 5;
            // 
            // cadastrar_desc
            // 
            this.cadastrar_desc.Location = new System.Drawing.Point(651, 412);
            this.cadastrar_desc.Name = "cadastrar_desc";
            this.cadastrar_desc.Size = new System.Drawing.Size(148, 47);
            this.cadastrar_desc.TabIndex = 6;
            this.cadastrar_desc.Text = "Cadastrar";
            this.cadastrar_desc.UseVisualStyleBackColor = true;
            this.cadastrar_desc.Click += new System.EventHandler(this.cadastrar_desc_Click);
            // 
            // voltar_desc
            // 
            this.voltar_desc.Location = new System.Drawing.Point(37, 31);
            this.voltar_desc.Name = "voltar_desc";
            this.voltar_desc.Size = new System.Drawing.Size(148, 47);
            this.voltar_desc.TabIndex = 7;
            this.voltar_desc.Text = "Voltar";
            this.voltar_desc.UseVisualStyleBackColor = true;
            this.voltar_desc.Click += new System.EventHandler(this.voltar_desc_Click);
            // 
            // CadastrarDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1034);
            this.Controls.Add(this.voltar_desc);
            this.Controls.Add(this.cadastrar_desc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.descricao_desc);
            this.Controls.Add(this.Porcentagem_desc);
            this.Controls.Add(this.Nome_desc);
            this.Controls.Add(this.textBox1);
            this.Name = "CadastrarDesc";
            this.Text = "CadastrarDesc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nome_desc;
        private System.Windows.Forms.Label Porcentagem_desc;
        private System.Windows.Forms.Label descricao_desc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cadastrar_desc;
        private System.Windows.Forms.Button voltar_desc;
    }
}