using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApi
{
    public class DesignContext : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<Context>();
            options.UseNpgsql("Host=localhost;Port=5432;Database=WebApiSokol;Username=postgres;Password=123");
            return new Context(options.Options);

        }
    }
}
