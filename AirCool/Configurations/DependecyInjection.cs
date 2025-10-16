using AirCool.Repositories.Interfaces;
using AirCool.Repositories.VotacaoRepository;
using AirCool.Services.Interfaces;
using AirCool.Services.Votacao;

namespace AirCool.Configurations
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddProjectDependencies(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IVotacaoRepository, VotacaoRepository>();

            // Services
            services.AddScoped<IVotacaoService, VotacaoService>();

            return services;
        }
    }
}
