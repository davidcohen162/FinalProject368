namespace FinalProject368
{
    partial class itemsForSale
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
            System.Windows.Forms.Label itemQuantityLabel;
            System.Windows.Forms.Label itemPriceLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemsForSale));
            this.login = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.finalProject368DatabaseDataSet = new FinalProject368.FinalProject368DatabaseDataSet();
            this.itemsForSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsForSaleTableAdapter = new FinalProject368.FinalProject368DatabaseDataSetTableAdapters.ItemsForSaleTableAdapter();
            this.tableAdapterManager = new FinalProject368.FinalProject368DatabaseDataSetTableAdapters.TableAdapterManager();
            this.itemsForSaleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.itemsForSaleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsForSaleDataGridView = new System.Windows.Forms.DataGridView();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.userPageButton = new System.Windows.Forms.Button();
            this.introTextBox = new System.Windows.Forms.TextBox();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.integerQuantityLabel = new System.Windows.Forms.Label();
            itemQuantityLabel = new System.Windows.Forms.Label();
            itemPriceLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            itemIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalProject368DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsForSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsForSaleBindingNavigator)).BeginInit();
            this.itemsForSaleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsForSaleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemQuantityLabel
            // 
            itemQuantityLabel.AutoSize = true;
            itemQuantityLabel.Location = new System.Drawing.Point(120, 173);
            itemQuantityLabel.Name = "itemQuantityLabel";
            itemQuantityLabel.Size = new System.Drawing.Size(72, 13);
            itemQuantityLabel.TabIndex = 28;
            itemQuantityLabel.Text = "Item Quantity:";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Location = new System.Drawing.Point(120, 147);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new System.Drawing.Size(57, 13);
            itemPriceLabel.TabIndex = 26;
            itemPriceLabel.Text = "Item Price:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(120, 121);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 24;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(120, 95);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(44, 13);
            itemIDLabel.TabIndex = 22;
            itemIDLabel.Text = "Item ID:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(34, 264);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 43);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(170, 266);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(119, 41);
            this.signOutButton.TabIndex = 20;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // finalProject368DatabaseDataSet
            // 
            this.finalProject368DatabaseDataSet.DataSetName = "FinalProject368DatabaseDataSet";
            this.finalProject368DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsForSaleBindingSource
            // 
            this.itemsForSaleBindingSource.DataMember = "ItemsForSale";
            this.itemsForSaleBindingSource.DataSource = this.finalProject368DatabaseDataSet;
            // 
            // itemsForSaleTableAdapter
            // 
            this.itemsForSaleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsForSaleTableAdapter = this.itemsForSaleTableAdapter;
            this.tableAdapterManager.PurchasesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject368.FinalProject368DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserAccountsTableAdapter = null;
            // 
            // itemsForSaleBindingNavigator
            // 
            this.itemsForSaleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemsForSaleBindingNavigator.BindingSource = this.itemsForSaleBindingSource;
            this.itemsForSaleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsForSaleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemsForSaleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemsForSaleBindingNavigatorSaveItem});
            this.itemsForSaleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemsForSaleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsForSaleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsForSaleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsForSaleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsForSaleBindingNavigator.Name = "itemsForSaleBindingNavigator";
            this.itemsForSaleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsForSaleBindingNavigator.Size = new System.Drawing.Size(735, 25);
            this.itemsForSaleBindingNavigator.TabIndex = 21;
            this.itemsForSaleBindingNavigator.Text = "bindingNavigator1";
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
            // itemsForSaleBindingNavigatorSaveItem
            // 
            this.itemsForSaleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemsForSaleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsForSaleBindingNavigatorSaveItem.Image")));
            this.itemsForSaleBindingNavigatorSaveItem.Name = "itemsForSaleBindingNavigatorSaveItem";
            this.itemsForSaleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemsForSaleBindingNavigatorSaveItem.Text = "Save Data";
            this.itemsForSaleBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemsForSaleBindingNavigatorSaveItem_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(333, 264);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(75, 43);
            this.purchaseButton.TabIndex = 22;
            this.purchaseButton.Text = "Purchase Item";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemQuantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemQuantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // itemsForSaleDataGridView
            // 
            this.itemsForSaleDataGridView.AllowUserToAddRows = false;
            this.itemsForSaleDataGridView.AllowUserToDeleteRows = false;
            this.itemsForSaleDataGridView.AutoGenerateColumns = false;
            this.itemsForSaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsForSaleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemsForSaleDataGridView.DataSource = this.itemsForSaleBindingSource;
            this.itemsForSaleDataGridView.Location = new System.Drawing.Point(378, 12);
            this.itemsForSaleDataGridView.Name = "itemsForSaleDataGridView";
            this.itemsForSaleDataGridView.Size = new System.Drawing.Size(300, 220);
            this.itemsForSaleDataGridView.TabIndex = 29;
            this.itemsForSaleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsForSaleDataGridView_CellContentClick);
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsForSaleBindingSource, "ItemQuantity", true));
            this.itemQuantityTextBox.Location = new System.Drawing.Point(198, 170);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemQuantityTextBox.TabIndex = 29;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsForSaleBindingSource, "ItemPrice", true));
            this.itemPriceTextBox.Location = new System.Drawing.Point(198, 144);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPriceTextBox.TabIndex = 27;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsForSaleBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(198, 118);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 25;
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsForSaleBindingSource, "ItemID", true));
            this.itemIDTextBox.Location = new System.Drawing.Point(198, 92);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemIDTextBox.TabIndex = 23;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(42, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 32;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(437, 264);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 43);
            this.clearButton.TabIndex = 33;
            this.clearButton.Text = "Clear Item";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // userPageButton
            // 
            this.userPageButton.Location = new System.Drawing.Point(570, 264);
            this.userPageButton.Name = "userPageButton";
            this.userPageButton.Size = new System.Drawing.Size(75, 43);
            this.userPageButton.TabIndex = 34;
            this.userPageButton.Text = "Go To Your Info";
            this.userPageButton.UseVisualStyleBackColor = true;
            this.userPageButton.Click += new System.EventHandler(this.userPageButton_Click);
            // 
            // introTextBox
            // 
            this.introTextBox.Location = new System.Drawing.Point(12, 25);
            this.introTextBox.Multiline = true;
            this.introTextBox.Name = "introTextBox";
            this.introTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.introTextBox.Size = new System.Drawing.Size(100, 109);
            this.introTextBox.TabIndex = 35;
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(155, 333);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(357, 20);
            this.itemBox.TabIndex = 36;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(570, 333);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 20);
            this.quantityBox.TabIndex = 37;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(518, 336);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 38;
            this.quantityLabel.Text = "Quantity:";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(94, 336);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(30, 13);
            this.itemLabel.TabIndex = 39;
            this.itemLabel.Text = "Item:";
            // 
            // integerQuantityLabel
            // 
            this.integerQuantityLabel.AutoSize = true;
            this.integerQuantityLabel.Location = new System.Drawing.Point(587, 369);
            this.integerQuantityLabel.Name = "integerQuantityLabel";
            this.integerQuantityLabel.Size = new System.Drawing.Size(0, 13);
            this.integerQuantityLabel.TabIndex = 40;
            // 
            // itemsForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 543);
            this.Controls.Add(this.integerQuantityLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.introTextBox);
            this.Controls.Add(this.userPageButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.itemsForSaleDataGridView);
            this.Controls.Add(itemIDLabel);
            this.Controls.Add(this.itemIDTextBox);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(itemPriceLabel);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(itemQuantityLabel);
            this.Controls.Add(this.itemQuantityTextBox);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.itemsForSaleBindingNavigator);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.login);
            this.Name = "itemsForSale";
            this.Text = "itemsForSale";
            this.Load += new System.EventHandler(this.itemsForSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalProject368DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsForSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsForSaleBindingNavigator)).EndInit();
            this.itemsForSaleBindingNavigator.ResumeLayout(false);
            this.itemsForSaleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsForSaleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signOutButton;
        private FinalProject368DatabaseDataSet finalProject368DatabaseDataSet;
        private System.Windows.Forms.BindingSource itemsForSaleBindingSource;
        private FinalProject368DatabaseDataSetTableAdapters.ItemsForSaleTableAdapter itemsForSaleTableAdapter;
        private FinalProject368DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemsForSaleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itemsForSaleBindingNavigatorSaveItem;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView itemsForSaleDataGridView;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button userPageButton;
        private System.Windows.Forms.TextBox introTextBox;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label integerQuantityLabel;
    }
}