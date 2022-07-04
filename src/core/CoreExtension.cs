using GuayaswestSample.core.extensiones;
using Microsoft.Extensions.DependencyInjection;

namespace GuayaswestSample.core
{
    public static class CoreExtension
    {
        public static IServiceCollection AddCore(this IServiceCollection servicios)
        {
            //Enable AutoMapper
            servicios.AddAutoMapper(typeof(GuayaswestSampleMappingProfile));

            return servicios;
        }

    }
}
