using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint4.Task6.V29.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task6.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                       *");
            Console.WriteLine("* Тема: Класс Array                                                                                               *");
            Console.WriteLine("* Задание #6                                                                                                      *");
            Console.WriteLine("* Вариант #29                                                                                                     *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                             *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                        *");
            Console.WriteLine("* Дан строковый массив данных [Весна, Лето, Осень, Зима]                                                          *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых больше 4.                                 *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");

            var season = new string[] { "Весна", "Лето", "Осень", "Зима" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= season.Length - 1; i++)
            {
                Console.WriteLine(season[i]);
            }

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Количество элементов длина которых больше 4:");

            int nums = ds.Calculate(season);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
