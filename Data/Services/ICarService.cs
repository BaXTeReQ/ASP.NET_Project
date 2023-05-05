using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public interface ICarService
    {
        Task<Car> GetByIdAsync(int id);
    }
}
