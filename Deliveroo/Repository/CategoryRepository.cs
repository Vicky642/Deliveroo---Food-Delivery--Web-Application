using Deliveroo.Data;
using Deliveroo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Repository
{
    public class CategoryRepository : MainRepository<Category, DeliverooContext>
    {
        public CategoryRepository(DeliverooContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
