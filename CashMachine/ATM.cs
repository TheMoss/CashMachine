using System;

namespace CashMachineApplication
{
    public class ATM : ATMBase
    {
        private int _balance;
        public override int Balance 
        {
            get; set;
        }
        public override int  Deposit(int amount)
        {
           return _balance += amount;
        }
        public override int Withdraw(int amount)
        {            
           return _balance -= amount;
           
        }       
    }
}   
