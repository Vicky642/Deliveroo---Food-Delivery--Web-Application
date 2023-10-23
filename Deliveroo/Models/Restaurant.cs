using System;
using Deliveroo.Data;
using System.Collections.Generic;

namespace Deliveroo.Models
{
    public class Restaurant : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CuisineType { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public bool IsOpen { get; set; }
        public string ImageUrl { get; set; }
        public List<Menu> Menus { get; set; } // One-to-Many relationship with Menu
    }
}
