using AirCool.Domain.Entities;

namespace AirCool.Dto.Requests.Votacao
{
    public class CriarVotacaoRequest
    {
        public Departamento Departamento { get; set; }
        public Empresa Empresa { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime DataInicioVotacao { get; set; }
        public DateTime DataFinalVotacao { get; set; }
        public decimal Temperatura { get; set; }
    }
}
