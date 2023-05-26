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

        private void BtnPix_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPix = "UPDATE cliente SET forma_pagamento = @forma_pagamento WHERE id_cliente = '" + VariaveisGlobais.ultimoIdClienteInserido + "'";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPix, conn))
            {
                comandos.Parameters.AddWithValue("@forma_pagamento", "Pix");
                comandos.ExecuteNonQuery();
            }

            string queryInserirCarrinho = "INSERT INTO carrinho (id_cliente, valor_final, id_pedido_cliente) VALUES (@id_cliente, @valor_final, @id_pedido_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
            {
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.Parameters.AddWithValue("@valor_final", VariaveisGlobais.valorFinal);
                comandos.Parameters.AddWithValue("@id_pedido_cliente", VariaveisGlobais.ultimoIdPedidoInserido);
                comandos.ExecuteNonQuery();
            }

            conn.Close();

            Carrinho carrinho3 = new Carrinho();
            this.Hide();
            carrinho3.ShowDialog();
            this.Close();

        }

        private void BtnCartao_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirCartao = "UPDATE cliente SET forma_pagamento = @forma_pagamento WHERE id_cliente = '" + VariaveisGlobais.ultimoIdClienteInserido + "'";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirCartao, conn))
            {
                comandos.Parameters.AddWithValue("@forma_pagamento", "Cartão");
                comandos.ExecuteNonQuery();
            }
            string queryInserirCarrinho = "INSERT INTO carrinho (id_cliente, valor_final, id_pedido_cliente) VALUES (@id_cliente, @valor_final, @id_pedido_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
            {
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.Parameters.AddWithValue("@valor_final", VariaveisGlobais.valorFinal);
                comandos.Parameters.AddWithValue("@id_pedido_cliente", VariaveisGlobais.ultimoIdPedidoInserido);
                comandos.ExecuteNonQuery();
            }

            conn.Close();
            Carrinho carrinho3 = new Carrinho();
            this.Hide();
            carrinho3.ShowDialog();
            this.Close();
        }

        private void BtnDinheiro_Click(object sender, EventArgs e)
        {

            conn.Open();
            string queryInserirDinheiro = "UPDATE cliente SET forma_pagamento = @forma_pagamento WHERE id_cliente = '" + VariaveisGlobais.ultimoIdClienteInserido + "'";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirDinheiro, conn))
            {
                comandos.Parameters.AddWithValue("@forma_pagamento", "Dinheiro");
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdClienteInserido = (int)comandos.LastInsertedId;
            }

            string queryInserirCarrinho = "INSERT INTO carrinho (id_cliente, valor_final, id_pedido_cliente) VALUES (@id_cliente, @valor_final, @id_pedido_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
            {
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.Parameters.AddWithValue("@valor_final", VariaveisGlobais.valorFinal);
                comandos.Parameters.AddWithValue("@id_pedido_cliente", VariaveisGlobais.ultimoIdPedidoInserido);
                comandos.ExecuteNonQuery();
            }

            conn.Close();

            Carrinho carrinho3 = new Carrinho();
            this.Hide();
            carrinho3.ShowDialog();
            this.Close();
        }
    }
}
