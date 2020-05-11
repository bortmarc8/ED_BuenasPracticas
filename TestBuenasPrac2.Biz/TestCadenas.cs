using BuenasPracticas2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BuenasPracticas2
{
    [TestClass]
    public class TestCadenas
    {
        [TestMethod]
        public void testCadenaPrimerCaracter()
        {
            Cadena obj = new Cadena("HelloWorld!");
            Assert.AreEqual(obj.extraerPrimerCaracter(), 'H');
        }

        [TestMethod]
        public void testCadenaCaracterPos()
        {
            Cadena obj = new Cadena("HelloWorld!");
            Assert.AreEqual(obj.extraerCaracterPos(5), 'o');
        }

        [TestMethod]
        public void testCadenaUltimoCaracter()
        {
            Cadena obj = new Cadena("HelloWorld!");
            Assert.AreEqual(obj.extraerUltimoCaracter(), '!');
        }
    }
}
