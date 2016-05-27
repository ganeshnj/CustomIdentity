using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentity.Models
{
    public class ApplicationUser : IdentityUser<Int64>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
