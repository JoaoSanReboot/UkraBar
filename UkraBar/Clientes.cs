﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnSim_Click(object sender, EventArgs e)
        {

         PanelCpfNota.Visible = false;
      
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            MenuEscolha Escolha = new MenuEscolha();
            this.Hide();
            Escolha.ShowDialog();
            this.Close();
        }

        private void BtnCpfCad_Click(object sender, EventArgs e)
        {
            string ArmazenarCpf = BoxCpf.Text;

            if (string.IsNullOrEmpty(ArmazenarCpf))
            {
                MessageBox.Show("Você não digitou corretamente");
            }
            else
            {
                MenuEscolha Escolha = new MenuEscolha();
                this.Hide();
                Escolha.ShowDialog();
                this.Close();
            }
        }
    }
}
