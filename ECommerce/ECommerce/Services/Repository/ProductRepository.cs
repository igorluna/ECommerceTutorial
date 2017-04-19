using ECommerce.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using ECommerce.DataContext;

namespace ECommerce.Services.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly MyContext _db;

        public ProductRepository(MyContext db)
        {
            _db = db;
        }

        public int Count()
        {
            return _db.Products.Count();
        }

        public void Delete(int id)
        {
            var product = GetById(id);

            if (product != null)
            {
                _db.Products.Remove(product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products.Select(x => x);
        }

        public Product GetById(int id)
        {
            return _db.Products.FirstOrDefault(x => x.ProductId == id);
        }

        public void Insert(Product product)
        {
            _db.Products.Add(product);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            _db.Products.Update(product);
        }
    }
}
