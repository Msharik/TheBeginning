using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeginning.Entities.Entity;

namespace TheBeginning.Services.ProductRepository
{
    public interface IProductService
    {
        int Add(ProductEntity model);
        int Update(int Id, ProductEntity model);
        List<ProductEntity> GetList();
        ProductEntity GetItemById(int Id);

    }
}
