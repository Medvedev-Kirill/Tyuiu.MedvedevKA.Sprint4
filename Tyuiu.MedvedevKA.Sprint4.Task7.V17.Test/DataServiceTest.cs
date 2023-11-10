using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint4.Task7.V17.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "753159864";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
