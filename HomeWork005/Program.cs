using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork005
{
    internal class Program
    {
        #region Задание 1
        static void InputText(out string text)
        {
            text = Console.ReadLine();
        }

        static void TextSplitter()
        {
            string textS;
            InputText(out textS);

            string[] words = textS.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void Print()
        {
            TextSplitter();
        }

        static void Main(string[] args)
        {
            Print();
        }
        #endregion
        #region Задание 2
        //static string SplitWord2(string text)
        //{
        //    string[] wordsSplit2 = text.Split(' ');
        //    string newText = ReverseWord(wordsSplit2);
        //    return newText;
        //}
        //static string ReverseWord(string[] text)
        //{
        //    Array.Reverse(text);
        //    string str = string.Join(" ", text);
        //    return str;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Задание 2. Перестановка слов в предложении");
        //    Console.WriteLine("Введите предложение: ");

        //    string test2 = Console.ReadLine();

        //    test2 = SplitWord2(test2);


        //    Console.WriteLine(test2);
        //    Console.ReadLine();
        //}
        #endregion
    }
}