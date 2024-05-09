using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEx
{
    public static class Constants
    {
        public enum MenuType
        {
            Main = 1,
            Account = 2,
            Customer = 3
        }

        public enum AccountType
        {
            Saving = 1,
            Salary = 2,
            Current = 3
        }

        public enum Options
        {
            Create = 1,
            ViewAll = 2,
            VewById = 3
        }
        public enum AccountOptions
        {
            credit = 4,
            debit = 5
        }
    }
}
