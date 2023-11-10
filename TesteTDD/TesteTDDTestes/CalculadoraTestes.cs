using System;
using TesteTDD;
using Xunit;

namespace TesteTDDTestes
{
    public class CalculadoraTestes
    {   
        private Calculadora _calculadora;

        public CalculadoraTestes()
        {
            _calculadora = new Calculadora();
        }
        

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {

            int result = _calculadora.Somar(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            int result = _calculadora.Subtrair(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(5, 5, 25)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            int result = _calculadora.Multiplicar(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(20, 5, 4)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            int result = _calculadora.Dividir(val1, val2);

            Assert.Equal(resultado, result);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calculadora.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            _calculadora.Somar(1, 2);
            _calculadora.Somar(5, 2);
            _calculadora.Somar(8, 7);
            _calculadora.Somar(1, 4);

            var historico = _calculadora.Historico();

            Assert.NotEmpty(historico);
            Assert.Equal(3, historico.Count);

        }
    }
}
