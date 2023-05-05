using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Order>> GetAll(int id);
        Task<Car> CarGetByIdAsync(int id);
        Task<Users> UserGetByIdAsync(int id);
        Task<Users> UserGetIdByEmail(string user);
    }
}
