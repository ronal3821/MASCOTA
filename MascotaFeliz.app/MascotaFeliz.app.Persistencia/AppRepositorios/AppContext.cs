using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.app.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<DatosPersonales> DatosPersonales {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("DatosPersonales source = (localdb)\\MSSQLLocalDB; initial catalog =MascotaFelizData");

            }
        }
        

    }
}