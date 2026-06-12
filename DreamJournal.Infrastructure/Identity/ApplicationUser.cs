using DreamJournal.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public ReligiousAffiliationEnum? ReligiousAffiliation { get; set; }

        public string City { get; set; } = null!;

        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string Country { get; set; } = null!;

    }

}
