namespace FinalProject_EntityFreamework.Forms
{
    partial class TransferForm
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
            this.SupplierListBox = new System.Windows.Forms.ListBox();
            this.ToWarehouseListBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TransfersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FromWarehouseListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransfersList)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(13, 144);
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
            this.ItemsListBox.Location = new System.Drawing.Point(174, 111);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(178, 22);
            this.ItemsListBox.TabIndex = 86;
            // 
            // SupplierListBox
            // 
            this.SupplierListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierListBox.FormattingEnabled = true;
            this.SupplierListBox.ItemHeight = 18;
            this.SupplierListBox.Location = new System.Drawing.Point(174, 274);
            this.SupplierListBox.Name = "SupplierListBox";
            this.SupplierListBox.Size = new System.Drawing.Size(178, 22);
            this.SupplierListBox.TabIndex = 85;
            // 
            // ToWarehouseListBox
            // 
            this.ToWarehouseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToWarehouseListBox.FormattingEnabled = true;
            this.ToWarehouseListBox.ItemHeight = 18;
            this.ToWarehouseListBox.Location = new System.Drawing.Point(174, 209);
            this.ToWarehouseListBox.Name = "ToWarehouseListBox";
            this.ToWarehouseListBox.Size = new System.Drawing.Size(178, 22);
            this.ToWarehouseListBox.TabIndex = 84;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 82;
            this.label5.Text = "Item Name";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(174, 146);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(178, 22);
            this.Quantity.TabIndex = 81;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DeepPink;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(189, 328);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(163, 31);
            this.UpdateBtn.TabIndex = 79;
            this.UpdateBtn.Text = "Update Transfer";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(13, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 22);
            this.label6.TabIndex = 78;
            this.label6.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(13, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "To Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(13, 178);
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
            this.AddBtn.Location = new System.Drawing.Point(12, 328);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(149, 31);
            this.AddBtn.TabIndex = 75;
            this.AddBtn.Text = "Add Transfer";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 40);
            this.label1.TabIndex = 74;
            this.label1.Text = "Transfers List";
            // 
            // TransfersList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TransfersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TransfersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TransfersList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransfersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TransfersList.ColumnHeadersHeight = 25;
            this.TransfersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TransfersList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransfersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.TransfersList.GridColor = System.Drawing.Color.White;
            this.TransfersList.Location = new System.Drawing.Point(382, 73);
            this.TransfersList.Name = "TransfersList";
            this.TransfersList.RowHeadersVisible = false;
            this.TransfersList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.TransfersList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TransfersList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Turquoise;
            this.TransfersList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.TransfersList.RowTemplate.Height = 24;
            this.TransfersList.Size = new System.Drawing.Size(586, 323);
            this.TransfersList.TabIndex = 73;
            this.TransfersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TransfersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TransfersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TransfersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TransfersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TransfersList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.TransfersList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.TransfersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TransfersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TransfersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransfersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.TransfersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TransfersList.ThemeStyle.HeaderStyle.Height = 25;
            this.TransfersList.ThemeStyle.ReadOnly = false;
            this.TransfersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TransfersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TransfersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransfersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TransfersList.ThemeStyle.RowsStyle.Height = 24;
            this.TransfersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TransfersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FromWarehouseListBox
            // 
            this.FromWarehouseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromWarehouseListBox.FormattingEnabled = true;
            this.FromWarehouseListBox.ItemHeight = 18;
            this.FromWarehouseListBox.Location = new System.Drawing.Point(210, 241);
            this.FromWarehouseListBox.Name = "FromWarehouseListBox";
            this.FromWarehouseListBox.Size = new System.Drawing.Size(142, 22);
            this.FromWarehouseListBox.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Location = new System.Drawing.Point(13, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 22);
            this.label8.TabIndex = 90;
            this.label8.Text = "From Warehouse";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FromWarehouseListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.SupplierListBox);
            this.Controls.Add(this.ToWarehouseListBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransfersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransfersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox SupplierListBox;
        private System.Windows.Forms.ListBox ToWarehouseListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView TransfersList;
        private System.Windows.Forms.ListBox FromWarehouseListBox;
        private System.Windows.Forms.Label label8;
    }
}