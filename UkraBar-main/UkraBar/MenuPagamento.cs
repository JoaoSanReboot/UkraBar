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
    public partial class MenuPagamento : Form
    {
        public MenuPagamento()
        {
            InitializeComponent();
        }

  

        private void BtnPix_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.pix = 1;

            //Cria um String para colocar no Executor de Query.
            string inserirQuery = "INSERT INTO carrinho (id_cadastro, nome_funcionario, senha_funcionario, email_funcionario) VALUES" +
                "()";
        }

        private void BtnCartao_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.cartao = 1;
            Carrinho carrinho3 = new Carrinho();
            this.Hide();
            carrinho3.ShowDialog();
            this.Close();
        }

        private void BtnDinheiro_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.dinheiro = 1;
            Carrinho carrinho3 = new Carrinho();
            this.Hide();
            carrinho3.ShowDialog();
            this.Close();
        }
    }
}
