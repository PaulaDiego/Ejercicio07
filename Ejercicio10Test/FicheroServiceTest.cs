using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio07;

namespace Ejercicio10Test
{
    [TestClass]
    public class FicheroServiceTest
    {
        [TestMethod]
        public void TestGuardaNumero()
        {
            FicheroService.GuardaNumero(5);
            Assert.IsTrue(FicheroUtil.IsLlamado());
        }
    }
}
