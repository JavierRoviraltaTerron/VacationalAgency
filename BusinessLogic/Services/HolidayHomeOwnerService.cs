using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VacationalAgency.BusinessLogic.Interfaces;
using VacationalAgency.BusinessLogic.Models;
using VacationalAgency.Domain.Interfaces;
using VacationalAgency.Domain.Models;

namespace VacationalAgency.BusinessLogic.Services
{
    public class HolidayHomeOwnerService : IHolidayHomeOwnerService
    {
        private readonly IMapper _mapper;
        private IHolidayHomeOwnerRepository _holidayHomeOwnerRepository;

        public HolidayHomeOwnerService(IMapper mapper, IHolidayHomeOwnerRepository holidayHomeOwnerRepository) 
        {
            _mapper = mapper;
            _holidayHomeOwnerRepository = holidayHomeOwnerRepository;
        }

        public IEnumerable<HolidayHomeOwnerDTO> Get()
        {
            var repository = _holidayHomeOwnerRepository.Get();
            return _mapper.Map<IEnumerable<HolidayHomeOwner>,List<HolidayHomeOwnerDTO>>(repository);
        }
    }
}
