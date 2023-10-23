using Deliveroo.Data;
using Deliveroo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Repository
{
    public class MenuItemRepository : MainRepository<MenuItem, DeliverooContext>
    {
        public MenuItemRepository(DeliverooContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
