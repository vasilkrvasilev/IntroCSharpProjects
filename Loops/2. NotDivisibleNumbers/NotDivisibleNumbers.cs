using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        Console.WriteLine("The numbers in the interval [1...n] not divisible by three and seven simultaneously are:");
        string number = Console.ReadLine();
        int integerNumber;                                           //Could be a big number
        byte divider = 3 * 7;                                        //21
        bool isNumber = int.TryParse(number, out integerNumber);
        if (isNumber)                                                //First way - without continue
        {
            for (int currentNumber = 1; currentNumber <= integerNumber; currentNumber++)
            {
                if (currentNumber % divider != 0)
                {
                    Console.Write("{0} ", currentNumber);
                }
            }
        }
        else
        {
            Console.WriteLine("invalid number");
        }
        Console.WriteLine();
        if (isNumber)                                              //Second way - with continue
        {
            for (int currentNumber = 1; currentNumber <= integerNumber; currentNumber++)
            {
                if (currentNumber % divider == 0)
                {
                    continue;
                }
                Console.Write("{0} ", currentNumber);
            }
        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }
}