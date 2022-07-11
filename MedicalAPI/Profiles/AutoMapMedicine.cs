using AutoMapper;
using MedicalAPI.DataModels;
using MedicalAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Profiles
{
    public class AutoMapMedicine : Profile
    {
        public AutoMapMedicine()
        {
            CreateMap<DataModels.Medicine, MedicineDomain>()
                 .ReverseMap();
        }

        
    }
}
