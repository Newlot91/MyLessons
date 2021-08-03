using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Tests
{
    [TestClass()]
    public class MyLiblaryTests
    {
        [TestMethod()]
        public void GetNumberOfNumbersInStringTest()
        {
            //arrange
            string s = "da57zxv7v8";
            int expected = 4;
            //act
            int actual =MyLiblary.GetNumberOfNumbersInString(s);
            //assert
            Assert.AreEqual(expected,actual);

        }
        [TestMethod()]
        public void GetMaxWordTest()
        {
            //arrange
            string[] sArray = { "hi", "Albert", "Sam", "FiberGlass", "Leam" };
            string expected = "FiberGlass";
            //act
            string actual = MyLiblary.GetMaxWord(sArray);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}