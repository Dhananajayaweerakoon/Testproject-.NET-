using Microsoft.EntityFrameworkCore;
using SimpleLoginApp.Models;

namespace SimpleLoginApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RegistrationModel> Registrations { get; set; }
    }
} 