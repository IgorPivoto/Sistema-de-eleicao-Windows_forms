using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleicaoforms
{
    public static class VarGlobal
    {
        public static string nomeCandidato;
        public static List<string> Candidatos = new List<string>();
        public static int[] votos = new int[100];
        public static int menuPesquisa;
        public static int quantidadeEleitor = 1;
        public static bool trancaCandidato = false;
        public static bool trancaEleitor = false;
    }
}
