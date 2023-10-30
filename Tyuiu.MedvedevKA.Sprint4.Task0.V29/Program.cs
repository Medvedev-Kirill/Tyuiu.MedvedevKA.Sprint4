using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint4.Task0.V29.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task0.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                          *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                                                        *");
            Console.WriteLine("* Задание #0                                                                                                         *");
            Console.WriteLine("* Вариант #29                                                                                                        *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9      *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива.  {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}                                      * ");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            Console.WriteLine("Исходный массив:" );
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("Сумма нечетных элементов массива: " + ds.GetSumOddArrEl(numsArray));

            Console.ReadKey();
        }
    }
}
