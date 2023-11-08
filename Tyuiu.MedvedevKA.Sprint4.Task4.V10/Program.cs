using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint4.Task4.V10.Lib;

namespace Tyuiu.MedvedevKA.Sprint4.Task4.V10
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
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                                                                    *");
            Console.WriteLine("* Задание #4                                                                                                      *");
            Console.WriteLine("* Вариант #10                                                                                                     *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                             *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                        *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 1 до 7. *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                                                        *");
            Console.WriteLine("* 6, 6, 5, 3, 3,                                                                                                  *");
            Console.WriteLine("* 5, 7, 4, 6, 4,                                                                                                  *");
            Console.WriteLine("* 1, 2, 4, 1, 5,                                                                                                  *");
            Console.WriteLine("* 1, 7, 2, 5, 7,                                                                                                  *");
            Console.WriteLine("* 4, 2, 6, 5, 6,                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");

            Console.WriteLine("Введите количество строк массива");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("*******************************************************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t")
                        ;
                }
                Console.WriteLine();
            }
           
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Измененный массив:");
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
        
    
