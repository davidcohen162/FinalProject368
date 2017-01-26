namespace FinalProject368
{
    partial class userPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label balanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPage));
            this.finalProject368DatabaseDataSet = new FinalProject368.FinalProject368DatabaseDataSet();
            this.userAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAccountsTableAdapter = new FinalProject368.FinalProject368DatabaseDataSetTableAdapters.UserAccountsTableAdapter();
            this.tableAdapterManager = new FinalProject368.FinalProject368DatabaseDataSetTableAdapters.TableAdapterManager();
            this.userAccountsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userAccountsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.allPurchasesButton = new System.Windows.Forms.Button();
            this.allPurchasesDateButton = new System.Windows.Forms.Button();
            this.allPurchasesPriceButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.payBox = new System.Windows.Forms.TextBox();
            this.signOutButton = new System.Windows.Forms.Button();
            this.purchasesHistoryBox = new System.Windows.Forms.TextBox();
            this.invalidEntryLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalProject368DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingNavigator)).BeginInit();
            this.userAccountsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(53, 77);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(53, 103);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(42, 13);
            fnameLabel.TabIndex = 5;
            fnameLabel.Text = "Fname:";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new System.Drawing.Point(53, 129);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(42, 13);
            lnameLabel.TabIndex = 7;
            lnameLabel.Text = "Lname:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(53, 155);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(53, 181);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(49, 13);
            balanceLabel.TabIndex = 11;
            balanceLabel.Text = "Balance:";
            // 
            // finalProject368DatabaseDataSet
            // 
            this.finalProject368DatabaseDataSet.DataSetName = "FinalProject368DatabaseDataSet";
            this.finalProject368DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userAccountsBindingSource
            // 
            this.userAccountsBindingSource.DataMember = "UserAccounts";
            this.userAccountsBindingSource.DataSource = this.finalProject368DatabaseDataSet;
            // 
            // userAccountsTableAdapter
            // 
            this.userAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsForSaleTableAdapter = null;
            this.tableAdapterManager.PurchasesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject368.FinalProject368DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserAccountsTableAdapter = this.userAccountsTableAdapter;
            // 
            // userAccountsBindingNavigator
            // 
            this.userAccountsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userAccountsBindingNavigator.BindingSource = this.userAccountsBindingSource;
            this.userAccountsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userAccountsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userAccountsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userAccountsBindingNavigatorSaveItem});
            this.userAccountsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userAccountsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userAccountsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userAccountsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userAccountsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userAccountsBindingNavigator.Name = "userAccountsBindingNavigator";
            this.userAccountsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userAccountsBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.userAccountsBindingNavigator.TabIndex = 0;
            this.userAccountsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userAccountsBindingNavigatorSaveItem
            // 
            this.userAccountsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userAccountsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userAccountsBindingNavigatorSaveItem.Image")));
            this.userAccountsBindingNavigatorSaveItem.Name = "userAccountsBindingNavigatorSaveItem";
            this.userAccountsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userAccountsBindingNavigatorSaveItem.Text = "Save Data";
            this.userAccountsBindingNavigatorSaveItem.Click += new System.EventHandler(this.userAccountsBindingNavigatorSaveItem_Click_1);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountsBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(117, 74);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountsBindingSource, "Fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(117, 100);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fnameTextBox.TabIndex = 6;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountsBindingSource, "Lname", true));
            this.lnameTextBox.Location = new System.Drawing.Point(117, 126);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lnameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountsBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(117, 152);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountsBindingSource, "Balance", true));
            this.balanceTextBox.Location = new System.Drawing.Point(117, 178);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 12;
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(45, 214);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(114, 23);
            this.purchaseButton.TabIndex = 13;
            this.purchaseButton.Text = "Purchase An Item";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // allPurchasesButton
            // 
            this.allPurchasesButton.Location = new System.Drawing.Point(45, 253);
            this.allPurchasesButton.Name = "allPurchasesButton";
            this.allPurchasesButton.Size = new System.Drawing.Size(75, 38);
            this.allPurchasesButton.TabIndex = 14;
            this.allPurchasesButton.Text = "View All Purchases";
            this.allPurchasesButton.UseVisualStyleBackColor = true;
            this.allPurchasesButton.Click += new System.EventHandler(this.allPurchasesButton_Click);
            // 
            // allPurchasesDateButton
            // 
            this.allPurchasesDateButton.Location = new System.Drawing.Point(142, 253);
            this.allPurchasesDateButton.Name = "allPurchasesDateButton";
            this.allPurchasesDateButton.Size = new System.Drawing.Size(144, 38);
            this.allPurchasesDateButton.TabIndex = 15;
            this.allPurchasesDateButton.Text = "View All Purchases By Date Selection";
            this.allPurchasesDateButton.UseVisualStyleBackColor = true;
            this.allPurchasesDateButton.Click += new System.EventHandler(this.allPurchasesDateButton_Click);
            // 
            // allPurchasesPriceButton
            // 
            this.allPurchasesPriceButton.Location = new System.Drawing.Point(325, 253);
            this.allPurchasesPriceButton.Name = "allPurchasesPriceButton";
            this.allPurchasesPriceButton.Size = new System.Drawing.Size(112, 38);
            this.allPurchasesPriceButton.TabIndex = 16;
            this.allPurchasesPriceButton.Text = "View All Purchases By Price Selection";
            this.allPurchasesPriceButton.UseVisualStyleBackColor = true;
            this.allPurchasesPriceButton.Click += new System.EventHandler(this.allPurchasesPriceButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(180, 214);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 17;
            this.payButton.Text = "Pay:";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // payBox
            // 
            this.payBox.Location = new System.Drawing.Point(283, 217);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(100, 20);
            this.payBox.TabIndex = 18;
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(463, 253);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 38);
            this.signOutButton.TabIndex = 19;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // purchasesHistoryBox
            // 
            this.purchasesHistoryBox.Location = new System.Drawing.Point(45, 297);
            this.purchasesHistoryBox.Multiline = true;
            this.purchasesHistoryBox.Name = "purchasesHistoryBox";
            this.purchasesHistoryBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.purchasesHistoryBox.Size = new System.Drawing.Size(493, 150);
            this.purchasesHistoryBox.TabIndex = 20;
            // 
            // invalidEntryLabel
            // 
            this.invalidEntryLabel.AutoSize = true;
            this.invalidEntryLabel.Location = new System.Drawing.Point(389, 219);
            this.invalidEntryLabel.Name = "invalidEntryLabel";
            this.invalidEntryLabel.Size = new System.Drawing.Size(82, 13);
            this.invalidEntryLabel.TabIndex = 21;
            this.invalidEntryLabel.Text = "Enter an integer";
            // 
            // userPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 660);
            this.Controls.Add(this.invalidEntryLabel);
            this.Controls.Add(this.purchasesHistoryBox);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.payBox);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.allPurchasesPriceButton);
            this.Controls.Add(this.allPurchasesDateButton);
            this.Controls.Add(this.allPurchasesButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.userAccountsBindingNavigator);
            this.Name = "userPage";
            this.Text = "Your Info";
            this.Load += new System.EventHandler(this.userPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalProject368DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingNavigator)).EndInit();
            this.userAccountsBindingNavigator.ResumeLayout(false);
            this.userAccountsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinalProject368DatabaseDataSet finalProject368DatabaseDataSet;
        private System.Windows.Forms.BindingSource userAccountsBindingSource;
        private FinalProject368DatabaseDataSetTableAdapters.UserAccountsTableAdapter userAccountsTableAdapter;
        private FinalProject368DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userAccountsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userAccountsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button allPurchasesButton;
        private System.Windows.Forms.Button allPurchasesDateButton;
        private System.Windows.Forms.Button allPurchasesPriceButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.TextBox payBox;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.TextBox purchasesHistoryBox;
        private System.Windows.Forms.Label invalidEntryLabel;
    }
}