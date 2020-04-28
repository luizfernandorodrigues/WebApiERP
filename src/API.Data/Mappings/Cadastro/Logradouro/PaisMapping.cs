using API.Business.Models.Cadastro.Logradouro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Mappings.Cadastro.Logradouro
{
    public class PaisMapping : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais", "Cadastro");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("UNIQUEIDENTIFIER");

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(100)")
                .IsRequired(true);

            builder.Property(p => p.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("VARCHAR(10)")
                .IsRequired(false);

            builder.Property(p => p.Observacao)
                .HasColumnName("Observacao")
                .HasColumnType("VARCHAR(MAX)")
                .IsRequired(false);

            builder.Property(p => p.TimesTamp)
                .HasColumnName("TimesTamp")
                .HasColumnType("DATETIME")
                .IsRequired(true);

            builder.Property(p => p.Ativo)
                .HasColumnName("Ativo")
                .HasColumnType("BIT")
                .IsRequired(true);
        }
    }
}
