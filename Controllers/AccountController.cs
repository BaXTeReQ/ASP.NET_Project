using finalApp.Data.Services;
using finalApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace finalApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(IAccountService service, UserManager<IdentityUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index(Order order, Car car, Users user)
        {
            //var loggedUser = await _userManager.FindByIdAsync(User.Identity.Name);
            string loggedUser = (User.Identity.Name);

            var userData = await _service.UserGetIdByEmail(loggedUser);

            var data = await _service.GetAll(userData.UserId);

            foreach (var item in data)
            {
                item.Car = await _service.CarGetByIdAsync(item.CarId);
                item.User = await _service.UserGetByIdAsync(item.UserId);
            }

            return View(data);
        }
    }
}
