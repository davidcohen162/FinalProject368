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
    public partial class itemsForSale : Form
    {
        public itemsForSale()
        {
            InitializeComponent();
        }

        

        private void login_Click(object sender, EventArgs e)
        {
            Form f = new Login();
            f.Show();
            this.Hide();
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

        private void itemsForSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsForSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProject368DatabaseDataSet);

        }

        private void itemsForSale_Load(object sender, EventArgs e)
        {

            itemBox.Clear();
            quantityBox.Clear();
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
            var userLoggedIn = (from user in db.UserAccounts
                                where user.isLoggedIn == true
                                select user);
            if (userLoggedIn.Count() > 0)
            {
                usernameLabel.Text = userLoggedIn.First().Username;
                if (userLoggedIn.First().Balance>100)
                {
                    introTextBox.Text = "You owe too much. You can't purchase; the button will be hidden till you pay.";
                    purchaseButton.Hide();
                    quantityBox.Hide();
                    quantityLabel.Hide();
                    itemBox.Hide();
                    itemLabel.Hide();
                }
                introTextBox.Text = "To purchase an item, click anywhere on the content list except on the ID. "
                + "\nThe Item in the row you click will be ashown on the bottom with  a default quantity of 1 "
                + "\nCheck off the item and click Purchase to add to your purchase."
                + "\nTo purchase the same item in multiple quantities, simply update the quantity box."
                + "\nHowever, to purchase ddifferent items, you'll have to make separate purchases.";
                purchaseButton.Show();
                introTextBox.Show();
                itemLabel.Show();
                itemBox.Show();
                quantityBox.Show();
                login.Hide();
                signOutButton.Show();

            }
            else
            {
                purchaseButton.Hide();
                introTextBox.Hide();
                itemLabel.Hide();
                itemBox.Hide();
                login.Show();
                signOutButton.Hide();
            }
            // TODO: This line of code loads data into the 'finalProject368DatabaseDataSet.ItemsForSale' table. You can move, or remove it, as needed.
            this.itemsForSaleTableAdapter.Fill(this.finalProject368DatabaseDataSet.ItemsForSale);
            
           
            

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            int counter = 1;
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();
            var items = db.ItemsForSales;
            var userLoggedIn = (from user in db.UserAccounts
                                where user.isLoggedIn == true
                                select user);


            var itemToPurchase = db.ItemsForSales.Where(j => j.ItemName == itemBox.Text);
            var purchaseIDsTaken = db.Purchases.Select(j => j.PurchaseId);
            if (purchaseIDsTaken.Count()>0)
            {
                foreach(var k in purchaseIDsTaken)
                {
                    if (k == counter)
                    {
                        counter++;
                    }
                }
                
            }





            Purchase p = new Purchase();
            //there is only one user logged in and one item that will meet id or name so first is used
            p.PurchaseId = counter;
            p.UserId = userLoggedIn.First().Id;
            p.Username = userLoggedIn.First().Username;
            p.Fname = userLoggedIn.First().Fname;
            p.Lname = userLoggedIn.First().Lname;
            p.ItemID = itemToPurchase.First().ItemID;
            p.ItemName = itemToPurchase.First().ItemName;
            p.ItemQuantity = itemToPurchase.First().ItemQuantity;
            p.Date = DateTime.Now;
            //If purchase ID is taken increment counter
            int quantity = 0;
            if (Int32.TryParse(quantityBox.Text, out quantity)&&quantity<=itemToPurchase.First().ItemQuantity)
            {
               
                integerQuantityLabel.Text = "";
                p.ItemQuantity = quantity;
                itemToPurchase.First().ItemQuantity = itemToPurchase.First().ItemQuantity - quantity;
                p.BalanceChange = itemToPurchase.First().ItemPrice * quantity;
                userLoggedIn.First().Balance = userLoggedIn.First().Balance - p.BalanceChange;
                p.BalanceAfter = userLoggedIn.First().Balance;
                db.Purchases.InsertOnSubmit(p);
                counter++;
                db.SubmitChanges();
                itemBox.Clear();
                quantityBox.Clear();
            }
            else if (Int32.TryParse(quantityBox.Text, out quantity)&&quantity > itemToPurchase.First().ItemQuantity)
            {
                integerQuantityLabel.Text = "Enter a lower number.";
            }
            else
            {
                integerQuantityLabel.Text = "Enter a number.";
            }

        }                   
                                
                                
                            
                           
                            
                        

                               
                        
                    
            


            
            
       

        private void itemsForSaleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itemBox.Text= itemsForSaleDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityBox.Text = "1";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemBox.Clear();
            quantityBox.Clear();
        }

        private void userPageButton_Click(object sender, EventArgs e)
        {
            Form f = new userPage();
            f.Show();
            this.Hide();
        }
    }
}
