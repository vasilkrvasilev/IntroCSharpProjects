using System;

class CompareNumbers
{
    static void Main()
    {
        decimal precision = 0.000001m;                                                            //With decimal
        Console.WriteLine("Enter first number");
        decimal numberOne = decimal.Parse(Console.ReadLine());                                    //5.00000001
        Console.WriteLine("Enter second number");
        decimal numberTwo = decimal.Parse(Console.ReadLine());                                    //5.00000003
        bool oneEqualTwo = (Math.Abs(numberOne - numberTwo) <= precision);
        Console.WriteLine("The first number is equal to the second: {0}", oneEqualTwo);           //True
        decimal onePlusTwo = numberOne + numberTwo;
        Console.WriteLine("The sum of the first and the second number is: {0}", onePlusTwo);      //10.00000004
        float floatPrecision = (float)precision;                                                  //With float        
        float firstNumber = (float)numberOne;                                                     //5
        float secondNumber = (float)numberTwo;                                                    //5
        bool firstEqualSecond = (Math.Abs(firstNumber - secondNumber) <= floatPrecision);
        Console.WriteLine("The first number is equal to the second: {0}", oneEqualTwo);            //True
        float firstPlusSecond = firstNumber + secondNumber;
        Console.WriteLine("The sum of the first and the second number is: {0}", firstPlusSecond);  //10
    }
}