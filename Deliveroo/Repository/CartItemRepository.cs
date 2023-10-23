using Deliveroo.Data;
using Deliveroo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Repository
{
    public class CartItemRepository : MainRepository<CartItem, DeliverooContext>
    {
        public CartItemRepository(DeliverooContext context) : base(context)
        {

        }
    }
}
