using Microsoft.EntityFrameworkCore;
using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            var result = await _context.Cars.FirstOrDefaultAsync(n => n.CarId == id);
            return result;
        }
        public async Task<Users> UserGetIdByEmail(string user)
        {
            var result = await _context.Users.FirstOrDefaultAsync(n => n.Email == user);
            return result;
        }
    }
}
    
