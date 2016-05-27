using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentity.Models
{
    public class ApplicationRole : IdentityRole<Int64>
    {
        public string Description { get; set; }
    }
}
