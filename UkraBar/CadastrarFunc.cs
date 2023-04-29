using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UkraBar
{

    public partial class CadastrarFunc : Form
    {
        //Setando comando MySql para facilitar a contatenação.

        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        private string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        private MySqlCommand comando;
        private MySqlDataReader reader;
        private DataTable table;


        // Estabelecendo conexão com o Banco de Dados

        public CadastrarFunc()
        {
            InitializeComponent();
            CarregarDados();
        }

        Panel c = new Panel();// Complementação do BtnMouseEnter e Leave.


        public void CarregarDados()
        {

            MySqlConnection conn = new MySqlConnection(connectionString);//Definindo Conexão
            conn.Open();// Abre Conexão

            string query = "SELECT * FROM cadastro_funcionario";//Carrega dados no DataGriedView
            comando = new MySqlCommand(query, conn); //Declara comandos para o MySql
            reader = comando.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            DTgridFunc.DataSource = table;
            DTgridFunc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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


        private void btnBuscar_Click(object sender, EventArgs e)//Botão de fazer Busca na tabela.
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))//Executa a conn quando apertado.
            {
                string b = "'%" + BoxBuscar.Text + "%'"; // Defini BoxBuscar como string

                try
                {
                    conn.Open();//Abre Conexão.
                    comando = new MySqlCommand("SELECT * FROM ukrasystem.cadastro_funcionario WHERE" +
                        " id_cadastro LIKE" + b +
                        "OR nome_funcionario LIKE" + b +
                        "OR senha_funcionario LIKE" + b +
                        "OR email_funcionario LIKE" + b, conn); //Envia comando Select no MySql
                    DataTable ProcurarDataTable = new DataTable(); //Defini table nova
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))//Faz o filtro no DataGridView.
                    {
                        adapter.Fill(ProcurarDataTable);
                    }
                    DTgridFunc.DataSource = ProcurarDataTable; //Mostra nova table
                    DTgridFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Centraliza as Tabelas.
                    conn.Close();//Fecha Conexão.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algum erro Encontrado", ex.Message);
                }
            }
        }

      

        private void DTgridFunc_MouseClick(object sender, MouseEventArgs e)//Função Click na tabela para Enviar nas Box
        {
            BoxdId.Text = DTgridFunc.CurrentRow.Cells[1].Value.ToString();
            BoxdNome.Text = DTgridFunc.CurrentRow.Cells[2].Value.ToString();
            BoxdSenha.Text = DTgridFunc.CurrentRow.Cells[3].Value.ToString();
            BoxdEmail.Text = DTgridFunc.CurrentRow.Cells[4].Value.ToString();
        }

        bool sideBarMenuExpand;

        private void SideBarTime_Tick(object sender, EventArgs e)
        {
            if (sideBarMenuExpand)
            {
                sideBarMenu.Width -= 30;
                if (sideBarMenu.Width == sideBarMenu.MinimumSize.Width)
                {
                    sideBarMenuExpand = false;
                    SideBarTime.Stop();
                }
            }
            else
            {
                sideBarMenu.Width += 10;
                if (sideBarMenu.Width == sideBarMenu.MaximumSize.Width)
                {
                    sideBarMenuExpand = true;
                    SideBarTime.Stop();
                }
            }
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            SideBarTime.Start();
            if (sideBarMenuExpand == true)
            {
                panelNovoFunc.Visible = false;
                NovoFuncTimer.Start();
            }
      
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            PainelAdm adm = new PainelAdm();
            this.Hide();
            adm.ShowDialog();
            this.Close();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void BoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarFunc_Load(object sender, EventArgs e)
        {

        }

        private void DTgridFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void DTgridFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool PanelConfig;
        private void BtnConfigurações_Click(object sender, EventArgs e)
        {
            if(PanelConfig)
            {
                panelShowConfig.Height -= 257;
                PanelConfig = false;
            }
            else
            {
               panelShowConfig.Height += 257;
                PanelConfig = true;
            }
        }

        private void BtnLuzConf_Click(object sender, EventArgs e)
        {
            BtnClaro.BringToFront();
        }

        private void BtnClaro_Click(object sender, EventArgs e)
        {
            BtnEscuro.BringToFront();
        }

        bool NovoFuncBar;
        private void NovoFuncTimer_Tick(object sender, EventArgs e)
        {
         
                if (NovoFuncBar)
                {
                    panelNovoFunc.Width -= 30;
                    if (panelNovoFunc.Width == panelNovoFunc.MinimumSize.Width)
                    {
                        NovoFuncBar = false;
                        NovoFuncTimer.Stop();
                    }
                }
                else
                {
                    panelNovoFunc.Width += 10;
                    if (panelNovoFunc.Width == panelNovoFunc.MaximumSize.Width)
                    {
                        NovoFuncBar = true;
                        NovoFuncTimer.Stop();
                    }
                }
            }

        private void BtnNovoFunc_Click(object sender, EventArgs e)
        {
           
            if(sideBarMenuExpand == true) 
            {
                panelNovoFunc.Visible = true;
                NovoFuncTimer.Start();
            }

        }

        bool EditFundo;
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

        private void sideBarMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            NovoFuncTimer.Start();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string inserirQuery = "INSERT INTO cadastro_funcionario (id_cadastro, nome_funcionario, senha_funcionario, email_funcionario) VALUES" +
                "('" + BoxcId.Text + "', '" + BoxcNome.Text + "', '" + BoxcSenha.Text + "','" + BoxcEmail.Text + "')";
            executarQuery(inserirQuery);//Executa o comando InserirQuery string
            CarregarDados();//Carrega dados na tabela.
            NovoFuncTimer.Start();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailD_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
    




