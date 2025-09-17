/**
 * 
 * */
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}
