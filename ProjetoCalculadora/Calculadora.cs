using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;

        public Calculadora(string data)
        {
            ListaHistorico = [];
            this.data = data;
        }

        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;
            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + data);
            return res;
        }

        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + data);
            return res;
        }

        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + data);
            return res;
        }

        public int Dividir(int n1, int n2)
        {
            int res = n1 / n2;
            ListaHistorico.Insert(0, "Res: " + res + " - Data: " + data);
            return res;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}