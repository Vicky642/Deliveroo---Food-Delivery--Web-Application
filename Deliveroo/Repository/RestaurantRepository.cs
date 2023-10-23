using Deliveroo.Data;
using Deliveroo.Models;

namespace Deliveroo.Repository
{
    public class RestaurantRepository : MainRepository<Restaurant, DeliverooContext>
    {
        public RestaurantRepository(DeliverooContext context) : base(context)
        {

        }
    }
}
