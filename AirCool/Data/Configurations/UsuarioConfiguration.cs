using AirCool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirCool.Data.Configurations
{

    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            // Relacionamento Empresa (1:N)
            builder.HasOne(u => u.Empresa)
                   .WithMany(u => u.Usuarios)
                   .HasForeignKey(u => u.IdPai);

        }
    }
}
