using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Roamin.Persistence;
using Roaming.Application.Interfaces;

namespace Roaming.Persistence
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<RoamingDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<IRoamingDbContext>(provider => provider.GetService<RoamingDbContext>());
            return services;
        }
    }
}
