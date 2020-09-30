using ApiHorasDomain.Interfaces.Services;
using ApiHorasService.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ApiHorasInfraCrossCutting
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<ILancamentoService, LancamentoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
