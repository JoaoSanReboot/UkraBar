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
    public partial class CadastrarDescD : Form
    {
        public CadastrarDescD()
        {
            InitializeComponent();
        }
        MySqlConnection conn;

        bool sideBarLateral;
        private void SiberBarDesc_Tick(object sender, EventArgs e)
        {
            if (sideBarLateral)
            {
                sideBarMenuD.Width -= 30;
                if (sideBarMenuD.Width == sideBarMenuD.MinimumSize.Width)
                {
                    sideBarLateral = false;
                    SiderBarDesc.Stop();
                }
            }
            else
            {
                sideBarMenuD.Width += 10;
                if (sideBarMenuD.Width == sideBarMenuD.MaximumSize.Width)
                {
                    sideBarLateral = true;
                    SiderBarDesc.Stop();
                }
            }
        }

        private void pbMenuD_Click(object sender, EventArgs e)
        {
            SiderBarDesc.Start();
        }
    }
}
