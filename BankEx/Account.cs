using System;
using System.Collections.Generic;
using static BankEx.Constants;

namespace BankEx
{
    internal class Account
    {
        private static List<AccountModel> accounts = new List<AccountModel>();

        public static List<AccountModel> GetAccounts()
        {
            return accounts;
        }
        const decimal MinimumInitialBalance = 500;

        public static void AccountMenu()
        {
            MainMenuDisplay.DisplayMenu(Constants.MenuType.Account);
            int choice = MainMenuDisplay.MenuChoice();

            switch (choice)
            {
                case (int)Options.Create:
                    CreateAccount();
                    break;
                case (int)Options.ViewAll:
                    ViewAllAccounts();
                    break;
                case (int)Options.VewById:
                    ViewAccountById();
                    break;
                case (int)AccountOptions.credit:
                    CreditAmount();
                    break;
                case (int)AccountOptions.debit:
                    DebitAmount();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        public static void CreateAccount()
        {
            Console.WriteLine("Account Creation:");
            Console.WriteLine("A/C Type (1 for Saving, 2 for Salary, 3 for current): ");
            int typeInt = Convert.ToInt32(Console.ReadLine());
            if (!Enum.IsDefined(typeof(Constants.AccountType), typeInt))
            {
                Console.WriteLine("Invalid account type.");
                return;
            }
            Constants.AccountType type = (Constants.AccountType)typeInt;

            Console.WriteLine("Customer Id: ");
            string customerId = Console.ReadLine();
            Console.WriteLine("Initial Balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            if (balance < MinimumInitialBalance)
            {
                Console.WriteLine($"Initial balance should be at least {MinimumInitialBalance} Rs.");
                return;
            }


            List<CustomerModel> customers = Customer.GetCustomers();
            CustomerModel customer = customers.Find(c => c.Id == customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer does not exist.");
                return;
            }

            string accountId = Guid.NewGuid().ToString();

            AccountModel account = new AccountModel(accountId, type, customerId, customer.Name, balance);
            accounts.Add(account);

            Console.WriteLine("Account created successfully.");
        }


        static void ViewAllAccounts()
        {
            Console.WriteLine("All Accounts details:");
            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.AccountNumber} | {account.Typee} | {account.CustomerId} | {account.Name} | {account.Balance}");
            }
        }

        static void ViewAccountById()
        {
            Console.WriteLine("Enter the A/C No: ");
            string accountId = Console.ReadLine();

            AccountModel account = accounts.Find(a => a.AccountNumber == accountId);
            if (account == null)
            {
                Console.WriteLine("A/C # doesn’t exist.");
                return;
            }

            Console.WriteLine("Account Information:");
            Console.WriteLine($"A/C #: {account.AccountNumber}");
            Console.WriteLine($"A/C Type: {account.Typee}");
            Console.WriteLine($"Customer Id: {account.CustomerId}");
            Console.WriteLine($"Customer Name: {account.Name}");
            Console.WriteLine($"Balance Amount: {account.Balance}");
        }

        static void CreditAmount()
        {
            Console.WriteLine("Enter the Account Number: ");
            string accountId = Console.ReadLine();

            AccountModel account = accounts.Find(a => a.AccountNumber == accountId);
            if (account == null)
            {
                Console.WriteLine("A/C # doesn’t exist.");
                return;
            }

            Console.WriteLine("Enter the Amount to credit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.Balance += amount;

            Console.WriteLine("Amount credited successfully.");
        }

        static void DebitAmount()
        {
            Console.WriteLine("Enter the Account Number: ");
            string accountId = Console.ReadLine();

            AccountModel account = accounts.Find(a => a.AccountNumber == accountId);
            if (account == null)
            {
                Console.WriteLine("A/C # doesn’t exist.");
                return;
            }

            Console.WriteLine("Enter the Amount to debit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            if (account.Balance - amount < MinimumInitialBalance)
            {
                Console.WriteLine("Debit amount cannot exceed minimum balance.");
                return;
            }

            account.Balance -= amount;

            Console.WriteLine("Amount debited successfully.");
        }
    }
}
