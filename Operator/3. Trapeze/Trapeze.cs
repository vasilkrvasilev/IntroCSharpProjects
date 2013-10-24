using System;

class Trapeze
{
    static void Main()
    {
        //Task 8 from the presentation
        Console.WriteLine("Enter first side");
        double sideOne = double.Parse(Console.ReadLine());          //Could be not integer number
        Console.WriteLine("Enter second side");
        double sideTwo = double.Parse(Console.ReadLine());          //Could be not integer number
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());           //Could be not integer number
        double trapezeArea = ((sideOne + sideTwo) / 2) * height;
        Console.WriteLine("Trapeze area: {0}", trapezeArea);
    }
}