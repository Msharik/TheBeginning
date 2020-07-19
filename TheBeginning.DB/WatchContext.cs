using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeginning.Entities.Entity;

namespace TheBeginning.DB
{
    public class WatchContext :DbContext
    {
        public WatchContext():base("BeginConnection")
        {

        }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
