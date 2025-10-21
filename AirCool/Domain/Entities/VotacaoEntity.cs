using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class VotacaoEntity : SubEntity
    {
        public Guid DepartamentoId { get; private set; }
        public Departamento Departamento { get; private set; }
        public DateTime DataInicioVotacao { get; private set; }
        public DateTime DataFinalVotacao { get; private set; }
        public Empresa Empresa { get; private set; }
        public decimal Temperatura { get; private set; }

        protected VotacaoEntity() { }

        public VotacaoEntity(Guid empresaId, Guid usuarioId, Guid departamentoId, DateTime dataInicio, DateTime dataFinal, decimal temperatura)
            : base(empresaId, usuarioId)
        {
            DepartamentoId = departamentoId;
            DataInicioVotacao = dataInicio;
            DataFinalVotacao = dataFinal;
            Temperatura = temperatura;
        }
    }
}

