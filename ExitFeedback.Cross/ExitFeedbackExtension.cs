using ExitFeedback.DataAccess;
using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using ExitFeedback.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExitFeedback.Cross
{
    public static class ExitFeedbackExtension
    {
        public static IServiceCollection AddExitFeedbackExtension(this IServiceCollection services, string connectionString)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));


            services.AddDbContext<ExitFeedbackDataContext>(o => o.UseSqlServer(connectionString));

            services.AddScoped<IBaseService<Empleado>, EmpleadoService>();
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IHttpClient<Empleado>, BaseHttpClient>();

            return services;

        }
    }
}
