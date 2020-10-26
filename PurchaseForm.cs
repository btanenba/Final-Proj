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
    public partial class PurchaseForm : Form
    {
        Customer cust;
        DataClasses1DataContext db;
        List<String> list;

        public PurchaseForm(Customer cust, DataClasses1DataContext db)
        {
            this.cust = cust;
            this.db = db;
            list = new List<String>();
            InitializeComponent();
            fillProduct();

        }
        void fillProduct()
        {


            var items = db.Items.Select(s => s);
            foreach (var item in items)
            {
                products.Items.Add(item.Product + "\t Price: " + item.Price);
            }


        }
        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //add each checked item to a list
            string curChecked = products.SelectedItem.ToString();
            string[] curItemArray = curChecked.Split(' ');
            string curItem = curItemArray[0].ToString();
            
            list.Add(curItem);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            //for each item in the list, create a new purchase item and submit to the db
            foreach (String item in list)
            {
                Purchase purchase = new Purchase();
                purchase.CustID = cust.CustID;
                purchase.ItemID = db.Items.Where(i => i.Product == item).Select(i => i.ItemID).First();
                purchase.PurchaseDate = DateTime.Now;
                db.Purchases.InsertOnSubmit(purchase);
            }
            updateBalance();

            MainMenu checkout = new MainMenu(cust, db);
            checkout.Show();

            this.Close();

        }
        private void updateBalance()
        {

            decimal? price;
           
            decimal? currBalance = db.Customers.Where(c => c.CustID == cust.CustID).Select(c => c.Balance).First();
            currBalance = currBalance == null ? 0 : currBalance;

            //for each item purchased, update the users balance
            foreach (String item in list)
            {

                price = db.Items.Where(i => i.Product == item).Select(i => i.Price).First();
                currBalance += price;


            }
            cust.Balance = currBalance;
            // Submit the changes to the database.
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
               Console.WriteLine(e);
           }
        }

       
    }
}
