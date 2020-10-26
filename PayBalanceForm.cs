using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proj
{
    public partial class PayBalanceForm : Form
    {
        Customer cust;
        DataClasses1DataContext db;
        decimal? currBalance;
        public PayBalanceForm(Customer cust, DataClasses1DataContext db)
        {
            this.cust = cust;
            this.db = db;
            InitializeComponent();
        }

        private void PayBalanceForm_Load(object sender, EventArgs e)
        {
            currBalance = db.Customers.Where(i => i.CustID == cust.CustID).Select(i => i.Balance).First();
            if (currBalance > 5000)
            {
                displayBalance.Text = "Your Current Balance is " + currBalance + "\nYou cannot make a new purchase until you pay your balance"; 
            }
            else
            {
                displayBalance.Text = "Your Current Balance is " + currBalance;
            }
           
        }

        private void submitPayment_Click(object sender, EventArgs e)
        {
            decimal payment = decimal.Parse(enterPayment.Text);
            if(payment >= 0)
            {
                currBalance -= payment;
                cust.Balance = currBalance;
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                displayMessage.Text = "Payment Processed";
            }
           
            else
            {
                displayMessage.Text = "Error. Please Try Again.";
            }
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu cf = new MainMenu(cust, db);
            cf.Show();
            this.Close();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
