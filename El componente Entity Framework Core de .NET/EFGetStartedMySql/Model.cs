using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

// Replace "YourNamespace" with the namespace of your application.
namespace EFGetStartedMySql
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Replace "YourDbContext" with the name of your own DbContext derived class.
            services.AddDbContextPool<EFGetStartedMySql>(dbContextOptions => dbContextOptions.UseMySql("server=localhost;user=root;password=1234;database=ef",new MySqlServerVersion(new Version(8, 0, 21)),mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend)));
        }
    }
}