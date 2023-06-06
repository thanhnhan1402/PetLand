using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class Product
    {
        public Product()
        {
            Reviews = new HashSet<Review>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public byte[] ImageProduct { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitInStock { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
