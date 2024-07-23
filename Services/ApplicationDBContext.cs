using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using loginrazor.Models;
using Microsoft.AspNetCore.Identity;

namespace loginrazor.Services
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions options): base(options)
        {
                        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var teamleader = new IdentityRole("teamleader");
            teamleader.NormalizedName = "teamleader";

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var developer = new IdentityRole("developer");
            developer.NormalizedName = "developer";

            builder.Entity<IdentityRole>().HasData(admin, teamleader, developer);
        }
    }
}
