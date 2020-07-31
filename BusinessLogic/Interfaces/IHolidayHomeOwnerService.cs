using System;
using System.Collections.Generic;
using System.Text;
using VacationalAgency.BusinessLogic.Models;

namespace VacationalAgency.BusinessLogic.Interfaces
{
    public interface IHolidayHomeOwnerService
    {
        public IEnumerable<HolidayHomeOwnerDTO> Get();
    }
}
