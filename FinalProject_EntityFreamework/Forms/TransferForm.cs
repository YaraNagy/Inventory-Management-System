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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loadData();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {

                var warehouses = context.Warehouses;
                foreach (var item in warehouses)
                {
                    ToWarehouseListBox.Items.Add(item.WareHouseName);
                    FromWarehouseListBox.Items.Add(item.WareHouseName);
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
                var transfer = context.Transfers.Select(
                    o => new
                    {
                        ID = o.TransferID,
                        Date = o.TransferDate,
                        To= o.ToWarehouse.WareHouseName,
                        From= o.FromWarehouse.WareHouseName,
                        Supplier = o.Supplier.SupplierName,
                        Items = o.Item.ItemName
                    }
                    ).ToList();
                // Bind the data to the DataGridView
                TransfersList.DataSource = transfer;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                var transfer = new Transfer
                {
                    TransferDate = DateTime.Parse(dateTimePicker1.Text),
                    ToWarehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == ToWarehouseListBox.SelectedItem.ToString()),
                    ToWareHouseID = context.Warehouses.FirstOrDefault(w => w.WareHouseName == ToWarehouseListBox.SelectedItem.ToString()).WareHouseID,
                    FromWarehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == FromWarehouseListBox.SelectedItem.ToString()),
                    FromWareHouseID = context.Warehouses.FirstOrDefault(w => w.WareHouseName == FromWarehouseListBox.SelectedItem.ToString()).WareHouseID,
                    Supplier = context.Suppliers.FirstOrDefault(s => s.SupplierName == SupplierListBox.SelectedItem.ToString()),
                    SupplierID = context.Suppliers.FirstOrDefault(s => s.SupplierName == SupplierListBox.SelectedItem.ToString()).SupplierID,
                    Item = context.Items.FirstOrDefault(i => i.ItemName == ItemsListBox.SelectedItem.ToString()),
                    ItemID = context.Items.FirstOrDefault(i => i.ItemName == ItemsListBox.SelectedItem.ToString()).ItemID,
                };
                
                context.Transfers.Add(transfer);
                context.SaveChanges();
            }
            loadData();
        }
        private void updateTransfer()
        {
            int rowIndex = TransfersList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var transfer = context.Transfers.Find(TransfersList.Rows[rowIndex].Cells[0].Value);
                    if (transfer != null)
                    {
                        transfer.TransferDate = DateTime.Parse(dateTimePicker1.Text);
                        transfer.ToWarehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == ToWarehouseListBox.SelectedItem.ToString());
                        transfer.ToWareHouseID = transfer.ToWarehouse.WareHouseID;
                        transfer.FromWarehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == FromWarehouseListBox.SelectedItem.ToString());
                        transfer.FromWareHouseID = transfer.FromWarehouse.WareHouseID;
                        transfer.Supplier = context.Suppliers.FirstOrDefault(s => s.SupplierName == SupplierListBox.SelectedItem.ToString());
                        transfer.SupplierID = transfer.Supplier.SupplierID;
                        transfer.Item = context.Items.FirstOrDefault(i => i.ItemName == ItemsListBox.SelectedItem.ToString());
                        transfer.ItemID = transfer.Item.ItemID;

                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Transfer not found!");
                        Console.WriteLine("Transfer not found!");
                    }
                }
            }

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateTransfer();
            loadData();
        }
    }
}
