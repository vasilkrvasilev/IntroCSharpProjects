using System;

class MyAge
{
    static void Main()
    {
        byte myAge;                                                                  //Positive and usualy a small number
        Console.WriteLine("Enter your age");
        myAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("After ten years you gonna be {0} years old", myAge + 10);
    }
}