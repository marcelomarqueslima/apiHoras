using ApiHorasDomain.Entities;
using ApiHorasDomain.Interfaces.Repositories;
using ApiHorasDomain.Interfaces.Services;
using ApiHorasService.Validator;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace ApiHorasService.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IList<Usuario> Browse() => _usuarioRepository.GetAll();

        public void Delete(Guid id)
        {
            _usuarioRepository.Remove(id);
        }

        public Usuario Insert(Usuario usuario)
        {
            Validate(usuario, new UsuarioValidator());
            _usuarioRepository.Save(usuario);
            return usuario;

        }

        public Usuario RecoverById(Guid id) => _usuarioRepository.GetById(id);

        public Usuario Update(Usuario usuario)
        {
            Validate(usuario, new UsuarioValidator());
            _usuarioRepository.Save(usuario);
            return usuario;
        }

        private void Validate(Usuario usuario, UsuarioValidator validator)
        {
            if (usuario == null)
                throw new Exception("Usuário não encontrado!");
            validator.ValidateAndThrow(usuario);
        }
    }
}
