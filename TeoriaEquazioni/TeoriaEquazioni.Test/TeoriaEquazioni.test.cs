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

        [TestMethod]
        public void TestIsNotDetermined1()
        {
            double a = 4;
            double b = 5;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsnotDetermined(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsNotDetermined2()
        {
            double a = 0;
            double b = 5;
            bool response_attesa = true;
            bool response = TeoriaEquazioni.IsnotDetermined(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsNotDetermined3()
        {
            double a = 4;
            double b = 0;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsnotDetermined(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsNotDetermined4()
        {
            double a = 0;
            double b = 0;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsnotDetermined(a, b);
            Assert.AreEqual(response_attesa, response);
        }
        [TestMethod]
        public void IsImpossible1()
        {
            double a = 0;
            double b = 0;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void IsImpossible2()
        {
            double a = 5;
            double b = 5;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void IsImpossible3()
        {
            double a = 0;
            double b = 5;
            bool response_attesa = true;
            bool response = TeoriaEquazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void IsImpossible4()
        {
            double a = 5;
            double b = 0;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsImpossible(a, b);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDegree2_1()
        {
            double a = 3;
            bool response_attesa = true;
            bool response = TeoriaEquazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDegree2_2()
        {
            double a = -3;
            bool response_attesa = true;
            bool response = TeoriaEquazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestIsDegree2_3()
        {
            double a = 0;
            bool response_attesa = false;
            bool response = TeoriaEquazioni.IsDetermined(a);
            Assert.AreEqual(response_attesa, response);
        }

        [TestMethod]
        public void TestDelta1()
        {
            double a = 0;
            double b = 7;
            double c = 5;
            double expected = 49;
            double obtained = TeoriaEquazioni.Delta(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDelta2()
        {
            double a = 4;
            double b = 4;
            double c = 1;
            double expected = 0;
            double obtained = TeoriaEquazioni.Delta(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

        [TestMethod]
        public void TestDelta3()
        {
            double a = 3;
            double b = 6;
            double c = 2;
            double expected = 12;
            double obtained = TeoriaEquazioni.Delta(a, b, c);

            Assert.AreEqual(expected, obtained);
        }

    }
}
