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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace FinalProject_EntityFreamework.Forms
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            using (var context = new DatabaseContext())
            {
                var Items = context.Items.Select(
                    i => new
                    {
                        i.ItemID,
                        i.ItemName,
                        i.ItemQuantity,
                        i.Warehouse.WareHouseName
                    }
                    ).ToList();
                // Bind the data to the DataGridView
                ItemsList.DataSource = Items;
            }
        }
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            
            using (var context = new DatabaseContext())
            {
                
                var warehouses = context.Warehouses;
                foreach (var item in warehouses)
                {
                    WarehouseListBox.Items.Add(item.WareHouseName);

                }
                
            }
            
        }

        private void AddItem()
        {
            using (var context = new DatabaseContext())
            {
                var newItem = new Item
                {
                    ItemName = ItemNameVal.Text,
                    ItemMeaningUnit = UnitListBox.SelectedItem.ToString(),
                    ItemQuantity = int.Parse(ItemQuantityVal.Text),
                    ItemProDate = DateTime.Parse(ProductionDateVal.Text),
                    ItemExpDate = DateTime.Parse(ExpirationDateVal.Text),
                    WareHouseID = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString()).WareHouseID,
                    Warehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString())
                };

                context.Items.Add(newItem);  
                context.SaveChanges(); 
            }
        }
        public void UpdateItem()
        {
            int rowIndex = ItemsList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var item = context.Items.Find(ItemsList.Rows[rowIndex].Cells[0].Value);
                    if (item != null)
                    {
                        item.ItemName = ItemNameVal.Text;
                        item.ItemMeaningUnit = UnitListBox.SelectedItem.ToString();
                        item.ItemQuantity =int.Parse(ItemQuantityVal.Text);
                        item.ItemProDate = DateTime.Parse(ProductionDateVal.Text);
                        item.ItemExpDate =DateTime.Parse( ExpirationDateVal.Text);
                        item.Warehouse = context.Warehouses.FirstOrDefault(w => w.WareHouseName == WarehouseListBox.SelectedItem.ToString());
                        item.WareHouseID = item.Warehouse.WareHouseID;
                        context.SaveChanges();  // Update the database
                    }
                    else
                    {
                        Console.WriteLine("Item not found!");
                    }
                }
            }
        }
        public void DeleteItem()
        {
            int rowIndex = ItemsList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {

                using (var context = new DatabaseContext())
                {
                    var item = context.Items.Find(ItemsList.Rows[rowIndex].Cells[0].Value);
                    if (item != null)
                    {
                        context.Items.Remove(item);
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Item not found!");
                    }
                    
                }
            }
        }

        private void ItemsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = ItemsList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var Item = context.Items.Find(ItemsList.Rows[rowIndex].Cells[0].Value);
                    if (Item != null)
                    {
                        ItemNameVal.Text = Item.ItemName;
                        UnitListBox.SelectedItem = Item.ItemMeaningUnit;
                        ItemQuantityVal.Text = Item.ItemQuantity.ToString();
                        ProductionDateVal.Text = Item.ItemProDate.ToString();
                        ExpirationDateVal.Text = Item.ItemExpDate.ToString();
                        //WarehouseListBox.SelectedItem = Item.Warehouse.WareHouseName;
                    }
                    else
                    {
                        Console.WriteLine(ItemsList.Rows[rowIndex].Cells[0].Value?.ToString());
                        Console.WriteLine("Item not found!");
                    }

                }


            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            AddItem();
            loadData();
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            UpdateItem();
            loadData();
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            DeleteItem();
            loadData();
        }
    }
}
