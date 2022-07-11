using MedicalAPI.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Repositories
{
    public class SqlOrderRepository : OrderRepository
    {
        private readonly MedicineDbContext context;
        public SqlOrderRepository(MedicineDbContext context)
        {
            this.context = context;

        }

   

        //Add the Appointment in api
        public async Task<Order> AddOrder (Order request)
        {
            var app1 = await context.Order.AddAsync(request);
            await context.SaveChangesAsync();
            return app1.Entity;
        }
        //get the data with id 
        public async Task<Order> GetOrderAsync(int id)
        {
            return await context.Order.FirstOrDefaultAsync(x => x.id == id);
        }
    }
}
