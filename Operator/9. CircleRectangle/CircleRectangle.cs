using System;

class CircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter abscissa");
        double abscissa = double.Parse(Console.ReadLine());       //Could be not integer number
        Console.WriteLine("Enter ordinate");
        double ordinate = double.Parse(Console.ReadLine());       //Could be not integer number
        double squaredSum = ((abscissa - 1) * (abscissa - 1)) + ((ordinate - 1) * (ordinate - 1));
        double radius = Math.Sqrt(squaredSum);
        bool innerPoint = (radius <= 3);
        Console.WriteLine("The point X({0},{1}) is inner for the circle K((1,1),3): {2}", abscissa, ordinate, innerPoint);
        bool outAbscissa = ((1 >= abscissa) && (abscissa >= 7));
        bool outOrdinate = ((-3 >= ordinate) && (ordinate >= -1));
        bool outerPoint = (outAbscissa && outOrdinate);
        Console.WriteLine("The point X({0},{1}) is outer for the rectangle R((1,-1)(7,-3)): {2}", abscissa, ordinate, outerPoint);
        bool point = (innerPoint && outerPoint);
        Console.WriteLine(
            "The point X({0},{1}) is inner for the circle K((1,1),3) and is outer for the rectangle R((1,-1)(7,-3)): {2}",
            abscissa, ordinate, point);
    }
}