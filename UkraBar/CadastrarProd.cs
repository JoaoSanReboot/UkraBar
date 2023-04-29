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
    public partial class CadastrarProdP : Form
    {
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        private string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        private MySqlCommand comando;
        private MySqlDataReader reader;
        private DataTable table;

        public CadastrarProdP()
        {
            InitializeComponent();
        }

        Panel P = new Panel();// Complementação do BtnMouseEnter e Leave.

        //Configurações da Conexão
        public void CarregarDados()
        {

            MySqlConnection conn = new MySqlConnection(connectionString);//Definindo Conexão
            conn.Open();// Abre Conexão

            string query = "SELECT * FROM produto";//Carrega dados no DataGriedView
            comando = new MySqlCommand(query, conn); //Declara comandos para o MySql
            reader = comando.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            conn.Close(); //Fecha Conexão 

        }//Carrega dados no DataGridView.

        public void AbrirConexão()//Um Public para caso a conn esteja fechada ela se abra.
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void FecharConexão()//Um Public para caso a conn esteja aberta ela se feche.
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void executarQuery(string query)//Um Public para executar comando e mostrar box caso ele seja executado com exilio ou não.
        {
            try
            {
                AbrirConexão();
                comando = new MySqlCommand(query, conn);

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Executado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi Executado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexão();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
