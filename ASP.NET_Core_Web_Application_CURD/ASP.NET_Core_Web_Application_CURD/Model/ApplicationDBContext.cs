using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_Application_CURD.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }

    }
}
