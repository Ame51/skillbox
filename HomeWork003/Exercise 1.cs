using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Число чётное");
            else
                Console.WriteLine("Число нечётное");
            Console.ReadLine();
            #endregion
            #region Задание 2
            //Console.WriteLine("Здравствуйте. Введи количество карт на руке: ");
            //int handCards = int.Parse(Console.ReadLine());
            //int handValue = 0;

            //// Расчет суммы руки
            //for (int i = 1; i <= handCards; i++)
            //{
            //    Console.Write($"Введите номинал {i}-й карты: ");
            //    string cardValue = Console.ReadLine();
            //    int Value;
            //    switch (cardValue)
            //    {
            //        case "2":
            //            Value = 2;
            //            handValue += Value;
            //            break;

            //        case "3":
            //            Value = 3;
            //            handValue += Value;
            //            break;

            //        case "4":
            //            Value = 4;
            //            handValue += Value;
            //            break;

            //        case "5":
            //            Value = 5;
            //            handValue += Value;
            //            break;

            //        case "6":
            //            Value = 6;
            //            handValue += Value;
            //            break;

            //        case "7":
            //            Value = 7;
            //            handValue += Value;
            //            break;

            //        case "8":
            //            Value = 8;
            //            handValue += Value;
            //            break;

            //        case "9":
            //            Value = 9;
            //            handValue += Value;
            //            break;

            //        case "10":
            //            Value = 10;
            //            handValue += Value;
            //            break;

            //        case "J":
            //            Value = 10;
            //            handValue += Value;
            //            break;

            //        case "Q":
            //            Value = 10;
            //            handValue += Value;
            //            break;

            //        case "K":
            //            Value = 10;
            //            handValue += Value;
            //            break;

            //        case "T":
            //            Value = 10;
            //            handValue += Value;
            //            break;
            //    }
            //}
            //Console.WriteLine($"Сумма карту руки: {handValue}");
            //Console.ReadLine();

            #endregion
            #region Задание 3
            //bool simple = true;
            //Console.WriteLine("Введите число\n");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n / 2; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        simple = false;
            //        break;
            //    }
            //}
            //if (simple)
            //{
            //    Console.WriteLine("Число простое");
            //}
            //else
            //{
            //    Console.WriteLine("Число не простое");
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}


