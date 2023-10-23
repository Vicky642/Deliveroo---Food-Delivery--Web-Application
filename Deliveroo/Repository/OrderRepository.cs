using Deliveroo.Data;
using Deliveroo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Repository
{
    public class OrderRepository : MainRepository<Order, DeliverooContext>
    {
        public OrderRepository(DeliverooContext context) : base(context)
        {

        }
    }
}
