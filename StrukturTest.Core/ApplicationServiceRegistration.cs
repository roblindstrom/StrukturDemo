
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StrukturTest.Domain.Infrastructure;
using StrukturTest.Infrastructure.Repositories;
using System.Reflection;

namespace StrukturTest.Core
{
    public static class ApplicationServiceRegistration
    {


        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            


            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IModelRepository, ModelRepository>();


            //Aktiverar automapper i Core
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
