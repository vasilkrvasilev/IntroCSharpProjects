using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        byte integerNumber = byte.Parse(Console.ReadLine());            //From 1 to 19
        Console.WriteLine("\t\tThe Matrix");
        Console.WriteLine(new string('-', integerNumber * 4));
        for (int row = 0; row < integerNumber; row++)
        {
            Console.Write("|");
            for (int column = 1; column <= integerNumber; column++)
            {
                byte member = (byte)(row + column);                     //First member of every row is equal to (1 + row)
                Console.Write("{0,2}| ", member);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', integerNumber * 4));
        }
    }
}