using System;

class DivideFiveSeven
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        byte numberFive = 5;
        byte numberSeven = 7;
        byte divideFive = (byte)(number % numberFive);                         //From 0 to 4
        byte divideSeven = (byte)(number % numberSeven);                       //From 0 to 6
        bool divisibleByFive = (divideFive == 0);
        bool divisibleBySeven = (divideSeven == 0);
        string divideFiveSeven = ((divisibleByFive) ? 
            ((divisibleBySeven) ? ("The number is divisible by five and seven") : ("The number is not divisible by seven")) : 
            ("The number is not divisible by five"));                            //With the operator ?:
        Console.WriteLine(divideFiveSeven);
        bool divisibleByFiveSeven = divisibleByFive && divisibleBySeven;         //Without the operator ?:
        Console.WriteLine("The number {0} is divisible by five and seven: {1}", number, divisibleByFiveSeven);
    }
}