using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Infrastructure
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetAll();

        SubCategory GetById(int id);

        void Insert(SubCategory subCategory);

        void Update(SubCategory subCategory);

        void Delete(int id);

        void Save();
    }
}
