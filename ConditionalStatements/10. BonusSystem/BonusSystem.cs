using System;

class BonusSystem
{
    static void Main()
    {
        byte integerDigit;                  //From 0 to 9
        short bonus;                        //From 10 to 9000
        Console.WriteLine("Enter digit between 1 and 9");
        string digit = Console.ReadLine();
        bool digitValue = byte.TryParse(digit, out integerDigit);
        if (digitValue)
        {
            switch (integerDigit)
            {
                case 1:
                case 2:
                case 3:
                    bonus = (short)(integerDigit * 10);
                    Console.WriteLine("The bonus scores are {0}", bonus);
                    break;
                case 4:
                case 5:
                case 6:
                    bonus = (short)(integerDigit * 100);
                    Console.WriteLine("The bonus scores are {0}", bonus);
                    break;
                case 7:
                case 8:
                case 9:
                    bonus = (short)(integerDigit * 1000);
                    Console.WriteLine("The bonus scores are {0}", bonus);
                    break;
                default:
                    Console.WriteLine("Invalid digit");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid digit");
        }
    }
}