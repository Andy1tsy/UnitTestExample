using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace UnitTestingExample.Tests
{
    [TestClass()]
    public class StringMethodsTests
    {
        [TestMethod()]
        public void DoubleStringTest()
        {

            var testString = " ";
            var result = StringMethods.DoubleString(testString);
            Assert.AreEqual(result, testString + testString);
        }

        [TestMethod()]
        public void CutHeadStringTest()
        {
           
            var testString = "kuctykr";
            var result = StringMethods.CutHeadString(testString);
            Assert.AreEqual(result, testString.Remove(0, 2));
        }

        [TestMethod()]
        public void CutTailStringTest()
        {
           
            var testString = "lucuckg";
            var result = StringMethods.CutTailString(testString);
            Assert.AreEqual(result, testString.Remove(testString.Length - 2));
        }

        [TestMethod()]
        public void MixStringsTest()
        {
            var testString1 = "qwerty";
            var testString2 = "12345678";

            var result = StringMethods.MixStrings(testString1, testString2);
            Assert.AreEqual(result, "q1w2e3r4t5y678");
        }
    }
}