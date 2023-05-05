using Microsoft.AspNetCore.Mvc;
using finalApp.Data;
using finalApp.Data.Services;
using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace finalApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService _service;

        public OrdersController(IOrdersService service)
        {
            _service = service;
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Index(Order order, Car car)
        {
        
            var data = await _service.GetAll();

            foreach(var item in data)
            {
                item.Car = await _service.CarGetByIdAsync(item.CarId);
                item.User = await _service.UserGetByIdAsync(item.UserId);
            }
            return View(data);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Details(int id, Order order, Car car)
        {
            var orderDetails = await _service.GetByIdAsync(id);

            orderDetails.Car = await _service.CarGetByIdAsync(orderDetails.CarId);
            orderDetails.User = await _service.UserGetByIdAsync(orderDetails.UserId);

            return View(orderDetails);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Edit(int id)
        {
            var orderDetails = await _service.GetByIdAsync(id);

            orderDetails.Car = await _service.CarGetByIdAsync(orderDetails.CarId);
            orderDetails.User = await _service.UserGetByIdAsync(orderDetails.UserId);

            return View(orderDetails);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId, OrderPrice, CarId, UserId")] Order order)
        {
            order.OrderId = id;
            //order.CarId = id;

            var checkCarId = await _service.CarGetByIdAsync(order.CarId);
            var checkUserId = await _service.UserGetByIdAsync(order.UserId);

            if(checkCarId == null || checkUserId == null)
            {
                return (RedirectToAction(nameof(Edit)));
            }

            await _service.UpdateAsync(id, order);
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Delete(int id)
        {
            var orderDetails = await _service.GetByIdAsync(id);

            orderDetails.Car = await _service.CarGetByIdAsync(orderDetails.CarId);
            orderDetails.User = await _service.UserGetByIdAsync(orderDetails.UserId);
            return View(orderDetails);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
