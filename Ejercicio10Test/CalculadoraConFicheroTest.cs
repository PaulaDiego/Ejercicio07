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
            sut.Calculadora = new CalculadoraDel9();
            sut.SumarGuardando(4, 5);
        }

    }

    public class CalculadoraDel9 : ICalculadora
    {
        public int Sumar(int a, int b)
        {
            return 9;
        }
    }

    public class FicheroServiceDeMentira : IFicheroService
    {
        public void GuardaNumero(int c)
        {
            throw new NotImplementedException();
        }
    }

}
