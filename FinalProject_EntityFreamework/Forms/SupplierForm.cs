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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            using (var context = new DatabaseContext())
            {
                var supplier = context.Suppliers.Select(
                    s => new
                    {
                        ID=s.SupplierID,
                        Name = s.SupplierName,
                        Phone = s.SupplierPhone,
                        Email = s.SupplierEmail
                    }
                    ).ToList();
                SupplierList.DataSource = supplier;
            }
        }
        private void AddSupplier()
        {
            using (var context = new DatabaseContext())
            {
                var supplier = new Supplier
                {
                    SupplierName = SupplierNameVal.Text,
                    SupplierPhone = SupplierPhoneVal.Text,
                    SupplierEmail = SupplierEmailVal.Text,
                    SupplierFax = SupplierFaxVal.Text,
                    SupplierWebsite = SupplierWebsiteVal.Text
                };
                
                context.Suppliers.Add(supplier);
                context.SaveChanges();
            }
        }
        public void UpdateSupplier()
        {
            int rowIndex = SupplierList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var suplier = context.Suppliers.Find(SupplierList.Rows[rowIndex].Cells[0].Value);
                    if (suplier != null)
                    {
                        suplier.SupplierName = SupplierNameVal.Text;
                        suplier.SupplierPhone = SupplierPhoneVal.Text;
                        suplier.SupplierEmail = SupplierEmailVal.Text;
                        suplier.SupplierFax = SupplierFaxVal.Text;
                        suplier.SupplierWebsite = SupplierWebsiteVal.Text;

                        context.SaveChanges();  
                    }
                    else
                    {
                        MessageBox.Show("Supplier not found!");
                        Console.WriteLine("Supplier not found!");
                    }
                }
            }
        }
        private void supplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = SupplierList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var supplier = context.Suppliers.Find(SupplierList.Rows[rowIndex].Cells[0].Value);
                    if (supplier != null)
                    {
                        SupplierNameVal.Text=supplier.SupplierName;
                        SupplierPhoneVal.Text = supplier.SupplierPhone;
                        SupplierEmailVal.Text = supplier.SupplierEmail;
                        SupplierFaxVal.Text = supplier.SupplierFax;
                        SupplierWebsiteVal.Text = supplier.SupplierWebsite;
                    }
                    else
                    {
                        Console.WriteLine(SupplierList.Rows[rowIndex].Cells[0].Value?.ToString());
                        Console.WriteLine("Item not found!");
                    }

                }


            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddSupplier();
            loadData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
            loadData();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
