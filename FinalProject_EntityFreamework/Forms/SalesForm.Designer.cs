namespace FinalProject_EntityFreamework.Forms
{
    partial class SalesForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.WarehouseListBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesOrderList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(28, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 88;
            this.label7.Text = "Item Quantity";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 18;
            this.ItemsListBox.Location = new System.Drawing.Point(189, 211);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(178, 22);
            this.ItemsListBox.TabIndex = 86;
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.ItemHeight = 18;
            this.CustomerListBox.Location = new System.Drawing.Point(189, 173);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(178, 22);
            this.CustomerListBox.TabIndex = 85;
            // 
            // WarehouseListBox
            // 
            this.WarehouseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehouseListBox.FormattingEnabled = true;
            this.WarehouseListBox.ItemHeight = 18;
            this.WarehouseListBox.Location = new System.Drawing.Point(189, 138);
            this.WarehouseListBox.Name = "WarehouseListBox";
            this.WarehouseListBox.Size = new System.Drawing.Size(178, 22);
            this.WarehouseListBox.TabIndex = 84;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(28, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 82;
            this.label5.Text = "Item Name";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(189, 251);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(70, 22);
            this.Quantity.TabIndex = 81;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DeepPink;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(204, 341);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(163, 31);
            this.UpdateBtn.TabIndex = 79;
            this.UpdateBtn.Text = "Update Order";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(28, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 78;
            this.label6.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 76;
            this.label2.Text = "Order Date";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DeepPink;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(27, 341);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(149, 31);
            this.AddBtn.TabIndex = 75;
            this.AddBtn.Text = "Add Order";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(219, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 40);
            this.label1.TabIndex = 74;
            this.label1.Text = "Sales Orders List";
            // 
            // SalesOrderList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SalesOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.SalesOrderList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SalesOrderList.ColumnHeadersHeight = 25;
            this.SalesOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalesOrderList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesOrderList.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalesOrderList.GridColor = System.Drawing.Color.White;
            this.SalesOrderList.Location = new System.Drawing.Point(394, 79);
            this.SalesOrderList.Name = "SalesOrderList";
            this.SalesOrderList.RowHeadersVisible = false;
            this.SalesOrderList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.SalesOrderList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SalesOrderList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Turquoise;
            this.SalesOrderList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SalesOrderList.RowTemplate.Height = 24;
            this.SalesOrderList.Size = new System.Drawing.Size(586, 323);
            this.SalesOrderList.TabIndex = 73;
            this.SalesOrderList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesOrderList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SalesOrderList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SalesOrderList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SalesOrderList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SalesOrderList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.SalesOrderList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.SalesOrderList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SalesOrderList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SalesOrderList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOrderList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.SalesOrderList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalesOrderList.ThemeStyle.HeaderStyle.Height = 25;
            this.SalesOrderList.ThemeStyle.ReadOnly = false;
            this.SalesOrderList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesOrderList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SalesOrderList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesOrderList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SalesOrderList.ThemeStyle.RowsStyle.Height = 24;
            this.SalesOrderList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesOrderList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.CustomerListBox);
            this.Controls.Add(this.WarehouseListBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesOrderList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.ListBox WarehouseListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView SalesOrderList;
    }
}