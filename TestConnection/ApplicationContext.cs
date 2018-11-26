using System.Data.Entity;
using TestConnection.Tables;

namespace TestConnection
{
    class ApplicationContext:DbContext 
    {
        public ApplicationContext():base("DefaultConnection")
        {
        }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Sale> Sales { get; set; }

    }
}
