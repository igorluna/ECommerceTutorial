using ECommerce.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using ECommerce.DataContext;

namespace ECommerce.Services.Repository
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly MyContext _db;

        public SubCategoryRepository(MyContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var subcategory = GetById(id);

            if (subcategory != null)
            {
                _db.SubCategories.Remove(subcategory);
            }
        }

        public IEnumerable<SubCategory> GetAll()
        {
            return  _db.SubCategories.Select(x => x);
        }

        public SubCategory GetById(int id)
        {
            return _db.SubCategories.FirstOrDefault(x => x.SubCategoryId == id);
        }

        public void Insert(SubCategory subCategory)
        {
            _db.SubCategories.Add(subCategory);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _db.SubCategories.Update(subCategory);
        }
    }
}
