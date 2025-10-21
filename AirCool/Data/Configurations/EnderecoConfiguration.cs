using AirCool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirCool.Data.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            // Chave primária
            builder.HasKey(e => e.Id);

            builder.HasOne(u => u.Empresa)
                .WithOne(u => u.Endereco)
                .HasForeignKey<Endereco>(u => u.IdPai);
        }
    }
}
