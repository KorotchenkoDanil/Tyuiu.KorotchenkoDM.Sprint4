using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorotchenkoDM.Sprint4.Task6.V30.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint4.Task6.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Коротченко Д. М. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Коротченко Данил Михайлович | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [«Береза», «Дуб», «Клён», «Сосна», «Пихта», *");
            Console.WriteLine("* «Осина»], используя класс Array, выведите элементы массива, длина       *");
            Console.WriteLine("* которых больше 5 символов                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string[] array = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
                Console.WriteLine(array[i]);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Искомый массив: ");
            string[] res = ds.Calculate(array);
            for (int i = 0; i <= res.Length - 1; i++)
                Console.WriteLine(res[i]);

            Console.ReadKey();
        }
    }
}
