using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint4.Task6.V30.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] array = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Береза" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
