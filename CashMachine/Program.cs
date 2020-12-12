using System;
namespace CashMachineApplication
{
    public class CashMachine
    {
        public static void Main()
        {
            ATMBase atm = new ATM();
            while (true)
            {
                Console.WriteLine("To deposit money press 1 \nTo withdraw money press 2 \nTo check balance press 3");
                string input = Console.ReadLine();               
                
                    switch (input)
                {
                    case "1":
                        Console.WriteLine("How much money do you want to deposit?");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        atm.Deposit(deposit);
                        break;
                    case "2":
                        Console.WriteLine("How much money do you want to withdraw?");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        atm.Withdraw(withdraw);
                        break;
                    case "3":
                        Console.WriteLine("You currently have {0}$ on your account.", atm.Balance);
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }

        }
    }

}
