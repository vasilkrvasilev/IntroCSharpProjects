using System;

class ChangeValue
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position");
        byte position = byte.Parse(Console.ReadLine());                    //From 0 to 31
        Console.WriteLine("Enter the wanted value of the bit");
        byte value = byte.Parse(Console.ReadLine());                       //0 or 1
        if (value == 1)
        {
            int maskOne = 1 << position;
            int changeValueToOne = number | maskOne;
            bool valueOne = (changeValueToOne == number);
            Console.WriteLine(
                "The bit at position {0} of number {1} is 1: {2}\nBy changing it to 1 we get the number {3}", 
                position, number, valueOne, changeValueToOne);
        }
        else
        {
            int maskZero = ~(1 << position);
            int changeValueToZero = number & maskZero;
            bool valueZero = (changeValueToZero == number);
            Console.WriteLine(
                "The bit at position {0} of number {1} is 0: {2}\nBy changing it to 0 we get the number {3}",
                position, number, valueZero, changeValueToZero);
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}