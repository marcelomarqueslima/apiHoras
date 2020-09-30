using ApiHorasDomain.Entities;
using ApiHorasDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiHoras.Controllers
{
    [Route("v1/lancamento")]
    [ApiController]
    public class LancamentoController : ControllerBase
    {
        private readonly ILancamentoService _lancamentoService;

        public LancamentoController(ILancamentoService lancamentoService)
        {
            _lancamentoService = lancamentoService;
        }

        /// <summary>
        /// Método de Inclusão de Lançamento e necessário ter usuário cadastrado
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register([FromBody] Lancamento lancamento)
        {
            try
            {
                _lancamentoService.Insert(lancamento);

                return Ok(lancamento.Id);
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
        /// Método de Atualização de Lançamento
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Lancamento lancamento)
        {
            try
            {
                _lancamentoService.Update(lancamento);

                return Ok(lancamento);
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
        /// Método de Exclusão de Lançamento com o parametro ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] Guid id)
        {
            try
            {
                _lancamentoService.Delete(id);

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
        /// Método de Buscar todos os Lançamentos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                return Ok(_lancamentoService.Browse());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Método de busca de Lançamento pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] Guid id)
        {
            try
            {
                return Ok(_lancamentoService.RecoverById(id));
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
