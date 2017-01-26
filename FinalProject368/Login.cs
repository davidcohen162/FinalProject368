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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void userAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProject368DatabaseDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FinalProject368DatabaseDataContext db = new FinalProject368DatabaseDataContext();

            /*var query = db.UserAccounts.Where(c => c.Username == usernameTextBox.Text && c.Password
            == passwordTextBox.Text)
           
            .Select( c=>c.Username.First());*/
            /*var usersToLogOut = (from user in db.UserAccounts
                                 where user.isLoggedIn == true
                                 update user.isLoggedIn==false);*/


            var userToLogIn = (from user in db.UserAccounts
                               where user.Username == usernameTextBox.Text
                               && user.Password == passwordTextBox.Text
                               select user);

           
           

            var loggedInUsers = (from user in db.UserAccounts
                                 where user.isLoggedIn == true
                                 select user);

            if (userToLogIn.Count() == 1)
            {
                if (loggedInUsers.Count() > 0)
                {
                    foreach (var l in loggedInUsers)
                    {
                        l.isLoggedIn = false;
                        db.SubmitChanges();
                    }
                }

                userToLogIn.First().isLoggedIn = true;
                db.SubmitChanges();

                Form f = new userPage();
               
                f.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            
        }

        private void backHomeButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Startup();
            f.Show();
            this.Hide();
        }
    }
}
