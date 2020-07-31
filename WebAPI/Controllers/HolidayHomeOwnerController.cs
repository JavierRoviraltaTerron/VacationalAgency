using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacationalAgency.BusinessLogic.Interfaces;
using VacationalAgency.BusinessLogic.Models;

namespace VacationalAgency.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayHomeOwnerController : ControllerBase
    {
        public IHolidayHomeOwnerService _holidayHomeOwnerService;

        public HolidayHomeOwnerController(IHolidayHomeOwnerService holidayHomeOwnerService) 
        {
            _holidayHomeOwnerService = holidayHomeOwnerService;
        }

        // GET: api/HolidayHomeOwner
        [HttpGet]
        public IEnumerable<HolidayHomeOwnerDTO> Get()
        {
            var lstOwners = _holidayHomeOwnerService.Get();
            return lstOwners;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/HolidayHomeOwner/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HolidayHomeOwner
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/HolidayHomeOwner/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
