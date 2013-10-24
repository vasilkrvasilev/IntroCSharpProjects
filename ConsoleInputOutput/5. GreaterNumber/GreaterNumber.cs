using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers on two rows");                   //First way
        double numberOne = double.Parse(Console.ReadLine());                  //Could be not integer number
        double numberTwo = double.Parse(Console.ReadLine());                  //Could be not integer number
        bool comparison = (numberOne >= numberTwo);
        double greaterNumber = comparison ? numberOne : numberTwo;
        Console.WriteLine("The greter number is {0,15:F5}", greaterNumber);
        Console.WriteLine("Enter two numbers on one row, separated with space, point, comma, semicolon or star");
        string numberLine = Console.ReadLine();                               //Second way
        string[] numberArray = numberLine.Split(' ', '.', ',', ';', '*');
        double firstNumber = double.Parse(numberArray[0]);
        double secondNumber = double.Parse(numberArray[1]);
        bool floatComparison = (firstNumber >= secondNumber);
        double floatGreaterNumber = floatComparison ? firstNumber : secondNumber;
        Console.WriteLine("The greter number is {0,15:F5}", floatGreaterNumber);
    }
}