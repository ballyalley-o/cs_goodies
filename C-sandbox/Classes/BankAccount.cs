using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sandbox.Classes
{
    public class BankAccount
    {
        private double balance;
        public double Balance
        {
            get
            {
                if (balance < 1000000)
                    return balance;
                return 100000;
            }

            protected set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public BankAccount() 
        {
            // initial value
            Balance = 100;

        }

     
        public double AddToBalance(double balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }
    }

    public class KidsBankAccount : BankAccount
    {
        public KidsBankAccount()
        {
            Balance = 10;
        }
    }
}

