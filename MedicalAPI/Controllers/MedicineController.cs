using AutoMapper;
using MedicalAPI.DataModels;
using MedicalAPI.DomainModels;
using MedicalAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Controllers
{
    public class MedicineController : Controller
    {
        private readonly MedicineRepository repository;
        private readonly IMapper mapper;

        public MedicineController(MedicineRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[Controller]")]

        public async Task<IActionResult> GetAllMedicine()
        {
            var medicine = await repository.GetMedicnesAsync();
            return Ok(mapper.Map<List<MedicineDomain>>(medicine));

        }
       
    }
}
