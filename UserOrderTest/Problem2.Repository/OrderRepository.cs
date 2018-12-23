using Problem2.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Repository
{
    public class OrderRepository
    {
        private List<Order> _orders;

        private List<OrderUsers> _orderUsers;

        public OrderRepository()
        {
            _orderUsers = new List<OrderUsers>();
            _orders = new List<Order>()
            {
                new Order()
                {
                  OrderId = 1234,
                  FirstName = "Fred",
                  LastName = "Tom",
                  City = "Chicago",
                  State = "IL",
                  DOB = "01/01/2001"
                },
                new Order()
                {
                  OrderId = 1235,
                  FirstName = "Faisal",
                  LastName = "Khatri",
                  City = "Chicago",
                  State = "IL",
                  DOB = "01/01/1999"
                },
                new Order()
                {
                  OrderId = 1236,
                  FirstName = "John",
                  LastName = "Khan",
                  City = "Chicago",
                  State = "IL",
                  DOB = "01/01/2002"
                },
                new Order()
                {
                  OrderId = 1237,
                  FirstName = "Fab",
                  LastName = "Amazing",
                  City = "Chicago",
                  State = "IL",
                  DOB = "01/01/1997"
                },
                new Order()
                {
                  OrderId = 1238,
                  FirstName = "Some",
                  LastName = "Randomm",
                  City = "Chicago",
                  State = "IL",
                  DOB = "01/01/1998"
                }
            };
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = from a in _orders
                         from b in _orders.Where(x => x.OrderId != a.OrderId).DefaultIfEmpty()
                         select new Order() { OrderId = a.OrderId, FirstName = a.FirstName, LastName = b.LastName, DOB = a.DOB, City = a.City, State = a.State };

            return orders;
        }

        public Order GetOrderById(int orderId)
        {
            return _orders.First(x => x.OrderId == orderId);
        }

        public void UpdateOrderSelected(int orderId, string userId)
        {
            var order = _orderUsers.FirstOrDefault(x => x.OrderId == orderId && x.UserId==userId );
            if (order == null)
            {
                _orderUsers.Add(new OrderUsers()
                {
                    OrderId = orderId,
                    UserId = userId,
                    IsSelected = true
                });
            }
        }

        public void UpdateOrderModified(int orderId, string userId)
        {
            var order = _orderUsers.FirstOrDefault(x => x.OrderId == orderId && x.UserId == userId);
            if (order != null)
            {
                order.IsModified = true;
            }
        }
    }

}
