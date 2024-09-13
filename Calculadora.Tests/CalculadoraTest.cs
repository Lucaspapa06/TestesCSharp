using TesteSoftware;

namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, TesteSoftware.Calculadora.Somar(2, 2));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(4, TesteSoftware.Calculadora.Subtrair(6, 2));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(4, TesteSoftware.Calculadora.Dividir(8, 2));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(4, TesteSoftware.Calculadora.Multiplicar(2, 2));
        }

        [Fact]
        public void Bhaskara_DuasRaizes()
        {
            var resultado = TesteSoftware.Calculadora.Bhaskara(1, -5, 6);

            Assert.Equal(3, resultado.raiz1);
            Assert.Equal(2, resultado.raiz2);
        }
        
        [Fact]
        public void Bhaskara_UmaRaiz()
        {
            var resultado = TesteSoftware.Calculadora.Bhaskara(1, -4, 4);

            Assert.Equal(2, resultado.raiz1);
            Assert.Equal(2, resultado.raiz2);
        }
        
        [Fact]
        public void Bhaskara_NenhumaRaiz()
        {
            var resultado = TesteSoftware.Calculadora.Bhaskara(1, 1, 1);

            Assert.Null(resultado.raiz1);
            Assert.Null(resultado.raiz2);
        }
    }

    public class VotoTest
    {
        [Fact]
        public void testPodeVotar_16()
        {
            Voto voto = new Voto();
            Assert.Equal("Não pode votar.", voto.PodeVotar(15));
        }

        [Fact]
        public void testPodeVotar_16_17()
        {
            Voto voto = new Voto();
            Assert.Equal("Voto facultativo.", voto.PodeVotar(16));
            Assert.Equal("Voto facultativo.", voto.PodeVotar(17));
        }

        [Fact]
        public void testPodeVotar_18_70()
        {
            Voto voto = new Voto();
            Assert.Equal("Voto obrigatório.", voto.PodeVotar(18));
            Assert.Equal("Voto obrigatório.", voto.PodeVotar(70));
        }

        [Fact]
        public void testPodeVotar_71()
        {
            Voto voto = new Voto();
            Assert.Equal("Voto facultativo.", voto.PodeVotar(71));
        }
    }
}