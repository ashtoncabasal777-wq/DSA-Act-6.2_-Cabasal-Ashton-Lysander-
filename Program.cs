
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // DSA Activity 6.2 Cabasal, Ashton Lysander

        Queue<string> deposit = new Queue<string>();
        Queue<string> withdraw = new Queue<string>();
        Queue<string> inquire = new Queue<string>();
        Queue<string> others = new Queue<string>();

        int servedDeposit = 0;
        int servedWithdraw = 0;
        int servedInquire = 0;
        int servedOthers = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to ECO BANK, INC.");
            Console.WriteLine();
            Console.WriteLine("Select your transaction");
            Console.WriteLine("1 - DEPOSIT");
            Console.WriteLine("2 - WITHDRAW");
            Console.WriteLine("3 - INQUIRE");
            Console.WriteLine("4 - OTHERS");
            Console.WriteLine("5 - TELLER / SERVE CLIENT");
            Console.WriteLine("0 - EXIT");
            Console.Write("Enter code: ");

            string choice = Console.ReadLine();

            if (choice == "0")
                break;

            if (choice == "5")
            {
                Console.Write("Enter transaction code (1-4): ");
                string code = Console.ReadLine();

                Console.Write("Enter secret code: ");
                string secret = Console.ReadLine();

                if (secret != "0")
                {
                    Console.WriteLine("Invalid secret code!");
                }
                else
                {
                    if (code == "1" && deposit.Count > 0)
                    {
                        Console.WriteLine("Now serving: " + deposit.Dequeue());
                        servedDeposit++;
                    }
                    else if (code == "2" && withdraw.Count > 0)
                    {
                        Console.WriteLine("Now serving: " + withdraw.Dequeue());
                        servedWithdraw++;
                    }
                    else if (code == "3" && inquire.Count > 0)
                    {
                        Console.WriteLine("Now serving: " + inquire.Dequeue());
                        servedInquire++;
                    }
                    else if (code == "4" && others.Count > 0)
                    {
                        Console.WriteLine("Now serving: " + others.Dequeue());
                        servedOthers++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid code or no clients waiting!");
                    }
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                continue;
            }

            if (choice == "1" || choice == "2" ||
                choice == "3" || choice == "4")
            {
                Console.Write("Enter your account name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty!");
                }
                else
                {
                    if (choice == "1")
                        deposit.Enqueue(name);
                    else if (choice == "2")
                        withdraw.Enqueue(name);
                    else if (choice == "3")
                        inquire.Enqueue(name);
                    else
                        others.Enqueue(name);

                    Console.WriteLine("You have joined the queue!");
                }
            }
            else
            {
                Console.WriteLine("Invalid transaction code!");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        Console.WriteLine("\nThank you for using ECO BANK, INC.");
    }
}
