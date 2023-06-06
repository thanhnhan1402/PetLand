using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }
        public long UserId { get; set; }

        public virtual Account User { get; set; }
    }
}
