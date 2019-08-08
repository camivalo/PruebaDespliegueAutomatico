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
            int resultadoEsperado = 5;

            ClaseParaPruebas calculator = new ClaseParaPruebas();

            //Act
            var result = calculator.suma(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
