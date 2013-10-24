using System;

class ZeroCounter
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int integerNumber = int.Parse(Console.ReadLine());            //Could be a big number
        int zeroCounter = 0;
        for (int number = 5; number <= integerNumber; number *= 5)    //First - 5, 10, 15, 20, 25 ... 125 ... 250 ... 500 ...
        {                                                             //Second - 25, 50, 75, 100, 125 ... 250 ... 500 ...
            int counter = integerNumber / number;                     //Third - 125, 250, 375, 500 ... Fourth ...
            zeroCounter += counter;
        }
        Console.WriteLine("{0}! has {1} zeros at the end", integerNumber, zeroCounter);
    }
}