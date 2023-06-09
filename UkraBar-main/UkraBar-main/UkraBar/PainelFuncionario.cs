using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkraBar
{
    public partial class PainelFuncionario : Form
    {
        public PainelFuncionario()
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            PainelLogins painel = new PainelLogins();
            this.Hide();
            painel.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!PanelSair.Visible)

                PanelSair.Visible = true; //Exibi o Painel de Botões 

            else

                PanelSair.Visible = false;//Esconde o Painel de Botões
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (!pCadastro.Visible)

                pCadastro.Visible = true; //Exibi o Painel de Botões 

            else

                pCadastro.Visible = false;//Esconde o Painel de Botões
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            CadastrarProd ProdCad = new CadastrarProd();
            this.Hide();
            ProdCad.ShowDialog();
            this.Close();
        }

        private void BtnClientesView_Click(object sender, EventArgs e)
        {
            PainelCliente Cliente = new PainelCliente();
            this.Hide();
            Cliente.ShowDialog();
            this.Close();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            MenuEscolha menu = new MenuEscolha();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
    

