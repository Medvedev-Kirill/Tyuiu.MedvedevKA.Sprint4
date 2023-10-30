using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint4.Task1.V16.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                         *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                                                                     *");
            Console.WriteLine("* Задание #1                                                                                                        *");
            Console.WriteLine("* Вариант #16                                                                                                       *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                               *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                          *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный значениями с клавиатуры в диапазоне от 3 до 8     *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.  С клавиатуры: 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4         * ");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                  *");
            Console.WriteLine("*********************************************************************************************************************");

            int len;
            Console.WriteLine("Введите количесвто элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите занчение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
