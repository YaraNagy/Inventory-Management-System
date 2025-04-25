using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class SalesOrder
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesID { get; set; }
        public DateTime SalesDate { get; set; }

        // Foreign keys
        public int CustomerID { get; set; }
        public int WareHouseID { get; set; }

        // Navigation properties
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("WareHouseID")]
        public virtual Warehouse Warehouse { get; set; }
        public ICollection<SalesOrderItem> SalesItems { get; set; } = new List<SalesOrderItem>();

    }
}
