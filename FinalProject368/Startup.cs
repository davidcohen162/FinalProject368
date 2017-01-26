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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void itemsForSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsForSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finalProject368DatabaseDataSet);

        }

        private void Startup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProject368DatabaseDataSet.ItemsForSale' table. You can move, or remove it, as needed.
            this.itemsForSaleTableAdapter.Fill(this.finalProject368DatabaseDataSet.ItemsForSale);

        }

        

        private void login_Click(object sender, EventArgs e)
        {
            Form f = new Login();
            f.Show();
            this.Hide();
        }

        private void itemsForSale_Click(object sender, EventArgs e)
        {
            Form f = new itemsForSale();
            f.Show();
            this.Hide();
        }
    }
}
