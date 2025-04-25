using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class SalesOrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesItemsID { get; set; }
        public int Quantity { get; set; }

        // Foreign keys
        public int SalesOrderID { get; set; }
        public int ItemID { get; set; }

        // Navigation properties
        [ForeignKey("SalesOrderID")]
        public virtual SalesOrder SalesOrder { get; set; }
        [ForeignKey("ItemID")]
        public virtual Item Item { get; set; }
    }
}
