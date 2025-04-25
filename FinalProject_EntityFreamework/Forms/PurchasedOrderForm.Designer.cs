namespace FinalProject_EntityFreamework.Forms
{
    partial class PurchasedOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchasedOrderList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.WarehouseListBox = new System.Windows.Forms.ListBox();
            this.SupplierListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.itemsCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddItemToOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(14, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Item Name";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(175, 285);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(70, 22);
            this.Quantity.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(14, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Items in Order";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DeepPink;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(211, 333);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(163, 31);
            this.UpdateBtn.TabIndex = 60;
            this.UpdateBtn.Text = "Update Order";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 58;
            this.label3.Text = "Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Order Date";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DeepPink;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(34, 333);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(149, 31);
            this.AddBtn.TabIndex = 54;
            this.AddBtn.Text = "Add Order";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 40);
            this.label1.TabIndex = 53;
            this.label1.Text = "Purchased Orders List";
            // 
            // PurchasedOrderList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PurchasedOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PurchasedOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PurchasedOrderList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchasedOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PurchasedOrderList.ColumnHeadersHeight = 25;
            this.PurchasedOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PurchasedOrderList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchasedOrderList.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurchasedOrderList.GridColor = System.Drawing.Color.White;
            this.PurchasedOrderList.Location = new System.Drawing.Point(380, 73);
            this.PurchasedOrderList.Name = "PurchasedOrderList";
            this.PurchasedOrderList.RowHeadersVisible = false;
            this.PurchasedOrderList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.PurchasedOrderList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PurchasedOrderList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Turquoise;
            this.PurchasedOrderList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.PurchasedOrderList.RowTemplate.Height = 24;
            this.PurchasedOrderList.Size = new System.Drawing.Size(586, 323);
            this.PurchasedOrderList.TabIndex = 52;
            this.PurchasedOrderList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PurchasedOrderList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PurchasedOrderList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PurchasedOrderList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PurchasedOrderList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PurchasedOrderList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.PurchasedOrderList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.PurchasedOrderList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PurchasedOrderList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PurchasedOrderList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasedOrderList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.PurchasedOrderList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PurchasedOrderList.ThemeStyle.HeaderStyle.Height = 25;
            this.PurchasedOrderList.ThemeStyle.ReadOnly = false;
            this.PurchasedOrderList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PurchasedOrderList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PurchasedOrderList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasedOrderList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PurchasedOrderList.ThemeStyle.RowsStyle.Height = 24;
            this.PurchasedOrderList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PurchasedOrderList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PurchasedOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchasedOrderList_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // WarehouseListBox
            // 
            this.WarehouseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehouseListBox.FormattingEnabled = true;
            this.WarehouseListBox.ItemHeight = 18;
            this.WarehouseListBox.Location = new System.Drawing.Point(175, 132);
            this.WarehouseListBox.Name = "WarehouseListBox";
            this.WarehouseListBox.Size = new System.Drawing.Size(178, 22);
            this.WarehouseListBox.TabIndex = 67;
            // 
            // SupplierListBox
            // 
            this.SupplierListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierListBox.FormattingEnabled = true;
            this.SupplierListBox.ItemHeight = 18;
            this.SupplierListBox.Location = new System.Drawing.Point(175, 167);
            this.SupplierListBox.Name = "SupplierListBox";
            this.SupplierListBox.Size = new System.Drawing.Size(178, 22);
            this.SupplierListBox.TabIndex = 68;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 18;
            this.ItemsListBox.Location = new System.Drawing.Point(175, 250);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(178, 22);
            this.ItemsListBox.TabIndex = 69;
            // 
            // itemsCount
            // 
            this.itemsCount.Location = new System.Drawing.Point(175, 218);
            this.itemsCount.Name = "itemsCount";
            this.itemsCount.Size = new System.Drawing.Size(28, 22);
            this.itemsCount.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(14, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 71;
            this.label7.Text = "Item Quantity";
            // 
            // AddItemToOrder
            // 
            this.AddItemToOrder.BackColor = System.Drawing.Color.DeepPink;
            this.AddItemToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemToOrder.ForeColor = System.Drawing.Color.White;
            this.AddItemToOrder.Location = new System.Drawing.Point(269, 280);
            this.AddItemToOrder.Name = "AddItemToOrder";
            this.AddItemToOrder.Size = new System.Drawing.Size(84, 31);
            this.AddItemToOrder.TabIndex = 72;
            this.AddItemToOrder.Text = "Add";
            this.AddItemToOrder.UseVisualStyleBackColor = false;
            this.AddItemToOrder.Click += new System.EventHandler(this.AddItemToOrder_Click);
            // 
            // PurchasedOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddItemToOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itemsCount);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.SupplierListBox);
            this.Controls.Add(this.WarehouseListBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchasedOrderList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasedOrderForm";
            this.Text = "PurchasedOrderForm";
            this.Load += new System.EventHandler(this.PurchasedOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView PurchasedOrderList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox WarehouseListBox;
        private System.Windows.Forms.ListBox SupplierListBox;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TextBox itemsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddItemToOrder;
    }
}