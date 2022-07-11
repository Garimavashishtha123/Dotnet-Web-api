using AutoMapper;
using MedicalAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Profiles
{
    public class OrderMap : Profile
    {
        public OrderMap()
        {
            CreateMap<DataModels.Order, AddOrder>()
                .ReverseMap();
        }
    }
}
