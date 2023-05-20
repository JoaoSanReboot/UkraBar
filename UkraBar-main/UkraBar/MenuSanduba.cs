using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar;

namespace UkraBar
{
    public partial class MenuSanduba : Form
    {
        public MenuSanduba()
        {
            InitializeComponent();
            AtualizarValor();
        }

        private string quantidadeArmazenada = string.Empty;

        //Todos os Btn Compras.
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            panelItaliano.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelIberico.Visible = true;
        }
        private void BtnComprarPolones_Click(object sender, EventArgs e)
        {
            panelZapiekanka.Visible = true;
        }
        private void BtnVegetariano_Click(object sender, EventArgs e)
        {
            panelVegetariano.Visible = true;
        }
        private void BtnKatsuoSando_Click(object sender, EventArgs e)
        {
            panelKatsuSando.Visible = true;
        }
        private void BtnComprarAlemao_Click(object sender, EventArgs e)
        {
            panelAlemão.Visible = true;
        }

        //Todos Btn Cancelar

        private void BtnCancelarI_Click(object sender, EventArgs e)
        {
            panelItaliano.Visible = false;
        }
        private void BtnCancelarIB_Click(object sender, EventArgs e)
        {
            panelIberico.Visible = false;
        }
        private void BtnCancelarZ_Click(object sender, EventArgs e)
        {
            panelZapiekanka.Visible = false;
        }
        private void BtnCancelarK_Click(object sender, EventArgs e)
        {
            panelKatsuSando.Visible = false;
        }
        private void BtnCancelarV_Click(object sender, EventArgs e)
        {
            panelVegetariano.Visible = false;
        }
        private void BtnCancelarA_Click(object sender, EventArgs e)
        {
            panelAlemão.Visible = false;
        }

        //Todos os Btn Ok
        private void BtnOkI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VariaveisGlobais.quantidadeItaliano.ToString(), "Foram adicionados no Carrinho");
            panelItaliano.Visible = false;
        }

        private void BtnOkK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VariaveisGlobais.quantidadeJapones.ToString(), "Foram adicionados no Carrinho");
            panelKatsuSando.Visible = false;
        }

        private void BtnOkV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("R$"+VariaveisGlobais.valorVegetariano.ToString()+",00", "Foram adicionados no Carrinho");
            panelVegetariano.Visible = false;
        }
        private void BtnOkZ_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VariaveisGlobais.quantidadePolones.ToString(), "Foram adicionados no Carrinho");
            panelZapiekanka.Visible = false;
        }

        private void BtnOkA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VariaveisGlobais.quantidadeAlemao.ToString(), "Foram adicionados no Carrinho");
            panelAlemão.Visible = false;
        }

        private void BtnOkIB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VariaveisGlobais.quantidadeIberico.ToString(), "Foram adicionados no Carrinho");
            panelIberico.Visible = false;
        }


        //Resto
        private void AtualizarValor()
        {
            BoxCItaliano.Text = VariaveisGlobais.quantidadeItaliano.ToString();
            BoxcQuantidadeI.Text = VariaveisGlobais.quantidadeIberico.ToString();
            BoxCQuantidadeZ.Text = VariaveisGlobais.quantidadePolones.ToString();
            BoxCQuantidadeK.Text = VariaveisGlobais.quantidadeJapones.ToString();
            BoxCQuantidadeV.Text = VariaveisGlobais.quantidadeVegetariano.ToString();
            BoxCQuantidadeA.Text = VariaveisGlobais.quantidadeAlemao.ToString();
        }

        private void BtnMenos1_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeItaliano > 0)
            {
                VariaveisGlobais.quantidadeItaliano--;
                AtualizarValor();

            }
        }

        private void BtnMais1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeItaliano++;
            AtualizarValor();
            VariaveisGlobais.valorItaliano = VariaveisGlobais.quantidadeItaliano * 24;
        }

        private void BtnMaisI_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeIberico++;
            AtualizarValor();
            VariaveisGlobais.valorIberico=VariaveisGlobais.quantidadeIberico* 27;
        }

        private void BtnMenosI_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeIberico > 0)
            {
                VariaveisGlobais.quantidadeIberico--;
                AtualizarValor();
            }
        }

        private void BtnMaisZ_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadePolones++;
            AtualizarValor();
            VariaveisGlobais.valorPolones = VariaveisGlobais.quantidadePolones * 24;
        }

        private void BtnMenosZ_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadePolones > 0)
            {
                VariaveisGlobais.quantidadePolones--;
                AtualizarValor();
            }
        }


        private void BtnMaisK_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeJapones++;
            AtualizarValor();
            VariaveisGlobais.valorJapones = VariaveisGlobais.quantidadeJapones * 24;
        }

        private void BtnMenosK_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeJapones > 0)
            {
                VariaveisGlobais.quantidadeJapones--;
                AtualizarValor();
            }
        }


        private void BtnMaisV_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeVegetariano++;
            AtualizarValor();
           VariaveisGlobais.valorVegetariano= VariaveisGlobais.quantidadeVegetariano * 22;
        }

        private void BtnMenosV_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeVegetariano > 0)
            {
                VariaveisGlobais.quantidadeVegetariano--;
                AtualizarValor();
                VariaveisGlobais.valorVegetariano - 22;
            }
        }

        private void BtnMaisA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeAlemao++;
            AtualizarValor();
            VariaveisGlobais.valorAlemao = VariaveisGlobais.quantidadeAlemao * 25;
        }

        private void BtnMenosA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeAlemao > 0)
            {
                VariaveisGlobais.quantidadeAlemao--;
                AtualizarValor();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            MenuEscolha Escolha = new MenuEscolha();
            this.Hide();
            Escolha.ShowDialog();
            this.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            this.Hide();
            cliente.ShowDialog();
            this.Close();
        }

        private void pbFundo_Click(object sender, EventArgs e)
        {

        }

        private void BoxCItaliano_Click(object sender, EventArgs e)
        {

        }

    }
}

