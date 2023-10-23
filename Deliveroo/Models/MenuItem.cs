using Deliveroo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Models
{
    public class MenuItem : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int RestaurantId { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<CartItem> CartItems { get; set; } // One-to-Many relationship with CartItem
    }
}
