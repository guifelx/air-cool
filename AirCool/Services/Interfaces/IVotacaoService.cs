using AirCool.Dto.Requests.Votacao;

namespace AirCool.Services.Interfaces
{
    public interface IVotacaoService 
    {
        Task CriarVotacao(CriarVotacaoRequest request); 
    }
}
