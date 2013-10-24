using System;

class NumberDigits
{
    static void Main()
    {
        //From the book
        Console.WriteLine("Enter four digit number");
        ushort number = ushort.Parse(Console.ReadLine());                   //From 1000 to 9999
        ushort tens = (ushort)(number / 10);                                //From 100 to 999
        byte digitFour = (byte)(number % 10);                               //From 0 to 9
        byte hundreds = (byte)(tens / 10);                                  //From 10 to 99
        byte digitThree = (byte)(tens % 10);                                //From 0 to 9
        byte thousands = (byte)(hundreds / 10);                             //From 0 to 9
        byte digitTwo = (byte)(hundreds % 10);                              //From 0 to 9
        byte digitOne = thousands;                                          //From 0 to 9
        byte sum = (byte)(digitOne + digitTwo + digitThree + digitFour);    //From 1 to 36
        Console.WriteLine("The sum of digits of {0} is {1}", number, sum);
        Console.WriteLine("By exchanging the digits of {0} we get the following numbers:", number);
        Console.WriteLine("{0}{1}{2}{3}", digitFour, digitThree, digitTwo, digitOne);
        Console.WriteLine("{0}{1}{2}{3}", digitFour, digitOne, digitTwo, digitThree);
        Console.WriteLine("{0}{1}{2}{3}", digitOne, digitThree, digitTwo, digitFour);
    }
}