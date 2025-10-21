using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class Departamento : SubEntity
    {
        public string Nome { get; set; }
        public Empresa Empresa { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
        public ICollection<VotacaoEntity> Votacoes { get; set; }
        public Departamento(Guid idEmpresa, Guid idUsuario) : base(idEmpresa, idUsuario) { }
    }
}
