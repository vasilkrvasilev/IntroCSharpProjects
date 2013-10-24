using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Enter width");
        double width = double.Parse(Console.ReadLine());                  //Could be not integer number
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());                 //Could be not integer number
        double rectangleArea = width * height;
        double rectanglePerimeter = 2 * (width + height);
        Console.WriteLine("Rectangle area: {0}\nRectangle perimeter: {1}", rectangleArea, rectanglePerimeter);
    }
}