namespace FinalProject_EntityFreamework
{
    partial class WarehouseForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UpdateWarehouseBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WarehouseNameVal = new System.Windows.Forms.TextBox();
            this.WarehouseLocVal = new System.Windows.Forms.TextBox();
            this.AddWarehouseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WarehousesItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.WarehouseManagerVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesItems)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateWarehouseBtn
            // 
            this.UpdateWarehouseBtn.BackColor = System.Drawing.Color.DeepPink;
            this.UpdateWarehouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateWarehouseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateWarehouseBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateWarehouseBtn.Location = new System.Drawing.Point(189, 281);
            this.UpdateWarehouseBtn.Name = "UpdateWarehouseBtn";
            this.UpdateWarehouseBtn.Size = new System.Drawing.Size(163, 31);
            this.UpdateWarehouseBtn.TabIndex = 34;
            this.UpdateWarehouseBtn.Text = "Update Warehouse";
            this.UpdateWarehouseBtn.UseVisualStyleBackColor = false;
            this.UpdateWarehouseBtn.Click += new System.EventHandler(this.UpdateWarehouseBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Warehouse Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Warehouse location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Warehouse Name";
            // 
            // WarehouseNameVal
            // 
            this.WarehouseNameVal.Location = new System.Drawing.Point(189, 140);
            this.WarehouseNameVal.Name = "WarehouseNameVal";
            this.WarehouseNameVal.Size = new System.Drawing.Size(125, 22);
            this.WarehouseNameVal.TabIndex = 23;
            // 
            // WarehouseLocVal
            // 
            this.WarehouseLocVal.Location = new System.Drawing.Point(205, 172);
            this.WarehouseLocVal.Name = "WarehouseLocVal";
            this.WarehouseLocVal.Size = new System.Drawing.Size(109, 22);
            this.WarehouseLocVal.TabIndex = 22;
            // 
            // AddWarehouseBtn
            // 
            this.AddWarehouseBtn.BackColor = System.Drawing.Color.DeepPink;
            this.AddWarehouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWarehouseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWarehouseBtn.ForeColor = System.Drawing.Color.White;
            this.AddWarehouseBtn.Location = new System.Drawing.Point(12, 281);
            this.AddWarehouseBtn.Name = "AddWarehouseBtn";
            this.AddWarehouseBtn.Size = new System.Drawing.Size(149, 31);
            this.AddWarehouseBtn.TabIndex = 21;
            this.AddWarehouseBtn.Text = "Add Warehouse";
            this.AddWarehouseBtn.UseVisualStyleBackColor = false;
            this.AddWarehouseBtn.Click += new System.EventHandler(this.AddWarehouseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Warehouses List";
            // 
            // WarehousesItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.WarehousesItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WarehousesItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.WarehousesItems.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehousesItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WarehousesItems.ColumnHeadersHeight = 25;
            this.WarehousesItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.WarehousesItems.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WarehousesItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.WarehousesItems.GridColor = System.Drawing.Color.White;
            this.WarehousesItems.Location = new System.Drawing.Point(358, 115);
            this.WarehousesItems.Name = "WarehousesItems";
            this.WarehousesItems.RowHeadersVisible = false;
            this.WarehousesItems.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.WarehousesItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WarehousesItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Turquoise;
            this.WarehousesItems.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.WarehousesItems.RowTemplate.Height = 24;
            this.WarehousesItems.Size = new System.Drawing.Size(586, 323);
            this.WarehousesItems.TabIndex = 19;
            this.WarehousesItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.WarehousesItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.WarehousesItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.WarehousesItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.WarehousesItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.WarehousesItems.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.WarehousesItems.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.WarehousesItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.WarehousesItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.WarehousesItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehousesItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.WarehousesItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.WarehousesItems.ThemeStyle.HeaderStyle.Height = 25;
            this.WarehousesItems.ThemeStyle.ReadOnly = false;
            this.WarehousesItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.WarehousesItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.WarehousesItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehousesItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.WarehousesItems.ThemeStyle.RowsStyle.Height = 24;
            this.WarehousesItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.WarehousesItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.WarehousesItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarehousesItems_CellContentClick);
            // 
            // WarehouseManagerVal
            // 
            this.WarehouseManagerVal.Location = new System.Drawing.Point(205, 209);
            this.WarehouseManagerVal.Name = "WarehouseManagerVal";
            this.WarehouseManagerVal.Size = new System.Drawing.Size(109, 22);
            this.WarehouseManagerVal.TabIndex = 36;
            // 
            // WarehouseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(956, 491);
            this.Controls.Add(this.WarehouseManagerVal);
            this.Controls.Add(this.UpdateWarehouseBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WarehouseNameVal);
            this.Controls.Add(this.WarehouseLocVal);
            this.Controls.Add(this.AddWarehouseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarehousesItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button UpdateWarehouseBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WarehouseNameVal;
        private System.Windows.Forms.TextBox WarehouseLocVal;
        private System.Windows.Forms.Button AddWarehouseBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView WarehousesItems;
        private System.Windows.Forms.TextBox WarehouseManagerVal;
    }
}