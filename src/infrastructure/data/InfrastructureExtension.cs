using GuayaswestSample.core.interfaces.contratos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GuayaswestSample.infrastructure.data
{
    public static class InfrastructureExtension
    {
        public static IServiceCollection AddInfraestructura(this IServiceCollection servicios, string cadenaConexion)
        {
            servicios.AddScoped<IRepositorioWrapper, RepositorioWrapper>();

            servicios.AddDbContext<GuayaswestSampleContexto>(
                x => x.UseSqlite(cadenaConexion)
            );

            return servicios;
        }

    }
}
