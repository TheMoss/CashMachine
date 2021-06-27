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
                        if (atm.Balance < 0)
                        {
                            Console.WriteLine("There isn't enough money to do this.");
                        }
                        else
                        {
                            int hundred = withdraw / 100;
                            int fifty = (withdraw - (hundred * 100)) / 50;
                            int twenty = (withdraw - (hundred * 100 + fifty * 50)) / 20;
                            int ten = (withdraw - (hundred * 100 + fifty * 50 + twenty * 20)) / 10;
                            int one = (withdraw - (hundred * 100 + fifty * 50 + twenty * 20 + ten * 10));
                            Console.WriteLine("You'll be given the following bills: ${0} x 100, ${1} x 50, ${2} x 20, ${3} x 10, ${4} x 1", hundred, fifty, twenty, ten, one);
                        };
                        break;
                    case "3":
                        Console.WriteLine("You currently have ${0} on your account.", atm.Balance);
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }      
        }
    }

}
