using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class ChatMessage
    {
        public int ChatMessageId { get; set; }
        public string Content { get; set; }
        public DateTime? Timestamp { get; set; }
        public long SenderId { get; set; }
        public long ReciveId { get; set; }

        public virtual Account Recive { get; set; }
        public virtual Account Sender { get; set; }
    }
}
