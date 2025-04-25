using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class Supplier
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierFax { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierWebsite { get; set; }

        // Navigation properties
        public virtual ICollection<Transfer> Transfers { get; set; } = new List<Transfer>();
        public virtual ICollection<PurchasedOrder> PurchasedOrders { get; set; } = new List<PurchasedOrder>();
    }
}
