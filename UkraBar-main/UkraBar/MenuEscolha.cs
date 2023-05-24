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
    public partial class MenuEscolha : Form
    {

        //Setando comandos MySql para a contatenação.

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader;
        public DataTable table;

        public MenuEscolha()
        {
            InitializeComponent();
        }
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



        private void BtnSanduba_Click(object sender, EventArgs e)
        {
           MenuSanduba MenuS = new MenuSanduba();
            this.Hide();
            MenuS.ShowDialog();
            this.Close();   

        }

        private void BtnPratos_Click(object sender, EventArgs e)
        {
            MenuPratos MenuP = new MenuPratos();
            this.Hide();
            MenuP.ShowDialog();
            this.Close();
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            MenuBebidas MenuB = new MenuBebidas();
            this.Hide();
            MenuB.ShowDialog();
            this.Close();
        }

        private void BtnSobremesas_Click(object sender, EventArgs e)
        {
            MenuSobremesas MenuSm = new MenuSobremesas();
            this.Hide();
            MenuSm.ShowDialog();
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
           
            MenuPagamento menuPagamento = new MenuPagamento();
            this.Hide();
            menuPagamento.ShowDialog();
            this.Close();
        }
        
     
    }
}
