using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BuenasPracticas2
{
    [TestClass]
    public class CommonTests
    {
        [TestMethod]
        public void TestDiaSemana()
        {
            DateTime fecha = Convert.ToDateTime(DateTime.Now);
            Assert.AreEqual(Fechas.diaSemana(fecha), "Tuesday");
        }

        [TestMethod]
        public void TestCuantoFalta()
        {
            Assert.AreEqual(Fechas.cuantoFalta(Convert.ToDateTime("11/06/2020")), 30);
        }
    }
}
