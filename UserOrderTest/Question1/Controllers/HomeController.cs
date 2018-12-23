using Question1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Question1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// The OrderService 
        /// </summary>
        private OrderService _orderService;

        public HomeController()
        {
            this._orderService = new OrderService();
        }

        public ActionResult Index()
        {
            // The OrderService orderlist is decalared as static, this will cause to share the information between different users.
            return (ActionResult)this.View((object)OrderService.orderList);
        }

        public ActionResult Edit(int id)
        {
            return (ActionResult)this.View((object)this._orderService.GetOrderById(id));
        }

        [HttpPost]
        public ActionResult Edit(Order order)
        {
            this._orderService.ModifyOrder(order);
            Thread.Sleep(5000);
            return (ActionResult)this.RedirectToAction("Index");
        }
    }
}