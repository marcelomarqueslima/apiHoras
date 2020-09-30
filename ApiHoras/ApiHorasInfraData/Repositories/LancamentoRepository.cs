using ApiHorasDomain.Entities;
using ApiHorasDomain.Interfaces.Repositories;
using ApiHorasInfraData.Context;
using System;
using System.Collections.Generic;

namespace ApiHorasInfraData.Repositories
{
    public class LancamentoRepository : BaseRepository<Lancamento, Guid>, ILancamentoRepository
    {
        public LancamentoRepository(ApiHorasContext context) : base(context)
        {
        }

        public IList<Lancamento> GetAll() => base.Select();

        public Lancamento GetById(Guid id) => base.Select(id);

        public void Remove(Guid id)
        {
            base.Delete(id);
        }

        public void Save(Lancamento lancamento)
        {
            if (lancamento.Id == null)
            {
                base.Insert(lancamento);
            }
            else
            {
                base.Update(lancamento);
            }
        }
    }
}
