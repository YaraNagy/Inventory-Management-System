using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class PurchasedOrder
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        // Foreign keys
        public int WareHouseID { get; set; }
        public int SupplierID { get; set; }

        // Navigation properties
        [ForeignKey("WareHouseID")]
        public virtual Warehouse Warehouse { get; set; }
        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchasedItem> PurchasedItems { get; set; }=new List<PurchasedItem>();

    }
}
