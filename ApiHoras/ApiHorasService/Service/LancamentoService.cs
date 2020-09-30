using ApiHorasDomain.Entities;
using ApiHorasDomain.Interfaces.Repositories;
using ApiHorasDomain.Interfaces.Services;
using ApiHorasService.Validator;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace ApiHorasService.Service
{
    public class LancamentoService : ILancamentoService
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public LancamentoService(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }

        public IList<Lancamento> Browse() => _lancamentoRepository.GetAll();

        public void Delete(Guid id)
        {
            _lancamentoRepository.Remove(id);
        }

        public Lancamento Insert(Lancamento lancamento)
        {
            Validate(lancamento, new LancamentoValidator());
            _lancamentoRepository.Save(lancamento);
            return lancamento;

        }

        public Lancamento RecoverById(Guid id) => _lancamentoRepository.GetById(id);

        public Lancamento Update(Lancamento lancamento)
        {
            Validate(lancamento, new LancamentoValidator());
            _lancamentoRepository.Save(lancamento);
            return lancamento;
        }

        private void Validate(Lancamento lancamento, LancamentoValidator validator)
        {
            if (lancamento == null)
                throw new Exception("Lançamento não encontrado!");
            validator.ValidateAndThrow(lancamento);
        }
    }
}
