using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Data
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region "Seed data"
            builder.Entity<IdentityRole>().HasData(
                new {Id ="1", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
            );
            #endregion
        }
    }
}
