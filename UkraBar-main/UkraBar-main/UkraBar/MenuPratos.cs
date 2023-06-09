using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UkraBar
{
    public partial class MenuPratos : Form
    {
        public MenuPratos()
        {
            InitializeComponent();
            MostrarValor();
        }

                                             //Setando comandos MySql para a contatenação.

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader;
        public DataTable table;

        private void AtualizarValor()
        {
            BoxCquantidadeF.Text = VariaveisGlobais.quantidadeFrango.ToString();
            BoxcQuantidadeH.Text = VariaveisGlobais.quantidadeHulubsti.ToString();
            BoxCQuantidadeBA.Text = VariaveisGlobais.quantidadeBanosh.ToString();
            BoxCQuantidadeBO.Text = VariaveisGlobais.quantidadeBorscht.ToString();
            BoxCQuantidadeP.Text = VariaveisGlobais.quantidadePerohe.ToString();
            BoxCQuantidadeB.Text = VariaveisGlobais.quantidadeBatata.ToString();

            BoxValorfinalB.Text = VariaveisGlobais.valorBatata.ToString() + ",00";
            BoxValorfinalBA.Text = VariaveisGlobais.valorBanosh.ToString() + ",00";
            BoxValorfinalBO.Text = VariaveisGlobais.valorBorscht.ToString() + ",00";
            BoxValorfinalF.Text = VariaveisGlobais.valorFrango.ToString() + ",00";
            BoxValorfinalH.Text = VariaveisGlobais.valorHulubsti.ToString() + ",00";
            BoxValorfinalP.Text = VariaveisGlobais.valorPerohe.ToString() + ",00";
        }

        public void MostrarValor()
        {
            BoxCquantidadeF.Text = VariaveisGlobais.quantidadeFrango.ToString();
            BoxcQuantidadeH.Text = VariaveisGlobais.quantidadeHulubsti.ToString();
            BoxCQuantidadeBA.Text = VariaveisGlobais.quantidadeBanosh.ToString();
            BoxCQuantidadeBO.Text = VariaveisGlobais.quantidadeBorscht.ToString();
            BoxCQuantidadeP.Text = VariaveisGlobais.quantidadePerohe.ToString();
            BoxCQuantidadeB.Text = VariaveisGlobais.quantidadeBatata.ToString();

            BoxValorfinalB.Text = VariaveisGlobais.valorBatata.ToString() + ",00";
            BoxValorfinalBA.Text = VariaveisGlobais.valorBanosh.ToString() + ",00";
            BoxValorfinalBO.Text = VariaveisGlobais.valorBorscht.ToString() + ",00";
            BoxValorfinalF.Text = VariaveisGlobais.valorFrango.ToString() + ",00";
            BoxValorfinalH.Text = VariaveisGlobais.valorHulubsti.ToString() + ",00";
            BoxValorfinalP.Text = VariaveisGlobais.valorPerohe.ToString() + ",00";

        }

        private void BtnOkBA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorBanosh = Convert.ToDouble(BoxValorfinalBA.Text);
            if (VariaveisGlobais.CompraBanosh == true)
            {
                conn.Open();
                string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_produto", "Banosh");
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeBanosh);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorBanosh);
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
                }
                conn.Close();
                VariaveisGlobais.CompraBanosh = false;
                MessageBox.Show(VariaveisGlobais.quantidadeBanosh.ToString(), "Foram adicionados no Carrinho");
                panelBanosh.Visible = false;
            }
            else
            {
                conn.Open();
                string AtualizarCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(AtualizarCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeBanosh);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorBanosh);
                    comandos.Parameters.AddWithValue("@nome_produto", "Banosh");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeBanosh.ToString(), "Foram adicionados no Carrinho");
                panelBanosh.Visible = false;
            }
        }
        private void BtnOkBO_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorBorscht = Convert.ToDouble(BoxValorfinalBO.Text);
            if (VariaveisGlobais.CompraBorscht == true)
            {
                conn.Open();
                string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_produto", "Borscht");
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeBorscht);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorBorscht);
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
                }
                conn.Close();
                VariaveisGlobais.CompraBorscht = false;
                MessageBox.Show(VariaveisGlobais.quantidadeBorscht.ToString(), "Foram adicionados no Carrinho");
                panelBorscht.Visible = false;
            }
            else
            {
                conn.Open();
                string AtualizarCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(AtualizarCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeBorscht);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorBorscht);
                    comandos.Parameters.AddWithValue("@nome_produto", "Borscht");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeBorscht.ToString(), "Foram adicionados no Carrinho");
                panelBorscht.Visible = false;
            }
        }


        private void BtnOkH_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorHulubsti = Convert.ToDouble(BoxValorfinalB.Text);
            if (VariaveisGlobais.CompraHusbulist == true)
            {
                conn.Open();
                string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_produto", "Hulubsti");
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeHulubsti);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorHulubsti);
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
                }
                conn.Close();
                VariaveisGlobais.CompraHusbulist = false;
                MessageBox.Show(VariaveisGlobais.quantidadeHulubsti.ToString(), "Foram adicionados no Carrinho");
                panelHolubtsi.Visible = false;
            }
            else
            {
                conn.Open();
                string AtualizarCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(AtualizarCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeHulubsti);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorHulubsti);
                    comandos.Parameters.AddWithValue("@nome_produto", "Hulubsti");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeHulubsti.ToString(), "Foram adicionados no Carrinho");
                panelHolubtsi.Visible = false;
            }
        }

        private void BtnOkF_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorFrango = Convert.ToDouble(BoxValorfinalF.Text);
            if (VariaveisGlobais.CompraFrango == true)
            {
                conn.Open();
                string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_produto", "Frango a kyiv");
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeFrango);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorFrango);
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
                }
                conn.Close();
                VariaveisGlobais.CompraFrango = false;
                MessageBox.Show(VariaveisGlobais.quantidadeFrango.ToString(), "Foram adicionados no Carrinho");
                panelFrango.Visible = false;
            }
            else
            {
                conn.Open();
                string AtualizarCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(AtualizarCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeFrango);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorFrango);
                    comandos.Parameters.AddWithValue("@nome_produto", "Frango a kyiv");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeFrango.ToString(), "Foram adicionados no Carrinho");
                panelFrango.Visible = false;
            }
        }

        private void BtnOkP_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorPerohe = Convert.ToDouble(BoxValorfinalP.Text);
            if (VariaveisGlobais.CompraPerohe)
            {

                conn.Open();
                string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_produto", "Perohe");
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadePerohe);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorPerohe);
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
                }
                conn.Close();
                VariaveisGlobais.CompraPerohe = false;
                MessageBox.Show(VariaveisGlobais.quantidadePerohe.ToString(), "Foram adicionados no Carrinho");
                panelPerohe.Visible = false;
            }
            else
            {
                conn.Open();
                string AtualizarCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(AtualizarCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadePerohe);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorPerohe);
                    comandos.Parameters.AddWithValue("@nome_produto", "Perohe");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadePerohe.ToString(), "Foram adicionados no Carrinho");
                panelPerohe.Visible = false;
            }
        }
        private void BtnOkB_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.valorBatata = Convert.ToDouble(BoxValorfinalB.Text);
            if (VariaveisGlobais.CompraBatata == true)
            {
                conn.Open();
                string queryInserirPedido = "INSERT INTO pedido_cliente (nome_produto, quantidade, valor_produto, id_cliente) VALUES (@nome_produto, @quantidade, @valor_produto, @id_cliente)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirPedido, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_produto", "Batata com Cheddar");
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeBatata);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorBatata);
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                    VariaveisGlobais.ultimoIdPedidoInserido = (int)comandos.LastInsertedId;
                }
                conn.Close();
                VariaveisGlobais.CompraBatata = false;
                MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
                panelBatata.Visible = false;
            }
            else
            {
                conn.Open();
                string AtualizarCarrinho = "UPDATE pedido_cliente SET quantidade =  @quantidade, valor_produto = @valor_produto WHERE nome_produto = @nome_produto AND id_cliente = @id_cliente";
                using (MySqlCommand comandos = new MySqlCommand(AtualizarCarrinho, conn))
                {
                    comandos.Parameters.AddWithValue("@quantidade", VariaveisGlobais.quantidadeBatata);
                    comandos.Parameters.AddWithValue("@valor_produto", VariaveisGlobais.valorBatata);
                    comandos.Parameters.AddWithValue("@nome_produto", "Batata com Cheddar");
                    comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                    comandos.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show(VariaveisGlobais.quantidadeBatata.ToString(), "Foram adicionados no Carrinho");
                panelBatata.Visible = false;
            }
        }
        private void BtnCancelarBA_Click(object sender, EventArgs e)
        {
            panelBanosh.Visible = false;
        }
        private void BtnCancelarBO_Click(object sender, EventArgs e)
        {
            panelBorscht.Visible = false;
        }
        private void BtnCancelarH_Click(object sender, EventArgs e)
        {
            panelHolubtsi.Visible = false;
        }
        private void BtnCancelarF_Click(object sender, EventArgs e)
        {
            panelFrango.Visible = false;
        }
        private void BtnCancelarP_Click(object sender, EventArgs e)
        {
            panelPerohe.Visible = false;
        }

        private void BtnCancelarB_Click(object sender, EventArgs e)
        {
            panelBatata.Visible = false;
        }
        private void BtnMenosBA_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeBanosh > 1)

                VariaveisGlobais.quantidadeBanosh--;
                AtualizarValor();

            if (VariaveisGlobais.valorBanosh > 25)

                VariaveisGlobais.valorBanoshMenos = VariaveisGlobais.valorBanosh - 25;
                VariaveisGlobais.valorBanosh = VariaveisGlobais.valorBanoshMenos;
                BoxValorfinalBA.Text = VariaveisGlobais.valorBanosh.ToString() + ",00";
        }
        private void BtnMenosBO_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeBorscht > 1)

                VariaveisGlobais.quantidadeBorscht--;
                AtualizarValor();

            if (VariaveisGlobais.valorBorscht > 28)

                VariaveisGlobais.valorBorschtMenos = VariaveisGlobais.valorBorscht - 28;
                VariaveisGlobais.valorBorscht = VariaveisGlobais.valorBorschtMenos;
                BoxValorfinalBO.Text = VariaveisGlobais.valorBorscht.ToString() + ",00";
        }
        private void BtnMenosH_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeHulubsti > 1)

                VariaveisGlobais.quantidadeHulubsti--;
                AtualizarValor();

            if (VariaveisGlobais.valorHulubsti > 20)

                VariaveisGlobais.valorHulubstiMenos = VariaveisGlobais.valorHulubsti - 20;
                VariaveisGlobais.valorHulubsti = VariaveisGlobais.valorHulubstiMenos;
                BoxValorfinalH.Text = VariaveisGlobais.valorHulubsti.ToString() + ",00";
        }
        private void BtnMenosF_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeFrango > 1)

                VariaveisGlobais.quantidadeFrango--;
                AtualizarValor();

            if (VariaveisGlobais.valorFrango > 45)

                VariaveisGlobais.valorFrangoMenos = VariaveisGlobais.valorFrango - 45;
                VariaveisGlobais.valorFrango = VariaveisGlobais.valorFrangoMenos;
                BoxValorfinalF.Text = VariaveisGlobais.valorFrango.ToString() + ",00";
        }
        private void BtnMenosP_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadePerohe > 1)

                VariaveisGlobais.quantidadePerohe--;
                 AtualizarValor();

            if (VariaveisGlobais.valorPerohe > 32)

                 VariaveisGlobais.valorPeroheMenos = VariaveisGlobais.valorPerohe - 32;
                 VariaveisGlobais.valorPerohe = VariaveisGlobais.valorPeroheMenos;
                 BoxValorfinalP.Text = VariaveisGlobais.valorPerohe.ToString() + ",00";
        }
        private void BtnMenosB_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.quantidadeBatata > 1)

            VariaveisGlobais.quantidadeBatata--;
            AtualizarValor();

            if (VariaveisGlobais.valorBatata > 23)

                VariaveisGlobais.valorBatataMenos = VariaveisGlobais.valorBatata - 23;
                VariaveisGlobais.valorBatata = VariaveisGlobais.valorBatataMenos;
            BoxValorfinalB.Text = VariaveisGlobais.valorBatata.ToString() + ",00";
        }

        private void BtnMaisB_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeBatata++;
            AtualizarValor();
            VariaveisGlobais.valorBatata = VariaveisGlobais.quantidadeBatata * 23.00;
            BoxValorfinalB.Text = VariaveisGlobais.valorBatata.ToString() + ",00";
        }
        private void BtnMaisP_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadePerohe++;
            AtualizarValor();
            VariaveisGlobais.valorPerohe = VariaveisGlobais.quantidadePerohe * 32.00;
            BoxValorfinalP.Text = VariaveisGlobais.valorPerohe.ToString() + ",00";
        }
        private void BtnMaisF_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeFrango++;
            AtualizarValor();
            VariaveisGlobais.valorFrango = VariaveisGlobais.quantidadeFrango * 45.00;
            BoxValorfinalF.Text = VariaveisGlobais.valorFrango.ToString() + ",00";
        }
        private void BtnMaisH_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeHulubsti++;
            AtualizarValor();
            VariaveisGlobais.valorHulubsti = VariaveisGlobais.quantidadeHulubsti * 20.00;
            BoxValorfinalH.Text = VariaveisGlobais.valorHulubsti.ToString() + ",00";
        }
        private void BtnMaisBO_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeBorscht++;
            AtualizarValor();
            VariaveisGlobais.valorBorscht = VariaveisGlobais.quantidadeBorscht * 28.00;
            BoxValorfinalBO.Text = VariaveisGlobais.valorBorscht.ToString() + ",00";
        }
        private void BtnMaisBA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.quantidadeBanosh++;
            AtualizarValor();
            VariaveisGlobais.valorBanosh = VariaveisGlobais.quantidadeBanosh * 25.00;
            BoxValorfinalBA.Text = VariaveisGlobais.valorBanosh.ToString() + ",00";
        }

        private void BtnBatata_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorBatata = 23;
            BoxValorfinalB.Text = "23,00";
            panelBatata.Visible = true;
        }

        private void BtnFrango_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorFrango = 45;
            BoxValorfinalF.Text = "45,00";
            panelFrango.Visible = true;
        }

        private void BtnPerohe_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorPerohe = 32;
            BoxValorfinalP.Text = "32,00";
            panelPerohe.Visible = true;
        }

        private void BtnHulubsti_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorHulubsti = 20;
            BoxValorfinalH.Text = "20,00";
            panelHolubtsi.Visible = true;
        }

        private void BtnBorscht_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorBorcht = 28;
            BoxValorfinalBO.Text = "28,00";
            panelBorscht.Visible = true;
        }

        private void BtnBanosh_Click(object sender, EventArgs e)
        {
            //VariaveisGlobais.valorBanosh = 25;
            BoxValorfinalBA.Text = "25,00";
            panelBanosh.Visible = true;
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

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string DeletarCliente = "DELETE FROM cliente WHERE id_cliente = @id_cliente";
            using (MySqlCommand comandos = new MySqlCommand(DeletarCliente, conn))
            {
                comandos.Parameters.AddWithValue("@id_cliente", VariaveisGlobais.ultimoIdClienteInserido);
                comandos.ExecuteNonQuery();
            }
        
            string DeletarPedido = "DELETE FROM pedido_cliente WHERE id_pedido_cliente = @id_pedido_cliente";
            using (MySqlCommand comandos = new MySqlCommand(DeletarPedido, conn))
            {
                comandos.Parameters.AddWithValue("@id_pedido_cliente", VariaveisGlobais.ultimoIdPedidoInserido);
                comandos.ExecuteNonQuery();
            }
            conn.Close();




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

        private void BtnSanduba_Click(object sender, EventArgs e)
        {
            MenuSanduba Sanduba = new MenuSanduba();
            this.Hide();
            Sanduba.ShowDialog();
            this.Close();
        }

        private void BtnBebidas_Click(object sender, EventArgs e)
        {
            MenuBebidas Bebidas = new MenuBebidas();
            this.Hide();
            Bebidas.ShowDialog();
            this.Close();
        }

        private void MenuPratos_Load(object sender, EventArgs e)
        {

        }
    }
}
