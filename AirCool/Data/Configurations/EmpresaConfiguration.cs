using AirCool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirCool.Data.Configurations
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            // Chave primária
            builder.HasKey(e => e.Id);

            // Relacionamento 1:N com Usuários
            builder.HasMany(e => e.Usuarios)
                   .WithOne(u => u.Empresa)
                   .HasForeignKey(u => u.IdPai);

            builder.HasOne(e => e.Endereco)
                   .WithOne(end => end.Empresa)      
                   .HasForeignKey<Endereco>(end => end.IdPai);

            builder.HasMany(e => e.Departamento) 
                   .WithOne(end => end.Empresa)      
                   .HasForeignKey(end => end.IdPai);

            builder.HasMany(e => e.Votacoes) 
                  .WithOne(end => end.Empresa)      
                  .HasForeignKey(end => end.IdPai);
        }
    }
}
