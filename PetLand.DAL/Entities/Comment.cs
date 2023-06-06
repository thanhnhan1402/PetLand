using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public byte[] Content { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Likes { get; set; }
        public long UserId { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
        public virtual Account User { get; set; }
    }
}
