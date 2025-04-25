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

namespace FinalProject_EntityFreamework
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
            
        }
        private void LoadData()
        {
            using (var context = new DatabaseContext())
            {
                var warehouses = context.Warehouses
                    .Select(w => new
                    {
                        ID = w.WareHouseID,
                        Name = w.WareHouseName,
                        Location = w.WareHouseLocation,
                        Manager = w.WareHouseManager,
                        ItemCount = w.Items.Count
                    })
                    .ToList();

                // Bind the data to the DataGridView
                WarehousesItems.DataSource = warehouses;

            }

        }
        private void AddWarehouse()
        {
            using (var context = new DatabaseContext())
            {
                var newWarehouse = new Warehouse
                {
                    WareHouseName=WarehouseNameVal.Text,
                    WareHouseLocation=WarehouseLocVal.Text,
                    WareHouseManager=WarehouseManagerVal.Text,
                };

                context.Warehouses.Add(newWarehouse);
                context.SaveChanges();

            }
            WarehouseNameVal.Text = WarehouseLocVal.Text = WarehouseManagerVal.Text = "";
        }
        private void AddWarehouseBtn_Click(object sender, EventArgs e)
        {
            AddWarehouse();
            LoadData();
        }
        public void UpdateWarehouse()
        {
            int rowIndex = WarehousesItems.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var warehouse = context.Warehouses.Find(WarehousesItems.Rows[rowIndex].Cells[0].Value);
                    if (warehouse != null)
                    {
                        warehouse.WareHouseManager = WarehouseManagerVal.Text;
                        warehouse.WareHouseLocation = WarehouseLocVal.Text;
                        warehouse.WareHouseName = WarehouseNameVal.Text;
                        context.SaveChanges();  // Update the database
                    }
                    else
                    {
                        MessageBox.Show("Warehouse not found");
                        Console.WriteLine("Warehouse not found!");
                    }
                }
            }
        }

        private void UpdateWarehouseBtn_Click(object sender, EventArgs e)
        {
            UpdateWarehouse();
            LoadData();
        }

        private void WarehousesItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = WarehousesItems.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var warehouse = context.Warehouses.Find(WarehousesItems.Rows[rowIndex].Cells[0].Value);
                    if (warehouse != null)
                    {
                        WarehouseNameVal.Text = warehouse.WareHouseName;
                        WarehouseLocVal.Text = warehouse.WareHouseLocation;
                         WarehouseManagerVal.Text=warehouse.WareHouseManager ;
                    }
                    else
                    {
                        MessageBox.Show("Warehouse not found");
                        Console.WriteLine(WarehousesItems.Rows[rowIndex].Cells[0].Value?.ToString());
                        Console.WriteLine("Warehouse not found!");
                    }

                }


            }
        }
    }
}
