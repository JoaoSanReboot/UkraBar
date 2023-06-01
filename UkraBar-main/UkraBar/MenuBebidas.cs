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

            VariaveisGlobais.quantidadeChamate = 1;
            VariaveisGlobais.quantidadeCaipirinha = 1;
            VariaveisGlobais.quantidadeMoniche = 1;
            VariaveisGlobais.quantidadePolaka = 1;
            VariaveisGlobais.quantidadeMaçaAmor = 1;
            VariaveisGlobais.quantidadeSlava = 1;

        }

        public void ResetBox()
        {

            BoxcQuantidadeS.Text = "1";
            BoxCQuantidadeP.Text = "1";
            BoxCQuantidadeM.Text = "1";
            BoxquantidadeMA.Text = "1";
            BoxCQuantidadeCA.Text = "1";
            BoxCQuantidadeC.Text = "1";  

            BoxValorfinalP.Text = "26,00";
            BoxValorfinalCA.Text = "16,00";
            BoxValorfinalS.Text = "18,00";
            BoxValorfinalMA.Text = "18,00";
            BoxValorfinalM.Text = "23,00";
            BoxValorfinalC.Text = "8,00";

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
            VariaveisGlobais.valorChamate = 0;
        }
        private void BtnCancelarP_Click(object sender, EventArgs e)
        {
            panelPolaka.Visible = false;
            VariaveisGlobais.valorPolaka = 0;
        }
        private void BtnCancelarCA_Click(object sender, EventArgs e)
        {
            panelCaipirinha.Visible = false;
            VariaveisGlobais.valorCaipirinha = 0;
        }
        private void BtnCancelarM_Click(object sender, EventArgs e)
        {
            panelMunich.Visible = false;
            VariaveisGlobais.valorMoniche = 0;
        }
        private void BtnCancelarMA_Click(object sender, EventArgs e)
        {
            panelMacaAmor.Visible = false;
            VariaveisGlobais.valorMaçaAmor = 0;
        }

        private void BtnCancelarS_Click(object sender, EventArgs e)
        {
            panelSlava.Visible = false;
            VariaveisGlobais.valorSlava = 0;
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

            MessageBox.Show(VariaveisGlobais.quantidadePolaka.ToString(), "Foram adicionados no Carrinho");
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

            MessageBox.Show(VariaveisGlobais.quantidadeChamate.ToString(), "Foram adicionados no Carrinho");
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

            MessageBox.Show(VariaveisGlobais.quantidadeCaipirinha.ToString(), "Foram adicionados no Carrinho");
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

            MessageBox.Show(VariaveisGlobais.quantidadeMaçaAmor.ToString(), "Foram adicionados no Carrinho");
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

            MessageBox.Show(VariaveisGlobais.quantidadeMoniche.ToString(), "Foram adicionados no Carrinho");
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

            MessageBox.Show(VariaveisGlobais.quantidadeSlava.ToString(), "Foram adicionados no Carrinho");
            panelSlava.Visible = false;
        }
        private void BtnMenosP_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadePolaka > 0)

                VariaveisGlobais.quantidadePolaka--;
            AtualizarValor();

            if (VariaveisGlobais.valorPolaka > 0)

                VariaveisGlobais.valorPolakaMenos = VariaveisGlobais.valorPolaka - 26;
            VariaveisGlobais.valorPolaka = VariaveisGlobais.valorPolakaMenos;
            BoxValorfinalP.Text = VariaveisGlobais.valorPolaka.ToString() + ",00";
        }
        private void BtnMenosC_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeChamate > 0)

                VariaveisGlobais.quantidadeChamate--;
            AtualizarValor();

            if (VariaveisGlobais.valorChamate > 0)

                VariaveisGlobais.valorChamateMenos = VariaveisGlobais.valorChamate - 8;
            VariaveisGlobais.valorChamate = VariaveisGlobais.valorChamateMenos;
            BoxValorfinalC.Text = VariaveisGlobais.valorChamate.ToString() + ",00";
        }
        private void BtnMenosCA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeCaipirinha > 0)

                VariaveisGlobais.quantidadeCaipirinha--;
                AtualizarValor();

            if (VariaveisGlobais.valorCaipirinha > 0)

                VariaveisGlobais.valorCaipirinhaMenos = VariaveisGlobais.valorCaipirinha - 16;
            VariaveisGlobais.valorCaipirinha = VariaveisGlobais.valorCaipirinhaMenos;
            BoxValorfinalCA.Text = VariaveisGlobais.valorCaipirinha.ToString() + ",00";
        }
        private void BtnMenosMA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeMaçaAmor > 0)

                VariaveisGlobais.quantidadeMaçaAmor--;
            AtualizarValor();

            if (VariaveisGlobais.valorMaçaAmor > 0)

                VariaveisGlobais.valorMaçãAmorMenos = VariaveisGlobais.valorMaçaAmor - 18;
            VariaveisGlobais.valorMaçaAmor = VariaveisGlobais.valorMaçãAmorMenos;
            BoxValorfinalMA.Text = VariaveisGlobais.valorMaçaAmor.ToString() + ",00";
        }
        private void BtnMenosM_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeMoniche > 0)

                VariaveisGlobais.quantidadeMoniche--;
            AtualizarValor();

            if (VariaveisGlobais.valorMoniche > 0)

                VariaveisGlobais.valorMonicheMenos = VariaveisGlobais.valorMoniche - 23;
            VariaveisGlobais.valorMoniche = VariaveisGlobais.valorMonicheMenos;
            BoxValorfinalM.Text = VariaveisGlobais.valorMoniche.ToString() + ",00";
        }

        private void BtnMenosS_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeSlava > 0)

                VariaveisGlobais.quantidadeSlava--;
                AtualizarValor();

            if (VariaveisGlobais.valorSlava > 0)

                VariaveisGlobais.valorSlavaMenos = VariaveisGlobais.valorSlava - 18;
                VariaveisGlobais.valorSlava = VariaveisGlobais.valorSlavaMenos;
                BoxValorfinalS.Text = VariaveisGlobais.valorSlava.ToString() + ",00";
        }
        private void BtnMaisCA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeCaipirinha++;
            AtualizarValor();
            VariaveisGlobais.valorCaipirinha = VariaveisGlobais.quantidadeCaipirinha * 16.00;
            BoxValorfinalCA.Text = VariaveisGlobais.valorCaipirinha.ToString() + ",00";
        }
        private void BtnMaisMA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeMaçaAmor++;
            AtualizarValor();
            VariaveisGlobais.valorMaçaAmor = VariaveisGlobais.quantidadeMaçaAmor * 18.00;
            BoxValorfinalMA.Text = VariaveisGlobais.valorMaçaAmor.ToString() + ",00";
        }
        private void BtnMaisM_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeMoniche++;
            AtualizarValor();
            VariaveisGlobais.valorMoniche = VariaveisGlobais.quantidadeMoniche * 23.00;
            BoxValorfinalM.Text = VariaveisGlobais.valorMoniche.ToString() + ",00";
        }

        private void BtnMaisS_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeSlava++;
            AtualizarValor();
            VariaveisGlobais.valorSlava = VariaveisGlobais.quantidadeSlava * 18.00;
            BoxValorfinalS.Text = VariaveisGlobais.valorSlava.ToString() + ",00";
        }
        private void BtnMaisC_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeChamate++;
            AtualizarValor();
            VariaveisGlobais.valorChamate = VariaveisGlobais.quantidadeChamate * 8.00;
            BoxValorfinalC.Text = VariaveisGlobais.valorChamate.ToString() + ",00";
        }
        private void BtnMaisP_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadePolaka++;
            AtualizarValor();
            VariaveisGlobais.valorPolaka = VariaveisGlobais.quantidadePolaka * 26.00;
            BoxValorfinalP.Text = VariaveisGlobais.valorPolaka.ToString() + ",00";
        }

        bool sideBarMenuExpand1;
        private void SideBarTime_Tick(object sender, EventArgs e)
        {
            if (sideBarMenuExpand1)
            {
                SideBarLateral.Width -= 30;    //Declara o caso do Panel estiver com Determinado tamanho.
                if (SideBarLateral.Width == SideBarLateral.MinimumSize.Width)
                {

                    sideBarMenuExpand1 = false;//Deixa o Bool False.
                    SideBarTime.Stop();//Para o TimerTick
                }//Se estiver executa o comando.
            } //Se o Bool Estiver Sim.
            else
            {

                SideBarLateral.Width += 10;    //Declara o caso do Panel estiver com Determinado tamanho.
                if (SideBarLateral.Width == SideBarLateral.MaximumSize.Width)
                {

                    sideBarMenuExpand1 = true; //Deixa o Bool True.
                    SideBarTime.Stop();      //Para o TimerTick
                }//Se estiver executa o comando.
            }//Se o Bool Estiver Não.
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            SideBarTime.Start();
        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
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

        private void BtnCarrinho_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorFinal = VariaveisGlobais.valorItaliano + VariaveisGlobais.valorJapones + VariaveisGlobais.valorPolones + VariaveisGlobais.valorIberico + VariaveisGlobais.valorAlemao + VariaveisGlobais.valorVegetariano;
            VariaveisGlobais.valorFinalP = VariaveisGlobais.valorBatata + VariaveisGlobais.valorHulubsti + VariaveisGlobais.valorFrango + VariaveisGlobais.valorPerohe + VariaveisGlobais.valorBorscht + VariaveisGlobais.valorBanosh;
            VariaveisGlobais.valorFinalB = VariaveisGlobais.valorPolaka + VariaveisGlobais.valorChamate + VariaveisGlobais.valorMaçaAmor + VariaveisGlobais.valorMoniche + VariaveisGlobais.valorSlava + VariaveisGlobais.valorCaipirinha;

            VariaveisGlobais.valorFinalTotal = VariaveisGlobais.valorFinal + VariaveisGlobais.valorFinalB + VariaveisGlobais.valorFinalP;

            Carrinho carrinho = new Carrinho();
            this.Hide();
            carrinho.ShowDialog();
            this.Close();
        }
    }
}
