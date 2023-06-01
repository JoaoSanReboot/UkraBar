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
    public partial class PainelLogins : Form
    {
        public PainelLogins()
        {
            InitializeComponent();
        }

        private void PainelLogins_Load(object sender, EventArgs e)
        {

        }
        private void BtnAdm1_Click(object sender, EventArgs e)
        {
            if (TextAdm1.Text == "UkraAdm" & TextAdm2Senha.Text == "91371357")//Login Base do Adm
            {
                PainelAdm PainelMenu = new PainelAdm();//Abre Layout do ADM
                PainelMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Algo não foi Escrito Corretamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Mensagem de Error
            }

        }

        private void BtnFuncionario1_Click(object sender, EventArgs e)
        {

           
            //Declara as strings da Box
            string nomelogin = TextFunc1.Text;
            string senhalogin = TextFunc2.Text;

            //Estabelece Conexão com o BD
            string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //Faz o comando Select From na tabela
            MySqlCommand command = new MySqlCommand("SELECT * FROM cadastro_funcionario WHERE nome_funcionario=@nome_funcionario AND senha_funcionario=@senha_funcionario", conn);
            command.Parameters.AddWithValue("@nome_funcionario", nomelogin);
            command.Parameters.AddWithValue("@senha_funcionario", senhalogin);

            try
            {
                conn.Open();//Abre Conexão
                MySqlDataReader reader = command.ExecuteReader();//Executa comando

                if (reader.HasRows)
                {
                    MessageBox.Show("Logado com sucesso!");//Caso login executado com exilio abrir formulario
                    PainelAdm PainelLogins = new PainelAdm();
                    PainelLogins.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha ou Login invalidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo está Incorreto : " + ex.Message);//Senão Mostrar mensagem e não executar comando
            }
            finally
            {
                conn.Close();//Fecha Conexão
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();//Abre o Layout do Cliente
            cliente.Show();
            this.Hide();
        }

        private void TextFunc1_TextChanged(object sender, EventArgs e)
        {

        }


        private void pbMostrar2_Click(object sender, EventArgs e)
        {
            pbOcultar2.BringToFront();
            TextFunc2.PasswordChar = '*';//Botão de Ocultar senha do Funcionario
        }

        private void pbOcultar2_Click(object sender, EventArgs e)
        {
            pbMostrar2.BringToFront();
            TextFunc2.PasswordChar = '\0';//Botão de Mostrar senha do Funcionario
        }


        private void TextAdm1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pbOcultar_Click_1(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            TextAdm2Senha.PasswordChar = '\0';//Botão de Ocultar senha do Adm
        }

        private void pbMostrar_Click_1(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            TextAdm2Senha.PasswordChar = '*';//Botão de Mostrar senha do Adm
        }
    }

      
    }
 
