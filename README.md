# Inventory Management System (WinForms + EF6)

A desktop application built with C# WinForms and Entity Framework 6 for managing warehouse inventory, suppliers, customers, orders (purchase and sales), and item transfers between warehouses.


## Features

*   **MDI Interface:** Uses a Multiple Document Interface for managing different sections.
*   **Collapsible Navigation Menu:** Provides easy access to different modules.
*   **Warehouse Management:** Add and Update warehouse details (Name, Location, Manager). View item count per warehouse.
*   **Item Management:** Add and Update items (Name, Quantity, Measuring Unit, Production/Expiration Dates, Assigned Warehouse). View items list.
*   **Supplier Management:** Add and Update supplier information (Name, Phone, Email, Fax, Website). View suppliers list.
*   **Customer Management:** Add and Update customer details (Name, Phone). View customers list and their order count.
*   **Purchased Order Management:** Add and Update purchase orders (Date, Warehouse, Supplier). Add specific items and quantities to existing purchase orders. View purchase orders list.
*   **Sales Order Management:** Add and Update sales orders (Date, Warehouse, Customer). View sales orders list. *(Functionality to add items to sales orders might exist but is not fully shown in the provided code snippets)*.
*   **Transfer Management:** Record item transfers between warehouses (Date, From Warehouse, To Warehouse, Supplier, Item). View transfer history.
*   **Reporting:** Placeholder for various reports (Warehouse, Sales, Purchase, Transfers). *(Specific report generation logic not fully shown)*.
*   **Database Interaction:** Uses Entity Framework 6 Code First with a `DropCreateDatabaseIfModelChanges` initializer for database setup and seeding.

## Technologies Used

*   **Language:** C#
*   **.NET Framework:** Version 4.7.2
*   **UI:** Windows Forms (WinForms)
*   **ORM:** Entity Framework 6 (EF6) - Code First
*   **Database:** SQL Server (as configured by default EF provider)
*   **UI Components:** Guna UI2 WinForms

## Database Schema / Models

The application uses the following main entities, managed by `DatabaseContext.cs`:

*   **`Warehouse`**: Stores warehouse information and relationships to items, orders, and transfers.
*   **`Item`**: Represents inventory items with details like quantity, unit, dates, and warehouse location.
*   **`Supplier`**: Holds supplier contact information and related orders/transfers.
*   **`Customer`**: Stores customer details and their associated sales orders.
*   **`PurchasedOrder`**: Represents an order placed with a supplier for items coming into a warehouse.
*   **`PurchasedItem`**: Linking entity for the many-to-many relationship between `PurchasedOrder` and `Item`, including quantity.
*   **`SalesOrder`**: Represents an order placed by a customer for items leaving a warehouse.
*   **`SalesOrderItem`**: Linking entity for the many-to-many relationship between `SalesOrder` and `Item`, including quantity.
*   **`Transfer`**: Records the movement of a specific item between two warehouses, potentially involving a supplier.
