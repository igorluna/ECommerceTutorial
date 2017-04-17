using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Infrastructure
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void Insert(Product product);

        void Update(Product product);

        void Delete(int id);

        int Count();

        void Save();
    }
}
