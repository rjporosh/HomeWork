using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementAppPractice5
{
    public class List
    {
        public List()
        {
            customerList = new List<Customer>();
            accountList = new List<Account>();
          
        }
        public List<Customer> customerList;
        public List<Account> accountList;
        public bool checkAccount(string AccountNumber)
        {
            if (accountList.Count != 0)
            {
                foreach (Account a in accountList)
                {
                    if (a.Number == AccountNumber)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void AddAccount(Account a)
        {
            accountList.Add(a);
        }
       
        public bool checkCustomer(string NationalId)
        {
            if (customerList.Count >= 0)
            {
                foreach (Customer c in customerList)
                {
                    if (c.NationalId == NationalId)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
       
        public void AddCustomer(Customer c )
        {
            if (checkCustomer(c.NationalId))
            {
                customerList.Add(c);
            }
        }
        public void Deposite(Customer c,Account a,double amount)
        {
            a.Balance += amount;
            System.Windows.Forms.MessageBox.Show("Deposited Successfully");
        }
        public void Withdrawn(Customer c, Account a, double amount)
        {
            if (amount > a.Balance) { System.Windows.Forms.MessageBox.Show("Yo do not have sufficient Balance."); }
            else
            {
                a.Balance -= amount;
                System.Windows.Forms.MessageBox.Show("Withdrawn Successfully");
            }
        }
        public string showDetails(Customer c)
        {
            string header = "Customer Name" +"\t\t"+" Account " +  "\t\t" + "Balance";
            string rows = "";
            foreach (Customer cc in customerList)
            {
                if (cc.Name==c.Name)
                {
                    foreach(Account a in accountList)
                    {
                        if(a.customerName==c.Name)
                        {
                            string Name =a.customerName.ToString();
                            string Account=a.Number.ToString();
                            string Balance=a.Balance.ToString();
                          rows += Name+"\t\t\t   "+ Account+"\t\t\t "+Balance+ Environment.NewLine;
                        }
                    }
                }
            }
            string message = header + Environment.NewLine + rows;
            return message;
        }
    }
}
