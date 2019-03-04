using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeoriaEquazioni;

namespace TeoriaEquazioni.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = 3;
            bool response_attesa = true;
            bool response = TeoriaEquazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = -3;
            bool response_attesa = true;
            bool response = TeoriaEquazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDetermined3()
        {
            double a = 0;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

    }
}
