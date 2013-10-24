using System;

class NullableTypes
{
    static void Main()
    {
        int? integerValue = null;
        double? doubleValue = null;
        Console.WriteLine(integerValue);                         //null
        Console.WriteLine(doubleValue);                          //null
        Console.WriteLine(integerValue.GetValueOrDefault());     //default value
        Console.WriteLine(doubleValue.GetValueOrDefault());      //default value
    }
}