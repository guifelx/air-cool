namespace AirCool.Domain.Entities.Base
{
    public abstract class Entity
    {
        public long Id { get; private set; }
        public Guid IdExterno { get; private set; }
        public Guid IdUsuario { get; private set; }
        public Guid IdEmpresa { get; private set; }

        protected Entity() { }
        
        protected Entity(Guid empresaId, Guid idUsuario)
        {
            this.IdExterno = Guid.NewGuid();
            this.IdUsuario = idUsuario;
            this.IdEmpresa = empresaId;
            this.IdUsuario = idUsuario;
        }
    }
}
