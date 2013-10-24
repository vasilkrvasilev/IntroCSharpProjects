using System;
using System.Threading;
using System.Globalization;

class SwitchStatement
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter variable");
        string variable = Console.ReadLine();
        int number;
        double doubleNumber;
        bool isNumber = int.TryParse(variable, out number);
        bool isDoubleNumber = double.TryParse(variable, out doubleNumber);
        string result;
        if (isNumber)
        {
            result = "Integer";
        }
        else if (isDoubleNumber)
        {
            result = "Floating-Point";
        }
        else
        {
            result = "Text";
        }
        switch (result)
        {
            case "Integer":
                Console.WriteLine(number + 1);
                break;
            case "Floating-Point":
                Console.WriteLine(doubleNumber + 1);
                break;
            case "Text":
                Console.WriteLine("{0}*", variable);
                break;
        }

    }
}