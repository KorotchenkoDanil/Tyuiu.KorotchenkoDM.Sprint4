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
            int[,] mas2 = new int[5, 5] { { 4, 8, 3, 4, 8 }, 
                                          { 5, 3, 5, 7, 8 }, 
                                          { 3, 7, 2, 7, 7 }, 
                                          { 5, 2, 4, 6, 4 }, 
                                          { 4, 4, 6, 7, 2 } };
            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;
            int[] array = new int[columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 3)
                        array[i] = mas2[i, j];
                }
            }
            string res = ds.Calculate(array);
            string wait = "4";
            Assert.AreEqual(wait, res);
        }
    }
}
