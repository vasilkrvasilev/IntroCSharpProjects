using System;

class StringObjectTypes
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object titleOne = firstWord + " " + secondWord;
        Console.WriteLine(titleOne);
        Console.WriteLine(titleOne.ToString());
        string titleTwo = (string) titleOne;
        Console.WriteLine(titleTwo);
        string titleThree = Convert.ToString(titleOne);
        Console.WriteLine(titleThree);
    }
}