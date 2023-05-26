using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Carrinho : Form
    {
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader6;
        public DataTable table;

        public Carrinho()
        {
            InitializeComponent();
            CarregarDados();
            CarregarValores();
        }

        public void CarregarDados()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT nome_produto, quantidade, valor_produto FROM pedido_cliente WHERE id_cliente = '" + VariaveisGlobais.ultimoIdClienteInserido + "'";
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            MySqlDataReader reader6 = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader6); //Table lê os comandos.
            DTgridCarrinho2.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridCarrinho2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
            conn.Close(); //Fecha Conexão 

        }
        public void CarregarValores()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT valor_final FROM carrinho WHERE id_cliente = '" + VariaveisGlobais.ultimoIdClienteInserido + "'";
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            MySqlDataReader reader6 = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader6); //Table lê os comandos.
            DTgridValor.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridValor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
            conn.Close(); //Fecha Conexão 

        }
    }
}
