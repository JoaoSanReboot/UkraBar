using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Mysqlx.Crud;

namespace UkraBar
{

    public partial class CadastrarFunc : Form
    {
        //Setando comandos MySql para a contatenação.

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader;
        public DataTable table;


        public CadastrarFunc()
        {
            InitializeComponent();
            CarregarDados();

        }

        //Carregar Dados é um public para carregar informações no DataGridView.
        public void CarregarDados()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT * FROM cadastro_funcionario"; //Seleciona informações da tabela Cadastro Funcionário.
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            reader = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader); //Table lê os comandos.
            DTgridClientes.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridClientes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
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

        //Declarar Valores Bools

        bool sideBarMenuExpand; //Bool para Cronometro da Barra Lateral.
        bool PanelConfig;   //Bool para o Panel de Configurações.
        bool NovoFuncBar;   //Bool para o Panel de Novo Funcionário.
        bool EditFundo;     //Bool para o Panel de Editar Funcionário.

        //Timer Ticks para animações das Side Bars.

        //Side Bar Lateral.
        private void SideBarTime_Tick(object sender, EventArgs e)
        {
            if (sideBarMenuExpand)
            {
                sideBarMenu.Width -= 30;    //Declara o caso do Panel estiver com Determinado tamanho.
                if (sideBarMenu.Width == sideBarMenu.MinimumSize.Width)
                {

                    sideBarMenuExpand = false;//Deixa o Bool False.
                    SideBarTime.Stop();//Para o TimerTick
                }//Se estiver executa o comando.
            } //Se o Bool Estiver Sim.
            else
            {

                sideBarMenu.Width += 10;    //Declara o caso do Panel estiver com Determinado tamanho.
                if (sideBarMenu.Width == sideBarMenu.MaximumSize.Width)
                {

                    sideBarMenuExpand = true; //Deixa o Bool True.
                    SideBarTime.Stop();      //Para o TimerTick
                }//Se estiver executa o comando.
            }//Se o Bool Estiver Não.
        }

        //Side Bar Novo Funcionário.
        private void NovoFuncTimer_Tick(object sender, EventArgs e)
        {

            if (NovoFuncBar)
            {
                PanelCadastrarFunc.Width -= 30; //Declara o caso do Panel estiver com Determinado tamanho.
                if (PanelCadastrarFunc.Width == PanelCadastrarFunc.MinimumSize.Width) {



                    NovoFuncBar = false;//Deixa o Bool False.
                    NovoFuncTimer.Stop();//Para o TimerTick.
                }//Se estiver executa o comando.
            }//Se o Bool Estiver Sim.
            else
            {
                PanelCadastrarFunc.Width += 10;  //Declara o caso do Panel estiver com Determinado tamanho.
                if (PanelCadastrarFunc.Width == PanelCadastrarFunc.MaximumSize.Width)
                {

                    NovoFuncBar = true;   //Deixa o Bool True.
                    NovoFuncTimer.Stop();//Para o TimerTick.
                }
            }//Se o Bool Estiver Não.
        }


        //Funções em Gerais.


        //Executa o TimerTick SideBarLateral.
        private void pbMenu_Click_1(object sender, EventArgs e)
        {
            SideBarTime.Start();    //Começa o TimerTick.
            if (sideBarMenuExpand == true)  //Se o Bool Estiver True.

                PanelCadastrarFunc.Visible = false; //Esconder Outro Bool.
            NovoFuncTimer.Stop();        //Para outro Timer.
        }

        //Abre o Panel de Configurações.
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

        //Volta um Formulário.
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

        //PictureBox de X botton para fechar Panel de Cadastro
        private void pbFechar_Click(object sender, EventArgs e)
        {
            NovoFuncTimer.Start();//Inicia o Tempo para Fechar.
        }


