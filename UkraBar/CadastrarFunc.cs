using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace UkraBar
{

    public partial class CadastrarFunc : Form
    {
                                            //Setando comandos MySql para a contatenação.

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        private MySqlCommand comando;
        private MySqlDataReader reader;
        private DataTable table;


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
            DTgridFunc.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridFunc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
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
                if  (PanelCadastrarFunc.Width == PanelCadastrarFunc.MinimumSize.Width){
                    


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


        //Funções dos Botões da Side Bar Lateral Direia.


        //Executa o TimerTick SideBarLateral.
        private void pbMenu_Click_1(object sender, EventArgs e)
        {
            SideBarTime.Start();    //Começa o TimerTick.
            if (sideBarMenuExpand == true)  //Se o Bool Estiver True.

                PanelCadastrarFunc.Visible = false; //Esconder Outro Bool.
                NovoFuncTimer.Stop();        //Incia outro Timer.
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
            PainelAdm adm = new PainelAdm(); //Declara nome do Formulário
            this.Hide();       //Esconde o Atual
            adm.ShowDialog(); //Mostra o Novo Formulário.
            this.Close();    //Fecha o Formulário antigo.
        }

        private void BtnNovoFunc_Click(object sender, EventArgs e)
        {
            if (sideBarMenuExpand == true)
            {
                PanelCadastrarFunc.Visible = true;
                NovoFuncTimer.Start();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (EditFundo)
            {
                panelEditarFundo.Height -= 113;
                EditFundo = false;
            }
            else
            {
                panelEditarFundo.Height += 113;
                EditFundo = true;
            }
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            NovoFuncTimer.Start();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            byte[] imagem_byte = null;

            FileStream fStrem = new FileStream(this.BoxdFilesF.Text, FileMode.Open, FileAccess.Read);//Defini fStrem como Binário.

            BinaryReader br = new BinaryReader(fStrem);//Coloca o fStream Dentro de um Leitor Binário.

            imagem_byte = br.ReadBytes((int)fStrem.Length);//Defini que ele irá ler em Binário e salvará na array.

            string inserirQuery = "INSERT INTO cadastro_funcionário (id_cadastro, foto, nome_foto, nome_funcionario, senha_funcionario, email_funcionario) VALUES" +
                "('" + imagem_byte + "', '"+ BoxdFilesF.Text +"' '" + BoxcId.Text + "', '" + BoxcNome.Text + "', '" + BoxcSenha.Text + "','" + BoxcEmail.Text + "')";
                executarQuery(inserirQuery);
                CarregarDados();//Carrega dados na tabela.
                NovoFuncTimer.Stop();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            conn.Open();

            for (int i = 0; i < DTgridFunc.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell CheckBox = DTgridFunc.Rows[i].Cells[0] as DataGridViewCheckBoxCell;

                if (CheckBox.Value != null && (bool)CheckBox.Value == true)
                {
                    int id = Convert.ToInt32(DTgridFunc.Rows[i].Cells[1].Value);

                    MySqlCommand comando = new MySqlCommand("DELETE FROM cadastro_funcionario WHERE id_cadastro = @id_cadastro", conn);
                    comando.Parameters.AddWithValue("@id_cadastro", id);
                    comando.ExecuteNonQuery();

                    DTgridFunc.Rows.RemoveAt(i);
                    i--;
                }
            }
            CarregarDados();
            conn.Close();
        }

        private void CadastrarFunc_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MaximizarJanela.Location = MaximizarJanela.Location;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            MinimizarJanela.Location = MinimizarJanela.Location;
        }

        private void FecharJanelaF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); // Defini um dialog como o Novo
            //Um Filtro de imagens que aceita apenas Png e Jpg.
            dialog.Filter = "JPG Files(*.jpg)|*.jpg | PNG Files(*.png)|*png | AllFiles(*.*)|*.*";

            if(dialog.ShowDialog() == DialogResult.OK)//Se o usúario der Ok no Filles mostrar diretório.
            {
                string foto = dialog.FileName.ToString();
                BoxdFilesF.Text = foto;
                ImagenFunc.ImageLocation = foto; 

            }
        }
    }
}
    




 