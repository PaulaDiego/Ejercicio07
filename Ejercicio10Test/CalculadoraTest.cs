using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio07;

namespace Ejercicio10Test
{
    [TestClass]
    public class CalculadoraTest
    {

        [TestMethod]
        public void TestSumar()
        {
            int resultado = Calculadora.Sumar(4,5);

            Assert.AreEqual(9, resultado);
        }
    }
}
