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