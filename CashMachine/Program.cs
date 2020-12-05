    using System;
    namespace CashMachineApplication
    {
        class CashMachine
        {
            public static void Main()
            {
                var balance = 0;

                 int DepositMoney()
                {
                    Console.WriteLine("How much money do you want to deposit?");
                    var deposit = Convert.ToInt32(Console.ReadLine());
                   return balance += deposit;
                }

                 int WithdrawMoney()
                {
                    Console.WriteLine("How much money do you want to withdraw?");
                    var withdraw = Convert.ToInt32(Console.ReadLine());
                    return balance -= withdraw;
                }

                 void CheckBalance()
                {
                    Console.WriteLine("Your account's balance is: {0}$", balance);
                }
                Console.WriteLine("To deposit money press 1 \n To withdraw money press 2 \n To check balance press 3");
    
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1" :
                    DepositMoney();
                        break;
                    case "2":
                    WithdrawMoney();
                        break;
                    case "3":
                    CheckBalance();
                        break;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }

        }
    }
