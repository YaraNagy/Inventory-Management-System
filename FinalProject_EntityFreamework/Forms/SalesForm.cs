using FinalProject_EntityFreamework.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_EntityFreamework.Forms
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            loadData();
            using (var context = new DatabaseContext())
            {

                var warehouses = context.Warehouses;
                foreach (var item in warehouses)
                {
                    WarehouseListBox.Items.Add(item.WareHouseName);

                }
                var customers = context.Customers;
                foreach (var item in customers)
                {
                    CustomerListBox.Items.Add(item.CustomerName);
                }
                var items = context.Items;
                foreach (var item in items)
                {
                    ItemsListBox.Items.Add(item.ItemName);
                }

            }
        }
        private void loadData()
        {
            using (var context = new DatabaseContext())
            {
                var orders = context.SalesOrders.Select(
                    o => new
                    {
                        ID = o.SalesID,
                        Date = o.SalesDate,
                        Warehouse = o.Warehouse.WareHouseName,
                        Customer = o.Customer.CustomerName,
                        Items = o.SalesItems.Count
                    }
                    ).ToList();
                // Bind the data to the DataGridView
                SalesOrderList.DataSource = orders;
            }
        }
        private void AddOrder()
        {
            using (var context = new DatabaseContext())
            {
                var order = new SalesOrder
                {
                    SalesDate = DateTime.Parse(dateTimePicker1.Text),
                    Warehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString()),
                    WareHouseID = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString()).WareHouseID,
                    Customer = context.Customers.FirstOrDefault(s => s.CustomerName == CustomerListBox.SelectedItem.ToString()),
                    CustomerID = context.Customers.FirstOrDefault(s => s.CustomerName == CustomerListBox.SelectedItem.ToString()).CustomerID

                };
                context.SalesOrders.Add(order);
                context.SaveChanges();
            }
        }
        public void UpdateOrder()
        {
            int rowIndex = SalesOrderList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var order = context.SalesOrders.Find(SalesOrderList.Rows[rowIndex].Cells[0].Value);
                    if (order != null)
                    {
                        order.SalesDate = Convert.ToDateTime(SalesOrderList.Rows[rowIndex].Cells[1].Value);
                        order.Warehouse=context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString());
                        order.Customer = context.Customers.FirstOrDefault(c => c.CustomerName == CustomerListBox.SelectedItem.ToString());
                        order.CustomerID = context.Customers.FirstOrDefault(c => c.CustomerName == CustomerListBox.SelectedItem.ToString()).CustomerID;
                        order.WareHouseID = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString()).WareHouseID;

                        context.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("order not found!");
                        Console.WriteLine("order not found!");
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddOrder();
            loadData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateOrder();
            loadData();
        }
    }
}
