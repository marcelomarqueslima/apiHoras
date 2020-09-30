using ApiHorasDomain.Entities;
using System;
using System.Collections.Generic;

namespace ApiHorasDomain.Interfaces.Services
{
    public interface ILancamentoService
    {
        Lancamento Insert(Lancamento lancamento);
        Lancamento Update(Lancamento lancamento);
        void Delete(Guid id);
        Lancamento RecoverById(Guid id);
        IList<Lancamento> Browse();
    }
}
