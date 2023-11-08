using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint4.Task5.V21.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 2, -1, 0 }, 
                                            { -2, -7, 1 }, 
                                            { -8, 2, -4 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 1, -1, 0 },
                            { -2, -7, 1 },
                            { -8, 1, -4 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
