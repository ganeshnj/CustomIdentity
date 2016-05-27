using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentity.Models
{
    public class ApplicationUserClaim : IdentityUserClaim<Int64>
    {
    }
}
