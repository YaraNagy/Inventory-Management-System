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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            using (var context = new DatabaseContext())
            {
                var Customers = context.Customers.Select(
                    c => new
                    {
                        ID = c.CustomerID,
                        Name = c.CustomerName,
                        Phone = c.CustomerPhone,
                        OrderCount = c.SalesOrders.Count
                    }
                    ).ToList();
                // Bind the data to the DataGridView
                CustomerList.DataSource = Customers;
            }
        }
        private void addCustomer()
        {
            using (var context = new DatabaseContext())
            {
                var newCustomer = new Customer
                {
                    CustomerName = CustomerNameVal.Text,
                    CustomerPhone = CustomerPhoneVal.Text
                };
                context.Customers.Add(newCustomer);
                context.SaveChanges();
            }
        }
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            addCustomer();
            loadData();
        }
        private void updateCustomer()
        {
            int rowIndex = CustomerList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var customer = context.Customers.Find(CustomerList.Rows[rowIndex].Cells[0].Value);
                    if (customer != null)
                    {

                        customer.CustomerName = CustomerNameVal.Text;
                        customer.CustomerPhone = CustomerPhoneVal.Text;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!");
                        Console.WriteLine("Customer not found!");
                    }

                }
            }
        }
        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            updateCustomer();
            loadData();
        }

        private void CustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = CustomerList.CurrentCell.RowIndex;
            if (rowIndex > 0)
            {
                using (var context = new DatabaseContext())
                {
                    var customer = context.Customers.Find(CustomerList.Rows[rowIndex].Cells[0].Value);
                    if (customer != null)
                    {
                        CustomerNameVal.Text = customer.CustomerName;
                        CustomerPhoneVal.Text = customer.CustomerPhone;
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!");
                        Console.WriteLine(CustomerList.Rows[rowIndex].Cells[0].Value?.ToString());
                        Console.WriteLine("Customer not found!");
                    }

                }


            }
        }
    }
}
