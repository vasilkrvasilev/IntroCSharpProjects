using System;
using System.Threading;
using System.Globalization;

class Multiplication
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter the first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > 0)
        {
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sing of the result is +");
                }
                else if (thirdNumber < 0)
                {
                    Console.WriteLine("The sing of the result is -");
                }
                else
                {
                    Console.WriteLine("The result is 0");
                }
            }
            else if (secondNumber < 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sing of the result is -");
                }
                else if (thirdNumber < 0)
                {
                    Console.WriteLine("The sing of the result is +");
                }
                else
                {
                    Console.WriteLine("The result is 0");
                }
            }
            else
            {
                Console.WriteLine("The result is 0");
            }
        }
        else if (firstNumber < 0)
        {
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sing of the result is -");
                }
                else if (thirdNumber < 0)
                {
                    Console.WriteLine("The sing of the result is +");
                }
                else
                {
                    Console.WriteLine("The result is 0");
                }
            }
            else if (secondNumber < 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sing of the result is +");
                }
                else if (thirdNumber < 0)
                {
                    Console.WriteLine("The sing of the result is -");
                }
                else
                {
                    Console.WriteLine("The result is 0");
                }
            }
            else
            {
                Console.WriteLine("The result is 0");
            }
        }
        else
        {
            Console.WriteLine("The result is 0");
        }
    }
}