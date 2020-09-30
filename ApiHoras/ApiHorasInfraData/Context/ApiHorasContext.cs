using ApiHorasDomain.Entities;
using ApiHorasInfraData.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ApiHorasInfraData.Context
{
    public class ApiHorasContext : DbContext
    {
        public ApiHorasContext(DbContextOptions<ApiHorasContext> options) : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Lancamento> Lancamentos { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new LancamentoMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
