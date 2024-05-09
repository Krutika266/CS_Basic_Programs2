using System;
using static BankEx.Constants;

namespace BankEx
{
    internal class AccountModel
    {
        public string AccountNumber { get; set; }
        public string Typee { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public AccountModel(string accountNumber, AccountType type, string? customerId, string name, decimal balance)
        {
            AccountNumber = accountNumber;
            Typee = type.ToString();
            CustomerId = customerId;
            Name = name;
            Balance = balance;
        }
    }
}
