using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculates the roots of quadratic equation");
        Console.WriteLine("Enter a");
        double coefficientA = double.Parse(Console.ReadLine());                  //Could be not integer number
        Console.WriteLine("Enter b");
        double coefficientB = double.Parse(Console.ReadLine());                  //Could be not integer number
        Console.WriteLine("Enter c");
        double coefficientC = double.Parse(Console.ReadLine());                  //Could be not integer number
        double discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);
        if (discriminant < 0)
        {
            Console.WriteLine("The quadratic equation does not have real roots");
        }
        else if (discriminant == 0)
        {
            double root = -coefficientB / (2 * coefficientA);
            Console.WriteLine("The quadratic equation has one real root {0,9:F}", root);
        }
        else
        {
            double discriminantSquareRoot = Math.Sqrt(discriminant);
            double rootOne = (-coefficientB + discriminantSquareRoot) / (2 * coefficientA);
            double rootTwo = (-coefficientB - discriminantSquareRoot) / (2 * coefficientA);
            Console.WriteLine("The quadratic equation has two real roots {0,8:F}\n{1,50:F}", rootOne, rootTwo);
        }
    }
}