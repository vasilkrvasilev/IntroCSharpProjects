using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class FallingRocks      //The integer types byte and short are used because of the small velues of the variables,
{                                           //they could be changed, if there are more rounds for example
    static Random randomGenerator = new Random();
    static byte playerPosition = (byte)(Console.WindowWidth / 2);     //Window width is 85
    static byte initialPosition = 2;                                  //Window height is 43
    static bool collision = false;
    static bool gameOver = false;
    static byte rounds = 25;
    static byte lives = 3;
    static short points = 100;
    static byte minRocks = 1;
    static byte maxRocks = 2;


    static void RemoveScrollBars()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void PrintAtPosition(int x, int y, string symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    static void PrintResult(short points)
    {
        Console.SetCursorPosition(0, 0);
        Console.Write("Result : {0:D4} points      Lives : {1}", points, lives);
    }

    static void DrawDwarf()
    {
        PrintAtPosition(playerPosition - 1, Console.WindowHeight - 1, "(0)");
    }

    static void MoveDwarfRight()
    {
        if (playerPosition + 1 < Console.WindowWidth - 2)
        {
            playerPosition++;
        }
    }

    static void MoveDwarfLeft()
    {
        if (playerPosition - 1 > 0)
        {
            playerPosition--;
        }
    }


    static void Move()                                                    //Move the dwarf according to the pushed arrow key
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                MoveDwarfRight();
                PrintAtPosition(playerPosition - 2, Console.WindowHeight - 1, " ");
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                MoveDwarfLeft();
                PrintAtPosition(playerPosition + 2, Console.WindowHeight - 1, " ");
            }
        }
    }


    static void PrintRock(byte numberRocks, byte[] rockPosition, string[] rockSymbol)
    {
        for (byte rock = 0; rock < numberRocks; rock++)                      //Print new rocks
        {
            PrintAtPosition(rockPosition[rock], initialPosition, rockSymbol[rock]);
        }
        while (initialPosition <= Console.WindowHeight - 3)                 //Move the rocks and the dwarf simultaneously
        {
            DrawDwarf();
            for (byte rock = 0; rock < numberRocks; rock++)
            {
                PrintAtPosition(rockPosition[rock], initialPosition, "   ");
            }
            initialPosition++;
            for (byte rock = 0; rock < numberRocks; rock++)
            {
                PrintAtPosition(rockPosition[rock], initialPosition, rockSymbol[rock]);
            }
            Thread.Sleep(150);
            Move();
        }
        for (byte rock = 0; rock < numberRocks; rock++)                      //Remove old rocks
        {
            PrintAtPosition(rockPosition[rock], initialPosition, "   ");
        }
    }


    static void Collision(byte numberRocks, byte[] rockPosition)              //Check for collision between the dwarf and some of the rocks
    {
        for (byte rock = 0; rock < numberRocks; rock++)
        {
            if ((playerPosition + 1 >= rockPosition[rock]) && (playerPosition - 1 <= rockPosition[rock]))
            {
                collision = true;
            }
        }
    }

    static void GameOver()                                                  //The game is over if you have negative points or 0 lives
    {
        if (points < 0 || lives <= 0)
        {
            gameOver = true;
        }
    }

    static void Main()
    {
        RemoveScrollBars();
        while (rounds > 0)                                                  //The game runs for a chosen number of rounds (or infinitely)
        {
            PrintResult(points);
            collision = false;
            string[] symbols = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";", "^^", "**", "##", "+++", "$$$", "!!!" };
            byte numberRocks = (byte)(randomGenerator.Next(minRocks, maxRocks));               //Choose the number of rocks
            byte[] rockPosition = new byte[numberRocks];
            string[] rockSymbol = new string[numberRocks];
            for (byte rock = 0; rock < numberRocks; rock++)                  //Choose the position and the kind of the rocks
            {
                rockPosition[rock] = (byte)(randomGenerator.Next(0, Console.WindowWidth - 2));
                byte randomSymbol = (byte)(randomGenerator.Next(0, 17));
                rockSymbol[rock] = symbols[randomSymbol];
            }
            PrintRock(numberRocks, rockPosition, rockSymbol);               //Move the rocks and the dwarf simultaneously
            Collision(numberRocks, rockPosition);                           //Check for collision between the dwarf and some of the rocks
            if (collision)                                                  //If there is a collision you lose points and live
            {
                points -= 50;
                lives--;
            }
            points += 10;                                                   //You win point for every passed round
            GameOver();
            if (gameOver)                                                   //If the game is over program stops
            {
                PrintAtPosition(Console.WindowWidth / 4, Console.WindowHeight / 2, "Game Over!");
                PrintAtPosition(Console.WindowWidth / 4, Console.WindowHeight / 2 + 1, "You lose!");
                break;
            }
            switch (rounds)                                                 //Gradually the number of rocks increase
            {
                case 20:
                    maxRocks++;
                    break;
                case 15:
                    maxRocks++;
                    break;
                case 10:
                    minRocks++;
                    break;
                case 5:
                    minRocks++;
                    break;
            }
            initialPosition = 2;
            rounds--;
        }
        short endPoints = (short)(lives * points);             //When rounds became 0 the player win the game and his result is calculated
        PrintAtPosition(Console.WindowWidth / 4, Console.WindowHeight / 2, "You win! Congratulations!");
        PrintAtPosition(Console.WindowWidth / 4, Console.WindowHeight / 2 + 1, "");
        Console.WriteLine("Your result is {0} points.", endPoints);
    }
}