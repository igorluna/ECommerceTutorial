using ECommerce.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using ECommerce.DataContext;

namespace ECommerce.Services.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly MyContext _db;
        public CategoryRepository(MyContext db)
        {
            _db = db;
        }
        public int Count()
        {
            return _db.Categories.Count();
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if (category != null)
            {
                _db.Categories.Remove(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Categories.Select(x => x);
        }

        public Category GetById(int id)
        {
            return _db.Categories.FirstOrDefault(x => x.CategoryId == id);
        }

        public void Insert(Category category)
        {
            _db.Categories.Add(category);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
