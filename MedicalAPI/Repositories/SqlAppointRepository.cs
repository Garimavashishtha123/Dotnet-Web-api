using MedicalAPI.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Repositories

{

    public class SqlAppointRepository : AppointRepository
      {
        private readonly AppointmentDbContext context;
        public SqlAppointRepository(AppointmentDbContext context)
        {
            this.context = context;

        }

        //Get all details
        public async Task<List<Appointment>> GetAppointmentsAsync()
        {
           return await context.appointment.ToListAsync();
        }

        //Get with id 
        public async Task<Appointment> GetAppointmentAsync(int id)
        {
            return await context.appointment.FirstOrDefaultAsync(x => x.id == id);
        }

        //Ckeck the Existing Appointment
        public async Task<bool> Exists(int id)
        {
            return await context.appointment.AnyAsync(x => x.id == id);
        }

        //Update the Appointment
        public async Task<Appointment> UpdateAppointment(int id, Appointment request)
        {
            var appointments = await GetAppointmentAsync(id);
            if (appointments != null)
            {
                appointments.name = request.name;
                appointments.email = request.email;
                appointments.phone = request.phone;
                appointments.appdate = request.appdate;
                appointments.apptime = request.apptime;

                await context.SaveChangesAsync();
                return appointments;
            }
            return null;
        }


        //Add the Appointment in api
        public async Task<Appointment> AddAppointment(Appointment request)
        {
            var app1 = await context.appointment.AddAsync(request);
            await context.SaveChangesAsync();
            return app1.Entity;
        }

        //Delete the Appointment
        public async Task<Appointment> DeleteAppointment(int id)
        {
            var app1 = await GetAppointmentAsync(id);
            if (app1 != null)
            {
                context.appointment.Remove(app1);
                await context.SaveChangesAsync();
                return app1;
            }
            return null;
        }
    }
}
