using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class Usuario : SubEntity
    {
        public string Nome { get; set; }
        public Empresa Empresa { get; set; }
        public Departamento Departamento { get; set; }
        public Guid DepartamentoIdExterno { get; set; }
        public Usuario(Guid idEmpresa, Guid idUsuario) : base(idEmpresa, idUsuario)
        {

        }
    }

}
