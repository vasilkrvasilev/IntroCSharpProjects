using System;

class CharacterType
{
    static void Main()
    {
        char symbol = '\u0048';
        Console.WriteLine("The Unicode code of latin letter {0} is: {1}.", symbol, (int) symbol);
    }
}