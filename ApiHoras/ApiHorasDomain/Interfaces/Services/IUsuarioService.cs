using ApiHorasDomain.Entities;
using System;
using System.Collections.Generic;

namespace ApiHorasDomain.Interfaces.Services
{
    public interface IUsuarioService
    {
        Usuario Insert(Usuario usuario);
        Usuario Update(Usuario usuario);
        void Delete(Guid id);
        Usuario RecoverById(Guid id);
        IList<Usuario> Browse();
    }
}
