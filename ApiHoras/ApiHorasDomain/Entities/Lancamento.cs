using ApiHorasDomain.Shared;
using ApiHorasDomain.ValueObjects;
using System;

namespace ApiHorasDomain.Entities
{
    public class Lancamento : EntityBase<Guid>
    {
        public string Descricao { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public TipoRegistro TipoRegistro { get; set; }
        public DateTime DataLancamento { get; set; } = DateTime.UtcNow;
        public DateTime Horario { get; set; }
    }
}
