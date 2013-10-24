using System;
using System.Threading;
using System.Globalization;

class MaxNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double numberOne;
        double numberTwo;
        double numberThree;
        double numberFour;
        double numberFive;
        Console.WriteLine("Enter five numbers on five rows");
        string stringNumberOne = Console.ReadLine();
        bool valueNumberOne = double.TryParse(stringNumberOne, out numberOne);
        string stringNumberTwo = Console.ReadLine();
        bool valueNumberTwo = double.TryParse(stringNumberTwo, out numberTwo);
        string stringNumberThree = Console.ReadLine();
        bool valueNumberThree = double.TryParse(stringNumberThree, out numberThree);
        string stringNumberFour = Console.ReadLine();
        bool valueNumberFour = double.TryParse(stringNumberFour, out numberFour);
        string stringNumberFive = Console.ReadLine();
        bool valueNumberFive = double.TryParse(stringNumberFive, out numberFive);
        if (valueNumberOne && valueNumberTwo && valueNumberThree && valueNumberFour && valueNumberFive)
        {
            double firstComparison = Math.Max(numberOne, numberTwo);
            double secondComparison = Math.Max(firstComparison, numberThree);
            double thirdComparison = Math.Max(secondComparison, numberFour);
            double finalComparison = Math.Max(thirdComparison, numberFive);
            Console.WriteLine("The max number between {0,12:F5}\n{1,35:F5}\n{2,35:F5} is {3,11:F5}\n{4,35:F5}\n{5,35:F5}",
                numberOne, numberTwo, numberThree, finalComparison, numberFour, numberFive);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}