        private void BtnNovoFunc_Click_1(object sender, EventArgs e)
        {
            if (sideBarMenuExpand == true)//Se o Bool Estiver Sim.
            {
                PanelCadastrarFunc.Visible = true;//Então deixar Bool Sim;
                NovoFuncTimer.Start();          //Começar Timer.
            }
        }
        private void BtnDeletar_Click_1(object sender, EventArgs e)
        {
            conn.Open();

            string DeletarPK = "DELETE FROM cadastro_funcionario WHERE id_cadastro = @id_cadastro";
            string DeletarFKA = "DELETE FROM login_adm WHERE id_cadastro = @id_cadastro";

            for (int i = 0; i < DTgridClientes.Rows.Count; i++)//Faz a contagem de linhas Selecionadas enquanto i for menor que a contagens de rows.
            {
                DataGridViewCheckBoxCell CheckBox = DTgridClientes.Rows[i].Cells[0] as DataGridViewCheckBoxCell; //Defini CheckBox como funcional.

                if (CheckBox.Value != null && (bool)CheckBox.Value == true)//Bool sim ou não.
                {
                    int id = Convert.ToInt32(DTgridClientes.Rows[i].Cells[1].Value);//Int para contagem de celulas marcadas.

                    if (VariaveisGlobais.idAdm == 1)
                    {
                        using (MySqlCommand command = new MySqlCommand(DeletarFKA, conn))
                        {
                            command.Parameters.AddWithValue("@id_cadastro", id);
                            command.ExecuteNonQuery();
                        }
                    }
                    using (MySqlCommand command = new MySqlCommand(DeletarPK, conn))
                    {
                        command.Parameters.AddWithValue("@id_cadastro", id);
                        command.ExecuteNonQuery();
                    }

                    DTgridClientes.Rows.RemoveAt(i);//Deleta as linhas.
                    i--;                       //Diminui as linhas.
                }
            }
      
            CarregarDados();//Carregas os dados no GridView
            conn.Close();
        }


        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (EditFundo)//Se o Bool estiver menor ou igual valor.
            {
                panelEditarFundo.Height -= 113;
                EditFundo = false;//Deixar Bool false.
            }
            else
            {
                panelEditarFundo.Height += 113;//Se o Bool estiver maior ou igual valor.
                EditFundo = true;//Deixar Bool True.
            }
        }

        private void BtnPincel_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();//Abre Conexão.
                            //Declara String.
                string Atualizar = "UPDATE cadastro_funcionario SET nome_funcionario = @nome_funcionario, senha_funcionario = @senha_funcionario, email_funcionario = @email_funcionario WHERE id_cadastro = @id_cadastro";
                using (MySqlCommand comando = new MySqlCommand(Atualizar, conn))//Usa strings.
                {
                    {
                        //Declara Box como informações dentro do mysql.
                        comando.Parameters.AddWithValue("@id_cadastro", BoxdIdF.Text);
                        comando.Parameters.AddWithValue("@nome_funcionario", BoxdNomeF.Text);
                        comando.Parameters.AddWithValue("@senha_funcionario", BoxdSenhaF.Text);
                        comando.Parameters.AddWithValue("@email_funcionario", BoxdEmailF.Text);
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

        private void DTgridClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in DTgridClientes.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CheckBox"].Value))
                {
                    BoxdIdF.Text = DTgridClientes.CurrentRow.Cells[1].Value.ToString();
                    BoxdNomeF.Text = DTgridClientes.CurrentRow.Cells[2].Value.ToString();
                    BoxdSenhaF.Text = DTgridClientes.CurrentRow.Cells[3].Value.ToString();
                    BoxdEmailF.Text = DTgridClientes.CurrentRow.Cells[4].Value.ToString();
                }
            }
        }

        private void CadastrarFunc_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FecharJanelaF_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void MinimizarJanela_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSobre_Click_1(object sender, EventArgs e)
        {
            Sobre Sobrenos = new Sobre();
            Sobrenos.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))//Executa a conn quando apertado.
            {
                string b = "'%" + BoxBuscar.Text + "%'"; // Defini BoxBuscar como string

                try
                {
                    conn.Open();//Abre Conexão.
                    comando = new MySqlCommand("SELECT * FROM ukrasystem.cadastro_funcionario WHERE" +
                        " id_cadastro LIKE" + b +
                        "OR nome_foto LIKE" + b +
                        "OR nome_funcionario LIKE" + b +
                        "OR senha_funcionario LIKE" + b +
                        "OR email_funcionario LIKE" + b, conn); //Envia comando Select no MySql
                    DataTable ProcurarDataTable = new DataTable(); //Defini table nova
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))//Faz o filtro no DataGridView.
                    {
                        adapter.Fill(ProcurarDataTable);
                    }
                    DTgridClientes.DataSource = ProcurarDataTable; //Mostra nova table
                    DTgridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Centraliza as Tabelas.
                    conn.Close();//Fecha Conexão.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algum erro Encontrado", ex.Message);
                }
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryInserir = "INSERT INTO cadastro_funcionario (id_cadastro, nome_funcionario, senha_funcionario, email_funcionario) VALUES (@id_cadastro, @nome_funcionario, @senha_funcionario, @email_funcionario)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserir, conn))
            {
                comandos.Parameters.AddWithValue("@id_cadastro", BoxcId.Text);
                comandos.Parameters.AddWithValue("@nome_funcionario", BoxcNome.Text);
                comandos.Parameters.AddWithValue("@senha_funcionario", BoxcSenha.Text);
                comandos.Parameters.AddWithValue("@email_funcionario", BoxcEmail.Text);
                comandos.ExecuteNonQuery();
                VariaveisGlobais.ultimoIdFuncionarioInserido = (int)comandos.LastInsertedId;

                conn.Close();
            }

            conn.Open();
            string queryInserirLogin = "INSERT INTO login_adm (nome_adm, senha_adm, id_cadastro) VALUES (@nome_adm, @senha_adm, @id_cadastro)";
            using (MySqlCommand comandos = new MySqlCommand(queryInserirLogin, conn))
            {
                comandos.Parameters.AddWithValue("@nome_adm", "UkraAdm");
                comandos.Parameters.AddWithValue("@senha_adm", "8^#3xY@7c$S5p@2#9a4!g6R^@1f%T#");
                comandos.Parameters.AddWithValue("@id_cadastro", VariaveisGlobais.ultimoIdFuncionarioInserido);
                comandos.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Executado com Sucesso!");
            CarregarDados();        //Carrega dados na tabela.
            NovoFuncTimer.Start(); //Para o Timer.
        }

        private void pbFechar_Click_1(object sender, EventArgs e)
        {
            NovoFuncTimer.Start();//Reincia o timer ja ligado.
        }

    }
    }


    




 