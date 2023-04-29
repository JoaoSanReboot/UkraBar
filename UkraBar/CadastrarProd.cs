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
    public partial class CadastrarProd : Form
    {
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        private string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        private MySqlCommand comando;
        private MySqlDataReader reader;
        private DataTable table;

        public CadastrarProd()
        {
            InitializeComponent();
            CarregarDados();
        }

        Panel P = new Panel();// Complementação do BtnMouseEnter e Leave.

        //Configurações da Conexão
        public void CarregarDados()
        {

            MySqlConnection conn = new MySqlConnection(connectionString);//Definindo Conexão
            conn.Open();// Abre Conexão

            string query = "SELECT * FROM produto";//Carrega dados no DataGriedView
            comando = new MySqlCommand(query, conn); //Declara comandos para o MySql
            reader = comando.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            DTgridProd.DataSource = table;


            DTgridProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Centraliza as Tabelas
            conn.Close(); //Fecha Conexão 

        }//Carrega dados no DataGridView.

        public void AbrirConexão()//Um Public para caso a conn esteja fechada ela se abra.
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void FecharConexão()//Um Public para caso a conn esteja aberta ela se feche.
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void executarQuery(string query)//Um Public para executar comando e mostrar box caso ele seja executado com exilio ou não.
        {
            try
            {
                AbrirConexão();
                comando = new MySqlCommand(query, conn);

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Executado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi Executado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexão();
            }
        }

        //Configurações Mouse Enter e Leave
        private void MouseEnterCRUDP(object sender, EventArgs e)
        {

            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;//Defini que Btn é o Button

            cCrudProd.Controls.Add(P); // Controla Panel nomeado cCrud
            P.BackColor = Color.FromArgb(90, 210, 2);//Fundo fica verde
            P.Size = new Size(204, 4);//Defini o tamanho da linha
            P.Location = new
                Point(btn.Location.X, btn.Location.Y + 51);//E sua nova localização
        }

        private void MouseLeaveCRUDP(object sender, EventArgs e)
        {
            //Esconde a linha verde dos botões quando não selecionados
            cCrudProd.Controls.Remove(P);
        }

        private void MouseEnterCRUDREDP(object sender, EventArgs e)
        {

            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            cCrudProd.Controls.Add(P);
            P.BackColor = Color.Red;
            P.Size = new Size(204, 4);
            P.Location = new
                Point(btn.Location.X, btn.Location.Y + 51);
        }

        private void MouseEnterCRUDGRAYP(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            cCrudProd.Controls.Add(P);
            P.BackColor = Color.Gray;
            P.Size = new Size(204, 4);
            P.Location = new
                Point(btn.Location.X, btn.Location.Y + 51);
        }

        //Configurações do TxtEnter e Leave
        private void txtProdutoEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox; //Defini txt com TextBox.
            foreach (Control ctrl in pPainelProduto.Controls)//Defini ctrl controla panel pContainer.
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pbp" + txt.Tag.ToString())
                //Comando apenas executado quando é clicado na Box.
                //Comando que toda Picture que começa com "pb" e estão setadas pela Tags mude de cor.
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                    //Muda a cor do BackGround da Box
                }
                if (ctrl is Label
                   && ctrl.Name == "lblp" + txt.Tag.ToString())
                {
                    //Mesma função que anterior só que para o Label.
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }

        private void txtProdutoLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;
            foreach (Control ctrl in pPainelProduto.Controls)
            {
                if (ctrl is PictureBox
                    && ctrl.Name == "pbp" + txt.Tag.ToString())
                //Comando apenas executado quando é estiver fora da Box.
                //Comando que toda Picture que começa com "pb" e estão setadas pela Tags mude de cor.
                {
                    if (txt.Text == string.Empty)
                    {
                        //Caso a Box estiver Empty=Vazia ela fica vermelha.
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.Black;
                    }

                }
                if (ctrl is Label
                   && ctrl.Name == "lblp" + txt.Tag.ToString())
                //Mesmas funções acimas porém para o label.
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.Black;
                    }
                }
            }
        }

        //Configurações dos Botões
        private void button1_Click_1(object sender, EventArgs e) //Botão Cadastrar
        {
            try
            {
                //Comando Sql para dar o Insert Into
                string sql = "INSERT INTO produto (nome_produto, descricao, valor_produto, quantidade)" +
                    "VALUES ('" + BoxProduto.Text + "','" + BoxDescricao.Text + "','" + BoxValor.Text + "','" + BoxQuantidade.Text + "') ";

                comando = new MySqlCommand(sql, conn); // Envia comando para o MySql
                conn.Open();// Abre Conexão
                comando.ExecuteNonQuery();// Executa comando

                MessageBox.Show("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo deu Errado", ex.Message);// Menssagem de Error

            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            PainelAdm adm = new PainelAdm();
            this.Hide();
            adm.ShowDialog();
            this.Close();
        }//Botão de Voltar

        private void DTgridProd_MouseClick(object sender, MouseEventArgs e)
        {
            BoxpId.Text = DTgridProd.CurrentRow.Cells[0].Value.ToString();
            BoxpProduto.Text = DTgridProd.CurrentRow.Cells[1].Value.ToString();
            BoxpDescricao.Text = DTgridProd.CurrentRow.Cells[2].Value.ToString();
            BoxpValor.Text = DTgridProd.CurrentRow.Cells[3].Value.ToString();
            BoxpQuantidade.Text = DTgridProd.CurrentRow.Cells[4].Value.ToString();
        }//Data Grid

        private void BtnSalvarP_Click(object sender, EventArgs e)
        {
            string inserirQuery = "INSERT INTO produto (id_produto, nome_produto, descricao, valor_produto, quantidade) VALUES" +
                "('" + BoxpId.Text + "', '" + BoxpProduto.Text + "', '" + BoxpDescricao.Text + "','" + BoxpValor.Text + "','" + BoxpQuantidade.Text + "')";
            executarQuery(inserirQuery);//Executa o comando InserirQuery string
            CarregarDados();//Carrega dados na tabela.
        }//Botão Voltar

        private void BtnExcluirP_Click(object sender, EventArgs e)
        {
            string ExcluirQuery = "DELETE FROM produto WHERE id_produto ='" + BoxpId.Text + "'";
            executarQuery(ExcluirQuery);//Executa o comando ExcluirQuery string onde o id for igual a BoxId
            CarregarDados();//Carrega dados na tabela.
        }//Botão Excluir

        private void BtnAtualizarP_Click(object sender, EventArgs e)
        {
            string atualizarQuery = "UPDATE ukrasystem.produto SET nome_produto='" + BoxpProduto.Text +
            "',descricao='" + BoxpDescricao.Text +
            "',valor_produto='" + BoxpValor.Text +
            "',quantidade='" + BoxpQuantidade.Text +
            "' WHERE id_produto = '" + BoxpId.Text + "'";
            executarQuery(atualizarQuery);//Executa a string atualizarQuery
            CarregarDados();//Carrega dados na tabela.
        }//Botão Atualizar

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))//Executa a conn quando apertado.
            {
                string b = "'%" + BoxBuscar.Text + "%'"; // Defini BoxBuscar como string

                try
                {
                    conn.Open();//Abre Conexão.
                    comando = new MySqlCommand("SELECT * FROM ukrasystem.produto WHERE" +
                        " id_produto LIKE" + b +
                        "OR nome_produto LIKE" + b +
                        "OR descricao LIKE" + b +
                        "OR valor_produto LIKE" + b +
                        "OR quantidade LIKE" + b, conn); //Envia comando Select no MySql
                    DataTable ProcurarDataTable = new DataTable(); //Defini table nova
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))//Faz o filtro no DataGridView.
                    {
                        adapter.Fill(ProcurarDataTable);
                    }
                    DTgridProd.DataSource = ProcurarDataTable; //Mostra nova table
                    DTgridProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Centraliza as Tabelas.
                    conn.Close();//Fecha Conexão.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algum erro Encontrado", ex.Message);
                }
            }
        }//Botão Buscar
    }
    }

