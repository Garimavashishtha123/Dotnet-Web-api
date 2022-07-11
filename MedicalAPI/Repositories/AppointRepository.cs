using MedicalAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Repositories
{
    public interface AppointRepository
    {
        Task<List<Appointment>> GetAppointmentsAsync();
        Task<Appointment> GetAppointmentAsync(int id);
        Task<bool> Exists(int id);

        Task<Appointment> UpdateAppointment(int id, Appointment request);
        Task<Appointment> DeleteAppointment(int id);
        Task<Appointment> AddAppointment(Appointment request);
    }
}
