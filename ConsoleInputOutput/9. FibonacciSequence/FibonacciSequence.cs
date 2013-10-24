using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal previousNumber = 0;                     //Big numbers
        decimal currentNumber = 1;
        Console.WriteLine("The first 100 members of the Fibonacci sequensce are:");
        Console.Write("{0} {1} ", previousNumber, currentNumber);
        for (int member = 3; member <= 100; member++)
        {
            decimal nextNumber = previousNumber + currentNumber;
            Console.Write("{0} ", nextNumber);
            previousNumber = currentNumber;
            currentNumber = nextNumber;
        }
    }
}