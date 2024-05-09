using System;

namespace BankEx
{
    internal class CustomerModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }
        public string AccountNumber { get; set; }

        public CustomerModel(string id, string name, DateTime dob, string address, string pan)
        {
            Id = id;
            Name = name;
            DOB = dob;
            Address = address;
            PAN = pan;


            AccountNumber = "";
        }
    }
}
