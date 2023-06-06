using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int? Rating { get; set; }
        public string Commemt { get; set; }
        public DateTime? ReviewDate { get; set; }
        public long UserId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Account User { get; set; }
    }
}
