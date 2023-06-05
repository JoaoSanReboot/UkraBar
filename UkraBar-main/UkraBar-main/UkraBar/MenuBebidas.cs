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
            MostrarValor();
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

            BoxValorfinalC.Text = VariaveisGlobais.valorChamate.ToString() + ",00";
            BoxValorfinalCA.Text = VariaveisGlobais.valorCaipirinha.ToString() + ",00";
            BoxValorfinalM.Text = VariaveisGlobais.valorMoniche.ToString() + ",00";
            BoxValorfinalMA.Text = VariaveisGlobais.valorMaçaAmor.ToString() + ",00";
            BoxValorfinalP.Text = VariaveisGlobais.valorPolaka.ToString() + ",00";
            BoxValorfinalS.Text = VariaveisGlobais.valorSlava.ToString() + ",00";
        }

        private void MostrarValor()
        {
            BoxCQuantidadeC.Text = VariaveisGlobais.quantidadeChamate.ToString();
            BoxCQuantidadeCA.Text = VariaveisGlobais.quantidadeCaipirinha.ToString();
            BoxCQuantidadeM.Text = VariaveisGlobais.quantidadeMoniche.ToString();
            BoxquantidadeMA.Text = VariaveisGlobais.quantidadeMaçaAmor.ToString();
            BoxCQuantidadeP.Text = VariaveisGlobais.quantidadePolaka.ToString();
            BoxcQuantidadeS.Text = VariaveisGlobais.quantidadeSlava.ToString();

            BoxValorfinalC.Text = VariaveisGlobais.valorChamate.ToString() + ",00";
            BoxValorfinalCA.Text = VariaveisGlobais.valorCaipirinha.ToString() + ",00";
            BoxValorfinalM.Text = VariaveisGlobais.valorMoniche.ToString() + ",00";
            BoxValorfinalMA.Text = VariaveisGlobais.valorMaçaAmor.ToString() + ",00";
            BoxValorfinalP.Text = VariaveisGlobais.valorPolaka.ToString() + ",00";
            BoxValorfinalS.Text = VariaveisGlobais.valorSlava.ToString() + ",00";

        }

        private void BtnPolaka_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorPolaka = 26;
            BoxValorfinalP.Text = "26,00";
            panelPolaka.Visible = true;
        }

        private void btnChaMate_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorItaliano = 8;
            BoxValorfinalC.Text = "8,00";
            panelChaMatte.Visible = true;
        }

        private void btnMacaAmor_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorMacaAmor = 18;
            BoxValorfinalMA.Text = "18,00";
            panelMacaAmor.Visible = true;
        }

        private void btnMoniche_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorItaliano = 23;
            BoxValorfinalM.Text = "23,00";
            panelMunich.Visible = true;
        }

        private void btnSlava_Click(object sender, EventArgs e)
        { //VariaveisGlobais.valorSlava = 18;
            BoxValorfinalS.Text = "18,00";
            panelSlava.Visible = true;
        }

        private void btnCaipirinha_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorCaipirinha = 16;
            BoxValorfinalCA.Text = "16,00";
            panelCaipirinha.Visible = true;
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
            VariaveisGlobais.valorPolaka= Convert.ToDouble(BoxValorfinalP.Text);
            if (VariaveisGlobais.CompraPolaka == true)
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
                VariaveisGlobais.CompraPolaka = false;
                MessageBox.Show(VariaveisGlobais.quantidadePolaka.ToString(), "Foram adicionados no Carrinho");
                panelPolaka.Visible = false;
            }
            else
            {
                conn.Open();
                string queryInserirCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadePolaka);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorPolaka);
                    comandos.Parameters.AddWithValue("@nome_produto", "Polaka");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadePolaka.ToString(), "Foram adicionados no Carrinho");
                panelPolaka.Visible = false;
            }
        }

        private void BtnOkC_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorChamate = Convert.ToDouble(BoxValorfinalC.Text);
            if (VariaveisGlobais.CompraChamate == true)
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
                VariaveisGlobais.CompraChamate = false;
                MessageBox.Show(VariaveisGlobais.quantidadeChamate.ToString(), "Foram adicionados no Carrinho");
                panelChaMatte.Visible = false;
            }
            else
            {
                conn.Open();
                string queryInserirCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeChamate);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorChamate);
                    comandos.Parameters.AddWithValue("@nome_produto", "Chá Matte");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeChamate.ToString(), "Foram adicionados no Carrinho");
                panelChaMatte.Visible = false;
            }
        }
        private void BtnOkCA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorCaipirinha = Convert.ToDouble(BoxValorfinalCA.Text);
            if (VariaveisGlobais.CompraCaipirinha == true)
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
                VariaveisGlobais.CompraCaipirinha = false;
                MessageBox.Show(VariaveisGlobais.quantidadeCaipirinha.ToString(), "Foram adicionados no Carrinho");
                panelCaipirinha.Visible = false;
            }
            else
            {
                conn.Open();
                string queryInserirCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeCaipirinha);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorCaipirinha);
                    comandos.Parameters.AddWithValue("@nome_produto", "Caipirinha");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeCaipirinha.ToString(), "Foram adicionados no Carrinho");
                panelCaipirinha.Visible = false;
            }
        }

        private void BtnOkMA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorMaçaAmor = Convert.ToDouble(BoxValorfinalMA.Text);
            if (VariaveisGlobais.CompraMaça == true)
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
                VariaveisGlobais.CompraMaça = false;
                MessageBox.Show(VariaveisGlobais.quantidadeMaçaAmor.ToString(), "Foram adicionados no Carrinho");
                panelMacaAmor.Visible = false;
            }
            else
            {
                conn.Open();
                string queryInserirCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeMaçaAmor);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorMaçaAmor);
                    comandos.Parameters.AddWithValue("@nome_produto", "Maça do Amor");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeMaçaAmor.ToString(), "Foram adicionados no Carrinho");
                panelMacaAmor.Visible = false;
            }
        }
        private void BtnOkM_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorMoniche= Convert.ToDouble(BoxValorfinalM.Text);
            if (VariaveisGlobais.CompraMoniche == true)
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
                VariaveisGlobais.CompraMoniche = false;
                MessageBox.Show(VariaveisGlobais.quantidadeMoniche.ToString(), "Foram adicionados no Carrinho");
                panelMunich.Visible = false;
            }
            else
            {
                conn.Open();
                string queryInserirCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeMoniche);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorMoniche);
                    comandos.Parameters.AddWithValue("@nome_produto", "Moniche");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeMoniche.ToString(), "Foram adicionados no Carrinho");
                panelMunich.Visible = false;
            }
        }

        private void BtnOkS_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorSlava = Convert.ToDouble(BoxValorfinalS.Text);
            if (VariaveisGlobais.CompraSlava == true)
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
                VariaveisGlobais.CompraSlava = false;
                MessageBox.Show(VariaveisGlobais.quantidadeSlava.ToString(), "Foram adicionados no Carrinho");
                panelSlava.Visible = false;
            }
            else
            {
                conn.Open();
                string queryInserirCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeSlava);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorSlava);
                    comandos.Parameters.AddWithValue("@nome_produto", "Slava");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeSlava.ToString(), "Foram adicionados no Carrinho");
                panelSlava.Visible = false;
            }
        }
        private void BtnMenosP_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadePolaka > 1)

                VariaveisGlobais.quantidadePolaka--;
            AtualizarValor();

            if (VariaveisGlobais.valorPolaka > 26)

                VariaveisGlobais.valorPolakaMenos = VariaveisGlobais.valorPolaka - 26;
            VariaveisGlobais.valorPolaka = VariaveisGlobais.valorPolakaMenos;
            BoxValorfinalP.Text = VariaveisGlobais.valorPolaka.ToString() + ",00";
        }
        private void BtnMenosC_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeChamate > 1)

                VariaveisGlobais.quantidadeChamate--;
            AtualizarValor();

            if (VariaveisGlobais.valorChamate > 8)

                VariaveisGlobais.valorChamateMenos = VariaveisGlobais.valorChamate - 8;
            VariaveisGlobais.valorChamate = VariaveisGlobais.valorChamateMenos;
            BoxValorfinalC.Text = VariaveisGlobais.valorChamate.ToString() + ",00";
        }
        private void BtnMenosCA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeCaipirinha > 1)

                VariaveisGlobais.quantidadeCaipirinha--;
                AtualizarValor();

            if (VariaveisGlobais.valorCaipirinha > 16)

                VariaveisGlobais.valorCaipirinhaMenos = VariaveisGlobais.valorCaipirinha - 16;
            VariaveisGlobais.valorCaipirinha = VariaveisGlobais.valorCaipirinhaMenos;
            BoxValorfinalCA.Text = VariaveisGlobais.valorCaipirinha.ToString() + ",00";
        }
        private void BtnMenosMA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeMaçaAmor > 1)

                VariaveisGlobais.quantidadeMaçaAmor--;
            AtualizarValor();

            if (VariaveisGlobais.valorMaçaAmor > 18)

                VariaveisGlobais.valorMaçaAmorMenos = VariaveisGlobais.valorMaçaAmor - 18;
            VariaveisGlobais.valorMaçaAmor = VariaveisGlobais.valorMaçaAmorMenos;
            BoxValorfinalMA.Text = VariaveisGlobais.valorMaçaAmor.ToString() + ",00";
        }
        private void BtnMenosM_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeMoniche > 1)

                VariaveisGlobais.quantidadeMoniche--;
            AtualizarValor();

            if (VariaveisGlobais.valorMoniche > 23)

                VariaveisGlobais.valorMonicheMenos = VariaveisGlobais.valorMoniche - 23;
            VariaveisGlobais.valorMoniche = VariaveisGlobais.valorMonicheMenos;
            BoxValorfinalM.Text = VariaveisGlobais.valorMoniche.ToString() + ",00";
        }

        private void BtnMenosS_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeSlava > 1)

                VariaveisGlobais.quantidadeSlava--;
                AtualizarValor();

            if (VariaveisGlobais.valorSlava > 18)

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
            Carrinho carrinho = new Carrinho();
            this.Hide();
            carrinho.ShowDialog();
            this.Close();
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            Sobre Sobrenos = new Sobre();
            Sobrenos.ShowDialog();
            this.Close();
        }

        private void BtnPrato_Click(object sender, EventArgs e)
        {
            MenuPratos Pratos = new MenuPratos();
            this.Hide();
            Pratos.ShowDialog();
            this.Close();
        }

        private void BtnSanduba_Click(object sender, EventArgs e)
        {
            MenuSanduba Sanduba = new MenuSanduba();
            this.Hide();
            Sanduba.ShowDialog();
            this.Close();
        }
    }
}
