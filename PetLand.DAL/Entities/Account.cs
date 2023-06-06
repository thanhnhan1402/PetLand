using System;
using System.Collections.Generic;

namespace PetLand.DAL.Entities
{
    public partial class Account
    {
        public Account()
        {
            ChatMessageRecives = new HashSet<ChatMessage>();
            ChatMessageSenders = new HashSet<ChatMessage>();
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            Posts = new HashSet<Post>();
            Reviews = new HashSet<Review>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public byte[] ImageUser { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageRecives { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageSenders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
