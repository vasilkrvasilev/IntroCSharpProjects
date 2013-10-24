using System;

class ExchangeRandomBit
{
    static void Main()
    {
        Console.WriteLine("This program exchange the bits in the intervals\n[first beginning position; first beginning position + range]");
        Console.WriteLine("and\n[second beginning position; second beginning position + range]");
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter first beginning position");
        byte firstBeginningPosition = byte.Parse(Console.ReadLine());                   //From 0 to 31
        Console.WriteLine("Enter second beginning position");
        byte secondBeginningPosition = byte.Parse(Console.ReadLine());                  //From 0 to 31
        byte distance = (byte)(secondBeginningPosition - firstBeginningPosition);       //From 0 to 31
        Console.WriteLine("Enter range");
        byte range = byte.Parse(Console.ReadLine());                                    //From 0 to 31
        for (int bit = firstBeginningPosition; bit <= (firstBeginningPosition + range); bit++)
        {
            int firstMask = 1 << bit;
            int firstMaskNumber = number & firstMask;
            byte firstBitValue = (byte)(firstMaskNumber >> bit);                  //0 or 1
            int secondMask = 1 << (bit + distance);
            int secondMaskNumber = number & firstMask;
            byte secondBitValue = (byte)(firstMaskNumber >> (bit + distance));    //0 or 1
            if (firstBitValue == 1)
            {                                                                     //Change bit (i + range) to 1
                byte firstPsition = (byte)(bit + distance);                       //From 0 to 31
                int firstChangeMask = 1 << firstPsition;
                int changeNumber = number | firstChangeMask;
                if (secondBitValue == 1)
                {                                                                 //Change bit i to 1
                    byte secondPosition = (byte)bit;                              //From 0 to 31
                    int secondChangeMask = 1 << secondPosition;
                    int exchangeNumber = changeNumber | secondChangeMask;
                    number = exchangeNumber;
                }
                else
                {                                                                 //Change bit i to 0
                    byte secondPosition = (byte)bit;                              //From 0 to 31
                    int secondChangeMask = ~(1 << secondPosition);
                    int exchangeNumber = changeNumber & secondChangeMask;
                    number = exchangeNumber;
                }
            }
            else
            {                                                                     //Change bit (i + range) to 0
                byte firstPsition = (byte)(bit + distance);                       //From 0 to 31
                int firstChangeMask = ~(1 << firstPsition);
                int changeNumber = number & firstChangeMask;
                if (secondBitValue == 1)
                {                                                                 //Change bit i to 1
                    byte secondPosition = (byte)bit;                              //From 0 to 31
                    int secondChangeMask = 1 << secondPosition;
                    int exchangeNumber = changeNumber | secondChangeMask;
                    number = exchangeNumber;
                }
                else
                {                                                                //Change bit i to 0
                    byte secondPosition = (byte)bit;                              //From 0 to 31
                    int secondChangeMask = ~(1 << secondPosition);
                    int exchangeNumber = changeNumber & secondChangeMask;
                    number = exchangeNumber;
                }
            }
        }
        Console.Write("The created number is: ");
        Console.WriteLine(number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}