using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Infrastructure
{
    public interface ICartItem
    {
        IEnumerable<CartItem> GetAll();

        CartItem GetById(int id);

        void Insert(CartItem cartItem);

        void Update(CartItem cartItem);

        void Delete(int id);

        int Count();

        void Save();
    }
}
