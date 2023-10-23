using Deliveroo.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Models
{
    public class User : IdentityUser, IEntity
    {
        public new int Id { get; set; }
        public string Name { get; set; }
        public new string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public new string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsAdmin { get; set; }
        public List<Order> Orders { get; set; } // One-to-Many relationship with Order

        //[ForeignKey]
        //public int CartId { get; set; } // Foreign key to associate the user with a cart
        //public Cart Cart { get; set; } // One-to-One relationship with Cart
    }
}
