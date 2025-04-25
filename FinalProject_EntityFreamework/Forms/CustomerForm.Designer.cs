namespace FinalProject_EntityFreamework.Forms
{
    partial class CustomerForm
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
            this.UpdateCustomerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameVal = new System.Windows.Forms.TextBox();
            this.CustomerPhoneVal = new System.Windows.Forms.TextBox();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateCustomerBtn
            // 
            this.UpdateCustomerBtn.BackColor = System.Drawing.Color.DeepPink;
            this.UpdateCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCustomerBtn.Location = new System.Drawing.Point(182, 281);
            this.UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            this.UpdateCustomerBtn.Size = new System.Drawing.Size(163, 31);
            this.UpdateCustomerBtn.TabIndex = 45;
            this.UpdateCustomerBtn.Text = "Update Customer";
            this.UpdateCustomerBtn.UseVisualStyleBackColor = false;
            this.UpdateCustomerBtn.Click += new System.EventHandler(this.UpdateCustomerBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(2, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Customer Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(5, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Customer Name";
            // 
            // CustomerNameVal
            // 
            this.CustomerNameVal.Location = new System.Drawing.Point(204, 185);
            this.CustomerNameVal.Name = "CustomerNameVal";
            this.CustomerNameVal.Size = new System.Drawing.Size(141, 22);
            this.CustomerNameVal.TabIndex = 41;
            // 
            // CustomerPhoneVal
            // 
            this.CustomerPhoneVal.Location = new System.Drawing.Point(204, 157);
            this.CustomerPhoneVal.Name = "CustomerPhoneVal";
            this.CustomerPhoneVal.Size = new System.Drawing.Size(138, 22);
            this.CustomerPhoneVal.TabIndex = 40;
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.BackColor = System.Drawing.Color.DeepPink;
            this.AddCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.AddCustomerBtn.Location = new System.Drawing.Point(5, 281);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(149, 31);
            this.AddCustomerBtn.TabIndex = 39;
            this.AddCustomerBtn.Text = "Add Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = false;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(295, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "Customers List";
            // 
            // CustomerList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.CustomerList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerList.ColumnHeadersHeight = 25;
            this.CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerList.GridColor = System.Drawing.Color.White;
            this.CustomerList.Location = new System.Drawing.Point(486, 89);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.RowHeadersVisible = false;
            this.CustomerList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.CustomerList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.HotPink;
            this.CustomerList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerList.RowTemplate.Height = 24;
            this.CustomerList.Size = new System.Drawing.Size(586, 323);
            this.CustomerList.TabIndex = 37;
            this.CustomerList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.CustomerList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CustomerList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerList.ThemeStyle.HeaderStyle.Height = 25;
            this.CustomerList.ThemeStyle.ReadOnly = false;
            this.CustomerList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerList.ThemeStyle.RowsStyle.Height = 24;
            this.CustomerList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerList_CellContentClick);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.UpdateCustomerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNameVal);
            this.Controls.Add(this.CustomerPhoneVal);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpdateCustomerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerNameVal;
        private System.Windows.Forms.TextBox CustomerPhoneVal;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerList;
    }
}