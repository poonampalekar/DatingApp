using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuartion){
            services.AddScoped<ITokenService,TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite("Data Source=datingapp.db");
            });

            return services;
        }
    }
}