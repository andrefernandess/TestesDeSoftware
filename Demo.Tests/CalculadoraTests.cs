using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act

            var resultado = calculadora.Somar(2, 2);

            //Assert

            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 4, 5)]
        [InlineData(4, 2, 6)]
        public void Calculadora_Somar_RetornarValoresSomaCorertos(double x, double y, double total)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act

            var resultado = calculadora.Somar(x, y);

            //Assert

            Assert.Equal(total, resultado);
        }
    }
}
