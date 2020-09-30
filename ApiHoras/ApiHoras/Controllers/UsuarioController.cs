using ApiHorasDomain.Entities;
using ApiHorasDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiHoras.Controllers
{
    [Route("v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        /// <summary>
        /// Método de Inclusão de Usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioService.Insert(usuario);

                return Ok(usuario.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método de Atualização de Usuário
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioService.Update(usuario);

                return Ok(usuario);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método de Exclusão de Usuário com o parametro ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] Guid id)
        {
            try
            {
                _usuarioService.Delete(id);

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método de Buscar todos os Usuários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                return Ok(_usuarioService.Browse());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método de busca de Usuário pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] Guid id)
        {
            try
            {
                return Ok(_usuarioService.RecoverById(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
