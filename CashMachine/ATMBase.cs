namespace CashMachine
{
    public abstract class ATMBase
    {
        protected abstract int Balance { get; set; }
        public abstract void Deposit(int amount);
        public abstract int Withdraw(int amount);
    }
}