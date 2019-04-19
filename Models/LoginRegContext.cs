using Microsoft.EntityFrameworkCore;
 
namespace LoginReg.Models
{
    public class LoginRegContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public LoginRegContext(DbContextOptions options) : base(options) { }

         public DbSet<User> Users { get;set; }
         public DbSet<Wedding> Weddings { get;set; }
         public DbSet<Association> Associations { get;set; }
    }
}