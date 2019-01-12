using System.Data.Entity;
using TestConnection.Tables;

namespace TestConnection
{
    class ApplicationContex:DbContext 
    {
        public ApplicationContex():base("DefaultConnection")
        {
        }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
