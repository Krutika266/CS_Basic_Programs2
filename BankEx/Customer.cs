using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankEx.Constants;

namespace BankEx
{

    class Customer
    {
        private static List<CustomerModel> customers = new List<CustomerModel>();

        public static List<CustomerModel> GetCustomers()
        {
            return customers;
        }
        public static void CustomerMenu()
        {

            MainMenuDisplay.DisplayMenu(Constants.MenuType.Customer);
            int choice = MainMenuDisplay.MenuChoice();

            switch (choice)
            {
                case (int)Options.Create:
                    CreateCustomer();
                    break;
                case (int)Options.ViewAll:
                    ViewAllCustomers();
                    break;
                case (int)Options.VewById:
                    ViewCustomerById();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }


        static void CreateCustomer()
        {
            Console.WriteLine("Customer Creation:");
            Console.WriteLine("Customer Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("DOB (YYYY-MM-DD): ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("PAN: ");
            string pan = Console.ReadLine();

            if ((DateTime.Now - dob).TotalDays < 6570)
            {
                Console.WriteLine("Customer must be 18 years or older.");
                return;
            }

            string customerId = Guid.NewGuid().ToString();


            CustomerModel customer = new CustomerModel(customerId, name, dob, address, pan);
            customers.Add(customer);

            Console.WriteLine("Customer created successfully.");
        }

        static void ViewAllCustomers()
        {
            Console.WriteLine("All Customers details:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id} | {customer.Name} | {customer.DOB} | {customer.AccountNumber} | {customer.PAN}");
            }
        }

        static void ViewCustomerById()
        {
            Console.WriteLine("Enter the customer Id: ");
            string customerId = Console.ReadLine();

            CustomerModel customer = customers.Find(c => c.Id == customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer Id doesn't exist.");
                return;
            }

            Console.WriteLine("Customer Information:");
            Console.WriteLine($"Customer ID: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"DOB: {customer.DOB}");
            Console.WriteLine($"Address: {customer.Address}");
            Console.WriteLine($"PAN: {customer.PAN}");
            Console.WriteLine("Accounts:");
            List<AccountModel> accounts = Account.GetAccounts();
            foreach (var account in accounts)
            {
                if (account.CustomerId == customerId)
                {
                    Console.WriteLine($"{account.AccountNumber} | {account.Typee} | {account.Balance}");
                }
            }
        }
    }
}

