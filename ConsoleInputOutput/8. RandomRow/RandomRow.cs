using System;

    class RandomRow
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("All numbers in the interval [1...n] are:");
            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                Console.Write("{0} ", currentNumber);
            }
        }
    }