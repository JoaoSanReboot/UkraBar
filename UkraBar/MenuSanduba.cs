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

        private int quantidadeItaliano = 0;
        private int quantidadeIberico = 0;
        private int quantidadePolones = 0;
        private int quantidadeJapones = 0;
        private int quantidadeVegetariano = 0;
        private int quantidadeAlemao = 0;

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
        
        }

        private void BtnOkK_Click(object sender, EventArgs e)
        {

        }

        private void BtnOkV_Click(object sender, EventArgs e)
        {

        }
        private void BtnOkZ_Click(object sender, EventArgs e)
        {

        }

        private void BtnOkA_Click(object sender, EventArgs e)
        {

        }

        private void BtnOkIB_Click(object sender, EventArgs e)
        {

        }

        //Resto
        private void BtnMenos1_Click(object sender, EventArgs e)
        {
            if (quantidadeItaliano > 0)
            {
                quantidadeItaliano--;
                AtualizarValor();
            }
        }

        private void BtnMais1_Click(object sender, EventArgs e)
        {
            quantidadeItaliano++;
            AtualizarValor();
        }

        private void AtualizarValor()
        {
            BoxCItaliano.Text = quantidadeItaliano.ToString();
            BoxcQuantidadeI.Text = quantidadeIberico.ToString();
            BoxCQuantidadeZ.Text = quantidadePolones.ToString();
            BoxCQuantidadeK.Text = quantidadeJapones.ToString();
            BoxCQuantidadeV.Text = quantidadeVegetariano.ToString();
            BoxCQuantidadeA.Text = quantidadeAlemao.ToString();
        }

        private void BtnMaisI_Click(object sender, EventArgs e)
        {
            quantidadeIberico++;
            AtualizarValor();
        }

        private void BtnMenosI_Click(object sender, EventArgs e)
        {
            if (quantidadeIberico > 0)
            {
                quantidadeIberico--;
                AtualizarValor();
            }
        }

        private void BtnMaisZ_Click(object sender, EventArgs e)
        {
            quantidadePolones++;
            AtualizarValor();
        }

        private void BtnMenosZ_Click(object sender, EventArgs e)
        {
            if (quantidadePolones > 0)
            {
                quantidadePolones--;
                AtualizarValor();
            }
        }


        private void BtnMaisK_Click(object sender, EventArgs e)
        {
            quantidadeJapones++;
            AtualizarValor();
        }

        private void BtnMenosK_Click(object sender, EventArgs e)
        {
            if (quantidadeJapones > 0)
            {
                quantidadeJapones--;
                AtualizarValor();
            }
        }


        private void BtnMaisV_Click(object sender, EventArgs e)
        {
            quantidadeVegetariano++;
            AtualizarValor();
        }

        private void BtnMenosV_Click(object sender, EventArgs e)
        {
            if (quantidadeVegetariano > 0)
            {
                quantidadeVegetariano--;
                AtualizarValor();
            }
        }

        private void BtnMaisA_Click(object sender, EventArgs e)
        {
            quantidadeAlemao++;
            AtualizarValor();
        }

        private void BtnMenosA_Click(object sender, EventArgs e)
        {
            if (quantidadeAlemao > 0)
            {
                quantidadeAlemao--;
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

        private void BtnCarrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            this.Hide();
            carrinho.ShowDialog();
            this.Close();
        }
    }
}

