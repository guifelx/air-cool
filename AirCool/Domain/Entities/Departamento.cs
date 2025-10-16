using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class Departamento : Entity
    {
        public string Nome { get; set; }

        public Departamento(Guid idEmpresa, Guid idUsuario) : base(idEmpresa, idUsuario) { }
    }
}
