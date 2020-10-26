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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //if the username and password is in the database, it should submit
            DataClasses1DataContext db = new DataClasses1DataContext();

            bool user = db.Customers.Any(c => c.UserName == username.Text && c.Password == password.Text);
           
            if (user)
            {
                
            Customer cust = db.Customers.FirstOrDefault(c => c.UserName == username.Text) ;
            if (cust.Balance > 5000)
                {
                    PayBalanceForm pb = new PayBalanceForm(cust, db);
                    pb.Show();
                }
                else
                {
                    PurchaseForm f2 = new PurchaseForm(cust, db);
                    f2.Show();
                }
                        
            

                this.Hide();

            }
            else
            {
                displayError.Text = "Invalid Username or Password";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
