using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Ivailo";
            string middleName = "Cvetanov";
            string lastName = "Bojkov";
            string holderName = firstName + " " + middleName + " " + lastName;
            int balance = 1200;
            string bankName = "Unicredit";
            string iban = "BG190231209UNCR";
            long creditCard1 = 0931239012903;
            long CreditCard2 = 3929412398139;
            long CreditCard3 = 0318091293080;
            Console.WriteLine("Holder Name: {0}", holderName);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("Bank Name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Credit Cards: {0}, {1}, {2}", creditCard1, CreditCard2, CreditCard3); 
     
        }
    }
