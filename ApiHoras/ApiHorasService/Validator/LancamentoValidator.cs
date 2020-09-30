using ApiHorasDomain.Entities;
using FluentValidation;
using System;

namespace ApiHorasService.Validator
{
    public class LancamentoValidator : AbstractValidator<Lancamento>
    {
        public LancamentoValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.Usuario)
                .NotEmpty().WithMessage("Campo Usuário em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo Usuário não pode ser nulo, por favor preencher!");
            RuleFor(c => c.TipoRegistro)
                .NotEmpty().WithMessage("Campo Tipo de Registro em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo Tipo de Registro não pode ser nulo, por favor preencher!");
            RuleFor(c => c.Horario)
                .NotEmpty().WithMessage("Campo Horário em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo Horário não pode ser nulo, por favor preencher!");
        }
    }
}
