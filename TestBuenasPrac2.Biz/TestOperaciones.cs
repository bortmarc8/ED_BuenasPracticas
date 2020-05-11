using BuenasPracticas2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BuenasPracticas2
{
    [TestClass]
    public class TestOperaciones
    {
        [TestMethod]
        public void testOperacionSuma()
        {
            Operacion obj = new Operacion(5,7);
            Assert.AreEqual(obj.sumar(), 12);
        }

        [TestMethod]
        public void testOperacionResta()
        {
            Operacion obj = new Operacion(5, 7);
            Assert.AreEqual(obj.restar(), 2);
        }

        [TestMethod]
        public void testOperacionMultiplicar()
        {
            Operacion obj = new Operacion(5, 7);
            Assert.AreEqual(obj.multiplicar(), 35);
        }

        [TestMethod]
        public void testOperacionMayor()
        {
            Operacion obj = new Operacion(5, 7);
            Assert.AreEqual(obj.cualEsMayor(), 7);
        }
    }
}
