using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class Transfer
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransferID { get; set; }
        public int TransferQuantity { get; set; }
        public DateTime TransferDate { get; set; }

        // Foreign keys
        public int SupplierID { get; set; }
        public int ItemID { get; set; }
        public int FromWareHouseID { get; set; }
        public int ToWareHouseID { get; set; }

        // Navigation properties
        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
        [ForeignKey("FromWareHouseID")]
        public virtual Warehouse FromWarehouse { get; set; }
        [ForeignKey("ToWareHouseID")]
        public virtual Warehouse ToWarehouse { get; set; }
    }
}
