using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KorotchenkoDM.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public string Calculate(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return Convert.ToString(min);
        }
    }
}
