using System;

class DivisionByFive
{
    static void Main()
    {
        Console.WriteLine("Enter two positive numbers on two rows");
        int numberOne = int.Parse(Console.ReadLine());                            //First way
        int numberTwo = int.Parse(Console.ReadLine());
        int difference = Math.Abs(numberOne - numberTwo);
        bool oneDivisibleFive = ((numberOne % 5) == 0);
        bool twoDivisibleFive = ((numberOne % 5) == 0);
        if (oneDivisibleFive || twoDivisibleFive)
        {
            int numbersDivisibleFive = (difference / 5) + 1;
            Console.WriteLine("There are {0} numbers divisible by five between {1} and {2}", 
                numbersDivisibleFive, numberOne, numberTwo);
        }
        else
        {
            int numbersDivisibleFive = difference / 5;
            Console.WriteLine("There are {0} numbers divisible by five between {1} and {2}",
                numbersDivisibleFive, numberOne, numberTwo);
        }
        Console.WriteLine("Enter two numbers on one row, separated with space, point, comma, semicolon or star");
        string numberLine = Console.ReadLine();                                    //Second way
        string[] numberArray = numberLine.Split(' ', '.', ',', ';', '*');
        int firstNumber = int.Parse(numberArray[0]);
        int secondNumber = int.Parse(numberArray[1]);
        int integerDifference = Math.Abs(firstNumber - secondNumber);
        bool firstDivisibleFive = ((numberOne % 5) == 0);
        bool secondDivisibleFive = ((numberOne % 5) == 0);
        if (firstDivisibleFive || secondDivisibleFive)
        {
            int integerDivisibleFive = (integerDifference / 5) + 1;
            Console.WriteLine("There are {0} numbers divisible by five between {1} and {2}", 
                integerDivisibleFive, firstNumber, secondNumber);
        }
        else
        {
            int integerDivisibleFive = integerDifference / 5;
            Console.WriteLine("There are {0} numbers divisible by five between {1} and {2}", 
                integerDivisibleFive, firstNumber, secondNumber);
        }
    }
}