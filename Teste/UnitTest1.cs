using ProjetoTDD;
using System;
using Xunit;

namespace Teste
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
           return new Calculadora(DateTime.Now);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1,int val2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Somar(val1, val2);

            Assert.Equal(resultadoEsperado,resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Multiplicar(val1, val2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Dividir(val1, val2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Subtrair(val1, val2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = ConstruirClasse();   

            calc.Somar(1, 2);
            calc.Subtrair(3, 4);
            calc.Multiplicar(5, 8);
            calc.Dividir(10, 78);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }


    }
}
