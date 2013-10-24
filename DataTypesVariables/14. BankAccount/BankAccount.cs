using System;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("Enter the bank name");
        string bankName = Console.ReadLine();
        Console.WriteLine("Enter the holder's first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the holder's middle name");
        string middleName = Console.ReadLine();
        Console.WriteLine("Enter the holder's family name");
        string familyName = Console.ReadLine();
        Console.WriteLine("Enter the IBAN of holder's account");
        string accountIban = Console.ReadLine();                                          //Consists letters
        Console.WriteLine("Enter the BIC of holder's account");
        string accountBic = Console.ReadLine();                                           //Consists letters
        Console.WriteLine("Enter the available amaunt of money in the account");
        decimal availableAmountOfMoney = decimal.Parse(Console.ReadLine());               //decimal is recommended for financial data
        Console.WriteLine("Enter a number of credit card");
        string numberCreditCardOne = Console.ReadLine();                                  //Can consist zero in the beginning or letters
        Console.WriteLine("Enter a number of credit card");
        string numberCreditCardTwo = Console.ReadLine();                                  //Can consist zero in the beginning or letters
        Console.WriteLine("Enter a number of credit card");
        string numberCreditCardThree = Console.ReadLine();                                //Can consist zero in the beginning or letters
        Console.WriteLine(new string('-', 30) +
            "\n\n\nBank: {0}\nName:{1} {2} {3}\nIBAN: {4}, BIC: {5}\nAmount of money: {6}" + 
            "\nCredit card: {7}\nCredit card: {8}\nCredit card: {9}", 
            bankName, firstName, middleName, familyName, accountIban, accountBic, 
            availableAmountOfMoney, numberCreditCardOne, numberCreditCardTwo, numberCreditCardThree);
    }
}