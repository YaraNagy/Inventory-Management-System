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
    public partial class PurchasedOrderForm : Form
    {
        PurchasedItem newpurchasedItems;
        public PurchasedOrderForm()
        {
            InitializeComponent();
            loadData();
        }
        private void PurchasedOrderForm_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {

                var warehouses = context.Warehouses;
                foreach (var item in warehouses)
                {
                    WarehouseListBox.Items.Add(item.WareHouseName);

                }
                var suppliers = context.Suppliers;
                foreach (var item in suppliers)
                {
                    SupplierListBox.Items.Add(item.SupplierName);
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
                var orders = context.PurchaseOrders.Select(
                    o => new
                    {
                        ID = o.OrderID,
                        Date = o.OrderDate,
                        Warehouse = o.Warehouse.WareHouseName,
                        Supplier = o.Supplier.SupplierName,
                        Items = o.PurchasedItems.Count
                    }
                    ).ToList();
                // Bind the data to the DataGridView
                PurchasedOrderList.DataSource = orders;
            }
        }
        private void AddOrder()
        {
            using (var context = new DatabaseContext())
            {
                var order = new PurchasedOrder
                {
                    OrderDate = DateTime.Parse(dateTimePicker1.Text),
                    Warehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString()),
                    WareHouseID = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString()).WareHouseID,
                    Supplier = context.Suppliers.FirstOrDefault(s => s.SupplierName == SupplierListBox.SelectedItem.ToString()),
                    SupplierID = context.Suppliers.FirstOrDefault(s => s.SupplierName == SupplierListBox.SelectedItem.ToString()).SupplierID,
                    
                };
                dateTimePicker1.Text = "";
                WarehouseListBox.SelectedItem = null;
                SupplierListBox.SelectedItem = null;
                ItemsListBox.SelectedItem = null;
                itemsCount.Text = "0";
                context.PurchaseOrders.Add(order);
                context.SaveChanges();
            }
        }
        public void UpdateOrder()
        {
            int rowIndex = PurchasedOrderList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var order = context.PurchaseOrders.Find(PurchasedOrderList.Rows[rowIndex].Cells[0].Value);
                    if (order != null)
                    {
                        order.OrderDate = DateTime.Parse(dateTimePicker1.Text);
                        order.Warehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString());
                        order.WareHouseID = order.Warehouse.WareHouseID;
                        order.Supplier = context.Suppliers.FirstOrDefault(s => s.SupplierName == SupplierListBox.SelectedItem.ToString());
                        order.SupplierID = order.Supplier.SupplierID;
                        context.SaveChanges();

                        dateTimePicker1.Text = "";
                        WarehouseListBox.SelectedItem = null;
                        SupplierListBox.SelectedItem = null;
                        ItemsListBox.SelectedItem = null;
                        itemsCount.Text = "0";

                    }
                    else
                    {
                        MessageBox.Show("order not found!");
                        Console.WriteLine("order not found!");
                    }
                }
            }
        }
        private void PurchasedOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = PurchasedOrderList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var order = context.PurchaseOrders.Find(PurchasedOrderList.Rows[rowIndex].Cells[0].Value);
                    if (order != null)
                    {
                        dateTimePicker1.Text = order.OrderDate.ToString();
                        WarehouseListBox.SelectedItem = order.Warehouse?.WareHouseName ?? "Unknown";
                        SupplierListBox.SelectedItem = order.Supplier?.SupplierName ?? "Unknown";
                        itemsCount.Text = order.PurchasedItems.Count.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Order not found");
                        Console.WriteLine(PurchasedOrderList.Rows[rowIndex].Cells[0].Value?.ToString());
                        Console.WriteLine("Order not found!");
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

        private void AddItemToOrder_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                newpurchasedItems=new PurchasedItem
                {
                    ItemQuality = int.Parse(Quantity.Text),
                    Item = context.Items.FirstOrDefault(i => i.ItemName == ItemsListBox.SelectedItem.ToString()),
                    ItemID = context.Items.FirstOrDefault(i => i.ItemName == ItemsListBox.SelectedItem.ToString()).ItemID,
                    PurchasedOrder = context.PurchaseOrders.FirstOrDefault(o => o.OrderID == int.Parse(PurchasedOrderList.Rows[PurchasedOrderList.CurrentCell.RowIndex].Cells[0].Value.ToString())),
                    PurchasedOrderID = int.Parse(PurchasedOrderList.Rows[PurchasedOrderList.CurrentCell.RowIndex].Cells[0].Value.ToString())
                };
                var order = context.PurchaseOrders.FirstOrDefault(o => o.OrderID == int.Parse(PurchasedOrderList.Rows[PurchasedOrderList.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                if (order != null)
                {
                    
                        order.PurchasedItems.Add(newpurchasedItems);
                        itemsCount.Text = order.PurchasedItems.Count.ToString();
                    
                    
                }
                else
                {
                    MessageBox.Show("Order not found");
                    Console.WriteLine("Order not found!");
                }
            }

        }
    }
}
