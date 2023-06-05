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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void Clientes_Load(object sender, EventArgs e)
        {
            panel1.AutoSize = true;
            panel1.AutoSizeMode=AutoSizeMode.GrowAndShrink;
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            PanelCpfNota.Visible = false;
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            conn.Open();
            VariaveisGlobais.Cpf = Convert.ToString(BoxCpf.Text);
            string queryInserirCliente = "INSERT INTO cliente (cpf_cliente) VALUES (@cpf_cliente)";

            using (MySqlCommand comandos = new MySqlCommand(queryInserirCliente, conn))
            {
                comandos.Parameters.AddWithValue("@cpf_cliente", "Sem Cpf");
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdClienteInserido = (int)comandos.LastInsertedId;
            }

            MenuEscolha menuEscolha = new MenuEscolha();
            this.Hide();
            menuEscolha.ShowDialog();
            this.Close();
            conn.Close();
        }

        private void BtnCpfCad_Click(object sender, EventArgs e)
        {

            if (BoxCpf.Text.Length < 10)
            {
                MessageBox.Show("Você não inseriu todos os dados");
            }
            if (BoxCpf.Text.Length == 11)
            {

                conn.Open();
                VariaveisGlobais.Cpf = Convert.ToString(BoxCpf.Text);
                string queryInserirCliente = "INSERT INTO cliente (cpf_cliente) VALUES ('" + VariaveisGlobais.Cpf + "')";

                using (MySqlCommand comandos = new MySqlCommand(queryInserirCliente, conn))
                {
                    comandos.Parameters.AddWithValue("@cpf_cliente", VariaveisGlobais.Cpf);
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdClienteInserido = (int)comandos.LastInsertedId;
                }

                MenuEscolha menuEscolha = new MenuEscolha();
                this.Hide();
                menuEscolha.ShowDialog();
                this.Close();

                conn.Close();
            }
        }

        private void BoxCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
    


