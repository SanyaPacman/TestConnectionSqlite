using System.Data.Entity;

namespace TestConnection
{
    class ApplicationContext:DbContext 
    {
        public ApplicationContext():base("DefaultConnection")
        {
        }
        public DbSet<Phone> Phones { get; set; }
    }
}
