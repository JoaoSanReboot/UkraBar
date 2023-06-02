using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkraBar
{
    internal class VariaveisGlobais
    {
        public static int quantidadeItaliano = 1;
        public static int quantidadeIberico = 1;
        public static int quantidadePolones= 1;
        public static int quantidadeJapones = 1;
        public static int quantidadeVegetariano = 1;
        public static int quantidadeAlemao = 1;


        public static double valorAlemao = 25.00;
        public static double valorVegetariano = 22.00;
        public static double valorPolones = 24.00;
        public static double valorJapones = 24.00;
        public static double valorIberico = 27.00 ;          
        public static double valorItaliano = 24.00;

        public static double valorItalianoMenos = 24.00;
        public static double valorIbericoMenos = 27.00;
        public static double valorPolonesMenos = 24.00;
        public static double valorJaponesMenos = 24.00;
        public static double valorVegetarianoMenos = 22.00;
        public static double valorAlemaoMenos = 25.00;

        //Bebidas

        public static int quantidadeChamate = 1;
        public static int quantidadeMaçaAmor = 1;
        public static int quantidadeMoniche = 1;
        public static int quantidadeSlava = 1;
        public static int quantidadeCaipirinha = 1;
        public static int quantidadePolaka = 1;

        public static double valorChamate = 8.00;
        public static double valorMaçaAmor = 18.00;
        public static double valorMoniche = 23.00;
        public static double valorSlava = 18.00;
        public static double valorCaipirinha = 16.00;
        public static double valorPolaka = 26.00;

        public static double valorChamateMenos = 8.00;
        public static double valorMaçaAmorMenos = 18.00;
        public static double valorMonicheMenos = 23.00;
        public static double valorSlavaMenos = 18.00;
        public static double valorCaipirinhaMenos = 16.00;
        public static double valorPolakaMenos = 26.00;

        //Pratos

        public static int quantidadeBatata = 1;
        public static int quantidadeFrango = 1;
        public static int quantidadePerohe = 1;
        public static int quantidadeHulubsti = 1;
        public static int quantidadeBorscht = 1;
        public static int quantidadeBanosh = 1;

        public static double valorBatata = 23.00;
        public static double valorFrango = 45.00;
        public static double valorPerohe = 32.00;
        public static double valorHulubsti = 20.00;
        public static double valorBorscht = 28.00;
        public static double valorBanosh = 25.00;

        public static double valorBatataMenos = 23.00;
        public static double valorFrangoMenos = 45.00;
        public static double valorPeroheMenos = 32.00;
        public static double valorHulubstiMenos = 20.00;
        public static double valorBorschtMenos = 28.00;
        public static double valorBanoshMenos = 25.00;


        public static double valorFinal = 0;
        public static double valorFinalB = 0;
        public static double valorFinalP = 0;
        public static double valorFinalTotal = 0;

        public static string Cpf;

        public static int ultimoIdClienteInserido;
        public static int ultimoIdPedidoInserido;

        public static bool CompraItaliano = true;
        public static bool CompraJapones = true;
        public static bool CompraIberico = true;
        public static bool CompraVegetariano = true;
        public static bool CompraAlemao = true;
        public static bool CompraPolones = true;

        public static bool CompraChamate = true;
        public static bool CompraMaça = true;
        public static bool CompraCaipirinha = true;
        public static bool CompraMoniche = true;
        public static bool CompraSlava = true;
        public static bool CompraPolaka = true;

        public static bool CompraFrango = true;
        public static bool CompraBanosh = true;
        public static bool CompraBatata = true;
        public static bool CompraHusbulist= true;
        public static bool CompraBorscht = true;
        public static bool CompraPerohe = true;
    }
}
