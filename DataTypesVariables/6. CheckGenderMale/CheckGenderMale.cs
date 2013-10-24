using System;

class CheckGenderMale
{
    static void Main()
    {
        //From the book
        Console.WriteLine("Enter your gender (male/female)");
        string gender = Console.ReadLine();              
        string male = "male";
        bool isMale = (gender == male);
        Console.WriteLine("Your gender is male: {0}",isMale);
    }
}