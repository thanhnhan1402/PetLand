﻿using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class OrderDetail
    {
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public double? Discount { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
