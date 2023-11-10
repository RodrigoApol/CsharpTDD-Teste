using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTDD
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }

        public int Somar(int x, int y)
        {
            var result = x + y;
            historico.Insert(0, $"resultado: {result}");

            return result;
        }
        public int Subtrair(int x, int y)
        {
            var result = x - y;
            historico.Insert(0, $"resultado: {result}");

            return result;
        }
        public int Multiplicar(int x, int y)
        {
            var result = x * y;
            historico.Insert(0, $"resultado: {result}");

            return result;
        }
        public int Dividir(int x, int y)
        {
            var result = x / y;
            historico.Insert(0, $"resultado: {result}");

            return result;
        }
            public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }

    }
}
