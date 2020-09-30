using ApiHorasDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiHorasInfraData.Mapping
{
    public class LancamentoMapping : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> p)
        {
            p.ToTable("Lancamento");
            p.HasKey(p => p.Id);
            p.Property(p => p.Descricao).HasColumnType("varchar(80)");
            p.Property(p => p.TipoRegistro).HasConversion<string>();
        }
    }
}
