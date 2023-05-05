using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetByIdAsync(int id);
        Task<Order> UpdateAsync(int id, Order newOrder);
        Task DeleteAsync(int id);
        Task<Car> CarGetByIdAsync(int id);
        Task<Users> UserGetByIdAsync(int id);
    }
}
