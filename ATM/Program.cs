using System;

namespace ATM
{
    public class Program
    {
        static public decimal Balance;
        static void Main(string[] args)
        {
            UserInterface();
        }

        private static void UserInterface()
        {
            Console.WriteLine("Welcome to the Bank of Gaming!");
            bool active = true;
            while (active)
            {
                string userInput = Console.ReadLine();
                string[] splitInput = userInput.Split(':');
                string command = splitInput[0];
                decimal amount = 0m;
                try
                {
                    amount = Convert.ToDecimal(splitInput[1]);
                }
                catch (IndexOutOfRangeException e)
                {
                    amount = 0;
                }
                catch (FormatException e)
                {
                    amount = 0;
                }
                switch (command)
                {
                    case "balance":
                        decimal currentBal = ViewBalance();
                        Console.WriteLine($"Current balance: ${currentBal}");
                        break;
                    case "withdraw":
                        decimal amountDrawn = Withdraw(amount);
                        Console.WriteLine($"Withdrew ${amountDrawn} from your balance.");
                        break;
                    case "deposit":
                        decimal amountDeposited = Deposit(amount);
                        Console.WriteLine($"Deposited ${amountDeposited} into your account.");
                        break;
                    case "exit":
                        active = false;
                        break;
                    case "help":
                        Console.WriteLine("balance - Display your current balance.");
                        Console.WriteLine("withdraw:[amount] - Withdraws [amount] from your account.");
                        Console.WriteLine("deposit:[amount] - Deposit [amount] into your account.");
                        Console.WriteLine("help - Displays available commands.");
                        Console.WriteLine("exit - Leaves the App.");
                        break;
                    default:
                        Console.WriteLine("Sorry, I don't understand... try 'help' for a list of commands!");
                        break;
                }
            }
        }

        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                return 0m;
            }
            Balance += amount;

            return amount;
        }

        public static decimal Withdraw(decimal amount)
        {
            if(amount < 0)
            {
                return 0m;
            }
            if (amount > Balance)
            {
                amount = Balance;
                Balance -= amount;
            }
            else if (amount <= Balance)
            {
                Balance -= amount;
            }
            
            return amount;
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }
    }
}
