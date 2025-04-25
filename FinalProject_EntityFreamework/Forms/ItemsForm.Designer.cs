namespace FinalProject_EntityFreamework.Forms
{
    partial class ItemsForm
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
            this.ItemsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.ItemQuantityVal = new System.Windows.Forms.TextBox();
            this.ItemNameVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UnitListBox = new System.Windows.Forms.ListBox();
            this.ProductionDateVal = new System.Windows.Forms.DateTimePicker();
            this.ExpirationDateVal = new System.Windows.Forms.DateTimePicker();
            this.WarehouseListBox = new System.Windows.Forms.ListBox();
            this.UpdateItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ItemsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsList.ColumnHeadersHeight = 25;
            this.ItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsList.GridColor = System.Drawing.Color.White;
            this.ItemsList.Location = new System.Drawing.Point(447, 115);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.RowHeadersVisible = false;
            this.ItemsList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ItemsList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Turquoise;
            this.ItemsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ItemsList.RowTemplate.Height = 24;
            this.ItemsList.Size = new System.Drawing.Size(545, 323);
            this.ItemsList.TabIndex = 1;
            this.ItemsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.ItemsList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.ItemsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ItemsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.ItemsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsList.ThemeStyle.HeaderStyle.Height = 25;
            this.ItemsList.ThemeStyle.ReadOnly = false;
            this.ItemsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsList.ThemeStyle.RowsStyle.Height = 24;
            this.ItemsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items List";
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.Color.DeepPink;
            this.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemBtn.ForeColor = System.Drawing.Color.White;
            this.AddItemBtn.Location = new System.Drawing.Point(47, 367);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(155, 31);
            this.AddItemBtn.TabIndex = 3;
            this.AddItemBtn.Text = "Add new Item";
            this.AddItemBtn.UseVisualStyleBackColor = false;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // ItemQuantityVal
            // 
            this.ItemQuantityVal.Location = new System.Drawing.Point(214, 171);
            this.ItemQuantityVal.Name = "ItemQuantityVal";
            this.ItemQuantityVal.Size = new System.Drawing.Size(200, 22);
            this.ItemQuantityVal.TabIndex = 4;
            // 
            // ItemNameVal
            // 
            this.ItemNameVal.Location = new System.Drawing.Point(214, 139);
            this.ItemNameVal.Name = "ItemNameVal";
            this.ItemNameVal.Size = new System.Drawing.Size(200, 22);
            this.ItemNameVal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(43, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(43, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(43, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Warehouse Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(43, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Item Mesuring Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label7.Location = new System.Drawing.Point(43, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Production Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Location = new System.Drawing.Point(43, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Expiration Date";
            // 
            // UnitListBox
            // 
            this.UnitListBox.FormattingEnabled = true;
            this.UnitListBox.ItemHeight = 16;
            this.UnitListBox.Items.AddRange(new object[] {
            "Piece",
            "Litter",
            "Gram",
            "Kilo"});
            this.UnitListBox.Location = new System.Drawing.Point(259, 206);
            this.UnitListBox.Name = "UnitListBox";
            this.UnitListBox.Size = new System.Drawing.Size(155, 20);
            this.UnitListBox.TabIndex = 13;
            // 
            // ProductionDateVal
            // 
            this.ProductionDateVal.Location = new System.Drawing.Point(259, 239);
            this.ProductionDateVal.Name = "ProductionDateVal";
            this.ProductionDateVal.Size = new System.Drawing.Size(155, 22);
            this.ProductionDateVal.TabIndex = 14;
            // 
            // ExpirationDateVal
            // 
            this.ExpirationDateVal.Location = new System.Drawing.Point(259, 275);
            this.ExpirationDateVal.Name = "ExpirationDateVal";
            this.ExpirationDateVal.Size = new System.Drawing.Size(155, 22);
            this.ExpirationDateVal.TabIndex = 15;
            // 
            // WarehouseListBox
            // 
            this.WarehouseListBox.FormattingEnabled = true;
            this.WarehouseListBox.ItemHeight = 16;
            this.WarehouseListBox.Location = new System.Drawing.Point(259, 312);
            this.WarehouseListBox.Name = "WarehouseListBox";
            this.WarehouseListBox.Size = new System.Drawing.Size(155, 20);
            this.WarehouseListBox.TabIndex = 16;
            // 
            // UpdateItemBtn
            // 
            this.UpdateItemBtn.BackColor = System.Drawing.Color.DeepPink;
            this.UpdateItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateItemBtn.Location = new System.Drawing.Point(259, 367);
            this.UpdateItemBtn.Name = "UpdateItemBtn";
            this.UpdateItemBtn.Size = new System.Drawing.Size(155, 31);
            this.UpdateItemBtn.TabIndex = 17;
            this.UpdateItemBtn.Text = "Update Item";
            this.UpdateItemBtn.UseVisualStyleBackColor = false;
            this.UpdateItemBtn.Click += new System.EventHandler(this.UpdateItemBtn_Click);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.UpdateItemBtn);
            this.Controls.Add(this.WarehouseListBox);
            this.Controls.Add(this.ExpirationDateVal);
            this.Controls.Add(this.ProductionDateVal);
            this.Controls.Add(this.UnitListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemNameVal);
            this.Controls.Add(this.ItemQuantityVal);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ItemsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.TextBox ItemQuantityVal;
        private System.Windows.Forms.TextBox ItemNameVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox UnitListBox;
        private System.Windows.Forms.DateTimePicker ProductionDateVal;
        private System.Windows.Forms.DateTimePicker ExpirationDateVal;
        private System.Windows.Forms.ListBox WarehouseListBox;
        private System.Windows.Forms.Button UpdateItemBtn;
    }
}