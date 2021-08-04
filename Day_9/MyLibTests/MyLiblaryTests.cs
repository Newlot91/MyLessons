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
            int actual = MyLiblary.GetNumberOfNumbersInString(s);
            //assert
            Assert.AreEqual(expected, actual);

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

        [TestMethod()]
        public void GetHostNameFromURITest()
        {
            string URI = "https://vc.ru/trade/157257-vnutrennyaya-kuhnya-marketpleysov-sklad-v-tveri-pergidrolnye-tetki-i-uzhasnaya-podderzhka";
            string expected = "vc.ru";
            string actual = MyLiblary.GetHostNameFromURI(URI);
            Assert.AreEqual(expected, actual);

            URI = "https://wbcon.ru/2021/02/15/ozon-urok-12-fbs-tarifs/";
            expected = "wbcon.ru";
            actual = MyLiblary.GetHostNameFromURI(URI);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetProtocolFromURITest()
        {
            string URI = "https://vc.ru/trade/157257-vnutrennyaya-kuhnya-marketpleysov-sklad-v-tveri-pergidrolnye-tetki-i-uzhasnaya-podderzhka";
            string expected = "https";
            string actual = MyLiblary.GetProtocolFromURI(URI);
            Assert.AreEqual(expected, actual);

            URI = "https://wbcon.ru/2021/02/15/ozon-urok-12-fbs-tarifs/";
            expected = "https";
            actual = MyLiblary.GetProtocolFromURI(URI);
            Assert.AreEqual(expected, actual);
        }
    }
}