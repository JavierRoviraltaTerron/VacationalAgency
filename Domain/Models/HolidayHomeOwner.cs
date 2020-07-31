using System;
using System.Collections.Generic;

namespace VacationalAgency.Domain.Models
{
    public partial class HolidayHomeOwner
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Nif { get; set; }
    }
}
