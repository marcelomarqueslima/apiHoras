using ApiHorasDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiHorasInfraData.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> p)
        {
            p.ToTable("Usuario");
            p.HasKey(p => p.Id);
            p.Property(p => p.Nome).HasColumnType("varchar(80)").IsRequired();
            p.Property(p => p.TipoUsuario).HasConversion<string>();
        }
    }
}
