using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint4.Task3.V8.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint4.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 4, 8, 3, 4, 8 }, 
                                          { 5, 3, 5, 7, 8 }, 
                                          { 3, 7, 2, 7, 7 }, 
                                          { 5, 2, 4, 6, 4 }, 
                                          { 4, 4, 6, 7, 2 } };


            int res = ds.Calculate(array);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
