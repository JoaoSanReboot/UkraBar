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
            conn.Open();
            
            string queryInserirNome = "UPDATE cliente SET nome_cliente = @nome_cliente WHERE id_cliente = '"+ VariaveisGlobais.ultimoIdClienteInserido +"'";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirNome, conn))
            {
                comandos.Parameters.AddWithValue("@nome_cliente", BoxNome.Text);
                comandos.ExecuteNonQuery();
            }
            conn.Close();

            MenuPagamento menuPagamento = new MenuPagamento();
            this.Hide();
            menuPagamento.ShowDialog();
            this.Close();
        }
    }
}
