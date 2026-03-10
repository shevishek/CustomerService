using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataContext
{
    public class CustomerServiceContextFactory : IDesignTimeDbContextFactory<CustomerServiceContext>
    {
        public CustomerServiceContext CreateDbContext(string[] args)
        {
            // ב־Design-Time EF Core ירוץ מתוך התיקייה של ה-webapi
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..\\CustomerService.webApi"))
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("database");

            var optionsBuilder = new DbContextOptionsBuilder<CustomerServiceContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CustomerServiceContext(optionsBuilder.Options);
        }
    }
}
