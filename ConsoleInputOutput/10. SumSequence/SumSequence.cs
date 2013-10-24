using System;
using System.Threading;
using System.Globalization;

class SumSequence
{
    static void Main()
    {
        //From the book
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("The sequence:");
        int number = 2;
        double sum = 1.0;
        double difference = 1.0;
        Console.Write("1 ");
        while (difference >= 0.001)
        {
            Console.Write("{0} ", 1.0 / number);
            sum += (1.0 / number);
            difference = 1.0 / number;
            number++;
        }
        Console.WriteLine("The sum of the members of the sequence is: {0,10:F3}", sum);
    }
}