using System.Collections.Generic;
using System.Threading.Tasks;
using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Persistencia.Interfaces;
using Persistencia.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private ICrudService<Usuario> crudService;

        public UsuarioController()
        {
            this.crudService = new UserService();
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<List<Usuario>> Get()
        {
            return await this.crudService.Buscar();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<Usuario> Get(long id)
        {
            return await this.crudService.Buscar(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Usuario usuario)
        {
            this.crudService.Salvar(usuario);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Usuario usuario)
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
