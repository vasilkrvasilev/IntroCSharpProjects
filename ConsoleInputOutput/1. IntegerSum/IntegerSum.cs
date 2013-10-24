using System;

class IntegerSum
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers on three rows");
        int numberOne = int.Parse(Console.ReadLine());                     //First way
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());
        int sum = numberOne + numberTwo + numberThree;
        Console.WriteLine("The sum of the numbers is {0}", sum);
        Console.WriteLine("Enter three numbers on one row, separated with comma");
        string numberLine = Console.ReadLine();                             //Second way
        string[] numberArray = numberLine.Split(',');
        int firstNumber = int.Parse(numberArray[0]);
        int secondNumber = int.Parse(numberArray[1]);
        int thirdNumber = int.Parse(numberArray[2]);
        int integerSum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the numbers is {0}", integerSum);
    }
}