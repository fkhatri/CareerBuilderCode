using Problem2.Repository;
using Problem2.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Problem.Service.Controllers
{
    public class OrderQueueController : ApiController
    {
        private OrderRepository _orderRepository;

        public OrderQueueController()
        {
            _orderRepository = new OrderRepository();
        }

        public IEnumerable<Order> Get()
        {
            return _orderRepository.GetAllOrders();
        } 

        [HttpGet]
        public IHttpActionResult GetOrderById(int id,string userId)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            _orderRepository.UpdateOrderSelected(id, userId);
            return Ok(order);
        }

        [HttpPost]
        public IHttpActionResult OrderModified(int id,string userId)
        {
            _orderRepository.UpdateOrderModified(id,userId);
            
            return Ok();
        }
    }
}
