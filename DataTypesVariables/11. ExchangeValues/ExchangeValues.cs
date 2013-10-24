using System;

class ExchangeValues
{
    static void Main()
    {
        byte five = 5;
        byte ten = 10;
        byte exchangeNumber = five;
        five = ten;
        ten = exchangeNumber;
        Console.WriteLine("The value of five is {0}\nThe value of ten is {1}", five, ten);
    }
}