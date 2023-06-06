using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public byte[] Content { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Likes { get; set; }
        public long UserId { get; set; }

        public virtual Account User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
