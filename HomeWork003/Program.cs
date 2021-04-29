using System;
using System.Text.RegularExpressions;
namespace HomeWork003
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //флаг перезапуска игры
            bool gameStart = true;
            while (gameStart)
            {
                string Text = "Игра доберись до нуля.\nПравила: игроки ходят по очереди " +
    "<<отнимая>> от загаданного числа числа от одного до четырёх." +
    "\nПобедит игрок после хода которого загаданное число станет нулём.\n" +
    "\nЕсли хотите сыграть с компьютером, нажмите < 1 > или нажмите другую кнопку для продолжения...";
                string[] lines = Regex.Split(Text, "\r\n|\r|\n");
                int top = 0;
                int center = Console.WindowWidth / 2;
                for (int j = 0; j < lines.Length; j++)
                {
                    int left = center - (lines[j].Length / 2);
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine(lines[j]);
                    top = Console.CursorTop;
                }
                int flag = 0;
                //настройки игры                    
                if (Console.ReadLine() == "1")
                {
                    flag++;
                }
                Console.WriteLine("\nВыберете пределы загадываемого числа");
                Console.WriteLine("\nМинимальное: ");
                int gameNumberMin = int.Parse(Console.ReadLine());
                Console.WriteLine("\nМаксимальное: ");
                int gameNumberMax = int.Parse(Console.ReadLine());
                Console.WriteLine("\nВыберете диапазон чисел которые можно использовать");
                Console.WriteLine("\nМинимальное: ");
                int inputMin = int.Parse(Console.ReadLine());
                Console.WriteLine("\nМаксимальное: ");
                int inputMax = int.Parse(Console.ReadLine());
                int gameNumber = rand.Next(gameNumberMin, gameNumberMax + 1);
                Console.Write("\nВведите количество игроков: \n");
                // создание игроков
                int playersCount = int.Parse(Console.ReadLine());
                //int
                Console.WriteLine("\nНачали!");
                // запуск цикла угадываний 
                while (gameNumber > 0)
                {
                    for (var i = 0; i < playersCount; i++)
                    {
                        Console.WriteLine($"\nТекущее число: {gameNumber}");
                        Console.Write($"Ход игрока {i + 1} : ");
                        int userTry;
                        int compTry;
                        bool requestInput;
                        do
                        {
                            userTry = int.Parse(Console.ReadLine());
                            requestInput = userTry < inputMin || userTry > inputMax;
                            if (requestInput)
                                Console.WriteLine($"Некорректный ход! Только число от {inputMin} до {inputMax}!\n");

                        }
                        while (requestInput);
                        gameNumber -= userTry;
                        if (flag >= 1 && playersCount == i + 1)
                        {
                            Console.WriteLine($"\nТекущее число: {gameNumber}");
                            compTry = rand.Next(inputMin, inputMax + 1);
                            if (gameNumber <= inputMax + 1)
                            {
                                compTry = gameNumber;
                            }
                            Console.WriteLine($"Ход компьютера: {compTry}");
                            gameNumber -= compTry;
                        }
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"\n Победа игрока {i + 1} \n");
                            break;
                        }
                        if (gameNumber < 0)
                        {
                            Console.WriteLine($"\nНичья, сыграйте ещё раз.\n");
                            break;
                        }
                        // победа если дошли до нуля и ничья если ушли в минус.. 
                    }
                }
                Console.WriteLine("Нажмите 5 для перезапуска игры или любую другую кнопку для завершения игры.");
                if (Console.ReadLine() == "5")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
