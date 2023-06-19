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
    public partial class PainelCliente : Form
    {

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader3;
        public DataTable table;

        public PainelCliente()
        {
            InitializeComponent();
            CarregarDados();
        }

        public void CarregarDados()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT * FROM cliente"; //Seleciona informações da tabela Cadastro Funcionário.
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            reader3 = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader3); //Table lê os comandos.
            DTgridClie.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridClie.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
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
        bool PanelConfigD;   //Bool para o Panel de Configurações.
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

                                                   //Funções dos Botões da Side Bar Lateral Direia.
        //Abre o Menu Lareral
        private void pbMenu_Click(object sender, EventArgs e)
        {
            TimerSideBar.Start();    //Começa o TimerTick.
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

        //Volta um Formúlário.
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if(VariaveisGlobais.idAdm == 1)
            {
                PainelAdm adm = new PainelAdm(); //Declara nome do Formulário
                this.Hide();       //Esconde o Atual
                adm.ShowDialog(); //Mostra o Novo Formulário.
                this.Close();    //Fecha o Formulário antigo.
            }
            if(VariaveisGlobais.idFunc == 1)
            {
                PainelFuncionario func = new PainelFuncionario(); //Declara nome do Formulário
                this.Hide();       //Esconde o Atual
                func.ShowDialog(); //Mostra o Novo Formulário.
                this.Close();    //Fecha o Formulário antigo.
            }
          
        }

        //Remove as Bordas do Form Original.
        private void PainelCliente_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
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

        //Fecha o Form Atual.
        private void FecharJanelaF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Btn Deleta as linhas no Grid e no MySql.
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string DeletarPK = "DELETE FROM clientes WHERE id_cliente = @id_cliente";
            string DeletarFKA = "DELETE FROM login_adm WHERE id_cliente = @id_cliente";
            string DeletarFKF = "DELETE FROM login_func WHERE id_cliente = @id_cliente";

            for (int i = 0; i < DTgridClie.Rows.Count; i++)//Faz a contagem de linhas Selecionadas enquanto i for menor que a contagens de rows.
            {
                DataGridViewCheckBoxCell CheckBox = DTgridClie.Rows[i].Cells[0] as DataGridViewCheckBoxCell; //Defini CheckBox como funcional.

                if (CheckBox.Value != null && (bool)CheckBox.Value == true)//Bool sim ou não.
                {
                    int id = Convert.ToInt32(DTgridClie.Rows[i].Cells[1].Value);//Int para contagem de celulas marcadas.

                    if (VariaveisGlobais.idAdm == 1)
                    {
                        using (MySqlCommand command = new MySqlCommand(DeletarFKA, conn))
                        {
                            command.Parameters.AddWithValue("@id_cliente", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    if (VariaveisGlobais.idFunc == 1)
                    {
                        using (MySqlCommand command = new MySqlCommand(DeletarFKF, conn))
                        {
                            command.Parameters.AddWithValue("@id_cliente", id);
                            command.ExecuteNonQuery();
                        }
                    }
                    using (MySqlCommand command = new MySqlCommand(DeletarPK, conn))
                    {
                        command.Parameters.AddWithValue("@id_cliente", id);
                        command.ExecuteNonQuery();
                    }

                    DTgridClie.Rows.RemoveAt(i);//Deleta as linhas.
                    i--;                       //Diminui as linhas.
                }
            }
            CarregarDados();//Carregas os dados no GridView
            conn.Close();//Fecha a Conexão
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
                string Atualizar = "UPDATE cliente SET cpf_cliente = @cpf_cliente, nome_cliente = @nome_cliente, carrinho = @carrinho WHERE id_cliente = @id_cliente";
                using (MySqlCommand comando = new MySqlCommand(Atualizar, conn))//Usa strings.
                {
                    {
                        //Declara Box como informações dentro do mysql.
                        comando.Parameters.AddWithValue("@id_cliente", BoxdIdC.Text);
                        comando.Parameters.AddWithValue("@cpf_cliente", BoxdCpfC.Text);
                        comando.Parameters.AddWithValue("@nome_cliente", BoxdNomeC.Text);
                        comando.Parameters.AddWithValue("@carrinho", BoxdCarrinhoC.Text);
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
        private void DTgridClie_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in DTgridClie.Rows)
            {
                if (Convert.ToBoolean(row.Cells["CheckBox"].Value))
                {
                    BoxdIdC.Text = DTgridClie.CurrentRow.Cells[1].Value.ToString();
                    BoxdCpfC.Text = DTgridClie.CurrentRow.Cells[2].Value.ToString();
                    BoxdNomeC.Text = DTgridClie.CurrentRow.Cells[3].Value.ToString();
                    BoxdCarrinhoC.Text = DTgridClie.CurrentRow.Cells[4].Value.ToString();
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
                    comando = new MySqlCommand("SELECT * FROM ukrasystem.cliente WHERE" +
                        " id_cliente LIKE" + b +
                        "OR cpf_cliente LIKE" + b +
                        "OR nome_cliente LIKE" + b +
                        "OR carrinho LIKE" + b, conn); //Envia comando Select no MySql
                    DataTable ProcurarDataTable = new DataTable(); //Defini table nova
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))//Faz o filtro no DataGridView.
                    {
                        adapter.Fill(ProcurarDataTable);
                    }
                    DTgridClie.DataSource = ProcurarDataTable; //Mostra nova table
                    DTgridClie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Centraliza as Tabelas.
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
        }
    }
}
