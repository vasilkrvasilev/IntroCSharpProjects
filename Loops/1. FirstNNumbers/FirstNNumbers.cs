using System;

class FirstNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number n");
        Console.WriteLine("The numbers in the interval [1...n] are:");
        string number = Console.ReadLine();
        int integerNumber;
        bool isNumber = int.TryParse(number, out integerNumber);
        if (isNumber)
        {
            for (int currentNumber = 1; currentNumber <= integerNumber; currentNumber++)
            {
                Console.Write("{0} ", currentNumber);
            }
        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }
}