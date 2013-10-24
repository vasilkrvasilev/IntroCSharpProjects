using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculates the roots of quadratic equation: ax^2 + bx + c = 0");
        double coefficientA;                                                 //Could be not integer number
        Console.WriteLine("Enter a");
        string valueCoefficientA = Console.ReadLine();
        bool validCoefficientA = double.TryParse(valueCoefficientA, out coefficientA);
        double coefficientB;                                                 //Could be not integer number
        Console.WriteLine("Enter b");
        string valueCoefficientB = Console.ReadLine();
        bool validCoefficientB = double.TryParse(valueCoefficientB, out coefficientB);
        double coefficientC;                                                 //Could be not integer number
        Console.WriteLine("Enter c");
        string valueCoefficientC = Console.ReadLine();
        bool validCoefficientC = double.TryParse(valueCoefficientC, out coefficientC);
        if (validCoefficientA && validCoefficientB && validCoefficientC)
        {
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
        else
        {
            Console.WriteLine("You enter invalid coefficient");
        }

    }
}