using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VacationalAgency.BusinessLogic.Models;
using VacationalAgency.Domain.Models;

namespace VacationalAgency.BusinessLogic
{
    public class AutoMapping : Profile
    {
        public AutoMapping() 
        {
            CreateMap<HolidayHomeOwner, HolidayHomeOwnerDTO>()
                .ForMember(x => x.Id, x => x.MapFrom(e => e.Id))
                .ForMember(x => x.FirstName, x => x.MapFrom(e => e.Firstname))
                .ForMember(x => x.SurName, x => x.MapFrom(e => e.Surname))
                .ForMember(x => x.NIF, x => x.MapFrom(e => e.Nif));

            CreateMap<HolidayHomeOwnerDTO, HolidayHomeOwner>()
                .ForMember(x => x.Id, x => x.MapFrom(e => e.Id))
                .ForMember(x => x.Firstname, x => x.MapFrom(e => e.FirstName))
                .ForMember(x => x.Surname, x => x.MapFrom(e => e.SurName))
                .ForMember(x => x.Nif, x => x.MapFrom(e => e.NIF));
        }
    }
}
