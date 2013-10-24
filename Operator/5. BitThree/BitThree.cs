using System;

class BitThree
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        byte mask = 1 << 3;                                             //8
        int numberMask = number & mask;
        byte bit = (byte)(numberMask >> 3);                            //0 or 1
        Console.WriteLine("The third bit of {0} is {1}", number, bit);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}