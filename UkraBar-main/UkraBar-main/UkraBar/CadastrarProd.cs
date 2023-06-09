﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UkraBar
{
    public partial class CadastrarProd : Form
    {
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader2;
        public DataTable table;

        public CadastrarProd()
        {
            InitializeComponent();
            CarregarDados();
        }

        //Carregar Dados é um public para carregar informações no DataGridView.
        public void CarregarDados()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT * FROM produto_loja"; //Seleciona informações da tabela Cadastro Funcionário.
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            reader2 = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader2); //Table lê os comandos.
            DTgridProd.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridProd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
            conn.Close(); //Fecha Conexão 

        }

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

        //Declarar Valores Bools

        bool sideBarMenuExpandD; //Bool para Cronometro da Barra Lateral.
        bool PanelConfig;   //Bool para o Panel de Configurações.
        bool NovoProdBarD;   //Bool para o Panel de Novo Funcionário.
        bool EditFundoD;     //Bool para o Panel de Editar Funcionário.

        //Timer Ticks para animações das Side Bars.

        //Side Bar Lateral.
        private void TimerSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarMenuExpandD)
            {
                sideBarMenuD.Width -= 30;    //Declara o caso do Panel estiver com Determinado tamanho.
                if (sideBarMenuD.Width == sideBarMenuD.MinimumSize.Width)
                {

                    sideBarMenuExpandD = false;//Deixa o Bool False.
                    TimerSideBar.Stop();//Para o TimerTick
                }//Se estiver executa o comando.
            } //Se o Bool Estiver Sim.
            else
            {

                sideBarMenuD.Width += 10;    //Declara o caso do Panel estiver com Determinado tamanho.
                if (sideBarMenuD.Width == sideBarMenuD.MaximumSize.Width)
                {

                    sideBarMenuExpandD = true; //Deixa o Bool True.
                    TimerSideBar.Stop();      //Para o TimerTick
                }//Se estiver executa o comando.
            }//Se o Bool Estiver Não.
        }

        //Side Bar Novo Produto.
        private void NovoProdBar_Tick(object sender, EventArgs e)
        {

            if (NovoProdBarD)
            {
                PanelCadastrarProd.Width -= 30; //Declara o caso do Panel estiver com Determinado tamanho.
                if (PanelCadastrarProd.Width == PanelCadastrarProd.MinimumSize.Width)
                {



                    NovoProdBarD = false;//Deixa o Bool False.
                    NovoProdBar.Stop();//Para o TimerTick.
                }//Se estiver executa o comando.
            }//Se o Bool Estiver Sim.
            else
            {
                PanelCadastrarProd.Width += 10;  //Declara o caso do Panel estiver com Determinado tamanho.
                if (PanelCadastrarProd.Width == PanelCadastrarProd.MaximumSize.Width)
                {

                    NovoProdBarD = true;   //Deixa o Bool True.
                    NovoProdBar.Stop();//Para o TimerTick.
                }
            }//Se o Bool Estiver Não.
        }

                                    //Funções dos Botões da Side Bar Lateral Direia.

        //Abre o Menu Lareral
        private void pbMenu_Click(object sender, EventArgs e)
        {
            TimerSideBar.Start();    //Começa o TimerTick.
            if (sideBarMenuExpandD == true)  //Se o Bool Estiver True.

            PanelCadastrarProd.Visible = false; //Esconder Outro Bool.
            NovoProdBar.Stop();        //Para outro Timer.
        }

        //Volta um Formúlário.
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.idAdm == 1)
            {
                PainelAdm adm = new PainelAdm(); //Declara nome do Formulário
                this.Hide();       //Esconde o Atual
                adm.ShowDialog(); //Mostra o Novo Formulário.
                this.Close();    //Fecha o Formulário antigo.
            }
            if (VariaveisGlobais.idFunc == 1)
            {
                PainelFuncionario func = new PainelFuncionario(); //Declara nome do Formulário
                this.Hide();       //Esconde o Atual
                func.ShowDialog(); //Mostra o Novo Formulário.
                this.Close();    //Fecha o Formulário antigo.
            }
        }

        //Remove as Bordas do Form Original.
        private void CadastrarProd_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //Fecha o Form Atual.
        private void FecharJanelaF_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Maximiza o Form.
        private void MaximizarJanela_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Minimiza o Form.
        private void MinimizarJanela_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Btn Salvar Informações no MySql.
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserir = "INSERT INTO produto_loja (id_produto, nome_produto, descricao, valor_produto, quantidade) VALUES (@id_produto, @nome_produto, @descricao, @valor_produto, @quantidade)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserir, conn))
            {
                comandos.Parameters.AddWithValue("@id_produto", BoxcId.Text);
                comandos.Parameters.AddWithValue("@nome_produto", BoxcNome.Text);
                comandos.Parameters.AddWithValue("@descricao", BoxcDescricao.Text);
                comandos.Parameters.AddWithValue("@valor_produto", BoxcValorP.Text);
                comandos.Parameters.AddWithValue("@quantidade", BoxcQuantidade.Text);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdProdutoInserido = (int)comandos.LastInsertedId;

                conn.Close();
            }

            if (VariaveisGlobais.idAdm == 1)
            {
                conn.Open();
                string queryInserirLogin = "INSERT INTO login_adm (nome_adm, senha_adm, id_produto) VALUES (@nome_adm, @senha_adm, @id_produto)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirLogin, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_adm", VariaveisGlobais.nomeloginADM);
                    comandos.Parameters.AddWithValue("@senha_adm", VariaveisGlobais.senhaloginADM);
                    comandos.Parameters.AddWithValue("@id_produto", VariaveisGlobais.ultimoIdProdutoInserido);
                    comandos.ExecuteNonQuery();
                    conn.Close();
                }
            }

            if (VariaveisGlobais.idFunc == 1)
            {
                conn.Open();
                string queryInserirLogin = "INSERT INTO login_func (nome_login_funcionario, senha_login_funcionario, id_produto) VALUES (@nome_login_funcionario, @senha_login_funcionario, @id_produto)";
                using (MySqlCommand comandos = new MySqlCommand(queryInserirLogin, conn))
                {
                    comandos.Parameters.AddWithValue("@nome_login_funcionario", VariaveisGlobais.NomeFunc);
                    comandos.Parameters.AddWithValue("@senha_login_funcionario", VariaveisGlobais.SenhaFunc);
                    comandos.Parameters.AddWithValue("@id_produto", VariaveisGlobais.ultimoIdProdutoInserido);
                    comandos.ExecuteNonQuery();
                    conn.Close();
                }
            }
            MessageBox.Show("Executado com Sucesso!");
            CarregarDados();        //Carrega dados na tabela.
        }

        //Picture Box Fechar dentro do Panel de Cadastro de Produto.
        private void pbFechar_Click(object sender, EventArgs e)
        {
            NovoProdBar.Start();//Reincia o timer ja ligado.
        }

        //Edita Informações na tabela Mysql e no Grid.
        private void BtnPincel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();//Abre Conexão.
                //Declara String.
                string Atualizar = "UPDATE produto_loja SET nome_produto = @nome_produto, descricao = @descricao, valor_produto = @valor_produto, quantidade = @quantidade WHERE id_produto = @id_produto";
                using (MySqlCommand comando = new MySqlCommand(Atualizar, conn))//Usa strings.
                {
                    {
                        //Declara Box como informações dentro do mysql.
                        comando.Parameters.AddWithValue("@id_produto", BoxdIdP.Text);
                        comando.Parameters.AddWithValue("@nome_produto", BoxdNomeP.Text);
                        comando.Parameters.AddWithValue("@descricao", BoxdDescricaoP.Text);
                        comando.Parameters.AddWithValue("@valor_produto", BoxdValorP.Text);
                        comando.Parameters.AddWithValue("@quantidade", BoxdQuantidadeP.Text);
                        comando.ExecuteNonQuery();//Executa comando.
                    }
                }
                MessageBox.Show("Executado com Sucesso");//Mensagem de Execução.
                CarregarDados();//Carrega dados na tabela.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");//Mensagem de error.
            }
            finally
            {
                conn.Close();//Fecha Conexão.
            }

        }

        //Função Mouse Click na Row Selecionar.
        private void DTgridProd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in DTgridProd.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CheckBox"].Value))
                {
                    BoxdIdP.Text = DTgridProd.CurrentRow.Cells[1].Value.ToString();
                    BoxdNomeP.Text = DTgridProd.CurrentRow.Cells[2].Value.ToString();
                    BoxdDescricaoP.Text = DTgridProd.CurrentRow.Cells[3].Value.ToString();
                    BoxdValorP.Text = DTgridProd.CurrentRow.Cells[4].Value.ToString();
                    BoxdQuantidadeP.Text = DTgridProd.CurrentRow.Cells[5].Value.ToString();
                }
            }
     
        }

        //Btn Buscar informações.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))//Executa a conn quando apertado.
            {
                string b = "'%" + BoxBuscar.Text + "%'"; // Defini BoxBuscar como string

                try
                {
                    conn.Open();//Abre Conexão.
                    comando = new MySqlCommand("SELECT * FROM ukrasystem.produto_loja WHERE" +
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
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            Sobre Sobrenos = new Sobre();
            Sobrenos.ShowDialog();
            this.Close();
            //teste
        }

        private void BtnConfigurações_Click(object sender, EventArgs e)
        {
            if (PanelConfig)
            {

                panelShowConfig.Height -= 257;//Se o panel estiver Menor ou igual o Valor.
                PanelConfig = false;
            }//Se o Panel estive True
            else
            {
                panelShowConfig.Height += 257;//Se o panel estiver Maior ou igual o Valor.
                PanelConfig = true;          //Deixe o Bool True.
            }//Se o Panel estive False
        }

        private void BtnNovoFunc_Click(object sender, EventArgs e)
        {
            if (sideBarMenuExpandD == true)
            {
                PanelCadastrarProd.Visible = true;
                NovoProdBar.Start();
            }
        }

        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            string DeletarPK = "DELETE FROM produto_loja WHERE id_produto = @id_produto";
            string DeletarFKA = "DELETE FROM login_adm WHERE id_produto = @id_produto";
            string DeletarFKF = "DELETE FROM login_func WHERE id_produto = @id_produto";

            try
            {

                for (int i = 0; i < DTgridProd.Rows.Count; i++)//Faz a contagem de linhas Selecionadas enquanto i for menor que a contagens de rows.
                {
                    DataGridViewCheckBoxCell CheckBox = DTgridProd.Rows[i].Cells[0] as DataGridViewCheckBoxCell; //Defini CheckBox como funcional.

                    if (CheckBox.Value != null && (bool)CheckBox.Value == true)//Bool sim ou não.
                    {
                        int id = Convert.ToInt32(DTgridProd.Rows[i].Cells[1].Value);//Int para contagem de celulas marcadas.

                        if (VariaveisGlobais.idAdm == 1)
                        {
                            using (MySqlCommand command = new MySqlCommand(DeletarFKA, conn))
                            {
                                command.Parameters.AddWithValue("@id_produto", id);
                                command.ExecuteNonQuery();
                            }
                        }

                        if (VariaveisGlobais.idFunc == 1)
                        {
                            using (MySqlCommand command = new MySqlCommand(DeletarFKF, conn))
                            {
                                command.Parameters.AddWithValue("@id_produto", id);
                                command.ExecuteNonQuery();
                            }
                        }
                        using (MySqlCommand command = new MySqlCommand(DeletarPK, conn))
                        {
                            command.Parameters.AddWithValue("@id_produto", id);
                            command.ExecuteNonQuery();
                        }

                        DTgridProd.Rows.RemoveAt(i);//Deleta as linhas.
                        i--;                       //Diminui as linhas.

                    }

                }
            }catch (Exception ex)
            {
                MessageBox.Show("Você não cadastrou esse Produto, apenas o criador pode deletar.");
            }
            finally
            {
                CarregarDados();//Carregas os dados no GridView
                conn.Close();//Fecha a Conexão
            }
            {

            }
            
          
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (EditFundoD)//Se o Bool estiver menor ou igual valor.
            {
                panelEditarFundo.Height -= 113;
                EditFundoD = false;//Deixar Bool false.
            }
            else
            {
                panelEditarFundo.Height += 113;//Se o Bool estiver maior ou igual valor.
                EditFundoD = true;//Deixar Bool True.
            }
        }
    }
}
