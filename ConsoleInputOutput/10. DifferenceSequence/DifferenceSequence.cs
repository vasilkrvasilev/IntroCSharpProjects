using System;
using System.Threading;
using System.Globalization;

class DifferenceSequence
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("The sequence:");
        int number = 2;
        double sum = 1.0;
        double difference = 1.0;
        Console.Write("1 ");
        while (difference >= 0.001)
        {
            int even = number;
            int odd = -(number + 1);
            Console.Write("{0} {1} ", 1.0 / even, 1.0 / odd);
            sum += (1.0 / even) + (1.0 / odd);
            difference = (1.0 / even) + (1.0 / odd);
            number += 2;
        }
        Console.WriteLine("The sum of the members of the sequence is: {0,10:F3}", sum);
    }
}