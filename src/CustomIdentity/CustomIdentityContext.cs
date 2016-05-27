using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CustomIdentity.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomIdentity
{
    public class CustomIdentityContext : IdentityDbContext<ApplicationUser, ApplicationRole, Int64>
    {
        public CustomIdentityContext(DbContextOptions<CustomIdentityContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users");

            builder.Entity<ApplicationRole>().ToTable("Roles");

            builder.Entity<ApplicationUserRole>().ToTable("UserRoles");

            builder.Entity<ApplicationRoleClaim>().ToTable("RoleClaims");

            builder.Entity<ApplicationUserClaim>().ToTable("UserClaims");

            builder.Entity<ApplicationUserLogin>().ToTable("UserLogins");

            builder.Entity<ApplicationUserToken>().ToTable("UserTokens");
        }
    }
}
