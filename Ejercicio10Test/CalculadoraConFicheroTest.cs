using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio07;

namespace Ejercicio10Test
{
    [TestClass]
    public class CalculadoraConFicheroTest
    {
        [TestMethod]
        public void TestSumarGuardando()
        {
            CalculadoraConFichero sut = new CalculadoraConFichero();

            sut.SumarGuardando(4, 5);
        }

    }
}
