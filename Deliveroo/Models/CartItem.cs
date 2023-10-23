using Deliveroo.Data;

namespace Deliveroo.Models
{
    public class CartItem : IEntity
    {
        public int Id { get; set; }
        public int CartId { get; set; } // Foreign key to associate the cart item with a cart
        public int MenuId { get; set; } // Foreign key to associate the cart item with a menu item
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Cart Cart { get; set; } // Many-to-One relationship with Cart
        public Menu Menu { get; set; } // Many-to-One relationship with Menu
    }
}
