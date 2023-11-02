using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint4.Task2.V20.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                       *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                                                           *");
            Console.WriteLine("* Задание #2                                                                                                      *");
            Console.WriteLine("* Вариант #20                                                                                                     *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                             *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                        *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов                                                             *");
            Console.WriteLine("* заполненный случайными в диапазоне от 2 до 7 подсчитать сумму четных элементов массива.                         *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");

           
            Console.WriteLine("Введите количесвто элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2,7);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            

            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                      *");
            Console.WriteLine("*******************************************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
