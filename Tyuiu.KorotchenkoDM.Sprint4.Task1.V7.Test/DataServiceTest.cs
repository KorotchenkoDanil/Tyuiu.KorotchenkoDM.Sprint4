using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint4.Task1.V7.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint4.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate() 
        {
            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            int res = ds.Calculate(array);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
