using Api.Arquitetura.Controllers;
using Api.Arquitetura.Repositories;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("users")]
    public class UserController : ControllerBase
    {
        protected IRepository<User> repository = new UserRepository();

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return repository.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return repository.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]User entity)
        {
            repository.Insert(entity);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User entity)
        {
            repository.SaveOrUpdate(entity);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
