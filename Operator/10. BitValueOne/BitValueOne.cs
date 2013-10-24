using System;

class BitValueOne
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position");
        byte position = byte.Parse(Console.ReadLine());         //From 0 to 31
        int mask = 1 << position;
        int maskNumber = number & mask;
        bool isOne = (maskNumber != 0);
        Console.WriteLine("The bit at position {0} in number {1} is one: {2}", position, number, isOne);
        bool isZero = (maskNumber == 0);
        Console.WriteLine("The bit at position {0} in number {1} is zero: {2}", position, number, isZero);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}