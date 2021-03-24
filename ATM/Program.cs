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
                decimal amount;
                try
                {
                    amount = Convert.ToDecimal(splitInput[1]);
                }
                catch (IndexOutOfRangeException e)
                {
                    command = null;
                }
                switch (command)
                {
                    case "balance":
                        decimal currentBal = ViewBalance();
                        Console.WriteLine($"Current balance: ${currentBal}");
                        break;
                    case "withdraw":
                        break;
                    case "deposit":
                        break;
                    case "help":
                        Console.WriteLine("balance - Display your current balance.");
                        Console.WriteLine("withdraw:[amount] - Withdraws [amount] from your account.");
                        Console.WriteLine("deposit:[amount] - Deposit [amount] into your account.");
                        Console.WriteLine("help - Displays available commands");
                        break;
                    default:
                        Console.WriteLine("Sorry, I don't understand... try 'help' for a list of commands!");
                        break;
                }
            }
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }
    }
}
