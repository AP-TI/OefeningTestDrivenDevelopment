using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;

namespace RomanNumerals1
{
    [TestClass]
    public class UnitTest1
    {
        RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("I", romanNumeralConverter.Convert(1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("II", romanNumeralConverter.Convert(2));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("IV", romanNumeralConverter.Convert(4));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("V", romanNumeralConverter.Convert(5));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("VI", romanNumeralConverter.Convert(6));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("VII", romanNumeralConverter.Convert(7));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual("VIII", romanNumeralConverter.Convert(8));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual("IX", romanNumeralConverter.Convert(9));
        }
        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual("X", romanNumeralConverter.Convert(10));
        }
        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual("XI", romanNumeralConverter.Convert(11));
        }
        [TestMethod]
        public void TestMethod20()
        {
            Assert.AreEqual("XX", romanNumeralConverter.Convert(20));
        }
        [TestMethod]
        public void TestMethod21()
        {
            Assert.AreEqual("XXI", romanNumeralConverter.Convert(21));
        }
        [TestMethod]
        public void TestMethod30()
        {
            Assert.AreEqual("XXX", romanNumeralConverter.Convert(30));
        }
        [TestMethod]
        public void TestMethod39()
        {
            Assert.AreEqual("XXXIX", romanNumeralConverter.Convert(39));
        }
        [TestMethod]
        public void TestMethod40()
        {
            Assert.AreEqual("XL", romanNumeralConverter.Convert(40));
        }
        [TestMethod]
        public void TestMethod41()
        {
            Assert.AreEqual("XLI", romanNumeralConverter.Convert(41));
        }
        [TestMethod]
        public void TestMethod42()
        {
            Assert.AreEqual("XLII", romanNumeralConverter.Convert(42));
        }
        [TestMethod]
        public void TestMethod49()
        {
            Assert.AreEqual("XLIX", romanNumeralConverter.Convert(49));
        }
        [TestMethod]
        public void TestMethod50()
        {
            Assert.AreEqual("L", romanNumeralConverter.Convert(50));
        }
        [TestMethod]
        public void TestMethod51()
        {
            Assert.AreEqual("LI", romanNumeralConverter.Convert(51));
        }
        [TestMethod]
        public void TestMethod60()
        {
            Assert.AreEqual("LX", romanNumeralConverter.Convert(60));
        }
        [TestMethod]
        public void TestMethod64()
        {
            Assert.AreEqual("LXIV", romanNumeralConverter.Convert(64));
        }
        [TestMethod]
        public void TestMethod69()
        {
            Assert.AreEqual("LXIX", romanNumeralConverter.Convert(69));
        }
        [TestMethod]
        public void TestMethod90()
        {
            Assert.AreEqual("XC", romanNumeralConverter.Convert(90));
        }
        [TestMethod]
        public void TestMethod91()
        {
            Assert.AreEqual("XCI", romanNumeralConverter.Convert(91));
        }
        [TestMethod]
        public void TestMethod95()
        {
            Assert.AreEqual("XCV", romanNumeralConverter.Convert(95));
        }
        [TestMethod]
        public void TestMethod96()
        {
            Assert.AreEqual("XCVI", romanNumeralConverter.Convert(96));
        }
        [TestMethod]
        public void TestMethod99()
        {
            Assert.AreEqual("XCIX", romanNumeralConverter.Convert(99));
        }
        [TestMethod]
        public void TestMethod100()
        {
            Assert.AreEqual("C", romanNumeralConverter.Convert(100));
        }
        [TestMethod]
        public void TestMethod150()
        {
            Assert.AreEqual("CL", romanNumeralConverter.Convert(150));
        }
        [TestMethod]
        public void TestMethod200()
        {
            Assert.AreEqual("CC", romanNumeralConverter.Convert(200));
        }
        [TestMethod]
        public void TestMethod400()
        {
            Assert.AreEqual("CD", romanNumeralConverter.Convert(400));
        }
        [TestMethod]
        public void TestMethod270()
        {
            Assert.AreEqual("CCLXX", romanNumeralConverter.Convert(270));
        }

        private class RomanNumeralConverter
        {
            public string Convert(int input)
            {
                return input > 399 ?  "CD" + Convert(input - 400) : input > 99 ? "C" + Convert(input - 100) : input > 89 ? "XC" + Convert(input - 90) : input > 49 ? "L" + Convert(input - 50) : input > 39 ? "XL" + Convert(input - 40) : input > 10 ? "X" + Convert(input - 10) : input > 8 ? Convert(10 - input) + "X" : input > 4 ? "V" + Convert(input - 5) : input > 3 ? Convert(5 - input) + "V" : input > 0 ? "I" + Convert(input - 1) : "";
            }
        }

    }
}
