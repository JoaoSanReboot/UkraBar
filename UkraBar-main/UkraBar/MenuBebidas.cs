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
    public partial class MenuBebidas : Form
    {
        public MenuBebidas()
        {
            InitializeComponent();
        }

                                     //Setando comandos MySql para a contatenação.

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;

        private void AtualizarValor()
        {
            BoxCQuantidadeC.Text = VariaveisGlobais.quantidadeChamate.ToString();
            BoxCQuantidadeCA.Text = VariaveisGlobais.quantidadeCaipirinha.ToString();
            BoxCQuantidadeM.Text = VariaveisGlobais.quantidadeMoniche.ToString();
            BoxquantidadeMA.Text = VariaveisGlobais.quantidadeMaçaAmor.ToString();
            BoxCQuantidadeP.Text = VariaveisGlobais.quantidadePolaka.ToString();
            BoxcQuantidadeS.Text = VariaveisGlobais.quantidadeSlava.ToString();
        }

        public void ResetVariaveis()
        {

            VariaveisGlobais.quantidadeChamate = 0;
            VariaveisGlobais.quantidadeCaipirinha = 0;
            VariaveisGlobais.quantidadeMoniche = 0;
            VariaveisGlobais.quantidadePolaka = 0;
            VariaveisGlobais.quantidadeMaçaAmor = 0;
            VariaveisGlobais.quantidadeSlava = 0;

        }

        public void ResetBox()
        {

            BoxcQuantidadeS.Text = "";
            BoxCQuantidadeP.Text = "";
            BoxCQuantidadeM.Text = "";
            BoxquantidadeMA.Text = "";
            BoxCQuantidadeCA.Text = "";
            BoxCQuantidadeC.Text = "";

            BoxValorfinalP.Text = "";
            BoxValorfinalCA.Text = "";
            BoxValorfinalS.Text = "";
            BoxValorfinalMA.Text = "";
            BoxValorfinalM.Text = "";
            BoxValorfinalC.Text = "";

        }

        private void BtnPolaka_Click(object sender, EventArgs e)
        {
            panelPolaka.Visible = true;
            ResetVariaveis();
            ResetBox();
        }

        private void btnChaMate_Click(object sender, EventArgs e)
        {
            panelChaMatte.Visible = true;
            ResetVariaveis();
            ResetBox();
        }

        private void btnMacaAmor_Click(object sender, EventArgs e)
        {
            panelMacaAmor.Visible = true;
            ResetVariaveis();
            ResetBox();
        }

        private void btnMoniche_Click(object sender, EventArgs e)
        {
            panelMunich.Visible = true;
            ResetVariaveis();
            ResetBox();
        }

        private void btnSlava_Click(object sender, EventArgs e)
        {
            panelSlava.Visible = true;
            ResetVariaveis();
            ResetBox();
        }

        private void btnCaipirinha_Click(object sender, EventArgs e)
        {
            panelCaipirinha.Visible = true;
            ResetVariaveis();
            ResetBox();
        }
        private void BtnCancelarC_Click(object sender, EventArgs e)
        {
            panelChaMatte.Visible = false;
        }
        private void BtnCancelarP_Click(object sender, EventArgs e)
        {
            panelPolaka.Visible = false;
        }
        private void BtnCancelarCA_Click(object sender, EventArgs e)
        {
            panelCaipirinha.Visible = false;
        }
        private void BtnCancelarM_Click(object sender, EventArgs e)
        {
            panelMunich.Visible = false;
        }
        private void BtnCancelarMA_Click(object sender, EventArgs e)
        {
            panelMacaAmor.Visible = false;
        }

        private void BtnCancelarS_Click(object sender, EventArgs e)
        {
            panelSlava.Visible = false;
        }

        private void BtnOkP_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "Polaka");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadePolaka);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorPolaka);
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();

            MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
            panelPolaka.Visible = false;
        }

        private void BtnOkC_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "Chá Matte");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeChamate);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorChamate);
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();

            MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
            panelChaMatte.Visible = false;
        }
        private void BtnOkCA_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "Caipirinha");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeCaipirinha);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorCaipirinha);
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();

            MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
            panelCaipirinha.Visible = false;
        }

        private void BtnOkMA_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "Maça do Amor");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeMaçaAmor);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorMaçaAmor);
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();

            MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
            panelMacaAmor.Visible = false;
        }
        private void BtnOkM_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "Moniche");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeMoniche);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorMoniche);
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();

            MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
            panelMunich.Visible = false;
        }

        private void BtnOkS_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
            {
                comandos.Parameters.AddWithValue("@nome_produto", "Slava");
                comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeSlava);
                comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorSlava);
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
            }
            conn.Close();

            MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
            panelSlava.Visible = false;
        }
        private void BtnMenosP_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadePolaka > 0)

                VariaveisGlobais.quantidadePolaka--;
            AtualizarValor();

            if (VariaveisGlobais.valorPolaka > 0)

                VariaveisGlobais.valorPolakaMenos = VariaveisGlobais.valorPolaka - 24;
            VariaveisGlobais.valorPolaka = VariaveisGlobais.valorPolakaMenos;
            BoxValorfinalP.Text = VariaveisGlobais.valorPolaka.ToString() + ",00";
        }
        private void BtnMenosC_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeChamate > 0)

                VariaveisGlobais.quantidadeChamate--;
            AtualizarValor();

            if (VariaveisGlobais.valorChamate > 0)

                VariaveisGlobais.valorChamateMenos = VariaveisGlobais.valorChamate - 24;
            VariaveisGlobais.valorChamate = VariaveisGlobais.valorChamateMenos;
            BoxValorfinalM.Text = VariaveisGlobais.valorChamate.ToString() + ",00";
        }
        private void BtnMenosCA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeCaipirinha > 0)

                VariaveisGlobais.quantidadeCaipirinha--;
            AtualizarValor();

            if (VariaveisGlobais.valorCaipirinha > 0)

                VariaveisGlobais.valorCaipirinhaMenos = VariaveisGlobais.valorCaipirinha - 24;
            VariaveisGlobais.valorCaipirinha = VariaveisGlobais.valorCaipirinhaMenos;
            BoxValorfinalCA.Text = VariaveisGlobais.valorCaipirinha.ToString() + ",00";
        }
        private void BtnMenosMA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeMaçaAmor > 0)

                VariaveisGlobais.quantidadeMaçaAmor--;
            AtualizarValor();

            if (VariaveisGlobais.valorMaçaAmor > 0)

                VariaveisGlobais.valorMaçãAmorMenos = VariaveisGlobais.valorMaçaAmor - 24;
            VariaveisGlobais.valorMaçaAmor = VariaveisGlobais.valorMaçãAmorMenos;
            BoxValorfinalMA.Text = VariaveisGlobais.valorMaçaAmor.ToString() + ",00";
        }
        private void BtnMenosM_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeMoniche > 0)

                VariaveisGlobais.quantidadeMoniche--;
            AtualizarValor();

            if (VariaveisGlobais.valorMoniche > 0)

                VariaveisGlobais.valorMonicheMenos = VariaveisGlobais.valorMoniche - 24;
            VariaveisGlobais.valorMoniche = VariaveisGlobais.valorMonicheMenos;
            BoxValorfinalM.Text = VariaveisGlobais.valorHulubsti.ToString() + ",00";
        }

        private void BtnMenosS_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeSlava > 0)

                VariaveisGlobais.quantidadeSlava--;
                AtualizarValor();

            if (VariaveisGlobais.valorSlava > 0)

                VariaveisGlobais.valorSlavaMenos = VariaveisGlobais.valorSlava - 24;
                VariaveisGlobais.valorSlava = VariaveisGlobais.valorSlavaMenos;
                BoxValorfinalS.Text = VariaveisGlobais.valorSlava.ToString() + ",00";
        }
        private void BtnMaisCA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeCaipirinha++;
            AtualizarValor();
            VariaveisGlobais.valorCaipirinha = VariaveisGlobais.quantidadeCaipirinha * 25;
            BoxValorfinalCA.Text = VariaveisGlobais.valorCaipirinha.ToString() + ",00";
        }
        private void BtnMaisMA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeMaçaAmor++;
            AtualizarValor();
            VariaveisGlobais.valorMaçaAmor = VariaveisGlobais.quantidadeMaçaAmor * 25;
            BoxValorfinalMA.Text = VariaveisGlobais.valorMaçaAmor.ToString() + ",00";
        }
        private void BtnMaisM_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeMoniche++;
            AtualizarValor();
            VariaveisGlobais.valorMoniche = VariaveisGlobais.quantidadeMoniche * 25;
            BoxValorfinalM.Text = VariaveisGlobais.valorMoniche.ToString() + ",00";
        }

        private void BtnMaisS_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeSlava++;
            AtualizarValor();
            VariaveisGlobais.valorSlava = VariaveisGlobais.quantidadeSlava * 25;
            BoxValorfinalS.Text = VariaveisGlobais.valorSlava.ToString() + ",00";
        }
        private void BtnMaisC_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeChamate++;
            AtualizarValor();
            VariaveisGlobais.valorChamate = VariaveisGlobais.quantidadeChamate * 25;
            BoxValorfinalC.Text = VariaveisGlobais.valorChamate.ToString() + ",00";
        }
        private void BtnMaisP_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadePolaka++;
            AtualizarValor();
            VariaveisGlobais.valorPolaka = VariaveisGlobais.quantidadePolaka * 25;
            BoxValorfinalP.Text = VariaveisGlobais.valorPolaka.ToString() + ",00";
        }
    }
}
