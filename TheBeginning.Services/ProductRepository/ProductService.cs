using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeginning.DB;
using TheBeginning.Entities.Entity;

namespace TheBeginning.Services.ProductRepository
{
    public class ProductService : IProductService
    {
        private readonly WatchContext _context = new WatchContext();

        public int Add(ProductEntity model)
        {
            using (_context)
            {
                _context.Products.Add(model);
                _context.SaveChanges();
                return model.Id;
            }
        }

        public ProductEntity GetItemById(int Id)
        {
            return _context.Products.Find(Id);
        }

        public List<ProductEntity> GetList()
        {
            return _context.Products.ToList();
        }

        public int Update(int Id, ProductEntity model)
        {
            ProductEntity ID = _context.Products.Find(Id);
            if(ID!=null)
            {
                ID.Name = model.Name;
                ID.Description = model.Description;
                ID.Price = model.Price;
                ID.DiscountPrice = model.DiscountPrice;
                ID.AddedDate = model.AddedDate;
                _context.SaveChanges();
            }
            return model.Id;
        }
    }
}
