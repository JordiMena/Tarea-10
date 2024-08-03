using ControlDeInventario.Domain.Interfaces;
using ControlDeInventario.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ControlDeInventario.IoC
{
    public static class DependencyInjection
    {
        public static void AddProjectDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductoRepository, ProductoRepository>();
            // Agrega más servicios según sea necesario
        }
    }
}
