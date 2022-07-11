using MedicalAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Repositories
{
    public interface OrderRepository
    {
        public Task<Order> GetOrderAsync(int id);
        public Task<Order> AddOrder(Order request);
    }
}
