using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        //(2N)!/N!*(N+1)! = N!*(N+1)*(N+2)*...*(2N-1)*(2N)/N!*N!*(N+1) = (N+2)*...*(2N-1)*(2N)/N!
        Console.WriteLine("Enter number");
        string number = Console.ReadLine();
        int integerNumber;
        bool isNumber = int.TryParse(number, out integerNumber);
        BigInteger catalanNumber = 1;                               //Could be a very big number
        if (isNumber)
        {
            for (int currentNumber = 2; currentNumber <= integerNumber; currentNumber++)
            {
                BigInteger memberNumber = (integerNumber + currentNumber) / currentNumber;
                catalanNumber *= memberNumber;
            }
            Console.WriteLine("The {0}th Catalan number is {1:E10}", integerNumber, catalanNumber);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}