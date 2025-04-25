using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class PurchasedItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchasedItemID { get; set; }
        public int ItemQuality { get; set; }

        // Foreign keys
        public int PurchasedOrderID { get; set; }
        public int ItemID { get; set; }

        // Navigation properties
        [ForeignKey("PurchasedOrderID")]
        public virtual PurchasedOrder PurchasedOrder { get; set; }
        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}
