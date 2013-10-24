using System;

class ExchangeBit
{
    static void Main()
    {
        //Based on 14. ExchangeRandomBit
        Console.WriteLine("This program exchange 3, 4, 5 and 24, 25, 26 bit of the number\nEnter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        byte firstBeginningPosition = 3;
        byte distance = 21;
        byte range = 3;
        for (int bit = firstBeginningPosition; bit <= (firstBeginningPosition + range); bit++)
        {
            int firstMask = 1 << bit;
            int firstMaskNumber = number & firstMask;
            byte firstBitValue = (byte)(firstMaskNumber >> bit);                  //0 or 1
            int secondMask = 1 << (bit + distance);
            int secondMaskNumber = number & firstMask;
            byte secondBitValue = (byte)(firstMaskNumber >> (bit + distance));    //0 or 1
            if (firstBitValue == 1)
            {                                                                     //Change bit (i + 21) to 1
                byte firstPsition = (byte)(bit + distance);                       //From 0 to 31
                int firstChangeMask = 1 << firstPsition;
                int changeNumber = number | firstChangeMask;
                if (secondBitValue == 1)
                {                                                                  //Change bit i to 1
                    byte secondPosition = (byte)bit;                               //From 0 to 31
                    int secondChangeMask = 1 << secondPosition;
                    int exchangeNumber = changeNumber | secondChangeMask;
                    number = exchangeNumber;
                }
                else
                {                                                                  //Change bit i to 0
                    byte secondPosition = (byte)bit;                               //From 0 to 31
                    int secondChangeMask = ~(1 << secondPosition);
                    int exchangeNumber = changeNumber & secondChangeMask;
                    number = exchangeNumber;
                }
            }
            else
            {                                                                      //Change bit (i + 21) to 0
                byte firstPsition = (byte)(bit + distance);                        //From 0 to 31
                int firstChangeMask = ~(1 << firstPsition);
                int changeNumber = number & firstChangeMask;
                if (secondBitValue == 1)
                {                                                                  //Change bit i to 1
                    byte secondPosition = (byte)bit;                               //From 0 to 31
                    int secondChangeMask = 1 << secondPosition;
                    int exchangeNumber = changeNumber | secondChangeMask;
                    number = exchangeNumber;
                }
                else
                {                                                                  //Change bit i to 0
                    byte secondPosition = (byte)bit;                               //From 0 to 31
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