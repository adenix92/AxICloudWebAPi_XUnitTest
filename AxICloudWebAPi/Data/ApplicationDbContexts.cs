using AxICloudWebAPi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
namespace AxICloudWebAPi.Data
{
    public class ApplicationDbContextsIdentuty : IdentityDbContext<AppUser>
    {
        public ApplicationDbContextsIdentuty(DbContextOptions<ApplicationDbContextsIdentuty> _dbContextOptions):base(_dbContextOptions)
        {
            
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<City> Cities { get; set; }



    }
}
