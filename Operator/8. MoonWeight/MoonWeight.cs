using System;

class MoonWeight
{
    static void Main()
    {
        //From the book
        Console.WriteLine("Enter your weight on Earth");
        double weight = double.Parse(Console.ReadLine());       //Could be not integer number
        Console.WriteLine("Enter mesure");
        string mesure = Console.ReadLine();
        float moonGravitation = 0.17f;
        double moonWeight = weight * moonGravitation;
        Console.WriteLine("Your weight on Moon is {0} {1}", moonWeight, mesure);
    }
}