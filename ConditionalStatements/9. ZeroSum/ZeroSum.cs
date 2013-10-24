using System;

class ZeroSum
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers on different rows");
        Console.WriteLine("This program chackes if the sum of some subset of them is 0");
        int members = 5;
        int[] numbers = new int[members];
        for (int currentNumber = 0; currentNumber < members; currentNumber++)
        {
            numbers[currentNumber] = int.Parse(Console.ReadLine());
        }
        int subsets = 0;
        int sum = 0;
        int maxSubsets = (int)Math.Pow(2, members) - 1;
        for (int currentSubset = 1; currentSubset <= maxSubsets; currentSubset++)
        {
            int currentSum = 0;
            for (int bitPosition = 0; bitPosition < members; bitPosition++)
            {
                if (((currentSubset >> bitPosition) & 1) == 1)
                {
                    if (bitPosition == 0) 
                    {
                        currentSum += numbers[bitPosition];
                    }
                    if (bitPosition == 1) 
                    {
                        currentSum += numbers[bitPosition];
                    }
                    if (bitPosition == 2) 
                    {
                        currentSum += numbers[bitPosition];
                    }
                    if (bitPosition == 3) 
                    {
                        currentSum += numbers[bitPosition];
                    }
                    if (bitPosition == 4) 
                    {
                        currentSum += numbers[bitPosition];
                    }
                }
            }
            if (currentSum == sum) subsets++;
        }
        if (subsets != 0)
        {
            Console.WriteLine("There are such subsets.\n\rThe numbers of the subsets is {0,10}", subsets);
        }
        else
        {
            Console.WriteLine("There is no such subset");
        }
    }
}

        /*
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree = int.Parse(Console.ReadLine());
        int numberFour = int.Parse(Console.ReadLine());
        int numberFive = int.Parse(Console.ReadLine());
        int[] numbers = { numberOne, numberTwo, numberThree, numberFour, numberFive };
        byte positiveRank = 0;                    //From 0 to 5
        byte negativeRank = 0;                    //From 0 to 5
        int[] positive = new int[5];
        int[] negative = new int[5];
        int[] negativeSum;
        int[] positiveSum;
        bool zeroSum = false;
        byte subsets = 0;
        for (byte currentNumber = 0; currentNumber <= 4; currentNumber++)        //Check for zeros
        {
            if (numbers[currentNumber] == 0)
            {
                zeroSum = true;                   //Find a subset
                subsets++;
            }
        }
        for (byte currentNumber = 0; currentNumber <= 4; currentNumber++)        //Divide the numbers as positive or negative
        {
            if (numbers[currentNumber] >= 0)
            {
                positive[positiveRank] = numbers[currentNumber];
                positiveRank++;
            }
            else
            {
                negative[negativeRank] = numbers[currentNumber];
                negativeRank++;
            }
        }
        switch (negativeRank)
        {
            case 1:                             //If there is one negative number there are 1 posible negative subset and 14 positive
                negativeSum = new int[1] { negative[0] };
                positiveSum = new int[14] { positive[0], positive[1], positive[2], positive[3], positive[0] + positive[1], 
                    positive[0] + positive[2], positive[0] + positive[3] ,positive[1] + positive[2], positive[1] + positive[3], 
                    positive[2] + positive[3], positive[0] + positive[1] + positive[2], positive[0] + positive[1] + positive[3], 
                    positive[0] + positive[2] + positive[3], positive[0] + positive[1] + positive[2] + positive[3] };
                for (byte negativeNumber = 0; negativeNumber < negativeSum.Length; negativeNumber++)
                {
                    for (byte positiveNumber = 0; positiveNumber < positiveSum.Length; positiveNumber++)
                    {
                        if (negativeSum[negativeNumber] + positiveSum[positiveNumber] == 0)
                        {
                            zeroSum = true;     //Find a subset
                            subsets++;
                        }
                    }
                }
                break;
            case 2:                             //If there is one negative number there are 3 posible negative subset and 7 positive
                negativeSum = new int[3] { negative[0], negative[1], negative[0] + negative[1] };
                positiveSum = new int[7] { positive[0], positive[1], positive[2], positive[0] + positive[1], positive[0] + positive[2], 
                    positive[1] + positive[2], positive[0] + positive[1] + positive[2] };
                for (byte negativeNumber = 0; negativeNumber < negativeSum.Length; negativeNumber++)
                {
                    for (byte positiveNumber = 0; positiveNumber < positiveSum.Length; positiveNumber++)
                    {
                        if (negativeSum[negativeNumber] + positiveSum[positiveNumber] == 0)
                        {
                            zeroSum = true;     //Find a subset
                            subsets++;
                        }
                    }
                }
                break;
            case 3:                             //If there is one negative number there are 7 posible negative subset and 3 positive
                negativeSum = new int[7] { negative[0], negative[1], negative[2], negative[0] + negative[1], negative[0] + negative[2], 
                    negative[1] + negative[2], negative[0] + negative[1] + negative[2] };
                positiveSum = new int[3] { positive[0], positive[1], positive[0] + positive[1] };
                for (byte negativeNumber = 0; negativeNumber < negativeSum.Length; negativeNumber++)
                {
                    for (byte positiveNumber = 0; positiveNumber < positiveSum.Length; positiveNumber++)
                    {
                        if (negativeSum[negativeNumber] + positiveSum[positiveNumber] == 0)
                        {
                            zeroSum = true;     //Find a subset
                            subsets++;
                        }
                    }
                }
                break;
            case 4:                             //If there is one negative number there are 14 posible negative subset and 1 positive
                negativeSum = new int[14] { negative[0], negative[1], negative[2], negative[3], negative[0] + negative[1], 
                    negative[0] + negative[2], negative[0] + negative[3] ,negative[1] + negative[2], negative[1] + negative[3], 
                    negative[2] + negative[3], negative[0] + negative[1] + negative[2], negative[0] + negative[1] + negative[3], 
                    negative[0] + negative[2] + negative[3], negative[0] + negative[1] + negative[2] + negative[3] };
                positiveSum = new int[1] { positive[0] };
                for (byte negativeNumber = 0; negativeNumber < negativeSum.Length; negativeNumber++)
                {
                    for (byte positiveNumber = 0; positiveNumber < positiveSum.Length; positiveNumber++)
                    {
                        if (negativeSum[negativeNumber] + positiveSum[positiveNumber] == 0)
                        {
                            zeroSum = true;     //Find a subset
                            subsets++;
                        }
                    }
                }
                break;
        }
        if (zeroSum)
        {
            Console.WriteLine("There are such subsets.\n\rThe numbers of the subsets is {0,10}", subsets);
        }
        else
        {
            Console.WriteLine("There is no such subset");
        }
         */