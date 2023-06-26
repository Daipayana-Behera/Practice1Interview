using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankA bankA = new BankA(100);
            BankB bankB = new BankB(200);
            BankC bankC = new BankC(300);

            decimal balanceA = bankA.GetBalance();
            decimal balanceB = bankB.GetBalance();
            decimal balanceC = bankC.GetBalance();

            Console.WriteLine("BankA balance: $" + balanceA);
            Console.WriteLine("BankB balance: $" + balanceB);
            Console.WriteLine("BankC balance: $" + balanceC);
            Console.ReadLine();
        }
    }

abstract class Bank
    {
        public abstract decimal GetBalance();
    }

    class BankA : Bank
    {
        private decimal balance;

        public BankA(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public override decimal GetBalance()
        {
            return balance;
        }
    }

    class BankB : Bank
    {
        private decimal balance;

        public BankB(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public override decimal GetBalance()
        {
            return balance;
        }
    }

    class BankC : Bank
    {
        private decimal balance;

        public BankC(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public override decimal GetBalance()
        {
            return balance;
        }
    }



}
