using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal OrderTotal { get; set; }

        #region Customer

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        #endregion

        public virtual ICollection<OrderLine> OrderLines { get; set; }

    }
}
