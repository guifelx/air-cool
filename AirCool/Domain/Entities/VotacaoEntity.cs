using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class VotacaoEntity : SubEntity
    {
        public Guid IdEmpresa { get; set; }
        public Guid IdDepartamento { get; set; }
        public DateTime DataInicioVotacao { get; set; }
        public DateTime DataFinalVotacao { get; set; }
        public decimal Temperatura { get; set; }
        public VotacaoEntity(Guid EmpresaId,
                             Guid IdUsuario,
                             Guid DepartamentoId,
                             DateTime DataInicioVotacao,
                             DateTime DataFinalVotacao) : base(EmpresaId, IdUsuario)
        {
            this.IdEmpresa = EmpresaId;
            this.IdDepartamento= DepartamentoId;
            this.DataInicioVotacao = DataInicioVotacao;
            this.DataFinalVotacao = DataFinalVotacao;
        } 

        public static VotacaoEntity Criar(Guid EmpresaId,
                             Guid UsuarioId,
                             Guid DepartamentoId,
                             DateTime DataInicioVotacao,
                             DateTime DataFinalVotacao) => new VotacaoEntity(EmpresaId, UsuarioId, DepartamentoId, DataInicioVotacao, DataFinalVotacao); 
    }
}

