using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int WareHouseID { get; set; }
        public string WareHouseLocation { get; set; }
        public string WareHouseName { get; set; }
        public string WareHouseManager { get; set; }

        // Navigation properties
        public ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<Transfer> TransfersFrom { get; set; } = new List<Transfer>();
        public ICollection<Transfer> TransfersTo { get; set; } = new List<Transfer>();
        public ICollection<PurchasedOrder> PurchasedOrders { get; set; }=new List<PurchasedOrder>();
        public ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();
    }
}
