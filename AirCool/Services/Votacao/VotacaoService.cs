using AirCool.Domain.Entities;
using AirCool.Dto.Requests.Votacao;
using AirCool.Repositories.Interfaces;
using AirCool.Services.Interfaces;
using Azure.Core;

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

            var votacao = new VotacaoEntity(request.Empresa.IdExterno,
                                            request.UsuarioId,
                                            request.Departamento.IdExterno,
                                            request.DataInicioVotacao,
                                            request.DataFinalVotacao,
                                            request.Temperatura);

            var result = await _votacaoRepository.CriarVotacao(votacao);

            return;
        }
    }
}
