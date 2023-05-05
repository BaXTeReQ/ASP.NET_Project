using finalApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;

        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAll(int id)
        {
            //var idLoggedUser = UserGetIdByEmail(user);

            var result = await _context.Orders.Where(n => n.UserId == id).ToListAsync();

            return result;
        }
        public async Task<Car> CarGetByIdAsync(int id)
        {
            var result = await _context.Cars.FirstOrDefaultAsync(n => n.CarId == id);
            return result;
        }

        public async Task<Users> UserGetByIdAsync(int id)
        {
            var result = await _context.Users.FirstOrDefaultAsync(n => n.UserId == id);
            return result;
        }        
        public async Task<Users> UserGetIdByEmail(string user)
        {
            var result = await _context.Users.FirstOrDefaultAsync(n => n.Email == user);
            return result;
        }
    }
}
