using System;

class NumbersVerbally
{
    static void Ones(int thirdDigit)                //Express the third digit of the number in written form (after ....ty)
    {
        switch (thirdDigit)
        {
            case 0:
                Console.WriteLine("");
                break;
            case 1:
                Console.WriteLine("-one");
                break;
            case 2:
                Console.WriteLine("-two");
                break;
            case 3:
                Console.WriteLine("-three");
                break;
            case 4:
                Console.WriteLine("-four");
                break;
            case 5:
                Console.WriteLine("-five");
                break;
            case 6:
                Console.WriteLine("-six");
                break;
            case 7:
                Console.WriteLine("-seven");
                break;
            case 8:
                Console.WriteLine("-eight");
                break;
            case 9:
                Console.WriteLine("-nine");
                break;
        }
    }

    static void HundredAndOne(int thirdDigit)                //Express the third digit of the number in written form (after hundred)
    {
        switch (thirdDigit)
        {
            case 0:
                Console.WriteLine("");
                break;
            case 1:
                Console.WriteLine("and one");
                break;
            case 2:
                Console.WriteLine("and two");
                break;
            case 3:
                Console.WriteLine("and three");
                break;
            case 4:
                Console.WriteLine("and four");
                break;
            case 5:
                Console.WriteLine("and five");
                break;
            case 6:
                Console.WriteLine("and six");
                break;
            case 7:
                Console.WriteLine("and seven");
                break;
            case 8:
                Console.WriteLine("and eight");
                break;
            case 9:
                Console.WriteLine("and nine");
                break;
        }
    }

    static void HundredAndTen(int thirdDigit)                  //Express the third digit of the number in written form (after hundred)
    {
        switch (thirdDigit)
        {
            case 0:
                Console.WriteLine("and ten");
                break;
            case 1:
                Console.WriteLine("and eleven");
                break;
            case 2:
                Console.WriteLine("and twelve");
                break;
            case 3:
                Console.WriteLine("and thirteen");
                break;
            case 4:
                Console.WriteLine("and fourteen");
                break;
            case 5:
                Console.WriteLine("and fifteen");
                break;
            case 6:
                Console.WriteLine("and sixteen");
                break;
            case 7:
                Console.WriteLine("and seventeen");
                break;
            case 8:
                Console.WriteLine("and eighteen");
                break;
            case 9:
                Console.WriteLine("and nineteen");
                break;
        }
    }

    static void Tens(int secondDigit, int thirdDigit)           //Express the second digit of the number in written form (after hundred)
    {
        switch (secondDigit)
        {
            case 0:
                HundredAndOne(thirdDigit);
                break;
            case 1:
                HundredAndTen(thirdDigit);
                break;
            case 2:
                Console.Write("and twenty");
                Ones(thirdDigit);
                break;
            case 3:
                Console.Write("and thirty");
                Ones(thirdDigit);
                break;
            case 4:
                Console.Write("and forty");
                Ones(thirdDigit);
                break;
            case 5:
                Console.Write("and fifty");
                Ones(thirdDigit);
                break;
            case 6:
                Console.Write("and sixty");
                Ones(thirdDigit);
                break;
            case 7:
                Console.Write("and seventy");
                Ones(thirdDigit);
                break;
            case 8:
                Console.Write("and eighty");
                Ones(thirdDigit);
                break;
            case 9:
                Console.Write("and ninety");
                Ones(thirdDigit);
                break;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number between 0 and 999");
        short number = short.Parse(Console.ReadLine());                                 //From 0 to 999
        byte thirdDigit = (byte)(number % 10);                                          //From 0 to 9
        byte secondDigit = (byte)(((number - thirdDigit) % 100) / 10);                  //From 0 to 9
        byte firstDigit = (byte)((number - thirdDigit - (secondDigit * 10)) / 100);     //From 0 to 9
        switch (firstDigit)
        {
            case 0:
                switch (secondDigit)
                {
                    case 0:
                        switch (thirdDigit)
                        {
                            case 0:
                                Console.WriteLine("Zero");
                                break;
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
                        }
                        break;
                    case 1:
                        switch (thirdDigit)
                        {
                            case 0:
                                Console.WriteLine("Ten");
                                break;
                            case 1:
                                Console.WriteLine("Eleven");
                                break;
                            case 2:
                                Console.WriteLine("Twelve");
                                break;
                            case 3:
                                Console.WriteLine("Thirteen");
                                break;
                            case 4:
                                Console.WriteLine("Fourteen");
                                break;
                            case 5:
                                Console.WriteLine("Fifteen");
                                break;
                            case 6:
                                Console.WriteLine("Sixteen");
                                break;
                            case 7:
                                Console.WriteLine("Seventeen");
                                break;
                            case 8:
                                Console.WriteLine("Eighteen");
                                break;
                            case 9:
                                Console.WriteLine("Nineteen");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Twenty");
                        Ones(thirdDigit);
                        break;
                    case 3:
                        Console.Write("Thirty");
                        Ones(thirdDigit);
                        break;
                    case 4:
                        Console.Write("Forty");
                        Ones(thirdDigit);
                        break;
                    case 5:
                        Console.Write("Fifty");
                        Ones(thirdDigit);
                        break;
                    case 6:
                        Console.Write("Sixty");
                        Ones(thirdDigit);
                        break;
                    case 7:
                        Console.Write("Seventy");
                        Ones(thirdDigit);
                        break;
                    case 8:
                        Console.Write("Eighty");
                        Ones(thirdDigit);
                        break;
                    case 9:
                        Console.Write("Ninety");
                        Ones(thirdDigit);
                        break;
                }
                break;
            case 1:
                Console.Write("One hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 2:
                Console.Write("Two hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 3:
                Console.Write("Three hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 4:
                Console.Write("Four hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 5:
                Console.Write("Five hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 6:
                Console.Write("Six hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 7:
                Console.Write("Seven hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 8:
                Console.Write("Eight hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            case 9:
                Console.Write("Nine hundred ");
                Tens(secondDigit, thirdDigit);
                break;
            default:
                Console.WriteLine("invalid number");
                break;
        }
    }
}