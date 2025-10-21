using AirCool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirCool.Data.Configurations
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            // Chave primária
            builder.HasKey(d => d.Id);

            // Relacionamento 1:N com Empresa
            builder.HasOne(d => d.Empresa)          
                   .WithMany(e => e.Departamento)   
                   .HasForeignKey(d => d.IdPai);      
        }
    }
}
