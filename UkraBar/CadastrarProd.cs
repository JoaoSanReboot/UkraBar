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
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        private MySqlCommand comando;
        private MySqlDataReader reader;
        private DataTable table;

        public CadastrarProd()
        {
            InitializeComponent();
        }

        //Carregar Dados é um public para carregar informações no DataGridView.
        public void CarregarDados()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT * FROM cadastro_produto"; //Seleciona informações da tabela Cadastro Funcionário.
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            reader = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader); //Table lê os comandos.
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

        private void pbMenu_Click(object sender, EventArgs e)
        {
            TimerSideBar.Start();    //Começa o TimerTick.
            if (sideBarMenuExpandD == true)  //Se o Bool Estiver True.

            PanelCadastrarProd.Visible = false; //Esconder Outro Bool.
            NovoProdBar.Stop();        //Para outro Timer.
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
            {
                panelShowConfig.Height += 257;//Se o panel estiver Maior ou igual o Valor.
                PanelConfigD = true;          //Deixe o Bool True.
            }//Se o Panel estive False
        }

        private void BtnConfigurações_Click_1(object sender, EventArgs e)
        {
            if (PanelConfigD)
            {

                panelShowConfig.Height -= 257;//Se o panel estiver Menor ou igual o Valor.
                PanelConfigD = false;
            }//Se o Panel estive True
            else
            {
                panelShowConfig.Height += 257;//Se o panel estiver Maior ou igual o Valor.
                PanelConfigD = true;          //Deixe o Bool True.
            }//Se o Panel estive False
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            PainelAdm adm = new PainelAdm(); //Declara nome do Formulário
            this.Hide();       //Esconde o Atual
            adm.ShowDialog(); //Mostra o Novo Formulário.
            this.Close();    //Fecha o Formulário antigo.
        }

        private void CadastrarProd_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FecharJanelaF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizarJanela_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            MinimizarJanela.Location = MinimizarJanela.Location;
        }

        private void MinimizarJanela_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MaximizarJanela.Location = MaximizarJanela.Location;
        }

        private void BtnNovoProd_Click(object sender, EventArgs e)
        {
            if (sideBarMenuExpandD == true)
            {
                PanelCadastrarProd.Visible = true;
                NovoProdBar.Start();
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
