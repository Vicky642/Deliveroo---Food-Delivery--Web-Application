using Deliveroo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Models
{
    public class Menu : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; } // Foreign key to associate the menu item with a restaurant
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; } // Many-to-One relationship with Category
        public Restaurant Restaurant { get; set; } // Many-to-One relationship with Restaurant
    }
}
