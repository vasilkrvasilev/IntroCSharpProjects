using System;

class TwoInteger
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int smallerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int greaterNumber = int.Parse(Console.ReadLine());
        if (greaterNumber >= smallerNumber)
        {
            Console.WriteLine("{0} {1}", smallerNumber, greaterNumber);
        }
        else
        {
            int exchangeNumber = smallerNumber;
            smallerNumber = greaterNumber;
            greaterNumber = exchangeNumber;
            Console.WriteLine("{0} {1}", smallerNumber, greaterNumber);
        }
    }
}