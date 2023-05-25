using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ExplorerBar;

namespace UkraBar
{
    public partial class MenuSanduba : Form
    {
        public MenuSanduba()
        {
            InitializeComponent();
            AtualizarValor();
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

        private string quantidadeArmazenada = string.Empty;


        //Todos os Btn Compras.
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            panelItaliano.Visible = true;
        }

        private void BtnIberico_Click(object sender, EventArgs e)
        {
            panelIberico.Visible = true;
        }

        private void BtnPolonesComprar_Click(object sender, EventArgs e)
        {
            panelZapiekanka.Visible = true;
        }

        private void BtnVegetariano_Click(object sender, EventArgs e)
        {
            panelVegetariano.Visible = true;
        }
        private void BtnKatsuoSando_Click(object sender, EventArgs e)
        {
            panelKatsuSando.Visible = true;
        }
        private void BtnComprarAlemao_Click(object sender, EventArgs e)
        {
            panelAlemão.Visible = true;
        }

        //Todos Btn Cancelar

        private void BtnCancelarI_Click(object sender, EventArgs e)
        {
            panelItaliano.Visible = false;
        }
        private void BtnCancelarIB_Click(object sender, EventArgs e)
        {
            panelIberico.Visible = false;
        }
        private void BtnCancelarZ_Click(object sender, EventArgs e)
        {
            panelZapiekanka.Visible = false;
        }
        private void BtnCancelarK_Click(object sender, EventArgs e)
        {
            panelKatsuSando.Visible = false;
        }
        private void BtnCancelarV_Click(object sender, EventArgs e)
        {
            panelVegetariano.Visible = false;
        }
        private void BtnCancelarA_Click(object sender, EventArgs e)
        {
            panelAlemão.Visible = false;
        }

