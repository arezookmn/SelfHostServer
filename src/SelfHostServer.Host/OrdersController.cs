using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class OrdersController : ApiController
    {
        private Order[] orders = new Order[]
        {
            new Order { Id = 1, Name = "Tomato", Category = "Groceries", Price = 1 },
            new Order { Id = 2, Name = "YoYo", Category = "Toys", Price = 3.75M },
            new Order { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }

        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }

    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
