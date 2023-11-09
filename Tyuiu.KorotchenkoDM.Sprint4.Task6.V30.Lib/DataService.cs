using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KorotchenkoDM.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length > 5);
            return mas;
        }
    }
}
