using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace UkraBar
{
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();
        }
        //Setando comandos MySql para a contatenação.

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader;
        public DataTable table;


        //Publics Abrir e Fechar Conexão com o Banco de Dados.
        public void AbrirConexão()
        {
            //Se o status da conexão estiver fechada então abrir.
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void FecharConexão()
        {
            //Se o status da conexão estiver aberta então fechar.
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //Public Executar comandos no banco de dados.
        public void executarQuery(string query)
        {
            try
            {
                AbrirConexão(); //Abre Conexão.
                comando = new MySqlCommand(query, conn); //Declara comandos para MySql.
            }
            //Se uma exceção for encontrada Mostrar Error Message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Depois de Executar tudo Fechar.
                FecharConexão();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            PanelCpfNota.Visible = false;
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            MenuEscolha Escolha = new MenuEscolha();
            this.Hide();
            Escolha.ShowDialog();
            this.Close();
        }

        private void BtnCpfCad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BoxCpf.Text))
            {
                MessageBox.Show("Você não insiriu todos os dado");
            }
            if (BoxCpf.Text.Length == 11)
            {
                conn.Open();
                VariaveisGlobais.Cpf = Convert.ToString(BoxCpf.Text);
                string queryInserirCliente = ("INSERT INTO cliente (cpf_cliente) VALUES ('" + VariaveisGlobais.Cpf + "')");
                    
                using (MySqlCommand comandos = new MySqlCommand(queryInserirCliente, conn))
                {   
                    comandos.Parameters.AddWithValue("@cpf_cliente", VariaveisGlobais.Cpf);      
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdClienteInserido = (int)comandos.LastInsertedId;
                }

                MenuEscolha menu = new MenuEscolha();
                this.Hide();
                menu.ShowDialog();
                this.Close();
                conn.Close();

            }
        }
    }

}
