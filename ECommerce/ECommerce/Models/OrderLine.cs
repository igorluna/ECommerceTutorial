using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("OrderLines")]
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        [Range(1, 100,ErrorMessage ="Valor deve ser entre {0} e {1}")]
        public decimal? Price { get; set; }

        #region Order

        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }

        #endregion

        #region Product

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        #endregion

    }
}
