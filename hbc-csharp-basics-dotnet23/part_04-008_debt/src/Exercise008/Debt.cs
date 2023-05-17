using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise008
{
    public class Debt
    {
        private double balance;
        private double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(this.balance);

        }

        public void WaitOneYear()
        {
            this.balance *= this.interestRate;

        }
    }
}