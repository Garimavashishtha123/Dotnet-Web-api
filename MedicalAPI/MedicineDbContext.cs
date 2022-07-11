using MedicalAPI.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI
{
    public class MedicineDbContext : DbContext
    {
        internal object order;

        public MedicineDbContext(DbContextOptions<MedicineDbContext> options) : base(options)
        {
        }
        public DbSet<Medicine> Medicine { get; set; }

        public DbSet<Order> Order { get; set; }
    }
}
