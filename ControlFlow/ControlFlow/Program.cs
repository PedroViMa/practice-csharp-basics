using System;
using System.Text;

namespace ControlFlow
{
    internal class Program
    {
        enum mainMenu
        {
            Balance = 1,
            Deposit = 2,
            Withdraw = 3,
            Exit = 4
        }

        static int balance = 0;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================")
                .AppendLine("========== ATM ==========")
                .AppendLine("=========================");

            while(true)
            {
                Console.WriteLine(sb.ToString());
                mainMenu opt = MainMenu();

                switch (opt)
                {
                    case mainMenu.Balance:
                        ShowBalance();
                        break;
                    case mainMenu.Deposit:
                        Deposit();
                        break;
                    case mainMenu.Withdraw:
                        Withdraw();
                        break;
                    case mainMenu.Exit:
                        return;
                }
            }
                    
        }
        
        static void ShowBalance ()
        {
            Console.WriteLine("You have {0}", balance.ToString("C"));
        }

        static void Deposit ()
        {
            Console.Write("Enter the amount to deposit (make sure is a number): ");
            balance += Convert.ToInt32(Console.ReadLine());
        }

        static void Withdraw ()
        {
            Console.Write("Enter the amount to withdraw (make sure is a number): ");
            int withdraw = Convert.ToInt32(Console.ReadLine());

            if (withdraw > balance)
            {
                Console.WriteLine("You don't have the enough money to withdraw.");
                return;
            }

            balance -= withdraw;
        }

        static mainMenu MainMenu () 
        {
            string opt;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Check Balance")
                .AppendLine("2. Deposit")
                .AppendLine("3. Withdraw")
                .AppendLine("4. Exit");
            Console.WriteLine(sb.ToString());
            do
            {
                Console.Write("Select an option (1-4): ");
                opt = Console.ReadLine();
            } while (String.IsNullOrEmpty(opt) || Convert.ToInt32(opt) < 1 || Convert.ToInt32(opt) > 4);

            return (mainMenu)Convert.ToInt32(opt);
        }
    }
}
