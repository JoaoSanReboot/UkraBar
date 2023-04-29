using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UkraBar
{
    public partial class PainelAdm : Form
    {
        public PainelAdm()
        {
            InitializeComponent();
        }

        Panel p = new Panel();//Complementação do comando da linha verde dos botões
          
        private void btnMouseEnter(object sender, EventArgs e)
        {

            //Deixa uma linha verde abaixo dos botões selecionados

            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(187, 25);
            p.Location = new
                Point(btn.Location.X, btn.Location.Y + 40);
        }
         
        private void btnMouseLeave(object sender, EventArgs e)
        {
           //Esconde a linha verde dos botões quando não selecionados
           pMenu.Controls.Remove(p);
        }

        private void PainelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)//Panel para mostrar botões
        {
            if (!pCadastro.Visible)

                pCadastro.Visible = true; //Exibi o Painel de Botões 

            else

                pCadastro.Visible = false;//Esconde o Painel de Botões
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CadastrarProdP ProdCad = new CadastrarProdP();
            this.Hide();
            ProdCad.ShowDialog();
            this.Close();

        }//Botão de Cadastro de Produto

        private void button9_Click(object sender, EventArgs e)//Botão de Cadastro Desconto
        {
            CadastrarDesc DesCad = new CadastrarDesc();
            this.Hide();
            DesCad.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)//Botão de Cadastro Funcionario
        {
            CadastrarFunc FuncCad = new CadastrarFunc();
            this.Hide();
            FuncCad.ShowDialog();
            this.Close();
        }

        private void BtnMesas_Click(object sender, EventArgs e)
        {
            CadastrarMesas MesasCad = new CadastrarMesas();
            this.Hide();
            MesasCad.ShowDialog();
            this.Close();
        }//Botao Cadastras Mesas

        private void voltar1_Click(object sender, EventArgs e)
        {
            PainelLogins PainelLog = new PainelLogins();
            this.Hide();
            PainelLog.ShowDialog();
            this.Close();
        }//Botão de Voltar para Logins

        private void pCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
