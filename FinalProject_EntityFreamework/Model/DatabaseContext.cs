using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("NourhaneDB")
        {
            Database.SetInitializer(new CompanyInitializer());

        }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PurchasedOrder> PurchaseOrders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<SalesOrderItem> SalesItems { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<PurchasedItem> PurchaseItems { get; set; }
        public DbSet<Customer> Customers { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Warehouse configurations
            modelBuilder.Entity<Warehouse>()
                .HasKey(w => w.WareHouseID);

            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.Items)
                .WithRequired(i => i.Warehouse)
                .HasForeignKey(i => i.WareHouseID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.TransfersFrom)
                .WithRequired(t => t.FromWarehouse)
                .HasForeignKey(t => t.FromWareHouseID)
                .WillCascadeOnDelete(false); // Restrict delete in EF6

            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.TransfersTo)
                .WithRequired(t => t.ToWarehouse)
                .HasForeignKey(t => t.ToWareHouseID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.PurchasedOrders)
                .WithRequired(po => po.Warehouse)
                .HasForeignKey(po => po.WareHouseID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Warehouse>()
                .HasMany(w => w.SalesOrders)
                .WithRequired(so => so.Warehouse)
                .HasForeignKey(so => so.WareHouseID)
                .WillCascadeOnDelete(true);

            // Item configurations
            modelBuilder.Entity<Item>()
                .HasKey(i => i.ItemID);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.Transfers)
                .WithRequired(t => t.Item)
                .HasForeignKey(t => t.ItemID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.PurchasedItems)
                .WithRequired(pi => pi.Item)
                .HasForeignKey(pi => pi.ItemID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Item>()
                .HasMany(i => i.SalesItems)
                .WithRequired(si => si.Item)
                .HasForeignKey(si => si.ItemID)
                .WillCascadeOnDelete(true);

            // PurchaseOrder configurations
            modelBuilder.Entity<PurchasedOrder>()
                .HasKey(po => po.OrderID);

            modelBuilder.Entity<PurchasedOrder>()
                .HasMany(po => po.PurchasedItems)
                .WithRequired(pi => pi.PurchasedOrder)
                .HasForeignKey(pi => pi.PurchasedOrderID);

            // Supplier configurations
            modelBuilder.Entity<Supplier>()
                .HasKey(s => s.SupplierID);

            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.Transfers)
                .WithRequired(t => t.Supplier)
                .HasForeignKey(t => t.SupplierID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.PurchasedOrders)
                .WithRequired(po => po.Supplier)
                .HasForeignKey(po => po.SupplierID)
                .WillCascadeOnDelete(true);

            // Transfer configurations
            modelBuilder.Entity<Transfer>()
                .HasKey(t => t.TransferID);

            // SalesItem configurations
            modelBuilder.Entity<SalesOrderItem>()
                .HasKey(si => si.SalesItemsID);

            modelBuilder.Entity<SalesOrderItem>()
                .HasRequired(si => si.SalesOrder)
                .WithMany(so => so.SalesItems)
                .HasForeignKey(si => si.SalesOrderID)
                .WillCascadeOnDelete(true);

            // SalesOrder configurations
            modelBuilder.Entity<SalesOrder>()
                .HasKey(so => so.SalesID);

            modelBuilder.Entity<SalesOrder>()
                .HasMany(so => so.SalesItems)
                .WithRequired(si => si.SalesOrder)
                .HasForeignKey(si => si.SalesOrderID)
                .WillCascadeOnDelete(true);

            // PurchaseItem configurations
            modelBuilder.Entity<PurchasedItem>()
                .HasKey(pi => new { pi.PurchasedOrderID, pi.ItemID });

            modelBuilder.Entity<PurchasedItem>()
                .HasRequired(pi => pi.PurchasedOrder)
                .WithMany(po => po.PurchasedItems)
                .HasForeignKey(pi => pi.PurchasedOrderID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<PurchasedItem>()
                 .HasRequired(pi => pi.Item)
                 .WithMany(i => i.PurchasedItems)
                 .HasForeignKey(pi => pi.ItemID)
                 .WillCascadeOnDelete(true);

            // Customer configurations
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.CustomerID);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.SalesOrders)
                .WithRequired(so => so.Customer)
                .HasForeignKey(so => so.CustomerID)
                .WillCascadeOnDelete(true);
        }

    }
    internal class CompanyInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            // Add Warehouses
            var warehouse1 = new Warehouse
            {
                WareHouseName = "Warehouse1",
                WareHouseLocation = "Smouha",
                WareHouseManager = "Samy"
            };
            var warehouse2 = new Warehouse
            {
                WareHouseName = "Warehouse2",
                WareHouseLocation = "Gleem",
                WareHouseManager = "Ahmed Medhat"
            };


            // Add Suppliers
            var supplier1 = new Supplier
            {
                SupplierName = "ABC Supplier",
                SupplierPhone = "015428793",
                SupplierEmail = "ABC@gmail.com"
            };
            var supplier2 = new Supplier
            {
                SupplierName = "Tech Supplier",
                SupplierPhone = "0147859632",
                SupplierEmail = "tech@gmail.com"
            };
            context.Suppliers.Add(supplier1);
            context.Suppliers.Add(supplier2);

            // Add Items
            var item1 = new Item
            {
                ItemName = "Laptop",
                ItemMeaningUnit = "Piece",
                ItemQuantity = 50,
                ItemExpDate = DateTime.Now.AddYears(2),
                ItemProDate = DateTime.Now,
                Warehouse = warehouse1
            };
            var item2 = new Item
            {
                ItemName = "Monitor",
                ItemMeaningUnit = "Piece",
                ItemQuantity = 100,
                ItemExpDate = DateTime.Now.AddYears(3),
                ItemProDate = DateTime.Now,
                Warehouse = warehouse1
            };

            var item3 = new Item
            {
                ItemName = "Mac Laptop",
                ItemMeaningUnit = "Piece",
                ItemQuantity = 50,
                ItemExpDate = DateTime.Now.AddYears(2),
                ItemProDate = DateTime.Now,
                Warehouse = warehouse2
            };
            var item4 = new Item
            {
                ItemName = "Mug",
                ItemMeaningUnit = "Piece",
                ItemQuantity = 100,
                ItemExpDate = DateTime.Now.AddYears(3),
                ItemProDate = DateTime.Now,
                Warehouse = warehouse2
            };
            context.Items.Add(item1);
            context.Items.Add(item2);

            context.Items.Add(item3);
            context.Items.Add(item4);

            warehouse1.Items.Add(item1);
            warehouse1.Items.Add(item2);

            warehouse2.Items.Add(item3);
            warehouse2.Items.Add(item4);

            context.Warehouses.Add(warehouse1);
            context.Warehouses.Add(warehouse2);

            // Add Customers
            var customer1 = new Customer
            {
                CustomerName = "Ahmed Mohsen",
                CustomerPhone = "0145236589"
            };
            var customer2 = new Customer
            {
                CustomerName = "May Metwaly",
                CustomerPhone = "0124578965"
            };
            context.Customers.Add(customer1);
            context.Customers.Add(customer2);

            //// Add Purchase Orders
            var purchaseOrder1 = new PurchasedOrder
            {
                OrderDate = DateTime.Now,
                WareHouseID = warehouse1.WareHouseID,
                SupplierID = supplier1.SupplierID,
                Supplier = supplier1,
                Warehouse = warehouse1
            };
            var purchaseOrder2 = new PurchasedOrder
            {
                OrderDate = DateTime.Now,
                WareHouseID = warehouse1.WareHouseID,
                SupplierID = supplier2.SupplierID,
                Supplier = supplier2,
                Warehouse = warehouse1
            };
            context.PurchaseOrders.Add(purchaseOrder1);
            context.PurchaseOrders.Add(purchaseOrder2);
            context.SaveChanges();
            //// Add Purchase Items
            var purchaseItem1 = new PurchasedItem
            {
                PurchasedOrderID = purchaseOrder1.OrderID,
                ItemID = item1.ItemID,
                ItemQuality = 10
            };
            var purchaseItem2 = new PurchasedItem
            {
                PurchasedOrderID = purchaseOrder1.OrderID,
                ItemID = item2.ItemID,
                ItemQuality = 20
            };

            var purchaseItem3 = new PurchasedItem
            {
                PurchasedOrderID = purchaseOrder2.OrderID,
                ItemID = item3.ItemID,
                ItemQuality = 10
            };
            var purchaseItem4 = new PurchasedItem
            {
                PurchasedOrderID = purchaseOrder2.OrderID,
                ItemID = item4.ItemID,
                ItemQuality = 20
            };
            context.PurchaseItems.Add(purchaseItem1);
            context.PurchaseItems.Add(purchaseItem2);
            context.PurchaseItems.Add(purchaseItem3);
            context.PurchaseItems.Add(purchaseItem4);
            context.SaveChanges();
            //// Add Sales Orders
            var salesOrder1 = new SalesOrder
            {
                SalesDate = DateTime.Now,
                CustomerID = customer1.CustomerID,
                WareHouseID = warehouse1.WareHouseID,
                Customer = customer1,
                Warehouse = warehouse1
            };
            var salesOrder2 = new SalesOrder
            {
                SalesDate = DateTime.Now,
                CustomerID = customer2.CustomerID,
                WareHouseID = warehouse1.WareHouseID,
                Customer = customer2,
                Warehouse = warehouse1
            };
            context.SalesOrders.Add(salesOrder1);
            context.SalesOrders.Add(salesOrder2);

            //// Add Sales Items
            var salesItem1 = new SalesOrderItem
            {
                SalesOrderID = salesOrder1.SalesID,
                ItemID = item1.ItemID,
                Quantity = 5,
                SalesOrder = salesOrder1,
                Item = item1
            };
            var salesItem2 = new SalesOrderItem
            {
                SalesOrderID = salesOrder2.SalesID,
                ItemID = item2.ItemID,
                Quantity = 10,
                SalesOrder = salesOrder2,
                Item = item2
            };
            context.SalesItems.Add(salesItem1);
            context.SalesItems.Add(salesItem2);

            //// Add Transfers
            var transfer1 = new Transfer
            {
                TransferQuantity = 50,
                TransferDate = DateTime.Now,
                SupplierID = supplier1.SupplierID,
                ItemID = item1.ItemID,
                FromWareHouseID = warehouse1.WareHouseID,
                ToWareHouseID = warehouse2.WareHouseID,
                Supplier = supplier1,
                Item = item1,
                FromWarehouse = warehouse1,
                ToWarehouse = warehouse2

            };
            var transfer2 = new Transfer
            {
                TransferQuantity = 29,
                TransferDate = DateTime.Now,
                SupplierID = supplier2.SupplierID,
                ItemID = item2.ItemID,
                FromWareHouseID = warehouse2.WareHouseID,
                ToWareHouseID = warehouse1.WareHouseID,
                Supplier = supplier2,
                Item = item2,
                FromWarehouse = warehouse2,
                ToWarehouse = warehouse1,
            };
            context.Transfers.Add(transfer1);
            context.Transfers.Add(transfer2);

            // Save changes to the database
            context.SaveChanges();
        }
    }
}
