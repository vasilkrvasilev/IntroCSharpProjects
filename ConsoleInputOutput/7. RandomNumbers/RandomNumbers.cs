using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number n");
        int count = int.Parse(Console.ReadLine());
        int[] random = new int[count];                      //First way - generate n random numbers
        Random randomNumber = new Random();
        int sum = 0;
        for (int position = 0; position < count; position++)
        {
            random[position] = randomNumber.Next(1, 999999);
            Console.WriteLine(random[position]);
            sum += random[position];
        }
        Console.WriteLine("The sum of these {0} random numbers is {1:E}", count, sum);
        int[] numbers = new int[count];                      //Second way - read from the console n numbers
        int numbersSum = 0;
        Console.WriteLine("Enter n numbers on different rows");
        for (int position = 0; position < count; position++)
        {
            numbers[position] = int.Parse(Console.ReadLine());
            Console.WriteLine(numbers[position]);
            numbersSum += numbers[position];
        }
        Console.WriteLine("The sum of these {0} random numbers is {1:E}", count, numbersSum);
    }
}