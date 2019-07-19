using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementAppPractice5
{
    public class Account
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string customerName { get; set; }
        public double Balance { get; set; }
        public Account()
        {
        }
        public Account(string CustomerName,string Type,string Number)
        {
            this.customerName = CustomerName;
            this.Type = Type;
            this.Number = Number;
        }
    }
}
