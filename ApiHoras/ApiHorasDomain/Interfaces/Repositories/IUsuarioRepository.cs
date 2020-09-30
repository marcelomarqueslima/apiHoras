using ApiHorasDomain.Entities;
using System;
using System.Collections.Generic;

namespace ApiHorasDomain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        void Save(Usuario usuario);
        void Remove(Guid id);
        Usuario GetById(Guid id);
        IList<Usuario> GetAll();
    }
}
