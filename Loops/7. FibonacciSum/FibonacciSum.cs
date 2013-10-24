using System;
using System.Numerics;

class FibonacciSum
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        BigInteger previousNumber = 0;                       //Could be a very big number
        BigInteger currentNumber = 1;                        //Could be a very big number
        BigInteger sum = previousNumber + currentNumber;     //Could be a very big number
        Console.WriteLine("The first {0} members of Fibonacci sequence are:", number);
        Console.Write("{0} {1} ", previousNumber, currentNumber);
        for (int count = 3; count <= number; count++)
        {
            BigInteger nextNumber = previousNumber + currentNumber;
            Console.Write("{0} ", nextNumber);
            previousNumber = currentNumber;
            currentNumber = nextNumber;
            sum += currentNumber;
        }
        Console.WriteLine();
        Console.WriteLine("Their sum is:{0}", sum);
        Console.WriteLine("Their sum is:{0:E10}", sum);
    }
}