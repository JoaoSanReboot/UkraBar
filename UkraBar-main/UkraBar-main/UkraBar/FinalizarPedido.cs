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
    public partial class FinalizarPedido : Form
    {
        public FinalizarPedido()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            this.Hide();
            cliente.ShowDialog();
            this.Close();
        }
    }
}
