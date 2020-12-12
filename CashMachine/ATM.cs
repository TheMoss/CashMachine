using System;

namespace CashMachineApplication
{
    public class ATM : ATMBase
    {
        private int balance;
        public override int Balance 
        {
            get { return balance; }
            set { balance = value; }
        }
        public override int  Deposit(int amount)
        {
           return balance += amount;
        }
        public override int Withdraw(int amount)
        {            
            return balance -= amount;
        }
        
    }
}   
