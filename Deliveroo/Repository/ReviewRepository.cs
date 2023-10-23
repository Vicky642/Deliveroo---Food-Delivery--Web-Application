using Deliveroo.Data;
using Deliveroo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Repository
{
    public class ReviewRepository : MainRepository<Review, DeliverooContext>
    {
        public ReviewRepository(DeliverooContext context) : base(context)
        {

        }
    }
}
