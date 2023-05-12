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
    public partial class CadastrarDesc : Form
    {
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader4;
        public DataTable table;

        public CadastrarDesc()
        {
            InitializeComponent();
            CarregarDados();
        }

        //Carregar Dados é um public para carregar informações no DataGridView.
        public void CarregarDados()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT * FROM desconto"; //Seleciona informações da tabela Desconto.
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            reader4 = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader4); //Table lê os comandos.
            DTgridDesc.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridDesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
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

        bool sideBarMenuExpandD; //Bool para Cronometro da Barra Lateral.
        bool PanelConfigD;   //Bool para o Panel de Configurações.
        bool NovoDescBarD;   //Bool para o Panel de Novo Funcionário.
        bool EditFundoD;     //Bool para o Panel de Editar Funcionário.

        //Timer Ticks para animações das Side Bars.

        //Side Bar Lateral.
        private void TimerSideBar_Tick_1(object sender, EventArgs e)
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
        private void NovoDescTimer_Tick(object sender, EventArgs e)
        {

            if (NovoDescBarD)
            {
                PanelCadastrarDesc.Width -= 30; //Declara o caso do Panel estiver com Determinado tamanho.
                if (PanelCadastrarDesc.Width == PanelCadastrarDesc.MinimumSize.Width)
                {



                    NovoDescBarD = false;//Deixa o Bool False.
                    NovoDescTimer.Stop();//Para o TimerTick.
                }//Se estiver executa o comando.
            }//Se o Bool Estiver Sim.
            else
            {
                PanelCadastrarDesc.Width += 10;  //Declara o caso do Panel estiver com Determinado tamanho.
                if (PanelCadastrarDesc.Width == PanelCadastrarDesc.MaximumSize.Width)
                {

                    NovoDescBarD = true;   //Deixa o Bool True.
                    NovoDescTimer.Stop();//Para o TimerTick.
                }
            }//Se o Bool Estiver Não.
        }

                                             //Funções dos Botões da Side Bar Lateral Direia.

        //Abre o Menu Lareral
        private void pbMenu_Click(object sender, EventArgs e)
        {
            TimerSideBar.Start();    //Começa o TimerTick.
            if (sideBarMenuExpandD == true)  //Se o Bool Estiver True.

                PanelCadastrarDesc.Visible = false; //Esconder Outro Bool.
                NovoDescTimer.Stop();        //Para outro Timer.
        }

        //Abre o Panel de Configurações.
        private void BtnConfigurações_Click(object sender, EventArgs e)
        {
            if (PanelConfigD)
            {

                panelShowConfig.Height -= 257;//Se o panel estiver Menor ou igual o Valor.
                PanelConfigD = false;
            }//Se o Panel estive True
            else
                panelShowConfig.Height += 257;//Se o panel estiver Maior ou igual o Valor.
            PanelConfigD = true;
            {       //Deixe o Bool True.
            }//Se o Panel estive False
        }

        //Volta um Formúlário.
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            PainelAdm adm = new PainelAdm(); //Declara nome do Formulário
            this.Hide();       //Esconde o Atual
            adm.ShowDialog(); //Mostra o Novo Formulário.
            this.Close();    //Fecha o Formulário antigo.
        }

        //Remove as Bordas do Form Original.
        private void CadastrarDesc_Load(object sender, EventArgs e)
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
            MinimizarJanela.Location = MinimizarJanela.Location;
        }

        //Abre Panel de Novo Desconto.
        private void BtnNovoDesc_Click(object sender, EventArgs e)
        {
            if (sideBarMenuExpandD == true)
            {
                PanelCadastrarDesc.Visible = true;
                NovoDescTimer.Start();
            }
        }

        //Btn Deleta as linhas no Grid e no MySql.
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            conn.Open();

            for (int i = 0; i < DTgridDesc.Rows.Count; i++)//Faz a contagem de linhas Selecionadas enquanto i for menor que a contagens de rows.
            {
                DataGridViewCheckBoxCell CheckBox = DTgridDesc.Rows[i].Cells[0] as DataGridViewCheckBoxCell; //Defini CheckBox como funcional.

                if (CheckBox.Value != null && (bool)CheckBox.Value == true)//Bool sim ou não.
                {
                    int id = Convert.ToInt32(DTgridDesc.Rows[i].Cells[1].Value);//Int para contagem de celulas marcadas.

                    MySqlCommand comando = new MySqlCommand("DELETE FROM desconto WHERE id_desconto = @id_desconto", conn);//Comandos MySql
                    comando.Parameters.AddWithValue("@id_desconto", id);
                    comando.ExecuteNonQuery();

                    DTgridDesc.Rows.RemoveAt(i);//Deleta as linhas.
                    i--;                       //Diminui as linhas.
                }
            }
            CarregarDados();//Carregas os dados no GridView
            conn.Close();//Fecha a Conexão
        }

        //Btn Salvar Informações no MySql.
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string inserirQuery = "INSERT INTO desconto (id_desconto, nome_desconto, descricao, porcentagem) VALUES" +
               "('" + BoxcId.Text + "','" + BoxcNome.Text + "', '" + BoxcDescricao.Text + "','" + BoxcPorcentagem.Text + "')";
            executarQuery(inserirQuery);//Executa a String
            CarregarDados();        //Carrega dados na tabela.
            NovoDescTimer.Stop(); //Para o Timer.
        }

        //Picture Box Fechar dentro do Panel de Cadastro de Produto.
        private void pbFechar_Click(object sender, EventArgs e)
        {
            NovoDescTimer.Start();//Reincia o timer ja ligado.
        }

        //Abre o Panel de Editar.
        private void BtnEditar_Click(object sender, EventArgs e)
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

        //Edita Informações na tabela Mysql e no Grid.
        private void BtnPincel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();//Abre Conexão.
                //Declara String.
                string Atualizar = "UPDATE desconto SET nome_desconto = @nome_desconto, descricao = @descricao, porcentagem = @porcentagem WHERE id_desconto = @id_desconto";
                using (MySqlCommand comando = new MySqlCommand(Atualizar, conn))//Usa strings.
                {
                    {
                        //Declara Box como informações dentro do mysql.
                        comando.Parameters.AddWithValue("@id_produto", BoxdIdP.Text);
                        comando.Parameters.AddWithValue("@nome_produto", BoxdNomeP.Text);
                        comando.Parameters.AddWithValue("@descricao", BoxdDescricaoP.Text);
                        comando.Parameters.AddWithValue("@valor_produto", BoxdPorcentagemD.Text);
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

        //Função Mouse Click na Row Selecionada.
        private void DTgridDesc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in DTgridDesc.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CheckBox"].Value))
                {
                    BoxdIdP.Text = DTgridDesc.CurrentRow.Cells[1].Value.ToString();
                    BoxdNomeP.Text = DTgridDesc.CurrentRow.Cells[2].Value.ToString();
                    BoxdDescricaoP.Text = DTgridDesc.CurrentRow.Cells[3].Value.ToString();
                    BoxdPorcentagemD.Text = DTgridDesc.CurrentRow.Cells[4].Value.ToString();
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
                    comando = new MySqlCommand("SELECT * FROM ukrasystem.desconto WHERE" +
                        " id_desconto LIKE" + b +
                        "OR nome_desconto LIKE" + b +
                        "OR descricao LIKE" + b +
                        "OR porcentagem LIKE" + b, conn); //Envia comando Select no MySql
                    DataTable ProcurarDataTable = new DataTable(); //Defini table nova
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))//Faz o filtro no DataGridView.
                    {
                        adapter.Fill(ProcurarDataTable);
                    }
                    DTgridDesc.DataSource = ProcurarDataTable; //Mostra nova table
                    DTgridDesc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Centraliza as Tabelas.
                    conn.Close();//Fecha Conexão.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algum erro Encontrado", ex.Message);
                }
            }
        }
    }
}
