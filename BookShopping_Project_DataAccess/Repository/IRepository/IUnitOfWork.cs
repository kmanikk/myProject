﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopping_Project_DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }
        IApplicationUserRepository ApplicationUser { get; }
        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart {get;}
        IOrderDetailRepository OrderDetail { get;}
        IOrderHeaderRepository OrderHeader { get; }
        void Save();
    }
}
