using finalApp.Data;
using Microsoft.EntityFrameworkCore;
using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext _context;

        public CarsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Cars.FirstOrDefaultAsync(n => n.CarId == id);
            _context.Cars.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            var result = await _context.Cars.ToListAsync();
            return result;
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            var result = await _context.Cars.FirstOrDefaultAsync(n => n.CarId == id);
            return result;
        }

        public async Task<Car> UpdateAsync(int id, Car newCar)
        {
            _context.Update(newCar);
            await _context.SaveChangesAsync();
            return newCar;
        }
    }
}
