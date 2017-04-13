using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {
            CartItems = new HashSet<CartItem>();
            Orders = new HashSet<Order>();
        }

        [ScaffoldColumn(false)]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        public string CustomerName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// Primeira parte do Endereco
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// Segunda parte do Endereco
        /// </summary>
        public string Address2 { get; set; }
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
        public DateTime? DateEntered { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
