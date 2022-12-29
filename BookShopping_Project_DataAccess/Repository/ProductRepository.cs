using BookShopping_Project_DataAccess.Repository.IRepository;
using BookShopping_Project_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_BookShopping_Project5.Data;

namespace BookShopping_Project_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public void Update(Product product)
        {
            var productInDb = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if(productInDb != null)
            {
                if (productInDb.ImageURL != "")
                    productInDb.ImageURL = product.ImageURL;
                productInDb.Title = product.Title;
                productInDb.ISBN = product.ISBN;
                productInDb.Author = product.Author;
                productInDb.Discription = product.Discription;
                productInDb.ListPrice = product.ListPrice;
                productInDb.Price = product.Price;
                productInDb.Price50 = product.Price50;
                productInDb.Price100 = product.Price100;
                productInDb.CategoryId = product.CategoryId;
                productInDb.CoverTypeId = product.CoverTypeId;





            }
        }
    }
}
