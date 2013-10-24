using System;

class RandomNumbers
{
    static void Main()
    {
        //From the book
        Console.WriteLine("Enter number n");
        string number = Console.ReadLine();
        int integerNumber;                                                          //Could be a big number
        bool isNumber = int.TryParse(number, out integerNumber);                    //Check is the input an integer number
        int[] array = new int[integerNumber];
        if (isNumber)
        {
            for (int position = 0; position < integerNumber; position++)            //Create a array of numbers from 1 to n
            {
                array[position] = position + 1;
            }
        }
        else
        {
            Console.WriteLine("invalid number");
        }
        for (int iteration = 0; iteration < integerNumber; iteration += 2)            //Exchange the numbers in the array (n / 2) times
        {
            Random randomNumber = new Random();
            int firstRandom = randomNumber.Next(iteration, integerNumber);
            int secondRandom = randomNumber.Next(iteration, integerNumber);
            int changeNumber = array[firstRandom];
            array[firstRandom] = array[secondRandom];
            array[secondRandom] = changeNumber;
        }
        Console.WriteLine("The numbers in the interval [1...n] arranged randomly");
        for (int position = 0; position < integerNumber; position++)                  //Print the array with exchanged numbers
        {
            Console.Write("{0} ", array[position]);
        }
    }
}