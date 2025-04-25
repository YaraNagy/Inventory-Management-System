using FinalProject_EntityFreamework.Forms;
using FinalProject_EntityFreamework.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_EntityFreamework
{
    public partial class Form1 : Form
    {
        bool menuExpand = true;
        WarehouseForm warehouseForm;
        ItemsForm itemsForm;
        SupplierForm supplierForm;
        CustomerForm customerForm;
        PurchasedOrderForm purchasedOrderForm;
        SalesForm salesForm;
        TransferForm transferForm;
        ReportForm reportForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadWareHouseData()
        {
            using (var context = new DatabaseContext())
            {
                var warehouses = context.Warehouses
                    .Include(w => w.Items) // Include related Items
                    .Select(w => new
                    {
                        w.WareHouseID,
                        w.WareHouseName,
                        w.WareHouseLocation,
                        w.WareHouseManager,
                        ItemCount = w.Items.Count // Count the number of items in each warehouse
                    })
                    .ToList();

                // Bind the data to the DataGridView
                //dataGridView1.DataSource = warehouses;

            }
        }
        public void LoadItemsData()
        {
            using (var context = new DatabaseContext())
            {
                var Items = context.Items.ToList();

                // Bind the data to the DataGridView
                //dataGridView1.DataSource = Items;

                // Retrieve all sales orders and their items
                var salesOrders = context.SalesOrders
                    .Include(so => so.SalesItems) // Include related SalesItems
                    .Select(so => new
                    {
                        so.SalesID,
                        so.SalesDate,
                        CustomerName = so.Customer.CustomerName, // Access related Customer
                        ItemCount = so.SalesItems.Count // Count the number of items in each sales order
                    })
                    .ToList();
                //dataGridView1.DataSource = salesOrders;
                // Display sales orders in a message box (or another DataGridView)
                MessageBox.Show("Sales Orders Loaded: " + salesOrders.Count);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadWareHouseData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadItemsData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(warehouseForm == null)
            {
                warehouseForm = new WarehouseForm();
                warehouseForm.FormClosed += WarehouseForm_FormClosed;
                warehouseForm.MdiParent=this;
                warehouseForm.Dock = DockStyle.Fill;
                warehouseForm.Show();
            }
            else
            {
                warehouseForm.Activate();
            }
        }

        private void WarehouseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            warehouseForm = null;
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                PanelMenu.Width += 5;
                if (PanelMenu.Width >= 175)
                {
                    MenuTimer.Stop();
                    menuExpand = true;
                    this.Refresh();
                }
            }
            else
            {
                PanelMenu.Width -= 5;
                if (PanelMenu.Width <= 55)
                {
                    MenuTimer.Stop();
                    menuExpand = false;

                    this.Refresh();
                }


            }
            WarehousePanel.Width = PanelMenu.Width;
            ItemsPanel.Width = PanelMenu.Width;
            SalesPanel.Width = PanelMenu.Width;
            PurchasedPanel.Width = PanelMenu.Width;
            CustomersPanel.Width = PanelMenu.Width;
            SupplierPanel.Width = PanelMenu.Width;
            TransferPanel.Width = PanelMenu.Width;
            ReportsPanel.Width = PanelMenu.Width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemsBtn_Click(object sender, EventArgs e)
        {
            if (itemsForm == null)
            {
                itemsForm = new ItemsForm();
                itemsForm.FormClosed += ItemsForm_FormClosed;
                itemsForm.MdiParent = this;
                itemsForm.Dock = DockStyle.Fill;
                itemsForm.Show();
            }
            else
            {
                itemsForm.Activate();
            }

        }

        private void ItemsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            itemsForm = null;
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            if (supplierForm == null)
            {
                supplierForm = new SupplierForm();
                supplierForm.FormClosed += SupplierForm_FormClosed;
                supplierForm.MdiParent = this;
                supplierForm.Dock = DockStyle.Fill;
                supplierForm.Show();
            }
            else
            {
                supplierForm.Activate();
            }
        }

        private void SupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            supplierForm=null;
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            if (customerForm == null)
            {
                customerForm = new CustomerForm();
                customerForm.FormClosed += CustomerForm_FormClosed;
                customerForm.MdiParent = this;
                customerForm.Dock = DockStyle.Fill;
                customerForm.Show();
            }
            else
            {
                customerForm.Activate();
            }
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerForm=null;
        }

        private void PurchasedBtn_Click(object sender, EventArgs e)
        {
            if (purchasedOrderForm == null)
            {
                purchasedOrderForm = new PurchasedOrderForm();
                purchasedOrderForm.FormClosed += PurchasedOrderForm_FormClosed;
                purchasedOrderForm.MdiParent = this;
                purchasedOrderForm.Dock = DockStyle.Fill;
                purchasedOrderForm.Show();
            }
            else
            {
                purchasedOrderForm.Activate();
            }
        }

        private void PurchasedOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            purchasedOrderForm=null;
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            if (salesForm == null)
            {
                salesForm = new SalesForm();
                salesForm.FormClosed += SalesForm_FormClosed;
                salesForm.MdiParent = this;
                salesForm.Dock = DockStyle.Fill;
                salesForm.Show();
            }
            else
            {
                salesForm.Activate();
            }
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesForm=null;
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (transferForm == null)
            {
                transferForm = new TransferForm();
                transferForm.FormClosed += TransferForm_FormClosed;
                transferForm.MdiParent = this;
                transferForm.Dock = DockStyle.Fill;
                transferForm.Show();
            }
            else
            {
                transferForm.Activate();
            }
        }

        private void TransferForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            transferForm=null;
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                reportForm = new ReportForm();
                reportForm.FormClosed += ReportForm_FormClosed;
                reportForm.MdiParent = this;
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm=null;
        }
    }
}

