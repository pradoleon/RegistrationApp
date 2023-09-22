using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RegistrationApp.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegistrationApp.IoC
{
    public static class DbConfig
    {
        public static IServiceCollection AddDatabaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RegistrationAppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("RegistrationAppDbContext"))
                );

            return services;
        }
    }
}
