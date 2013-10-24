using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        // N!/K! = k+1 * k+2 * ... * n-1 * n
        Console.WriteLine("Enter first number (N)");
        int firstNumber = int.Parse(Console.ReadLine());                //Could be a big number
        Console.WriteLine("Enter second number (K) smaller than first number");
        int secondNumber = int.Parse(Console.ReadLine());               //Could be a big number
        BigInteger factorial = 1;                                       //Could be a very big number
        if (firstNumber >= secondNumber)
        {
            for (int currentNumber = secondNumber + 1; currentNumber <= firstNumber; currentNumber++)
            {
                factorial *= currentNumber;
            }
            Console.WriteLine("N!/K! is equal to {0}", factorial);
        }
        else
        {
            Console.WriteLine("Second number is bigger than the first number");
        }
    }
}