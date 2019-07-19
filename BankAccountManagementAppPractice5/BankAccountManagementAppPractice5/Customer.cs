using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementAppPractice5
{
    public class Customer
    {
        public string NationalId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PresentAddress { get; set; }
        public Customer()
        {
           
        }
        public Customer(string NID,string name ,string phone, string presentAddress)
        {
            this.NationalId = NID;
            this.Name = name;
            this.Phone = phone;
            this.PresentAddress = presentAddress;
        }
    }
}
