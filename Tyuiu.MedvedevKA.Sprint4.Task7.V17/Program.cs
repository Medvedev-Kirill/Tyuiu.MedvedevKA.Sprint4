using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint4.Task7.V17.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string str = "753159864";

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                       *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                         *");
            Console.WriteLine("* Задание #7                                                                                                      *");
            Console.WriteLine("* Вариант #17                                                                                                     *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                             *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                        *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 753159864.                                                                    *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел.                                         *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Количество четных чисел = " + res);
            Console.ReadKey();
        }
    }
}
