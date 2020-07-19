using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeginning.Entities.Entity;

namespace TheBeginning.Database
{
    public class ProductContext:DbContext
    {
        public ProductContext():base("WatchConnection")
        {

        }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
