using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FPT_JOB_Mart.Models;

namespace FPT_JOB_Mart.Models
{
    public class DB1670Context: IdentityDbContext
    {
        public DB1670Context(DbContextOptions<DB1670Context> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<FPT_JOB_Mart.Models.Profile> Profile { get; set; } = default!;
        public DbSet<FPT_JOB_Mart.Models.ProJob> ProJob { get; set; } = default!;
    }
}
