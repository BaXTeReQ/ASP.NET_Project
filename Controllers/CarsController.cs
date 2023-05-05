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
    public class CarsController : Controller
    {
        private readonly ICarsService _service;

        public CarsController(ICarsService service)
        {
            _service = service;
        }

        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Details(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);

            return View(carDetails);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Edit(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);
            return View(carDetails);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("CarId, CarPicture, CarName, CarYear, CarDescription, CarModel, CarOrigin, CarPrice")] Car car)
        {
            car.CarId = id;



            await _service.UpdateAsync(id, car);
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Delete(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);
            return View(carDetails);
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carDetails = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Policy = "RequireAdministratorRole")]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("CarPicture, CarName, CarYear, CarDescription, CarModel, CarOrigin, CarPrice")] Car car)
        {
            _service.Add(car);
            return RedirectToAction(nameof(Index));
        }
    }
}
