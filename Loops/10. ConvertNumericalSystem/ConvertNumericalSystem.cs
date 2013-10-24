using System;

class ConvertNumericalSystem
{
    static void Main()
    {
        //From the book
        Console.WriteLine("Enter number in decimal numerical system");
        int firstNumber = int.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(firstNumber, 2).PadLeft(32, '0');
        Console.WriteLine("{0} in binary numerical system is equal to {1}", firstNumber, binaryNumber);
        string hexNumber = Convert.ToString(firstNumber, 16);
        Console.WriteLine("{0} in hexademical numerical system is equal to {1}", firstNumber, hexNumber);
        Console.WriteLine("Enter number in binary numerical system");
        string secondNumber = Console.ReadLine();
        int binaryToInteger = Convert.ToInt32(secondNumber, 2);
        Console.WriteLine("{0} in decimal numerical system is equal to {1}", secondNumber, binaryToInteger);
        Console.WriteLine("Enter number in hexademical numerical system");
        string thirdNumber = Console.ReadLine();
        int hexToInteger = Convert.ToInt32(thirdNumber, 16);
        Console.WriteLine("{0} in decimal numerical system is equal to {1}", thirdNumber, hexToInteger);
    }
}