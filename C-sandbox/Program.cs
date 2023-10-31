// See https://aka.ms/new-console-template for more information
using C_sandbox.Classes;


namespace C_sandbox 
{
    class Program

    {
        static double num2 = 1;
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AddToBalance(100);
            double bankBalance = bankAccount.Balance;

           Console.WriteLine(bankBalance);

            KidsBankAccount kidsBankAccount = new KidsBankAccount();
            kidsBankAccount.AddToBalance(20);

            Console.WriteLine(kidsBankAccount.Balance);

            Console.ReadLine();
        }
    }

    class Math
    {
        public static double Add(double n1, double n2) { return n1 + n2; }
    }
}

