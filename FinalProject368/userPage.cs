using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject368
{
    public partial class userPage : Form
    {
        public userPage()
        {
            InitializeComponent();
        }

        private void userPage_Load(object sender, EventArgs e)
        {
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
            
            var userLoggedIn = (from user in db.UserAccounts
                                where user.isLoggedIn == true
                                select user);



            this.usernameTextBox.Text = userLoggedIn.First().Username;
            this.fnameTextBox.Text = userLoggedIn.First().Fname;
            this.lnameTextBox.Text = userLoggedIn.First().Lname;
            this.passwordTextBox.Text = userLoggedIn.First().Password;
            this.balanceTextBox.Text = ("" + userLoggedIn.First().Balance);
            invalidEntryLabel.Hide();


        }

        private void userAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProject368DatabaseDataSet);

        }

        private void userAccountsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.userAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProject368DatabaseDataSet);

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            Form f = new itemsForSale();
            f.Show();
            this.Hide();
        }

        private void allPurchasesButton_Click(object sender, EventArgs e)
        {
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
            var userLoggedIn = (from user in db.UserAccounts
                                where user.Username == usernameTextBox.Text
                                && user.Password == passwordTextBox.Text
                                select user.Username);
            if(userLoggedIn.Count()>0)
            {
                var historyToShow = db.Purchases.Where(d => d.Username == userLoggedIn.First());
                string s = "";
                foreach (var h in historyToShow)
                {
                    s = s + "PurchaseID: "+h.PurchaseId+" UserId: " + h.UserId+ " Username: " + h.Username + " Fname: " + h.Fname + " h.Lname: "
                        + h.Lname + "\r\nItem ID: " + h.ItemID + " Item Name: " + h.ItemName + " Item Quantity: " + h.ItemQuantity
                     + "\r\nPurchase Date: " + h.Date + " Purchase Cost: " + h.BalanceChange + " Balance After: " + h.BalanceAfter + "\r\n";
                }
                purchasesHistoryBox.Text = s;
            }
           
                                 
           
        }

        private void allPurchasesDateButton_Click(object sender, EventArgs e)
        {
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
            var userLoggedIn = (from user in db.UserAccounts
                                where user.isLoggedIn==true
                                select user.Username);
            if (userLoggedIn.Count() > 0)
            {
                var historyToShow = db.Purchases.Where(d => d.Username == userLoggedIn.First())
                                 .OrderBy(d => d.Date);
                string s = "";
                foreach (var h in historyToShow)
                {
                    s = s + "ID:" + h.UserId + " Username: " + h.Username + " Fname: " + h.Fname + " Lname: "
                        + h.Lname + "\r\nItem ID: " + h.ItemID + " Item Name: " + h.ItemName + " Item Quantity: " + h.ItemQuantity
                     + "\r\nPurchase Date: " + h.Date + " Purchase Cost: " + h.BalanceChange + " Balance After: " + h.BalanceAfter + "\r\n";
                }
                purchasesHistoryBox.Text = s;
            }
            
        }

        private void allPurchasesPriceButton_Click(object sender, EventArgs e)
        {
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
            var userLoggedIn = (from user in db.UserAccounts
                                where user.Username == usernameTextBox.Text
                                && user.Password == passwordTextBox.Text
                                select user.Id);
           
            var historyToShow = db.Purchases.Where(d => d.UserId == userLoggedIn.First())
            .OrderBy(d => d.BalanceChange);

            string s = "";
            foreach (var h in historyToShow)
            {
                s = s+ "ID:" + h.UserId + " Username: " + h.Username + " Fname: " + h.Fname + " Lname: " 
                    + h.Lname + "\r\nItem ID: " + h.ItemID + " Item Name: " + h.ItemName + " Item Quantity: " + h.ItemQuantity
                 + "\r\nPurchase Date: " + h.Date + " Purchase Cost: " + h.BalanceChange + " Balance After: " + h.BalanceAfter+"\r\n";
            }
            purchasesHistoryBox.Text = s;
            


        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
            var userLoggedIn = (from user in db.UserAccounts
                                where user.isLoggedIn == true
                                select user);
            if (userLoggedIn.Count() > 0)
            {
                userLoggedIn.First().isLoggedIn = false;
                db.SubmitChanges();
            }
            
            Form f = new Startup();
            f.Show();
            this.Hide();

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            int payInt;
            if (Int32.TryParse(payBox.Text,out payInt)||payBox.Text=="")
            {
                invalidEntryLabel.Hide();
                FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
                var userLoggedIn = (from user in db.UserAccounts
                                    where user.isLoggedIn == true
                                    select user);
                userLoggedIn.First().Balance = userLoggedIn.First().Balance + payInt;
                balanceTextBox.Text = "" + userLoggedIn.First().Balance;
                payBox.Text = "";
                invalidEntryLabel.Hide();
                db.SubmitChanges();
            }
            else
            {
                invalidEntryLabel.Show();
            }
           
        }
    }
}
