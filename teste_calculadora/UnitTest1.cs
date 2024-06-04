using System;
using Xunit;
using projeto_dio_csharp;

namespace teste_projeto_dio_csharp
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "04/06/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Fact]
        public void TesteSomar01()
        {
            //arrange
            Calculadora calc = construirClasse();

            //act
            int resultado = calc.Somar(1, 2);

            //assert
            Assert.Equal(3, resultado);
        }
        [Theory]
        [InlineData(2, 4, 6)]
        [InlineData(5, 11, 16)]
        public void TesteSomar02(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Somar(n1, n2);

            Assert.Equal(resultado, resultadoCalc);
        }
        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(5, 11, 55)]
        public void TesteMultiplicar(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Multiplicar(n1, n2);

            Assert.Equal(resultado, resultadoCalc);
        }
        [Theory]
        [InlineData(6, 4, 2)]
        [InlineData(11, 7, 4)]
        public void TesteSubtrair(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Subtrair(n1, n2);

            Assert.Equal(resultado, resultadoCalc);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        public void TesteDividir(int n1, int n2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.Dividir(n1, n2);

            Assert.Equal(resultado, resultadoCalc);
        }
        [Fact]
        public void TesteDividirPor0()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }
        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(5, 5);
            calc.Somar(10,4);
            calc.Somar(3,8);

            var fila = calc.Historico();

            Assert.NotEmpty(fila);
            Assert.Equal(3, fila.Count);
        }
    }
}
