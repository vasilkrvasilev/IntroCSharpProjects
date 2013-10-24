using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        int hundreds = number / 100;
        byte thirdDigit = (byte)(hundreds % 10);                 //From 0 to 9
        bool isSeven = (thirdDigit == 7);
        Console.WriteLine("The third digit (right to left) of {0} is seven: {1}", number, isSeven);
    }
}