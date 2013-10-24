using System;
using System.Numerics;

class FactorialExpression
{
    static void Main()
    {
        // N!*K!/(N-K)!=K! * (n-k+1) * (n-k+2) * ... * n-1 * n
        Console.WriteLine("Enter first number (N)");
        int firstNumber = int.Parse(Console.ReadLine());                //Could be a big number
        Console.WriteLine("Enter second number (K) smaller than first number");
        int secondNumber = int.Parse(Console.ReadLine());               //Could be a big number
        BigInteger factorial = 1;                                       //Could be a very big number
        BigInteger multiplication = 1;                                  //Could be a very big number
        if (firstNumber >= secondNumber)
        {
            for (int currentNumber = 1; currentNumber <= secondNumber; currentNumber++)
            {
                multiplication *= (firstNumber - secondNumber + currentNumber);
                factorial *= currentNumber;
            }
            Console.WriteLine("N!*K!/(N-K)! is equal to {0}", factorial * multiplication);
        }
        else
        {
            Console.WriteLine("Second number is bigger than the first number");
        }

    }
}