using System;

class EuclidianAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNumber = int.Parse(Console.ReadLine());
        int greaterNumber;
        int smallerNumber;
        if (firstNumber >= secondNumber)
        {
            greaterNumber = firstNumber;
            smallerNumber = secondNumber;
        }
        else
        {
            greaterNumber = secondNumber;
            smallerNumber = firstNumber;
        }
        int remainder;
        do
        {
            remainder = greaterNumber % smallerNumber;
            greaterNumber = smallerNumber;
            smallerNumber = remainder;
        }
        while (remainder != 0);
        Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", firstNumber, secondNumber, greaterNumber);
    }
}