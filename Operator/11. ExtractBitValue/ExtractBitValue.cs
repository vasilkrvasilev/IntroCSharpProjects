using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position");
        byte position = byte.Parse(Console.ReadLine());         //From 0 to 31
        int mask = 1 << position;
        int maskNumber = number & mask;
        byte bitValue = (byte)(maskNumber >> position);         //0 or 1
        Console.WriteLine("The value of the bit at position {0} in number {1} is {2}", position, number, bitValue);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}