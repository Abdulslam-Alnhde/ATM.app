using System;

namespace ATMSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 1000;

            Console.WriteLine("Welcome to the ATM Simulator!");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice : ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Your current balance is: {balance} units");
                        break;

                    case "2":
                        Console.Write("Enter the amount to withdraw: ");
                        int withdrawAmount = int.Parse(Console.ReadLine());

                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient balance!");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"Successfully withdrew {withdrawAmount} units");
                            Console.WriteLine($"Your updated balance is: {balance} units");
                        }

                        break;

                    case "3":
                        Console.Write("Enter the amount to deposit: ");
                        int depositAmount = int.Parse(Console.ReadLine());

                        balance += depositAmount;
                        Console.WriteLine($"Successfully deposited {depositAmount} units");
                        Console.WriteLine($"Your updated balance is: {balance} units");

                        break;

                    case "4":
                        Console.WriteLine("Thank you for using the ATM Simulator. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}