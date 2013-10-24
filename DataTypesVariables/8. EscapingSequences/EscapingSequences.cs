using System;

class EscapingSequences
{
    static void Main()
    {
        string withQuotedStrings = "The \"use\" of quotations causes difficulties.";
        string withoutQuotedStrings = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("with quoted strings:\n\t{0}\nwithout quoted strings:\n\t{1}", 
            withQuotedStrings, withoutQuotedStrings);
    }
}