using BankEx;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using static BankEx.Constants;



class Program
{


    static void Main(string[] args)
    {

        while (true)
        {
            MainMenuDisplay.DisplayMenu(BankEx.Constants.MenuType.Main);
            int choice = MainMenuDisplay.MenuChoice();

            switch (choice)
            {
                case 1:
                    Account.AccountMenu();

                    break;
                case 2:
                    Customer.CustomerMenu();

                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


