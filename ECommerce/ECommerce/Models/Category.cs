using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            SubCategories = new HashSet<SubCategory>();
        }
        #region Category

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        #endregion

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
