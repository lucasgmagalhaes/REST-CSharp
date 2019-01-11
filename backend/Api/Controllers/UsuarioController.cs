using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Persistencia.Interfaces;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private ICrudService<Usuario> crudService;

        public UsuarioController(ICrudService<Usuario> userService)
        {
            this.crudService = userService;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<List<Usuario>> Get()
        {
            return await this.crudService.BuscarAsync();
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
