using System;

class Heart
{
    static void Main()
    {
        //From the book
        string heart = @"           
                      oo   oo  
                     o  o o  o 
                    o    o    o
                    o         o
                     o       o 
                      o     o  
                       o   o   
                         o     
                                    ";
        Console.WriteLine(new string('-', 50) + "\n{0}\n" + new string('-', 50), heart);
    }
}