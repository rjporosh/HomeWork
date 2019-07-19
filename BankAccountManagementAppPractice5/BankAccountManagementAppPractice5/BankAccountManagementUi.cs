using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManagementAppPractice5
{
    public partial class BankAccountManagementUi : Form
    {
        Customer c;
        Account a;
        List l;
        public List<Customer> customerList;
        List<Account> accountList;
        Dictionary<string, Account> accountDictionary;
        public BankAccountManagementUi()
        {
            InitializeComponent();

            l = new List();
            customerList = new List<Customer>();
            accountList = new List<Account>();
            accountDictionary = new Dictionary<string, Account>();
            customerComboBox.DisplayMember = "Name";
            transactionCustomerComboBox.DisplayMember = "Name";
            accountComboBox.DisplayMember = "Number";
            reportCustomerComboBox.DisplayMember = "Name";
        }

        private void CustomerSaveButton_Click(object sender, EventArgs e)
        {
            c = new Customer();
            if (l.checkCustomer(idTextBox.Text.ToString()))
            {
                c.Name = nameTextBox.Text;
                c.NationalId = idTextBox.Text.ToString();
                c.Phone = phoneTextBox.Text;
                c.PresentAddress = addressTextBox.Text;
                 l.AddCustomer(c);
                customerComboBox.Items.Add(c);
                transactionCustomerComboBox.Items.Add(c);
                reportCustomerComboBox.Items.Add(c);
                nameTextBox.Text = "";
                idTextBox.Text = "";
                phoneTextBox.Text = "";
                addressTextBox.Text = "";
                MessageBox.Show("Customer Added");
            }
            else
            {
                nameTextBox.Text = "";
                idTextBox.Text = "";
                phoneTextBox.Text = "";
                addressTextBox.Text = "";
                MessageBox.Show("Customer Already Exist");
            }
        }
    
        private void AccountSaveButton_Click(object sender, EventArgs e)
        {
            a = new Account();
            if (l.checkAccount(accountNumTextBox.Text.ToString()))
            {
                a.customerName = customerComboBox.Text;
                a.Type = typeComboBox.SelectedItem.ToString();
                a.Number = accountNumTextBox.Text.ToString();
                l.AddAccount(a);
                accountNumTextBox.Text = "";
                typeComboBox.SelectedItem = null;
                customerComboBox.SelectedItem = null;
                MessageBox.Show("Account Added");
            }
            else
            {
                accountNumTextBox.Text = "";
                typeComboBox.SelectedItem = null;
                customerComboBox.SelectedItem = null;
                MessageBox.Show("Account Already Exist");
            }
        }
        private void transactionCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountComboBox.Items.Clear();
            checkCustomerAccount();
            MessageBox.Show("Account List Created");
        }
        public void checkCustomerAccount()
        {
            accountComboBox.Items.Clear();
            foreach (Account aa in l.accountList)
            {
                if (aa.customerName == transactionCustomerComboBox.Text)
                { accountComboBox.Items.Add(aa); }
            }

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            l.Deposite((Customer)customerComboBox.SelectedItem,(Account)accountComboBox.SelectedItem,Convert.ToDouble(amountTextBox.Text));
            customerComboBox.Text = null;
            accountComboBox.SelectedItem = null;
            amountTextBox.Text = "";
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            l.Withdrawn((Customer)customerComboBox.SelectedItem,(Account)accountComboBox.SelectedItem,Convert.ToDouble(amountTextBox.Text));
            customerComboBox.Text = null;
            accountComboBox.SelectedItem = null;
            amountTextBox.Text = "";
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string msg=l.showDetails((Customer)reportCustomerComboBox.SelectedItem);
            MessageBox.Show(msg);
        }
    }
}

