using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_24._04._24
{
    internal class BankAcount
    {
        private int id;
        private double balance;
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance 
        {
            get { return balance; }
            set { balance = value; }
        }
        private double deposit;
        private double withdraw;
        public void Deposit(double amount) 
        {
            this.balance+=double.Parse(Console.ReadLine());
        }
        public void Withdraw(double amount) 
        {
            this.balance-=double.Parse(Console.ReadLine());
        }
        public override string ToString() 
        {
            return $"Accont {this.id}, balance {this.balance}";
        }

    }
}
