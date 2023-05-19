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

        public int PagamentoPix = 0;
        public int PagamentoCartao = 0;
        public int PagamentoDinheiro = 0;


        private void BtnPix_Click(object sender, EventArgs e)
        {
            PagamentoPix = 1;
        }

        private void BtnCartao_Click(object sender, EventArgs e)
        {
            PagamentoCartao = 1;
        }

        private void BtnDinheiro_Click(object sender, EventArgs e)
        {
            PagamentoDinheiro = 1;
        }
    }
}
