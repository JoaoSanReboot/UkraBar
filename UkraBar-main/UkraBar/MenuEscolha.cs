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

        private void BtnSanduba_Click(object sender, EventArgs e)
        {
           MenuSanduba MenuS = new MenuSanduba();
            this.Hide();
            MenuS.ShowDialog();
            this.Close();   

        }

        private void BtnPratos_Click(object sender, EventArgs e)
        {
            MenuPratos MenuP = new MenuPratos();
            this.Hide();
            MenuP.ShowDialog();
            this.Close();
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            MenuBebidas MenuB = new MenuBebidas();
            this.Hide();
            MenuB.ShowDialog();
            this.Close();
        }

        private void BtnSobremesas_Click(object sender, EventArgs e)
        {
            MenuSobremesas MenuSm = new MenuSobremesas();
            this.Hide();
            MenuSm.ShowDialog();
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorFinal = VariaveisGlobais.valorItaliano + VariaveisGlobais.valorJapones + VariaveisGlobais.valorPolones + VariaveisGlobais.valorIberico + VariaveisGlobais.valorAlemao + VariaveisGlobais.valorVegetariano;
          
            _NomeCliente MenuNome = new _NomeCliente();
            this.Hide();
            MenuNome.ShowDialog();
            this.Close();
        }
        
     
    }
}
