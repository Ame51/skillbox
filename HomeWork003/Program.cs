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
    "\nВыберите режим игры: \n\n<1> Игра вдвоём   \n<2> Игра с несколькими игроками и настройками сложности  \n<3> Игра с компьютером";
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
                bool playerTurn = true;
                var gameMode = Console.ReadLine();
                if (gameMode == "1")
                {
                    Console.Write($"Введите имя первого игрока : ");
                    string playerName_1 = Console.ReadLine();
                    Console.Write($"Введите имя второго игрока : ");
                    string playerName_2 = Console.ReadLine();
                    //загадывается число
                    int gameNumber = rand.Next(11, 121);
                    while (gameNumber > 0)  // запуск цикла угадываний
                    {
                        Console.WriteLine($"\nТекущее число: {gameNumber}");
                        bool requestInput = true;
                        while (requestInput)
                        {
                            string currentPlayer = playerTurn ? playerName_1 : playerName_2;
                            Console.Write($"Ваш ход {currentPlayer}: ");
                            int userTry = int.Parse(Console.ReadLine());
                            if (userTry < 1 || userTry > 4)
                            {
                                Console.WriteLine($"Некорректный ход! Только число от 1 до 4!");
                            }
                            else
                            {
                                requestInput = false;
                                gameNumber -= userTry;
                                if (gameNumber == 0)
                                {
                                    string winner = playerTurn ? playerName_1 : playerName_2;
                                    Console.WriteLine($"Победил {winner}!");
                                    Console.ReadLine();
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
                                else if (gameNumber < 0)
                                {
                                    Console.WriteLine($"\nНедопустимый ход.\nПереход хода.");
                                    Console.ReadLine();
                                    gameNumber += userTry;
                                }
                            }
                            // переключение хода между игроками
                            playerTurn = !playerTurn;
                        }
                    }
                }
                else if (gameMode == "2")
                {
                    //настройки игры                
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
                    Console.WriteLine("\nНачали!");
                    // запуск цикла угадываний 
                    while (gameNumber > 0)
                    {
                        for (var i = 0; i < playersCount; i++)
                        {
                            Console.WriteLine($"\nТекущее число: {gameNumber}");
                            Console.Write($"Ход игрока {i + 1} : ");
                            int userTry;
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
                            // победа если дошли до нуля и ничья если ушли в минус..                    
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"\n Победа игрока {i + 1} \n");
                                break;
                            }
                            else if (gameNumber < 0)
                            {
                                Console.WriteLine($"\nНичья, сыграйте ещё раз.\n");
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
                else if (gameMode == "3")
                {
                    //загадывается число
                    int gameNumber = rand.Next(11, 121);
                    Console.Write($"\nВведите ваше имя : ");
                    string playerName = Console.ReadLine();
                    bool playerTurn2 = true;
                    while (gameNumber > 0)
                    {
                        Console.WriteLine($"\nТекущее число: {gameNumber}");
                        // запрос хода игрока
                        if (playerTurn) //ход игрока
                        {
                            bool requestInput = true;
                            while (requestInput)
                            {
                                Console.Write($"Ваш ход {playerName}: ");
                                int userTry = int.Parse(Console.ReadLine());
                                if (userTry < 1 || userTry > 4)
                                {
                                    Console.WriteLine($"Некорректный ход! Только число от {1} до {4}!\n");
                                }
                                else
                                {
                                    requestInput = false;
                                    gameNumber -= userTry;
                                }
                            }
                        }
                        else // ход компьютера
                        {
                            int randNumber = rand.Next(1, 4 + 1);
                            Console.WriteLine($"Ход компьютера : {randNumber}");
                            if (gameNumber <= 4)
                            {
                                randNumber = gameNumber;
                            }
                            gameNumber -= randNumber;
                        }
                        // переключение хода между игроком и компьютером
                        playerTurn2 = !playerTurn2;
                    }
                    // победа если дошли до нуля и ничья если ушли в минус..
                    if (gameNumber == 0)
                    {
                        string winner = playerTurn2 ? "Компьютер" : playerName;
                        Console.WriteLine($"\nПобедил {winner} !!!\n");
                    }
                    else if (gameNumber < 0)
                    {
                        Console.WriteLine($"\nНичья, попробуйте в другой раз");
                    }
                    Console.WriteLine("\nНажмите 5 для перезапуска игры или любую другую кнопку для завершения игры.");
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
}
