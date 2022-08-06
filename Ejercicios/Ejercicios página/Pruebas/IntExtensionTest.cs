using Microsoft.VisualStudio.TestTools.UnitTesting;
using I02_Contador;

namespace Pruebas
{
    [TestClass]
    public class IntExtensionTest
    {
        [TestMethod]
        public void ContarCantidadDigitos_CuandoLePasamosUno_DeberiaRetornarUno()
        {
            //Arrange
            long numero = 1;
            int expected = 1;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCantidadDigitos_CuandoLePasamosCien_DeberiaRetornarTres()
        {
            //Arrange
            long numero = 100;
            int expected = 3;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCantidadDigitos_CuandoLePasamosDiezNegativo_DeberiaRetornarDos()
        {
            //Arrange
            long numero = -10;
            int expected = 2;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
