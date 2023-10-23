using Deliveroo.Data;
using System.Collections.Generic;

namespace Deliveroo.Models
{
    public class Cart : IEntity
    {
        public int Id { get; set; }

        //[ForeignKey]
        //public int UserId { get; set; } // Foreign key to associate the cart with a user
        public List<CartItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        //public User User { get; set; } // One-to-One relationship with User
    }
}
