using Microsoft.EntityFrameworkCore;
using NutriConsultoriaAPI.Models;

namespace NutriConsultoriaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Consulta> Consultas { get; set; }
    }
}
