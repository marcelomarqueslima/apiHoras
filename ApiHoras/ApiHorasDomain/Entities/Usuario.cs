using ApiHorasDomain.Shared;
using ApiHorasDomain.ValueObjects;
using System;

namespace ApiHorasDomain.Entities
{
    public class Usuario : EntityBase<Guid>
    {
        public string Nome { get; set; }
        public DateTime DataRegistro { get; set; } = DateTime.UtcNow;
        public DateTime DataInicio { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
