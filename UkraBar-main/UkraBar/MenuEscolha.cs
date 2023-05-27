using MySql.Data.MySqlClient;
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
    public partial class MenuEscolha : Form
    {
        public MenuEscolha()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorFinal = VariaveisGlobais.valorItaliano + VariaveisGlobais.valorJapones + VariaveisGlobais.valorPolones + VariaveisGlobais.valorIberico + VariaveisGlobais.valorAlemao + VariaveisGlobais.valorVegetariano;
            VariaveisGlobais.valorFinalP = VariaveisGlobais.valorBatata + VariaveisGlobais.valorHulubsti + VariaveisGlobais.valorFrango + VariaveisGlobais.valorPerohe+ VariaveisGlobais.valorBorscht + VariaveisGlobais.valorBanosh;
            VariaveisGlobais.valorFinalB = VariaveisGlobais.valorPolaka + VariaveisGlobais.valorChamate + VariaveisGlobais.valorMaçaAmor + VariaveisGlobais.valorMoniche + VariaveisGlobais.valorSlava + VariaveisGlobais.valorCaipirinha;

            VariaveisGlobais.valorFinalTotal = VariaveisGlobais.valorFinal + VariaveisGlobais.valorFinalB + VariaveisGlobais.valorFinalP;  
            
            _NomeCliente MenuNome = new _NomeCliente();
            this.Hide();
            MenuNome.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuSanduba MenuS = new MenuSanduba();
            this.Hide();
            MenuS.ShowDialog();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuPratos MenuP = new MenuPratos();
            this.Hide();
            MenuP.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuBebidas MenuB = new MenuBebidas();
            this.Hide();
            MenuB.ShowDialog();
            this.Close();
        }
    }
}
