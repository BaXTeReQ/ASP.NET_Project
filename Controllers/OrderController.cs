using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using finalApp.Data.Services;
using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //public async Task<IActionResult> MakeOrder([Bind("OrderPrice, CarId")]Order order)
        public async Task<IActionResult> MakeOrder(IFormCollection form, [Bind("OrderPrice, CarId")] Order order)
        {
            Order newOrder = new Order();

            string loggedUser = (User.Identity.Name);

            var userData = await _service.UserGetIdByEmail(loggedUser);

            newOrder.OrderPrice = Convert.ToDouble(form["orderPrice"]);
            newOrder.CarId = Convert.ToInt16(form["carId"]);
            newOrder.UserId = Convert.ToInt16(userData.UserId);
            //newOrder.UserId = 
            order.Car = await _service.GetByIdAsync(newOrder.CarId);



            _service.Add(newOrder);
            return View(model: order);
        }
    }
}
