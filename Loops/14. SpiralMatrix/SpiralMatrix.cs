using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        byte integerNumber = byte.Parse(Console.ReadLine());                      //From 1 to 19
        Console.WriteLine("\t\tThe Spiral Matrix\n\r");
        ushort[,] matrix = new ushort[integerNumber, integerNumber];              //From 1 to 361
        ushort value = 1;                                                         //From 1 to 361
        byte loop = 1;                                                            //Loop is equal to the 4 sides of the matrix 
        for (int position = 0; position < integerNumber; position++)              //Fill the first row of the matrix
        {
            matrix[0, position] = value;
            value++;
        }
        while (value <= (integerNumber * integerNumber))                           //Fill the rest of the matrix
        {
            for (int row = loop; row <= integerNumber - loop; row++)               //First side - right side
            {
                matrix[row, integerNumber - loop] = value;
                value++;
            }
            for (int column = integerNumber - loop; column >= loop; column--)      //Second side - bottom side
            {
                matrix[integerNumber - loop, column - 1] = value;
                value++;
            }
            for (int row = integerNumber - loop - 1; row >= loop; row--)           //Third side - left side
            {
                matrix[row, loop - 1] = value;
                value++;
            }
            for (int column = loop; column <= integerNumber - loop - 1; column++)   //Fourth side - top side
            {
                matrix[loop, column] = value;
                value++;
            }
            loop++;
        }
        for (int row = 0; row < integerNumber; row++)                               //Print the matrix
        {
            for (int column = 0; column < integerNumber; column++)
            {
                Console.Write("{0,3} ", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}