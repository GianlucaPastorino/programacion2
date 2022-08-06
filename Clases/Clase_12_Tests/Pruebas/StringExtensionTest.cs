using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ContarVolcales_CuandoNoTieneVocales_DeberiaReronarCero()
        {
            //Arrange
            int expected = 0;
            string text = "trypsnv jklmnq";

            // Act
            int actual = StringExtension.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVolcales_CuandoTieneDosVocales_DeberiaReronarDos()
        {
            //Arrange
            int expected = 2;
            string text = "trypsnav jklemnq";

            // Act
            int actual = StringExtension.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVolcales_CuandoTieneTresVocalesEnMayuscula_DeberiaReronarTres()
        {
            //Arrange
            int expected = 3;
            string text = "LA COSA";

            // Act
            int actual = text.ContarVocales(); // Metodo de extension

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))] // Assert
        public void ContarVolcales_CuandoElTextoEsNulo_DeberiaReronarCero()
        {
            //Arrange
            string text = null;

            // Act
            int actual = StringExtension.ContarVocales(text);
        }

        [TestMethod]
        public void ContarVocales_CuandoElTextoEsVacio_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = string.Empty;

            // Act
            int actual = text.ContarVocales();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCaracteres_CuandoTieneElCaracterDosVeces_DeberiaReronarDos()
        {
            //Arrange
            int expected = 2;
            string text = "s.uuu.";
            char caracter = '.';

            // Act
            int actual = text.ContarCaracteres(caracter); // Método de extensión con parámetro 

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ContarCaracteres_CuandoElTextoEsNulo_DeberiaLanzarBusinessException()
        {
            // Arrange
            string text = null;
            char caracter = '.';

            // Act
            text.ContarCaracteres(caracter); 
        }

        [TestMethod]
        public void ContarCaracteres_CuandoElTextoEsVacio_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = string.Empty;
            char caracter = '.';

            // Act
            int actual = text.ContarCaracteres(caracter);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
