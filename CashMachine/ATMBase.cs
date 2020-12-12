namespace CashMachine
{
    public abstract class ATMBase
    {
        public abstract int Balance { get; set; }
        public abstract int Deposit(int amount);
        public abstract int Withdraw(int amount);
    }
}