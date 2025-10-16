namespace AirCool.Dto.Requests.Votacao
{
    public class CriarVotacaoRequest
    {
        public Guid EmpresaId { get; set; }
        public Guid DepartamentoId { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime DataInicioVotacao { get; set; }
        public DateTime DataFinalVotacao { get; set; }
        public decimal Temperatura { get; set; }
    }
}
