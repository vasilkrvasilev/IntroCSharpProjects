using System;

class MinMaxNumber
{
    static void Main()
    {
        Console.WriteLine("Enter sequence of numbers divided by space");
        string numbers = Console.ReadLine();
        string[] numbersSequence = numbers.Split(' ');
        byte countNumbers = (byte)numbersSequence.Length;               //Usually small number
        int minNumber = int.Parse(numbersSequence[0]);
        int maxNumber = int.Parse(numbersSequence[0]);
        for (int numberPosition = 1; numberPosition < countNumbers; numberPosition++)
        {
            int currentNumber = int.Parse(numbersSequence[numberPosition]);
            if (currentNumber < minNumber)
            {
                minNumber = currentNumber;
            }
            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
        }
        Console.WriteLine("The min number in the sequence is: {0,10}", minNumber);
        Console.WriteLine("The max number in the sequence is: {0,10}", maxNumber);
    }
}