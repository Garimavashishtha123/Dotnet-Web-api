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
    [ApiController]
    public class AppointmentController : Controller
    {
        
        private readonly AppointRepository repository;
        private readonly IMapper mapper;
        public AppointmentController(AppointRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        //public AppointRepository Repository => Repository1;

        //public AppointRepository Repository1 => repository;
        //Get all Appointment
        [HttpGet]
        [Route("[Controller]")]
        public async Task<IActionResult> GetAllAppointment()
        {
            var app1 = await repository.GetAppointmentsAsync();

            return Ok(mapper.Map<List<Appointmentdomain>>(app1));

        }
        
        //Get Appointment record with id
        [HttpGet]
        [Route("[Controller]/{id:int}"), ActionName("GetAppointmentAsync")]

        public async Task<IActionResult> GetAppointmentAsync([FromRoute] int id)
        {
            //fetch data
            var app = await repository.GetAppointmentAsync(id);
            //return data
            if (app== null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<Appointmentdomain>(app));
        }

        //Update Appointment
        [HttpPut]
        [Route("[Controller]/{id:int}")]

        public async Task<IActionResult> UpdateAppointmentAsync([FromRoute] int id, [FromBody] UpdateAppointment request)
        {
            //Update Details
            var Updatedappointment = await repository.UpdateAppointment(id, mapper.Map<DataModels.Appointment>(request));

            if (Updatedappointment != null)
            {
                return Ok(mapper.Map<Appointmentdomain>(Updatedappointment));
            }
            return NotFound();
        }

        //Delete the records

        [HttpDelete]
        [Route("[Controller]/{id:int}")]
        public async Task<IActionResult> DeleteAppointmentAsync([FromRoute] int id)
        {
            if (await repository.Exists(id))
            {
                //Delete the Appointment
                var deletedata = await repository.DeleteAppointment(id);
                return Ok(mapper.Map<Appointment>(deletedata));
            }
            return NotFound();
        }

        //Add the data into the api
        [HttpPost]
        [Route("[Controller]/Add")]
        public async Task<IActionResult> AddAppointmentAsync([FromBody] AddAppointment request)
        {
            var Adapp = await repository.AddAppointment(mapper.Map<DataModels.Appointment>(request));
            return CreatedAtAction(nameof(GetAppointmentAsync), new { id = Adapp.id},
                mapper.Map<Appointment>(Adapp));
        }




    }
   
    }


    

