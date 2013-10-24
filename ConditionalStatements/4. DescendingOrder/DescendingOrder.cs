using System;
using System.Threading;
using System.Globalization;

class DescendingOrder
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
        Console.WriteLine("Arranged in descending order:" );
        if (firstNumber >= secondNumber)
        {
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else if ((firstNumber >= thirdNumber) && (thirdNumber >= secondNumber))
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else
        {
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else if ((secondNumber >= thirdNumber) && (thirdNumber >= firstNumber))
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }
    }
}