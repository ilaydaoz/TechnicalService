using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TechnicalServiceDataAccess.Context;

namespace TechnicalServiceDataAccess
{
    public static class ServiceRegistration
    {
        //static sınıfın bir örneğini oluşturmadan doğrudan sınıfın içeriğine erişebilmek için 
        public static void AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfContext>(x =>
            {
                x.UseNpgsql(configuration.GetConnectionString("EfContext"));
            });
            services.TryAddScoped<DbContext, EfContext>();
        }
    }
}