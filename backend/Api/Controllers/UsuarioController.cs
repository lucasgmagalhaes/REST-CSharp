using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Persistencia.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
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
        public void Post([FromBody]Usuario usuario)
        {
            this.crudService.Salvar(usuario);
        }

        // PUT api/<controller>
        [HttpPut]
        public void Put([FromBody]Usuario usuario)
        {
            this.crudService.Atualizar(usuario);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            this.crudService.Deletar(id);
        }
    }
}
