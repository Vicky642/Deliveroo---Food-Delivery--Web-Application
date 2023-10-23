using Deliveroo.Data;

namespace Deliveroo.Models
{
    public class Review : IEntity
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Restaurant Restaurant { get; set; } // Many-to-One relationship with Restaurant
        public User User { get; set; } // Many-to-One relationship with User
    }
}
