using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_EntityFreamework.Model
{
    internal class Customer
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        // Navigation properties
        public ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();
    }
}
