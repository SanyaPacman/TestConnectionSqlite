using System.Data.Entity;

namespace TestConnection
{
    class ApplicationContex:DbContext 
    {
        public ApplicationContex():base("DefaultConnection")
        {
        }
        public DbSet<Phone> Phones { get; set; }
    }
}
