
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovikovaVA.Sprint6.Task0.V16.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 3.111;
            Assert.AreEqual(res, wait);
        }
    }
}