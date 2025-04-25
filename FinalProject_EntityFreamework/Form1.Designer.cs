namespace FinalProject_EntityFreamework
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.WarehousePanel = new System.Windows.Forms.Panel();
            this.WarehouseBtn = new System.Windows.Forms.Button();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.ItemsBtn = new System.Windows.Forms.Button();
            this.SupplierPanel = new System.Windows.Forms.Panel();
            this.SupplierBtn = new System.Windows.Forms.Button();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.PurchasedPanel = new System.Windows.Forms.Panel();
            this.PurchasedBtn = new System.Windows.Forms.Button();
            this.SalesPanel = new System.Windows.Forms.Panel();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.TransferPanel = new System.Windows.Forms.Panel();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.ReportsPanel = new System.Windows.Forms.Panel();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.WarehousePanel.SuspendLayout();
            this.ItemsPanel.SuspendLayout();
            this.SupplierPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.PurchasedPanel.SuspendLayout();
            this.SalesPanel.SuspendLayout();
            this.TransferPanel.SuspendLayout();
            this.ReportsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 37);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.panel10);
            this.PanelMenu.Controls.Add(this.WarehousePanel);
            this.PanelMenu.Controls.Add(this.ItemsPanel);
            this.PanelMenu.Controls.Add(this.SupplierPanel);
            this.PanelMenu.Controls.Add(this.CustomersPanel);
            this.PanelMenu.Controls.Add(this.PurchasedPanel);
            this.PanelMenu.Controls.Add(this.SalesPanel);
            this.PanelMenu.Controls.Add(this.TransferPanel);
            this.PanelMenu.Controls.Add(this.ReportsPanel);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 37);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(194, 504);
            this.PanelMenu.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel10.Size = new System.Drawing.Size(200, 17);
            this.panel10.TabIndex = 7;
            // 
            // WarehousePanel
            // 
            this.WarehousePanel.Controls.Add(this.WarehouseBtn);
            this.WarehousePanel.Location = new System.Drawing.Point(3, 26);
            this.WarehousePanel.Name = "WarehousePanel";
            this.WarehousePanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.WarehousePanel.Size = new System.Drawing.Size(200, 44);
            this.WarehousePanel.TabIndex = 6;
            // 
            // WarehouseBtn
            // 
            this.WarehouseBtn.BackColor = System.Drawing.Color.White;
            this.WarehouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarehouseBtn.ForeColor = System.Drawing.Color.Black;
            this.WarehouseBtn.Image = ((System.Drawing.Image)(resources.GetObject("WarehouseBtn.Image")));
            this.WarehouseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WarehouseBtn.Location = new System.Drawing.Point(-13, -14);
            this.WarehouseBtn.Name = "WarehouseBtn";
            this.WarehouseBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.WarehouseBtn.Size = new System.Drawing.Size(252, 74);
            this.WarehouseBtn.TabIndex = 0;
            this.WarehouseBtn.Text = "Warehouses";
            this.WarehouseBtn.UseVisualStyleBackColor = false;
            this.WarehouseBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.Controls.Add(this.ItemsBtn);
            this.ItemsPanel.Location = new System.Drawing.Point(3, 76);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ItemsPanel.Size = new System.Drawing.Size(200, 44);
            this.ItemsPanel.TabIndex = 7;
            // 
            // ItemsBtn
            // 
            this.ItemsBtn.BackColor = System.Drawing.Color.White;
            this.ItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsBtn.ForeColor = System.Drawing.Color.Black;
            this.ItemsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ItemsBtn.Image")));
            this.ItemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemsBtn.Location = new System.Drawing.Point(-13, -14);
            this.ItemsBtn.Name = "ItemsBtn";
            this.ItemsBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ItemsBtn.Size = new System.Drawing.Size(252, 74);
            this.ItemsBtn.TabIndex = 0;
            this.ItemsBtn.Text = "Items";
            this.ItemsBtn.UseVisualStyleBackColor = false;
            this.ItemsBtn.Click += new System.EventHandler(this.ItemsBtn_Click);
            // 
            // SupplierPanel
            // 
            this.SupplierPanel.Controls.Add(this.SupplierBtn);
            this.SupplierPanel.Location = new System.Drawing.Point(3, 126);
            this.SupplierPanel.Name = "SupplierPanel";
            this.SupplierPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.SupplierPanel.Size = new System.Drawing.Size(200, 44);
            this.SupplierPanel.TabIndex = 7;
            // 
            // SupplierBtn
            // 
            this.SupplierBtn.BackColor = System.Drawing.Color.White;
            this.SupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierBtn.ForeColor = System.Drawing.Color.Black;
            this.SupplierBtn.Image = ((System.Drawing.Image)(resources.GetObject("SupplierBtn.Image")));
            this.SupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupplierBtn.Location = new System.Drawing.Point(-13, -14);
            this.SupplierBtn.Name = "SupplierBtn";
            this.SupplierBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.SupplierBtn.Size = new System.Drawing.Size(252, 74);
            this.SupplierBtn.TabIndex = 0;
            this.SupplierBtn.Text = "Suppliers";
            this.SupplierBtn.UseVisualStyleBackColor = false;
            this.SupplierBtn.Click += new System.EventHandler(this.SupplierBtn_Click);
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Controls.Add(this.CustomerBtn);
            this.CustomersPanel.Location = new System.Drawing.Point(3, 176);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.CustomersPanel.Size = new System.Drawing.Size(200, 44);
            this.CustomersPanel.TabIndex = 8;
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.BackColor = System.Drawing.Color.White;
            this.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBtn.ForeColor = System.Drawing.Color.Black;
            this.CustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.Image")));
            this.CustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerBtn.Location = new System.Drawing.Point(-13, -14);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.CustomerBtn.Size = new System.Drawing.Size(252, 74);
            this.CustomerBtn.TabIndex = 0;
            this.CustomerBtn.Text = "Customers";
            this.CustomerBtn.UseVisualStyleBackColor = false;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // PurchasedPanel
            // 
            this.PurchasedPanel.Controls.Add(this.PurchasedBtn);
            this.PurchasedPanel.Location = new System.Drawing.Point(3, 226);
            this.PurchasedPanel.Name = "PurchasedPanel";
            this.PurchasedPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.PurchasedPanel.Size = new System.Drawing.Size(200, 44);
            this.PurchasedPanel.TabIndex = 9;
            // 
            // PurchasedBtn
            // 
            this.PurchasedBtn.BackColor = System.Drawing.Color.White;
            this.PurchasedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchasedBtn.ForeColor = System.Drawing.Color.Black;
            this.PurchasedBtn.Image = ((System.Drawing.Image)(resources.GetObject("PurchasedBtn.Image")));
            this.PurchasedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PurchasedBtn.Location = new System.Drawing.Point(-13, -14);
            this.PurchasedBtn.Name = "PurchasedBtn";
            this.PurchasedBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PurchasedBtn.Size = new System.Drawing.Size(252, 74);
            this.PurchasedBtn.TabIndex = 0;
            this.PurchasedBtn.Text = "Purchased Orders";
            this.PurchasedBtn.UseVisualStyleBackColor = false;
            this.PurchasedBtn.Click += new System.EventHandler(this.PurchasedBtn_Click);
            // 
            // SalesPanel
            // 
            this.SalesPanel.Controls.Add(this.SalesBtn);
            this.SalesPanel.Location = new System.Drawing.Point(3, 276);
            this.SalesPanel.Name = "SalesPanel";
            this.SalesPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.SalesPanel.Size = new System.Drawing.Size(200, 44);
            this.SalesPanel.TabIndex = 10;
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.White;
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.ForeColor = System.Drawing.Color.Black;
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesBtn.Location = new System.Drawing.Point(-13, -14);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.SalesBtn.Size = new System.Drawing.Size(252, 74);
            this.SalesBtn.TabIndex = 0;
            this.SalesBtn.Text = "Sales Orders";
            this.SalesBtn.UseVisualStyleBackColor = false;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // TransferPanel
            // 
            this.TransferPanel.Controls.Add(this.TransferBtn);
            this.TransferPanel.Location = new System.Drawing.Point(3, 326);
            this.TransferPanel.Name = "TransferPanel";
            this.TransferPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.TransferPanel.Size = new System.Drawing.Size(200, 44);
            this.TransferPanel.TabIndex = 11;
            // 
            // TransferBtn
            // 
            this.TransferBtn.BackColor = System.Drawing.Color.White;
            this.TransferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferBtn.ForeColor = System.Drawing.Color.Black;
            this.TransferBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransferBtn.Image")));
            this.TransferBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransferBtn.Location = new System.Drawing.Point(-13, -14);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.TransferBtn.Size = new System.Drawing.Size(252, 74);
            this.TransferBtn.TabIndex = 0;
            this.TransferBtn.Text = "Transfers";
            this.TransferBtn.UseVisualStyleBackColor = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // ReportsPanel
            // 
            this.ReportsPanel.Controls.Add(this.ReportsBtn);
            this.ReportsPanel.Location = new System.Drawing.Point(3, 376);
            this.ReportsPanel.Name = "ReportsPanel";
            this.ReportsPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ReportsPanel.Size = new System.Drawing.Size(200, 44);
            this.ReportsPanel.TabIndex = 12;
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackColor = System.Drawing.Color.White;
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsBtn.ForeColor = System.Drawing.Color.Black;
            this.ReportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportsBtn.Image")));
            this.ReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsBtn.Location = new System.Drawing.Point(-13, -14);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ReportsBtn.Size = new System.Drawing.Size(252, 74);
            this.ReportsBtn.TabIndex = 0;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = false;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // MenuTimer
            // 
            this.MenuTimer.Interval = 10;
            this.MenuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(950, 541);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.WarehousePanel.ResumeLayout(false);
            this.ItemsPanel.ResumeLayout(false);
            this.SupplierPanel.ResumeLayout(false);
            this.CustomersPanel.ResumeLayout(false);
            this.PurchasedPanel.ResumeLayout(false);
            this.SalesPanel.ResumeLayout(false);
            this.TransferPanel.ResumeLayout(false);
            this.ReportsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel PanelMenu;
        private System.Windows.Forms.Panel WarehousePanel;
        private System.Windows.Forms.Button WarehouseBtn;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Button ItemsBtn;
        private System.Windows.Forms.Panel SupplierPanel;
        private System.Windows.Forms.Button SupplierBtn;
        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Panel PurchasedPanel;
        private System.Windows.Forms.Button PurchasedBtn;
        private System.Windows.Forms.Panel SalesPanel;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Panel TransferPanel;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Panel ReportsPanel;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Timer MenuTimer;
        private System.Windows.Forms.Panel panel10;
    }
}

