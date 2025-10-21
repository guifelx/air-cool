using AirCool.Domain.Entities.Base;

namespace AirCool.Domain.Entities
{
    public class Resultado : SubEntity
    {
        public int QuantidadeVotos { get; set; }
        public string Periodo { get; set; }
        public Guid IdDepartamento { get; set; }
        public decimal TemperaturaInicial { get; set; }
        public decimal TemperaturaFinal { get; set; }
        public VotacaoEntity Votacao { get; set; }

        public Resultado(Guid idEmpresa, Guid idUsuario) : base(idEmpresa, idUsuario) { }
    }
}
