using System;
using System.Threading;
using System.Globalization;
using System.Numerics;

    class FactorialSequence
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter first number (N)");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number (X)");                   //First way - use floating-point variables
        double doubleNumber = double.Parse(Console.ReadLine());
        double factorial = 1;
        double power = 1;
        double sum = 1;
        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            factorial *= currentNumber;
            power *= doubleNumber;
            sum += factorial / power;
        }
        string sequence = "1 + 1!/X + 2!/X^2 + … + N!/X^N";
        Console.WriteLine("Sum of the sequence {0} is:\t{1}", sequence, sum);
        BigInteger integerNumber = (BigInteger)doubleNumber;          //Second way - use integer variables (could be a very big numbers)
        BigInteger integerfactorial = 1;
        BigInteger integerpower = 1;
        BigInteger integersum = 1;
        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            integerfactorial *= currentNumber;
            integerpower *= integerNumber;
            integersum += integerfactorial / integerpower;
        }
        Console.WriteLine("If we use integer division");
        Console.WriteLine("Sum of the sequence {0} is:\t{1}", sequence, integersum);
    }
}