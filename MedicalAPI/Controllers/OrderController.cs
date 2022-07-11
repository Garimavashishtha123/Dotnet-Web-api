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
    public class OrderController : Controller
    {
        private readonly OrderRepository repository;
        private readonly IMapper mapper;

        public OrderController(OrderRepository repository, IMapper mapper) 
        {
            this.repository = repository;

        }

        //Get data with id
        [HttpGet]
        [Route("[Controller]/{id:int}"), ActionName(" GetOrderAsync")]

        public async Task<IActionResult> GetOrderAsync([FromRoute] int id)
        {
            //fetch data
            var app = await repository.GetOrderAsync(id);
            //return data
            if (app == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<AddOrder>(app));
        }

        //Add the data into the api
        [HttpPost]
        [Route("[Controller]/Add")]
        public async Task<IActionResult> AddOrder1([FromBody] AddOrder request)
        {
            var Adapp = await repository.AddOrder(mapper.Map<DataModels.Order>(request));
            return CreatedAtAction(nameof(AddOrder1), new { id = Adapp.id },
                mapper.Map<AddOrder>(Adapp));
        }
    }
}
