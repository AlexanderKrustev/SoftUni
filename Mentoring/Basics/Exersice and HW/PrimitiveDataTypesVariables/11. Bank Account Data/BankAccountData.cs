using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class BankAccountData
    {
        static void Main()
        {
        string firstName = "John";
        string middleName = "David";
        string lastName = "Joe";
        decimal balance = 273000m;
        string bankName = "Bank Name ";
        string IBAN = "BG 1254 55884 554446";
        string cardNumber1 = "1452-3658-9854-7720";
        string cardNumber2 = "6582-9874-6358-5445";
        string cardNumber3 = "5874-1478-9512-3574";
        Console.WriteLine("Card Holder Name: {0} {1} {2}",firstName,middleName,lastName);
        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("IBAN: {0}",IBAN);
        Console.WriteLine("Balance: {0}",balance);
        Console.WriteLine("Card Numbers: {0}{1}{2}{3}{4}{5}",Environment.NewLine, cardNumber1,Environment.NewLine,cardNumber2,Environment.NewLine,cardNumber3);
    }
    }

