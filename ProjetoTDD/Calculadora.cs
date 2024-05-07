using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTDD
{
    public class Calculadora
    {
        private List<string> _historico;
        private DateTime _data;

        public Calculadora(DateTime data)
        {
            _historico = new List<string>();
            _data = data;
        }

        public int Somar(int x, int y)
        {
            int res = x + y;

            _historico.Insert(0,$"{x} + {y} = {res}");

            return res;
        }

        public int Subtrair(int x, int y)
        {
            int res = x - y;

            _historico.Insert(0, $"{x} - {y} = {res}");

            return res;
        }

        public int Multiplicar(int x, int y)
        {
            int res = x * y;

            _historico.Insert(0, $"{x} X {y} = {res}");
            return res;
        }

        public int Dividir(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            int res = x / y;

            _historico.Insert(0, $"{x} / {y} = {res}");

            return res;
        }

        public List<string> Historico()
        {
           _historico.RemoveRange(3, _historico.Count -3);

            return _historico;
        }
    }
}
