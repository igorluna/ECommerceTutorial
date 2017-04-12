using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("CartItems")]
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }

        #region Customer

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        #endregion

        #region Product

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        #endregion
    }
}
