using System;

class OddEven
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        int integerDivide = number % 2;                                        //First way: check the rimainder after division by 2
        bool isEven = (integerDivide == 0);
        bool isOdd = (integerDivide != 0);
        Console.WriteLine("{0} is even: {1}\n{0} is odd: {2}", number, isEven, isOdd);
        string firstResult = (isEven ? "The number is even" : "The number is odd");
        Console.WriteLine(firstResult);
        byte mask = 1;                                                        //Second way: chack the bit at position 0
        int numberMask = number & mask;
        bool isEvenBitwise = (numberMask == 0);
        bool isOddBitwise = (numberMask != 0);
        Console.WriteLine("{0} is even: {1}\n{0} is odd: {2}", number, isEvenBitwise, isOddBitwise);
        string secondResult = (isEvenBitwise ? "The number is even" : "The number is odd");
        Console.WriteLine(secondResult);
    }
}