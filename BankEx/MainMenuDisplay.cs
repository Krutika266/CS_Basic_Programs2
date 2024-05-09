using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEx
{
    internal class MainMenuDisplay
    {
        public static void DisplayMenu(Constants.MenuType menuType)
        {
            switch (menuType)
            {
                case Constants.MenuType.Main:
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("1. Account");
                    Console.WriteLine("2. Customer");
                    break;
                case Constants.MenuType.Account:
                    Console.WriteLine("Account Menu");
                    Console.WriteLine("1. Create");
                    Console.WriteLine("2. View All");
                    Console.WriteLine("3. View By Id");
                    Console.WriteLine("4. Credit Amount");
                    Console.WriteLine("5. Debit Amount");
                    break;
                case Constants.MenuType.Customer:
                    Console.WriteLine("Customer Menu");
                    Console.WriteLine("1. Create");
                    Console.WriteLine("2. View All");
                    Console.WriteLine("3. View By Id");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Enter your choice: ");
        }

        public static int MenuChoice()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }

}

