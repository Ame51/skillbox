using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            //Console.WriteLine("Введите количество строк матрицы: ");
            //int line = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите количество столбцов матрицы: ");
            //int column = Int32.Parse(Console.ReadLine());

            //int[,] matrix = new int[line, column]; // Задание двумерного массива, в котором o строк и p столбцов

            //matrix[1, 2] = 3;

            //int sum = 0;
            //Random r = new Random();

            //for (int i = 0; i < line; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        matrix[i, j] = r.Next(10);
            //        Console.Write($"{matrix[i, j]} ");
            //        sum += matrix[i, j];
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(sum);
            //Console.ReadLine();
            #endregion
            #region Задание 2
            //Console.WriteLine("Наименьший элемент последовательности");
            //Console.WriteLine("Введите длину последовательности: ");

            //int n = int.Parse(Console.ReadLine());

            //int[] matrix = new int[n];
            //int min = int.MaxValue;

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    Console.Write($"Введите {i + 1}-й элемент последовательности: ");
            //    matrix[i] = int.Parse(Console.ReadLine());
            //}

            //for (int j=0; j<matrix.Length;j++)
            //{
            //    if (matrix[j]<min)
            //    {
            //        min = matrix[j];
            //    }
            //}

            //Console.WriteLine(min);
            //Console.ReadLine();
            #endregion
            #region Задание 3            

            int x = 0;
            Console.Write("Введите максимальное число диапазона: ");
            int y = int.Parse(Console.ReadLine());

            Random rand = new Random();

            int A = rand.Next(x, y);
            while (true)
            {
                Console.WriteLine("Введите число");

                string B = (Console.ReadLine());

                if (String.IsNullOrEmpty(B))
                {
                    Console.WriteLine($"Загаданное число {A}!\n Удачи в следующий раз.");

                    break;
                }

                else if (Convert.ToInt32(B) > A)
                {
                    Console.WriteLine("Загаданное число меньше, продолжайте");
                }

                else if (Convert.ToInt32(B) < A)
                {
                    Console.WriteLine("Загаданное число больше, продолжайте");
                }

                else if (Convert.ToInt32(B) == A)
                {
                    Console.WriteLine("Вы угадали!");

                    break;
                }
            }

            Console.ReadLine();
            #endregion
        }
    }
}
