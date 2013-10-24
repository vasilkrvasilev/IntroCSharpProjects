using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter the company name");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter the company address");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter the company phone number");
        int companyPhoneNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company fax number");
        int companyFaxNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company web site");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine("Enter the first name of the company manager");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter the last name of the company manager");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter the age of the company manager");
        byte managerAge = byte.Parse(Console.ReadLine());                       //Usually small and positive number
        Console.WriteLine("Enter the phone number of the company manager");
        int managerPhoneNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.Write(new string('-', 80));
        Console.WriteLine();
        Console.WriteLine("{0,25}", companyName);
        Console.Write("Visit us on address: {0} or website: {1}.\r\n", companyAddress, companyWebSite);
        Console.Write("For more information our phone number is: {0:0### ### ###}, or fax: {1:### ### ###}.", 
            companyPhoneNumber, companyFaxNumber);
        Console.WriteLine(" You can find our maneger {0} {1} (age: {2}) on phone number: {3:0### ### ###}", 
            managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        Console.WriteLine("Yours,\r\n\t{0}", companyName);
        Console.Write(new string('-', 80));
    }
}