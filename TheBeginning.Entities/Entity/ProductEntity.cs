using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeginning.Entities.Entity
{
    public class ProductEntity :BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public Decimal DiscountPrice { get; set; }
        public DateTime AddedDate { get; set; }
        
    }
}
