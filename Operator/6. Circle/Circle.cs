using System;

class Circle
{
    static void Main()
    {
        Console.WriteLine("Enter abscissa");
        double abscissa = double.Parse(Console.ReadLine());             //Could be not integer number
        Console.WriteLine("Enter ordinate");
        double ordinate = double.Parse(Console.ReadLine());             //Could be not integer number
        double squaredSum = (abscissa * abscissa) + (ordinate * ordinate);
        double radius = Math.Sqrt(squaredSum);
        bool innerPoint = (radius <= 5);
        Console.WriteLine("The point X({0},{1}) is inner for the circle K(0,5): {2}", abscissa, ordinate, innerPoint);
        bool outAbscissa = ((-1 >= abscissa) && (abscissa >= 5));
        bool outOrdinate = ((1 >= ordinate) && (ordinate >= 5));
        bool outerPoint = (outAbscissa && outOrdinate);
        Console.WriteLine("The point X({0},{1}) is outer for the rectangle R((-1,1)(5,5)): {2}", abscissa, ordinate, outerPoint);
        bool point = (innerPoint && outerPoint);
        Console.WriteLine(
            "The point X({0},{1}) is inner for the circle K(0,5) and is outer for the rectangle R((-1,1)(5,5)): {2}", 
            abscissa, ordinate, point);
    }
}