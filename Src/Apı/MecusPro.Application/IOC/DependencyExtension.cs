using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MecusPro.Application.IOC
{
    public static class DependencyExtension
    {
        public static void AddApplicationDependency(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        }
    }
}
