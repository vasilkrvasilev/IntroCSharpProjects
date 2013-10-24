using System;
using System.Threading;
using System.Globalization;

class MaxNumber
{
    static void Main()
    {
        //From the book
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter five numbers on five rows");
        double numberOne = double.Parse(Console.ReadLine());                  //Could be not integer number
        double numberTwo = double.Parse(Console.ReadLine());                  //Could be not integer number
        double numberThree = double.Parse(Console.ReadLine());                //Could be not integer number
        double numberFour = double.Parse(Console.ReadLine());                 //Could be not integer number
        double numberFive = double.Parse(Console.ReadLine());                 //Could be not integer number
        double firstComparison = Math.Max(numberOne, numberTwo);
        double secondComparison = Math.Max(firstComparison, numberThree);
        double thirdComparison = Math.Max(secondComparison, numberFour);
        double finalComparison = Math.Max(thirdComparison, numberFive);
        Console.WriteLine("The max number between {0,12:F5}\n{1,35:F5}\n{2,35:F5} is {3,11:F5}\n{4,35:F5}\n{5,35:F5}", 
            numberOne, numberTwo, numberThree, finalComparison, numberFour, numberFive);
    }
}