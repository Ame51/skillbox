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
                bool isCompToPlay = true;
                string currentPlayer = "";
                int userTry = 0;
                Random r = new Random();

                //настройки игры                    
                //if (Console.ReadLine() == "1")
                //{
                //    flag++;
                //}

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

                //Console.Write("\nВведите количество игроков: \n");
                // создание игроков
                int playersCount = 4/*int.Parse(Console.ReadLine())*/;

                Console.WriteLine("Введите имя 1-го игрока:");
                var name1 = Console.ReadLine();

                Console.WriteLine("Введите имя 2-го игрока:");
                var name2 = Console.ReadLine();

                Console.WriteLine("Введите имя 3-го игрока:");
                var name3 = Console.ReadLine();

                Console.WriteLine("Введите имя 4-го игрока:");
                var name4 = Console.ReadLine();

                var name0 = "Компьютер";

                Console.WriteLine("\nНачали!");
                // запуск цикла угадываний 
                while (gameNumber > 0)
                {
                    #region
                    ////ход игрока(ов)
                    //for (var i = 0; i < playersCount; i++)
                    //{
                    //    Console.WriteLine($"\nТекущее число: {gameNumber}");
                    //    Console.Write($"Ход игрока {i + 1} : ");
                    //    int userTry;
                    //    int compTry;
                    //    bool requestInput;
                    //    do
                    //    {
                    //        userTry = int.Parse(Console.ReadLine());
                    //        requestInput = userTry < inputMin || userTry > inputMax;
                    //        if (requestInput)
                    //            Console.WriteLine($"Некорректный ход! Только число от {inputMin} до {inputMax}!\n");

                    //    }
                    //    while (requestInput);
                    //    gameNumber -= userTry;
                    //    //ход компьютера
                    //    if (flag >= 1 && playersCount == i + 1)
                    //    {
                    //        Console.WriteLine($"\nТекущее число: {gameNumber}");
                    //        compTry = rand.Next(inputMin, inputMax + 1);
                    //        if (gameNumber <= inputMax)
                    //        {
                    //            compTry = gameNumber;
                    //        }
                    //        Console.WriteLine($"Ход компьютера: {compTry}");
                    //        gameNumber -= compTry;
                    //        if (gameNumber == 0)
                    //        {
                    //            Console.WriteLine("Победил компьютер!");
                    //            Console.ReadLine();
                    //            continue;
                    //        }
                    //    }
                    //    // победа если дошли до нуля и ничья если ушли в минус..
                    //    if (gameNumber == 0)
                    //    {
                    //        Console.WriteLine($"\n Победа игрока {i + 1} \n");
                    //        break;
                    //    }
                    //    if (gameNumber < 0)
                    //    {
                    //        Console.WriteLine($"\nНичья, сыграйте ещё раз.\n");
                    //        break;
                    //    }
                    //}
                    #endregion
                    for (; ; )
                    {
                        Console.WriteLine($"Игровое число: {gameNumber}");

                        if (flag > playersCount)
                        {
                            switch (isCompToPlay)
                            {
                                case true:
                                    flag = 0; // если 0, то ход компьютера. Сбрасываем до нуля, если isCompToPlay = true
                                    break;
                                case false:
                                    flag = 1;
                                    break;
                            }
                        }

                        switch (flag)
                        {
                            case 0:
                                currentPlayer = name0;
                                break;
                            case 1:
                                currentPlayer = name1;
                                break;
                            case 2:
                                currentPlayer = name2;
                                break;
                            case 3:
                                currentPlayer = name3;
                                break;
                            case 4:
                                currentPlayer = name4;
                                break;
                        }

                        Console.Write($"Ходит: {currentPlayer}: ");

                        if (flag == 0)
                        {
                            userTry = r.Next(1, 5);
                            Console.WriteLine($"{userTry}");
                        }

                        else userTry = int.Parse(Console.ReadLine());

                        gameNumber -= userTry;

                        flag++;
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"Выиграл {currentPlayer}");
                            break;
                        }
                        if (gameNumber < 0)
                        {
                            Console.WriteLine("Ничья");
                            break;

                        }

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
