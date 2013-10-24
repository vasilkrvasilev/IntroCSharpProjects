using System;

class ValidSum
{
    static void Main()
    {
        //From the book
        int number;                     //Could be a big number
        byte count = 1;                 //From 1 to 5
        int sum = 0;
        while (count <= 5)
        {
            Console.WriteLine("Enter number");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                sum += number;
                count++;
            }
            else
            {
                Console.WriteLine("This number is invalid. Please enter another number.");
            }
        }
        Console.WriteLine("The sum of those five numbers is {0,15:D10}", sum);
    }
}