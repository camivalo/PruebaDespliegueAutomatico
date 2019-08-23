using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaDespliegueAutomatico;


namespace DespliegueAutomaticoTest
{
    [TestClass]
    public class ClaseParaPruebasTest 
    {
        [TestMethod]
        public void TestSuma()
        {
            //Arrange
            var a = 2;
            var b = 3;
            int resultadoEsperado = 7;

            ClaseParaPruebas calculator = new ClaseParaPruebas();

            //Act
            var result = calculator.suma(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }

        [TestMethod]
        public void Testresta()
        {
            //Arrange
            var a = 17;
            var b = 5;
            int resultadoEsperado = 12;

            ClaseParaPruebas calculator = new ClaseParaPruebas();

            //Act
            var result = calculator.resta(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }

        [TestMethod]
        public void TestMultiplicar()
        {
            //Arrange
            var a = 4;
            var b = 5;
            int resultadoEsperado = 20;

            ClaseParaPruebas calculator = new ClaseParaPruebas();

            //Act
            var result = calculator.multiplicar(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
