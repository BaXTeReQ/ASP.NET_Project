using Microsoft.AspNetCore.Mvc;
using finalApp.Data;
using finalApp.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _service;

        public CarController(ICarService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);
            return View(carDetails);
        }
    }
}
