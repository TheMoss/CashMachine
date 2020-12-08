using System;

namespace CashMachine
{
    class ATMActions : ATMBase
    {
        private int balance;
        protected override int Balance 
        {
            get { return balance; }
            set { balance = value; }
        }
        public override void Deposit(int amount)
        {
            Console.WriteLine("How much money do you want to deposit?");
            amount = Convert.ToInt32(Console.ReadLine());
            balance += amount;
        }
        public override int Withdraw(int amount)
        {
            Console.WriteLine("How much money do you want to withdraw?");
            amount = Convert.ToInt32(Console.ReadLine());
            return balance -= amount;
        }

        public void Menu()
        {
            Console.WriteLine("To deposit money press 1 \n To withdraw money press 2 \n To check balance press 3");
            string input = Console.ReadLine();
            ATMActions menu = new ATMActions();
            switch (input)
            {
                case "1":
                    Deposit();
                    break;
                case "2":
                    Withdraw();
                    break;
                case "3":
                    Balance();
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            Menu();
        }

    }
}   
