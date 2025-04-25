using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemMeaningUnit { get; set; }
        public int ItemQuantity { get; set; }
        public DateTime ItemExpDate { get; set; }
        public DateTime ItemProDate { get; set; }

        /// Foreign key for Warehouse
        public int WareHouseID { get; set; }

        // Navigation property for Warehouse
        [ForeignKey("WareHouseID")]
        public virtual Warehouse Warehouse { get; set; }
        public ICollection<Transfer> Transfers { get; set; } = new List<Transfer>();
        public ICollection<PurchasedItem> PurchasedItems { get; set; } = new List<PurchasedItem>();
        public ICollection<SalesOrderItem> SalesItems { get; set; } = new List<SalesOrderItem>();
    }
}
