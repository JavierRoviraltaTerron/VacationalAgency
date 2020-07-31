using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VacationalAgency.Domain.Interfaces;
using VacationalAgency.Domain.Models;

namespace VacationalAgency.BusinessLogic.Services
{
    public class HolidayHomeOwnerRepository : IHolidayHomeOwnerRepository
    {
        //private VacationalAgencyContext _dbContext;

        //public HolidayHomeOwnerRepository(VacationalAgencyContext dbContext) 
        //{
        //    _dbContext = dbContext;
        //}

        public IEnumerable<HolidayHomeOwner> Get()
        {
            //return _dbContext.HolidayHomeOwner.ToList();
            using (var dbContext = new VacationalAgencyContext())
            {
                return dbContext.HolidayHomeOwner.ToList();
            }
        }
    }
}
