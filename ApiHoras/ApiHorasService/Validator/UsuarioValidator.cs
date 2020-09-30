using ApiHorasDomain.Entities;
using FluentValidation;
using System;

namespace ApiHorasService.Validator
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c)
               .NotNull()
               .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Campo Nome Branco, por favor preencher!")
                .NotNull().WithMessage("Campo Nome não pode ser nulo, por favor preencher!");
            RuleFor(c => c.TipoUsuario)
                .NotEmpty().WithMessage("Campo Tipo de Usuário em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo Tipo de Usuário não pode ser nulo, por favor preencher!");
            RuleFor(c => c.DataInicio)
                .NotEmpty().WithMessage("Campo Data de Inicio em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo Data de Inicio não pode ser nulo, por favor preencher!");
        }
    }
}
