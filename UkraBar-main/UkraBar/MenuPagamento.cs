using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace UkraBar
{
    public partial class MenuPagamento : Form
    {
        public MenuPagamento()
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

                //Se o comando for executado corretamente mostrar Message Box
                if (comando.ExecuteNonQuery() == 1)

                    MessageBox.Show("Executado com Sucesso");

                //Senão Mostrar outra Message Box
                else

                    MessageBox.Show("Não foi Executado");

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

        private void BtnPix_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirCarrinho = "INSERT INTO carrinho (id_cliente, valor_final) VALUES (@idCliente, @valorFinal)";
            using (comando = new MySqlCommand(queryInserirCarrinho, conn))
            {
                comando.Parameters.AddWithValue("@idCliente", VariaveisGlobais.ultimoIdClienteInserido);
                comando.Parameters.AddWithValue("@valorFinal", VariaveisGlobais.valorFinal);
                comando.ExecuteNonQuery();
            }
            conn.Close();

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
