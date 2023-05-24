using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace UkraBar
{
    public partial class _NomeCliente : Form
    {

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader;

        public DataTable table;
        public _NomeCliente()
        {
            InitializeComponent();
        }

        private void BtnNome_Click(object sender, EventArgs e)
        {

        }
    }
}
