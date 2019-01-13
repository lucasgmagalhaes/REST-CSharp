using System;
using System.Threading.Tasks;
using Entidades.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistencia.Interfaces;

namespace Api.Controllers
{
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private ICrudService<Usuario> crudService;

        // GET: api/<controller>
        [HttpGet]
        public string Get()
        {
            return "BATATAAAAAAAAA";
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<Usuario> Get(long id)
        {
            return await this.crudService.BuscarAsync(id);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                this.crudService.Inserir(usuario);
                return Ok("Criado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<controller>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]Usuario usuario)
        {
            try
            {
                await this.crudService.AtualizarAsync(usuario);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await this.crudService.DeletarAsync(id);
            return Ok();
        }
    }
}
