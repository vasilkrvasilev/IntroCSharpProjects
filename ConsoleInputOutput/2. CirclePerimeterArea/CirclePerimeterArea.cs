using System;
using System.Threading;
using System.Globalization;

class CirclePerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter the radius of a circle in cm");
        double radius = double.Parse(Console.ReadLine());               //Could be not integer number
        double diameter = 2 * radius;
        double perimeter = Math.PI * diameter;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The diameter of the circle is {0,10:F2} cm\nThe parimeter of the circle is {1,9:F2} cm",
            diameter, perimeter);
        Console.WriteLine("The area of the circle is {0,14:F2} cm^2", area);
    }
}