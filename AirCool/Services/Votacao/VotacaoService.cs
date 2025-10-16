using AirCool.Domain.Entities;
using AirCool.Dto.Requests.Votacao;
using AirCool.Repositories.Interfaces;
using AirCool.Services.Interfaces;

namespace AirCool.Services.Votacao
{
    public class VotacaoService : IVotacaoService
    {
        private readonly IVotacaoRepository _votacaoRepository;

        public VotacaoService(IVotacaoRepository votacaoRepository)
        {
            _votacaoRepository = votacaoRepository;
        }
        public async Task CriarVotacao(CriarVotacaoRequest request)
        {

            var votacao = VotacaoEntity.Criar(request.EmpresaId,
                                              request.UsuarioId,
                                              request.DepartamentoId,
                                              request.DataInicioVotacao,
                                              request.DataFinalVotacao);

            var result = await _votacaoRepository.CriarVotacao(votacao);

            return;
        }
    }
}
