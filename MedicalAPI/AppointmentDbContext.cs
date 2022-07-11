using MedicalAPI.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI
{
    public class AppointmentDbContext : DbContext

    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) : base(options)
        {

        }

        public DbSet<Appointment> appointment { get; set; }

        
        
    }
}