        //Todos os Btn Ok
        private void BtnOkI_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirCarrinho = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto) VALUES (@nome_produto, @quantidade, @valor_produto)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "SandubaItaliano");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeItaliano);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorItaliano);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();

            MessageBox.Show(VariaveisGlobais.quantidadeItaliano.ToString(), "Foram adicionados no Carrinho");
            panelItaliano.Visible = false;
        }

        private void BtnOkK_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto) VALUES (@nome_produto, @quantidade, @valor_produto)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "KatsuSando");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeJapones);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorJapones);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();
            MessageBox.Show(VariaveisGlobais.quantidadeJapones.ToString(), "Foram adicionados no Carrinho");
            panelKatsuSando.Visible = false;
        }

        private void BtnOkV_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto) VALUES (@nome_produto, @quantidade, @valor_produto)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "SandubaVegetariano");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeVegetariano);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorVegetariano);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();
            MessageBox.Show(VariaveisGlobais.valorVegetariano.ToString(), "Foram adicionados no Carrinho");
            panelVegetariano.Visible = false;
        }
        private void BtnOkZ_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto) VALUES (@nome_produto, @quantidade, @valor_produto)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "SandubaPolones");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadePolones);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorPolones);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();
            MessageBox.Show(VariaveisGlobais.quantidadePolones.ToString(), "Foram adicionados no Carrinho");
            panelZapiekanka.Visible = false;
        }

        private void BtnOkA_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto) VALUES (@nome_produto, @quantidade, @valor_produto)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "SandubaAlemão");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeAlemao);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorAlemao);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();
            MessageBox.Show(VariaveisGlobais.quantidadeAlemao.ToString(), "Foram adicionados no Carrinho");
            panelAlemão.Visible = false;
        }

        private void BtnOkIB_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto) VALUES (@nome_produto, @quantidade, @valor_produto)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "SandubaIberico");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeIberico);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorIberico);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();
            MessageBox.Show(VariaveisGlobais.quantidadeIberico.ToString(), "Foram adicionados no Carrinho");
            panelIberico.Visible = false;
        }


        //Resto
        private void AtualizarValor()
        {
            BoxCItaliano.Text = VariaveisGlobais.quantidadeItaliano.ToString();
            BoxcQuantidadeI.Text = VariaveisGlobais.quantidadeIberico.ToString();
            BoxCQuantidadeZ.Text = VariaveisGlobais.quantidadePolones.ToString();
            BoxCQuantidadeK.Text = VariaveisGlobais.quantidadeJapones.ToString();
            BoxCQuantidadeV.Text = VariaveisGlobais.quantidadeVegetariano.ToString();
            BoxCQuantidadeA.Text = VariaveisGlobais.quantidadeAlemao.ToString();
        }

        private void BtnMenos1_Click(object sender, EventArgs e)
        {
           
                VariaveisGlobais.quantidadeItaliano--;
                AtualizarValor();
            VariaveisGlobais.valorItalianoMenos = VariaveisGlobais.valorItaliano - 24;
            VariaveisGlobais.valorItaliano = VariaveisGlobais.valorItalianoMenos;
            BoxValorfinalI.Text = VariaveisGlobais.valorItaliano.ToString() + ",00";

        }

        private void BtnMais1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeItaliano++;
            AtualizarValor();
            VariaveisGlobais.valorItaliano = VariaveisGlobais.quantidadeItaliano * 24;
            BoxValorfinalI.Text = VariaveisGlobais.valorItaliano.ToString() + ",00";
        }

        private void BtnMaisI_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeIberico++;
            AtualizarValor();
            VariaveisGlobais.valorIberico=VariaveisGlobais.quantidadeIberico* 27;
            BoxValorfinalIB.Text = VariaveisGlobais.valorIberico.ToString() + ",00";
        }

        private void BtnMenosI_Click(object sender, EventArgs e)
        {
           
                VariaveisGlobais.quantidadeIberico--;
                AtualizarValor();
            VariaveisGlobais.valorIbericoMenos = VariaveisGlobais.valorIberico - 27;
            VariaveisGlobais.valorIberico = VariaveisGlobais.valorIbericoMenos;
            BoxValorfinalIB.Text = VariaveisGlobais.valorIberico.ToString() + ",00";
        }

        private void BtnMaisZ_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadePolones++;
            AtualizarValor();
            VariaveisGlobais.valorPolones = VariaveisGlobais.quantidadePolones * 24;
            BoxValorfinalZ.Text = VariaveisGlobais.valorPolones.ToString() + ",00";
        }

        private void BtnMenosZ_Click(object sender, EventArgs e)
        {
           
            VariaveisGlobais.quantidadePolones--;
            AtualizarValor();
            VariaveisGlobais.valorPolonesMenos = VariaveisGlobais.valorPolones - 24;
            VariaveisGlobais.valorPolones = VariaveisGlobais.valorPolonesMenos;
            BoxValorfinalZ.Text = VariaveisGlobais.valorPolones.ToString() + ",00";
        }


        private void BtnMaisK_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeJapones++;
            AtualizarValor();
            VariaveisGlobais.valorJapones = VariaveisGlobais.quantidadeJapones * 24;
            BoxValorfinalK.Text = VariaveisGlobais.valorJapones.ToString() + ",00";
        }

        private void BtnMenosK_Click(object sender, EventArgs e)
        {
            
                VariaveisGlobais.quantidadeJapones--;
                AtualizarValor();
            VariaveisGlobais.valorJaponesMenos = VariaveisGlobais.valorJapones - 24;
            VariaveisGlobais.valorJapones= VariaveisGlobais.valorJaponesMenos;
            BoxValorfinalK.Text = VariaveisGlobais.valorJapones.ToString() + ",00";

        }


        private void BtnMaisV_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeVegetariano++;
            AtualizarValor();
            VariaveisGlobais.valorVegetariano= VariaveisGlobais.quantidadeVegetariano * 22;
            BoxValorfinalV.Text = VariaveisGlobais.valorVegetariano.ToString() + ",00";
        }

        private void BtnMenosV_Click(object sender, EventArgs e)
        {
            if(VariaveisGlobais.quantidadeVegetariano > 0 || VariaveisGlobais.valorVegetariano > 0)

                VariaveisGlobais.quantidadeVegetariano--;
                AtualizarValor();
                VariaveisGlobais.valorVegetarianoMenos= VariaveisGlobais.valorVegetariano - 22;
                VariaveisGlobais.valorVegetariano = VariaveisGlobais.valorVegetarianoMenos;
                BoxValorfinalV.Text = VariaveisGlobais.valorVegetariano.ToString()+ ",00";
        }

        private void BtnMaisA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeAlemao++;
            AtualizarValor();
            VariaveisGlobais.valorAlemao = VariaveisGlobais.quantidadeAlemao * 25;
            BoxValorfinal.Text = VariaveisGlobais.valorAlemao.ToString() + ",00";
        }

        private void BtnMenosA_Click(object sender, EventArgs e)
        {
           
                VariaveisGlobais.quantidadeAlemao--;
                AtualizarValor();
            VariaveisGlobais.valorAlemaoMenos = VariaveisGlobais.valorAlemao- 25;
            VariaveisGlobais.valorAlemao = VariaveisGlobais.valorAlemaoMenos;
            BoxValorfinal.Text = VariaveisGlobais.valorAlemao.ToString() + ",00";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            MenuEscolha Escolha = new MenuEscolha();
            this.Hide();
            Escolha.ShowDialog();
            this.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            this.Hide();
            cliente.ShowDialog();
            this.Close();
        }

        private void pbFundo_Click(object sender, EventArgs e)
        {

        }

        private void BoxCItaliano_Click(object sender, EventArgs e)
        {

        }

        private void MenuSanduba_Load(object sender, EventArgs e)
        {

        }
    }
}

