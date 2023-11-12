// See https://aka.ms/new-console-template for more information
using C_sandbox.Classes;
using C_sandbox.Interface;

namespace C_sandbox 
{
    class Program

    {
        static double num2 = 1;
        static void Main(string[] args)
        {
            KidsBankAccount bankAccount = new KidsBankAccount();
            bankAccount.AddToBalance(100);
           
            Math basicMath = new Math();

            Console.WriteLine(Information(bankAccount));

            Console.ReadLine();
        }

        private static string Information(IInformation information)
        {
           return information.GetInformation();
        }
    }

    class Math : IInformation
    {
        public static double Add(double n1, double n2) { return n1 + n2; }
        public static double Add(double[] numbers)
        {
            double result = 0;
            foreach (double d in numbers)
            {
                result += d;
            }
            return result;
        }

        public string GetInformation()
        {
            return "Solves Basic Maths";
        }
    }
}

