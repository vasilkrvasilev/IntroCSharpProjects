using System;
using System.Threading;
using System.Globalization;

class ThreeRandomNumbers
{
    static void Main()
    {
        //From the book - task 4
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Random randomNumber = new Random();
        int randomInteger = randomNumber.Next(0, 99999);
        double randomPositive = randomNumber.NextDouble();
        double randomNegative = -(randomNumber.NextDouble());
        double randomPositiveDouble = randomPositive * randomInteger;
        double randomNegativeDouble = randomNegative * randomInteger;
        Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}", randomInteger, randomPositiveDouble, randomNegativeDouble);
    }
}