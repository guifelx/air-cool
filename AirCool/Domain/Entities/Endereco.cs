using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class Endereco : SubEntity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public Endereco(Guid idEmpresa, Guid idUsuario) : base(idEmpresa, idUsuario) { }
    }
}