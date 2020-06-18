using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class DataContext: DbContext
    {
        

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Empleado> Empleados
        {
            get; set;
        }

        public DbSet<Beneficiario> Beneficiarios
        {
            get; set;
        }

       

    }
}