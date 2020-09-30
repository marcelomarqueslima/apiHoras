using ApiHorasDomain.Entities;
using System;
using System.Collections.Generic;

namespace ApiHorasDomain.Interfaces.Repositories
{
    public interface ILancamentoRepository
    {
        void Save(Lancamento lancamento);
        void Remove(Guid id);
        Lancamento GetById(Guid id);
        IList<Lancamento> GetAll();
    }
}
