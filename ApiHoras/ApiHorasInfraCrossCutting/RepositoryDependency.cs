using ApiHorasDomain.Interfaces.Repositories;
using ApiHorasInfraData.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ApiHorasInfraCrossCutting
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<ILancamentoRepository, LancamentoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
