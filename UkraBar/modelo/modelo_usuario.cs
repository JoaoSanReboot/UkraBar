using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    internal class modelo_usuario
    {
        //CRIO VARIAVEIS 
        private int CodigoCliente;
        private string NomeCliente;
        private int codigoperfil;
        private string cliente;
        private string senha;
        //defino construtor modelo cliente

        public modelo_usuario()
        {
            // declarando variaveis vazias
            CodigoCliente = 0;
            NomeCliente = "";
            codigoperfil = 0;
            cliente = "";
            senha = "";
        }
        public int codCliente
        {
            // INFORMAÇÕES CODIGO CLIENTE 
            get { return CodigoCliente; }
            // ALTERO VALORES DO CODIGO 
            set { CodigoCliente = value; }
        }
        public string NomeCli
        {
            get { return NomeCliente; }
            set { NomeCliente = value; }
        }
        public int perfil
        {
            get { return codigoperfil; }
            set { codigoperfil = value; }

        }
        public string usuariocliente
        {
            get { return cliente; }
            set { cliente = value; }

        }
        public string clientesenha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}



   