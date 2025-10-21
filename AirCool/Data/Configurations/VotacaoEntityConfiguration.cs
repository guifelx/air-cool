using AirCool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirCool.Data.Configurations
{
    public class VotacaoEntityConfiguration : IEntityTypeConfiguration<VotacaoEntity>
    {
        public void Configure(EntityTypeBuilder<VotacaoEntity> builder)
        {
            // Chave primária
            builder.HasKey(e => e.Id);

            builder.HasOne(v => v.Empresa)
               .WithMany(e => e.Votacoes) // adiciona ICollection<VotacaoEntity> na Empresa
               .HasForeignKey(v => v.IdPai); // FK na tabela Votacoes


            // Relacionamento 1:N com Departamento
            builder.HasOne(v => v.Departamento)
                   .WithMany(d => d.Votacoes) // adiciona ICollection<VotacaoEntity> no Departamento
                   .HasForeignKey(v => v.IdPai); // se quiser, pode criar uma FK separada
        }
    }
}
