using Microsoft.EntityFrameworkCore;
using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalApp.Data;

namespace finalApp.Data.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Car> GetByIdAsync(int id)
        {
            var result = await _context.Cars.FirstOrDefaultAsync(n => n.CarId == id);
            return result;
        }
    }
}
