using AirCool.Data;
using AirCool.Domain.Entities;
using AirCool.Repositories.Interfaces;

namespace AirCool.Repositories.VotacaoRepository
{
    public class VotacaoRepository : IVotacaoRepository
    {

        private readonly AirCoolContext _context;

        public VotacaoRepository(AirCoolContext context)
        {
            _context = context;
        }

        public async Task<bool> CriarVotacao(VotacaoEntity votacao)
        {
            await _context.Votacoes.AddAsync(votacao);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
