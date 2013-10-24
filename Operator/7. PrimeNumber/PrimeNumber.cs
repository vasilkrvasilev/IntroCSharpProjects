using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("This program checks if the number is prime\nEnter number to check");
        uint number = uint.Parse(Console.ReadLine());                                           //Prime numbers are positive numbers
        uint squareRoot = (uint)Math.Sqrt(number);
        for (uint divider = 2; divider <= squareRoot; divider++)
        {
            uint remainder = number % divider;
            bool divisible = (remainder == 0);
            if (divisible)
            {
                Console.WriteLine("{0} is not a prime, it is divisible by {1}", number, divider);
            }
            else Console.Write("");
        }
        Console.WriteLine("If there is no other statement {0} is a prime number", number);
        /*
        int number;
        number = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(number);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
            if (prime)
            {
        Console.WriteLine("{0} is prime number: {1}", number, prime);
        }
        */
    }
}