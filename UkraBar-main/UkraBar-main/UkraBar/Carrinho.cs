﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using Google.Protobuf.WellKnownTypes;

namespace UkraBar
{
    public partial class Carrinho : Form
    {
        public MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
        public string connectionString = "SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;";
        public MySqlCommand comando;
        public MySqlDataReader reader6;
        public DataTable table;

        public Carrinho()
        {
            InitializeComponent();
            CarregarDados();
            CarregarValores();
        }

        public void CarregarDados()
        {
            conn = new MySqlConnection("SERVER=localhost;DATABASE=ukrasystem;UID=root;PASSWORD=;");
            conn.Open();// Abre Conexão.

            string query = "SELECT nome_produto, quantidade, valor_produto FROM pedido_cliente WHERE id_cliente = '" + VariaveisGlobais.ultimoIdClienteInserido + "'";
            comando = new MySqlCommand(query, conn); //Declara comandos que serão usados.
            MySqlDataReader reader6 = comando.ExecuteReader(); //Lê os comandos.
            table = new DataTable(); //Abre a Table.
            table.Load(reader6); //Table lê os comandos.
            DTgridCarrinho2.DataSource = table; //Renomeia Table para DTgridFunc.
            DTgridCarrinho2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Comando para alinhar as tabelas no DataGriedView.
            conn.Close(); //Fecha Conexão 

        }
        public void CarregarValores()
        {
            VariaveisGlobais.valorFinal = VariaveisGlobais.valorItaliano + VariaveisGlobais.valorJapones + VariaveisGlobais.valorPolones + VariaveisGlobais.valorIberico + VariaveisGlobais.valorAlemao + VariaveisGlobais.valorVegetariano;


            VariaveisGlobais.valorFinalP = VariaveisGlobais.valorBatata + VariaveisGlobais.valorHulubsti + VariaveisGlobais.valorFrango + VariaveisGlobais.valorPerohe + VariaveisGlobais.valorBorscht + VariaveisGlobais.valorBanosh;
            VariaveisGlobais.valorFinalB = VariaveisGlobais.valorPolaka + VariaveisGlobais.valorChamate + VariaveisGlobais.valorMaçaAmor + VariaveisGlobais.valorMoniche + VariaveisGlobais.valorSlava + VariaveisGlobais.valorCaipirinha;

            VariaveisGlobais.valorFinalTotal = VariaveisGlobais.valorFinal+ VariaveisGlobais.valorFinalB + VariaveisGlobais.valorFinalP;

            int rowIndex = DTgridValor.Rows.Add();
            DTgridValor.Rows[rowIndex].Cells[0].Value = VariaveisGlobais.valorFinalTotal.ToString();

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

        private void BtnVoltar_Click(object sender, EventArgs e)
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

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            Sobre Sobrenos = new Sobre();
            Sobrenos.ShowDialog();
            this.Close();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (VariaveisGlobais.valorFinalTotal == 0)
            {
                MessageBox.Show("Você ainda não fez um Pedido!");
            }
            else
            {
                _NomeCliente MenuNome = new _NomeCliente();
                this.Hide();
                MenuNome.ShowDialog();
                this.Close();
            }
        }
    }
}
