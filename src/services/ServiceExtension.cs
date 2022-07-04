using GuayaswestSample.core.interfaces.contratos.servicios;
using Microsoft.Extensions.DependencyInjection;

namespace GuayaswestSample.services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServicios(this IServiceCollection servicios)
        {
            servicios.AddScoped<IGuayaswestSampleServicio, GuayaswestSampleServicio>();

            return servicios;
        }
    }
}
