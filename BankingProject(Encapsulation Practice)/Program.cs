using System;

namespace BankingProject_Encapsulation_Practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Bryce = new BankAccount();

            Bryce.Deposit(9400);
            Console.WriteLine(Bryce.GetBalance());
            Console.WriteLine("Bryce returns to withdraw a large sum of Cash to pay for a New Engineblock for his car, Certainly not happy.");
            Bryce.Withdraw(7500);
            Console.WriteLine(Bryce.GetBalance());
          
        }
    }
}
