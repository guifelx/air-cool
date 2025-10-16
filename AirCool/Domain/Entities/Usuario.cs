using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class Usuario : SubEntity
    {
        public string Nome { get; set; }
        public Guid IdDepartamento { get; set; }

        public Usuario(Guid idEmpresa, Guid idUsuario) : base (idEmpresa, idUsuario)
        {

        }
    }

}
