using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public interface ICarsService
    {
        Task<IEnumerable<Car>> GetAll();
        Task<Car> GetByIdAsync(int id);
        void Add(Car car);
        Task<Car> UpdateAsync(int id, Car newCar);
        Task DeleteAsync(int id);
    }
}
