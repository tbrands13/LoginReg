using Microsoft.EntityFrameworkCore;
namespace LoginReg.Models
{ 

    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<User> Users { get; set; }
    }
}
