﻿using Book.DataAccess.Repository.IRepository;
using Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public int DecrementCount(ShoppingCart shoppingCart, int cout)
        {
            shoppingCart.Count -= cout;
            return shoppingCart.Count;
        }

        public int IncrementCount(ShoppingCart shoppingCart, int cout)
        {
            shoppingCart.Count += cout;
            return shoppingCart.Count;
        }
    }
}
