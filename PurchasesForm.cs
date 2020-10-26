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
    public partial class PurchasesForm : Form
    {
        DataClasses1DataContext db;
        Customer cust;
        public PurchasesForm(Customer cust, DataClasses1DataContext db)
        {
            this.cust = cust;
            this.db = db;
            InitializeComponent();
        }

        private void allPurchasesButton_Click(object sender, EventArgs e)
        {
            displayPurchases.Text = " ";
            var purchases = db.Purchases.Where(p => cust.CustID == p.CustID);
            foreach(var p in purchases)
            {
                displayPurchases.Text += db.Items.Where(i => i.ItemID == p.ItemID).Select(i => i.Product).First()  + p.PurchaseDate + "\n";
            }
        }

        private void dateRangeButton_Click(object sender, EventArgs e)
        {
            displayPurchases.Text = " ";
            var purchases = db.Purchases.Where(p => p.PurchaseDate >= dateTimePicker1.Value && p.PurchaseDate <= dateTimePicker2.Value && cust.CustID == p.CustID);
            foreach (var p in purchases)
            {
                displayPurchases.Text += db.Items.Where(i => i.ItemID == p.ItemID).Select(i => i.Product).First() + p.PurchaseDate + "\n";
            }
        }

        private void priceRangeButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            displayPurchases.Text = " ";
            var purchases = db.Purchases.Where(p => cust.CustID == p.CustID);
            foreach (var p in purchases)
            {
                var result = db.Items.Any(i => i.ItemID == p.ItemID && i.Price >= decimal.Parse(textBox1.Text) && i.Price <= decimal.Parse(textBox2.Text));
                if (result)
                {
                    displayPurchases.Text += db.Items.Where(i => i.ItemID == p.ItemID && i.Price >= decimal.Parse(textBox1.Text) && i.Price <= decimal.Parse(textBox2.Text)).Select(i => i.Product).First() + p.PurchaseDate + "\n";
                    counter++;
                }
                      
            }
            if(counter == 0)
                displayPurchases.Text = "There are no purchases in that price range";
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu cf = new MainMenu(cust, db);
            cf.Show();
            this.Close();
        }
    }
}
