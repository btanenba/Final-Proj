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
    public partial class MainMenu : Form
    {
        Customer cust;
        DataClasses1DataContext db;
        public MainMenu(Customer cust, DataClasses1DataContext db)
        {
            this.cust = cust;
            this.db = db;
            InitializeComponent();
        }

        private void newPurchaseButton_Click(object sender, EventArgs e)
        {
            decimal? currBalance = db.Customers.Where(i => i.CustID == cust.CustID).Select(i => i.Balance).First();
            if (currBalance > 5000)
            {
                displayError.Text = "Your Current Balance is " + currBalance + "\nYou cannot make a new purchase\n until you pay your balance";
            }
            else
            {
                PurchaseForm newPurchase = new PurchaseForm(cust, db);
                newPurchase.Show();
                this.Close();
            }
            
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            PayBalanceForm pb = new PayBalanceForm(cust, db);
            pb.Show();
            this.Close();
        }

        private void checkPurchases_Click(object sender, EventArgs e)
        {
            PurchasesForm pf = new PurchasesForm(cust, db);
            pf.Show();
            this.Close();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
