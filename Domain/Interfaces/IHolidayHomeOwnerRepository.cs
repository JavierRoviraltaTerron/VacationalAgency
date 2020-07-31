using System;
using System.Collections.Generic;
using System.Text;
using VacationalAgency.Domain.Models;

namespace VacationalAgency.Domain.Interfaces
{
    public interface IHolidayHomeOwnerRepository
    {
        public IEnumerable<HolidayHomeOwner> Get();
    }
}
