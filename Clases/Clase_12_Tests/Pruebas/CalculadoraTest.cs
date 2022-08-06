using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Pruebas
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Dividir_CuandoElDivisorEsCero_DeberiaRetornarDoubleMinValue()
        {
            // Arrange - Preparar el caso de prueba
            double divisor = 0;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = double.MinValue;

            // Act - Invocar al m�todo a probar
            double resultado = calculadora.Dividir(2, divisor);

            // Assert - Verifico que el resutado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Dividir_CuandoElDivisorNoEsCero_DeberiaRetornarResultadoDivision()
        {
            // Arrange - Preparar el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1;

            // Act - Invocar al m�todo a probar
            double resultado = calculadora.Dividir(2, divisor);

            // Assert - Verifico que el resutado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Dividir_CuandoElDivisorEsIgualAlDividendo_DeberiaRetornarResultadoUno()
        {
            // Arrange - Preparar el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1;

            // Act - Invocar al m�todo a probar
            double resultado = calculadora.Dividir(2, divisor);

            // Assert - Verifico que el resutado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Dividir_CuandoElDivisorNoEsIgualAlDividendo_DeberiaRetornarResultadoDivision()
        {
            // Arrange - Preparar el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1.5;

            // Act - Invocar al m�todo a probar
            double resultado = calculadora.Dividir(3, divisor);

            // Assert - Verifico que el resutado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
