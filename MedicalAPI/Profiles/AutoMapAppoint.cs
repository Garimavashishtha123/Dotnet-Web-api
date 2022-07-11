using AutoMapper;
using MedicalAPI.DomainModels;
using DataModels=MedicalAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MedicalAPI.Profiles
{
    public class AutoMapAppoint : Profile
    {
        public AutoMapAppoint()
        {
            CreateMap < DataModels.Appointment, Appointmentdomain > ()
                .ReverseMap();

            CreateMap<UpdateAppointment, DataModels.Appointment>()
                .ReverseMap();

            CreateMap<AddAppointment, DataModels.Appointment>()
                .ReverseMap();
        }
    }
}
