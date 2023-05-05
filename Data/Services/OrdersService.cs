using Microsoft.EntityFrameworkCore;
using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly ApplicationDbContext _context;

        public OrdersService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Orders.FirstOrDefaultAsync(n => n.OrderId == id);
            _context.Orders.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            var result = await _context.Orders.ToListAsync();

            return result;
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            var result = await _context.Orders.FirstOrDefaultAsync(n => n.OrderId == id);
            return result;
        }

        public async Task<Order> UpdateAsync(int id, Order newOrder)
        {
            _context.Update(newOrder);
            await _context.SaveChangesAsync();
            return newOrder;
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
    }
}
