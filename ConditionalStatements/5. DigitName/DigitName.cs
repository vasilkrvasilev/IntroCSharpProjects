using System;

class DigitName
{
    static void Main()
    {
        byte integerDigit;                      //From 0 to 9
        Console.WriteLine("Enter digit");
        string digit = Console.ReadLine();
        bool digitValue = byte.TryParse(digit, out integerDigit);
        Console.WriteLine("This digit in written form is:");
        if (digitValue)
        {
            switch (integerDigit)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 0:
                    Console.WriteLine("Zero");
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