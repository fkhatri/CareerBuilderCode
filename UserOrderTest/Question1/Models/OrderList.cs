using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Question1.Models
{
    public static class OrderList
    {
        public static List<Order> GetOrders()
        {
            return new List<Order>()
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
    }

    public class OrderService
    {
        /// <summary>
        /// This OrderList is declared as static. This will share the information. 
        /// In order to restrict each object for each different users, it should not be declared as static
        /// </summary>
        public static List<Order> orderList = OrderList.GetOrders();

        public Order GetOrderById(int orderId)
        {
            return OrderService.orderList.First<Order>((Func<Order, bool>)(x => x.OrderId == orderId));
        }

        public void ModifyOrder(Order order)
        {
            for (int index = 0; index < OrderService.orderList.Count; ++index)
            {
                if (OrderService.orderList[index].OrderId == order.OrderId)
                {
                    OrderService.orderList[index] = order;
                    break;
                }
            }
        }
    }
}