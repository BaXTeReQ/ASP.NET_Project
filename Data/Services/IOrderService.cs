using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalApp.Data.Services
{
    public interface IOrderService
    {
        public void Add(Order order);

        Task<Car> GetByIdAsync(int id);
        Task<Users> UserGetIdByEmail(string user);

    }
}
