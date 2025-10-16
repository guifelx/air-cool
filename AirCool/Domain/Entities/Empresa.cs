using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class Empresa : Entity
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string  Telefone { get; set; }
        public string  Email { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    
        public Empresa(Guid idEmpresa, Guid idUsuario) : base(idEmpresa, idUsuario)
        {

        }
    }
}
