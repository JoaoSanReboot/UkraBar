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
    public partial class CadastrarDesc : Form
    {
        public CadastrarDesc()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void voltar_desc_Click(object sender, EventArgs e)
        {
            PainelAdm adm = new PainelAdm();
            this.Hide();
            adm.ShowDialog();
            this.Close();

        }

        private void cadastrar_desc_Click(object sender, EventArgs e)
        {
            try
            {
                // Estabelecendo conexão com o Banco de Dados
                string connectionString = "SERVER=localhost;DATABASE=ukrabar;UID=root;PASSWORD=;";

                MySqlConnection conn = new MySqlConnection(connectionString); //Definindo Conn = "Conexão"


                //Comando Sql para dar o Insert Into

                string sql = "INSERT INTO desconto(nome_desconto, porcentagem,descricao)" +
                    "VALUES ('" + Nome_desc.Text + "','" + Porcentagem_desc.Text + "','" + descricao_desc.Text + "') ";


                MySqlCommand comando = new MySqlCommand(sql, conn); // Envia comando para o MySql
                conn.Open();// Abre Conexão
                comando.ExecuteNonQuery();// Executa comando

                MySqlDataReader reader = comando.ExecuteReader();//Executa comando

                if (reader.HasRows)
                {
                    MessageBox.Show("Cadastrado com Sucesso");// Caso login executado com exilio abrir formulario

                }
                else
                {
                    MessageBox.Show("cadastro invalido.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);// Menssagem de Error

            }
        }
    }
}
