using System;

class EmployeeRecord
{
    static void Main()
    {
        Console.WriteLine("Enter employee first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter employee family name");
        string familyName = Console.ReadLine();
        Console.WriteLine("Enter employee age");
        byte currentAge = byte.Parse(Console.ReadLine());        //Positive and small number
        Console.WriteLine("Enter employee gender (m/f)");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee ID number");
        string idNumber = Console.ReadLine();                    //Can consist zero in the beginning
        Console.WriteLine("Enter employee unique number (from 27560000 to 27569999)");
        int numberEmployee = int.Parse(Console.ReadLine());
        Console.WriteLine(new string ('-', 30) + 
            "\n\n\nName: {0} {1}, Age: {2}\nGender: {3}\nID Number: {4}\nUnique Employee Number: {5}",
            firstName, familyName, currentAge, gender, idNumber, numberEmployee);
    }
}