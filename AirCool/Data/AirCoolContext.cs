using AirCool.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirCool.Data
{
    public class AirCoolContext : DbContext
    {

        public AirCoolContext(DbContextOptions<AirCoolContext> options) : base(options)
        {
            
        }

        public DbSet<VotacaoEntity> Votacoes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Resultado> Resultados { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        
    }
}
