using Microsoft.EntityFrameworkCore;
using Pronia_BackEnd.Models;

namespace Pronia_BackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
