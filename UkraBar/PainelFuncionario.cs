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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (!pCadastro.Visible)

                pCadastro.Visible = true; //Exibi o Painel de Botões 

            else

                pCadastro.Visible = false;//Esconde o Painel de Botões
        }
    }
}
