using AirCool.Domain.Entities;

namespace AirCool.Repositories.Interfaces
{
    public interface IVotacaoRepository
    {
        Task<bool> CriarVotacao(VotacaoEntity votacao);
    }
}
