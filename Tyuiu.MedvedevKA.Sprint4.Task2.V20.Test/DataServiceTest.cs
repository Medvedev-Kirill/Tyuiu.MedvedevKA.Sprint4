using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint4.Task2.V20.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7, 2, 3, 4, 5 };

            int res = ds.Calculate(numsArray);
            int wait = 30;

            Assert.AreEqual(wait, res);
        }
    }
}
