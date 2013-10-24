using System;

class CheckGenderFemale
{
    static void Main()
    {
        Console.WriteLine("Enter your gender (male/female)");
        string gender = Console.ReadLine();              
        string female = "female";
        bool isFemale = (gender == female);
        Console.WriteLine("Your gender is female: {0}", isFemale);
    }
}