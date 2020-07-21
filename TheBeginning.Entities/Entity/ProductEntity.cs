using System;

namespace TheBeginning.Entities.Entity
{
    public class ProductEntity :BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public Decimal DiscountPrice { get; set; }
        public DateTime AddedDate { get; set; }
        public ImageEntity ImageEntity { get; set; }
        public int ImageEntityID { get; set; }
        public CategoryEntity CategoryEntity { get; set; }
        public int CategoryEntityID { get; set; }

    }
}
