using Deliveroo.Data;
using Deliveroo.Models;

namespace Deliveroo.Repository
{
    public class UserRepository : MainRepository<User, DeliverooContext>
    {
        public UserRepository(DeliverooContext context) : base(context)
        {

        }
    }
}
