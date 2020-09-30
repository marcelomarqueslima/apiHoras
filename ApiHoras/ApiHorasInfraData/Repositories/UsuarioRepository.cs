using ApiHorasDomain.Entities;
using ApiHorasDomain.Interfaces.Repositories;
using ApiHorasInfraData.Context;
using System;
using System.Collections.Generic;

namespace ApiHorasInfraData.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario, Guid>, IUsuarioRepository
    {
        public UsuarioRepository(ApiHorasContext context) : base(context)
        {
        }

        public IList<Usuario> GetAll() => base.Select();

        public Usuario GetById(Guid id) => base.Select(id);

        public void Remove(Guid id)
        {
            base.Delete(id);
        }

        public void Save(Usuario usuario)
        {
            if (usuario.Id == null)
            {
                base.Insert(usuario);
            }
            else
            {
                base.Update(usuario);
            }
        }
    }
}
