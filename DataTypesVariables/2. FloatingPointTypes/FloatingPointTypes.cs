using System;

class FloatingPointTypes
{
    static void Main()
    {
        double firstNumber = 34.567839023;                                  //More than 7 digits
        float secondNumner = 12.345f;
        double thirdNumber = 8923.1234867;                                  //More than 7 digits
        float fourthNumber = 3456.091f;
        decimal fifthNumber = 3456.091124875956542151256683467m;            //More than 16 digits
        Console.WriteLine("doube: {0}\nfloat: {1}\ndoube: {2}\nfloat: {3}\ndecimal: {4}",
            firstNumber, secondNumner, thirdNumber, fourthNumber, fifthNumber);
        /*
        float sixthNumber = 3456.091124875956542151256683467f;
        double seventhNumber = 3456.091124875956542151256683467;
        Console.WriteLine(sixthNumber);                              //Returns 3456.091124875956542151256683467m as float
        Console.WriteLine(seventhNumber);                            //Returns 3456.091124875956542151256683467m as double
         */
    }
}